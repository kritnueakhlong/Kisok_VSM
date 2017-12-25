using System;
using System.Configuration;
using System.Configuration.Provider;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Web;
using System.Web.Security;
using VSM.Data;

namespace VSM.Security
{
	public partial class ApplicationRoleProvider : ApplicationRoleProviderBase
    {
    }
    
    public enum RoleProviderSqlStatement
    {
        
        AddUserToRole,
        
        CreateRole,
        
        DeleteRole,
        
        DeleteRoleUsers,
        
        GetAllRoles,
        
        GetRolesForUser,
        
        GetUsersInRole,
        
        IsUserInRole,
        
        RemoveUserFromRole,
        
        RoleExists,
        
        FindUsersInRole,
    }
    
    public class ApplicationRoleProviderBase : RoleProvider
    {
        
        protected static SortedDictionary<RoleProviderSqlStatement, string> Statements = new SortedDictionary<RoleProviderSqlStatement, string>();
        
        private ConnectionStringSettings _connectionStringSettings;
        
        private bool _writeExceptionsToEventLog;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _applicationName;
        
        static ApplicationRoleProviderBase()
        {
            Statements[RoleProviderSqlStatement.AddUserToRole] = "\r\ninsert into Employee_Roles(emp_id, roles_id) \r\nvalues (\r\n     (select emp_id fr" +
                "om Employee where emp_code=@UserName) \r\n    ,(select roles_id from Roles where r" +
                "oles_name=@RoleName)\r\n    \r\n)";
            Statements[RoleProviderSqlStatement.CreateRole] = "insert into Roles (roles_name) values (@RoleName)";
            Statements[RoleProviderSqlStatement.DeleteRole] = "delete from Roles where roles_name = @RoleName";
            Statements[RoleProviderSqlStatement.DeleteRoleUsers] = "delete from Employee_Roles where roles_id in (select roles_id from Roles where ro" +
                "les_name = @RoleName)";
            Statements[RoleProviderSqlStatement.GetAllRoles] = "select roles_name RoleName from Roles";
            Statements[RoleProviderSqlStatement.GetRolesForUser] = "\r\nselect Roles.roles_name RoleName from Roles Roles \r\ninner join Employee_Roles U" +
                "serRoles on Roles.roles_id = UserRoles.roles_id \r\ninner join Employee Users on U" +
                "sers.emp_id = UserRoles.emp_id\r\nwhere Users.emp_code = @UserName";
            Statements[RoleProviderSqlStatement.GetUsersInRole] = "select emp_code UserName from Employee where emp_id in (select emp_id from Employ" +
                "ee_Roles where roles_id in (select roles_id from Roles where roles_name = @RoleN" +
                "ame))";
            Statements[RoleProviderSqlStatement.IsUserInRole] = "\r\nselect count(*) from Employee_Roles\r\nwhere\r\n    emp_id in (select emp_id from E" +
                "mployee where emp_code = @UserName) and \r\n    roles_id in (select roles_id from " +
                "Roles where roles_name = @RoleName)";
            Statements[RoleProviderSqlStatement.RemoveUserFromRole] = "\r\ndelete from Employee_Roles\r\nwhere\r\n   emp_id in (select emp_id from Employee wh" +
                "ere emp_code = @UserName) and\r\n   roles_id in (select roles_id from Roles where " +
                "roles_name = @RoleName)";
            Statements[RoleProviderSqlStatement.RoleExists] = "select count(*) from Roles where roles_name = @RoleName";
            Statements[RoleProviderSqlStatement.FindUsersInRole] = @"
select Users.emp_code UserName from Employee Users
inner join Employee_Roles UserRoles on Users.emp_id= UserRoles.emp_id 
inner join Roles Roles on UserRoles.roles_id = Roles.roles_id
where 
	Users.emp_code like @UserName and 
	Roles.roles_name = @RoleName";
        }
        
        public virtual ConnectionStringSettings ConnectionStringSettings
        {
            get
            {
                return _connectionStringSettings;
            }
        }
        
        public bool WriteExceptionsToEventLog
        {
            get
            {
                return _writeExceptionsToEventLog;
            }
        }
        
        public override string ApplicationName
        {
            get
            {
                return this._applicationName;
            }
            set
            {
                this._applicationName = value;
            }
        }
        
        protected virtual SqlStatement CreateSqlStatement(RoleProviderSqlStatement command)
        {
            SqlText sql = new SqlText(Statements[command], ConnectionStringSettings.Name);
            sql.Command.CommandText = sql.Command.CommandText.Replace("@", sql.ParameterMarker);
            if (sql.Command.CommandText.Contains((sql.ParameterMarker + "ApplicationName")))
            	sql.AssignParameter("ApplicationName", ApplicationName);
            sql.Name = ("VSM Application Role Provider - " + command.ToString());
            sql.WriteExceptionsToEventLog = WriteExceptionsToEventLog;
            return sql;
        }
        
        public override void Initialize(string name, NameValueCollection config)
        {
            if (config == null)
            	throw new ArgumentNullException("config");
            if (String.IsNullOrEmpty(name))
            	name = "VSMApplicationRoleProvider";
            if (String.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "VSM application role provider");
            }
            base.Initialize(name, config);
            _applicationName = config["applicationName"];
            if (String.IsNullOrEmpty(_applicationName))
            	_applicationName = System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath;
            _writeExceptionsToEventLog = "true".Equals(config["writeExceptionsToEventLog"], StringComparison.CurrentCulture);
            _connectionStringSettings = ConfigurationManager.ConnectionStrings[config["connectionStringName"]];
            if ((_connectionStringSettings == null) || String.IsNullOrEmpty(_connectionStringSettings.ConnectionString))
            	throw new ProviderException("Connection string cannot be blank.");
        }
        
        public override void AddUsersToRoles(string[] usernames, string[] rolenames)
        {
            foreach (string rolename in rolenames)
            	if (!(RoleExists(rolename)))
                	throw new ProviderException(String.Format("Role name \'{0}\' not found.", rolename));
            foreach (string username in usernames)
            {
                if (username.Contains(","))
                	throw new ArgumentException("User names cannot contain commas.");
                foreach (string rolename in rolenames)
                	if (IsUserInRole(username, rolename))
                    	throw new ProviderException(String.Format("User \'{0}\' is already in role \'{1}\'.", username, rolename));
            }
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.AddUserToRole))
            	foreach (string username in usernames)
                {
                    ForgetUserRoles(username);
                    foreach (string rolename in rolenames)
                    {
                        sql.AssignParameter("UserName", username);
                        sql.AssignParameter("RoleName", rolename);
                        sql.ExecuteNonQuery();
                    }
                }
        }
        
        public override void CreateRole(string rolename)
        {
            if (rolename.Contains(","))
            	throw new ArgumentException("Role names cannot contain commas.");
            if (RoleExists(rolename))
            	throw new ProviderException("Role already exists.");
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.CreateRole))
            {
                sql.AssignParameter("RoleName", rolename);
                sql.ExecuteNonQuery();
            }
        }
        
        public override bool DeleteRole(string rolename, bool throwOnPopulatedRole)
        {
            if (!(RoleExists(rolename)))
            	throw new ProviderException("Role does not exist.");
            if (throwOnPopulatedRole && (GetUsersInRole(rolename).Length > 0))
            	throw new ProviderException("Cannot delete a pouplated role.");
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.DeleteRole))
            {
                using (SqlStatement sql2 = CreateSqlStatement(RoleProviderSqlStatement.DeleteRoleUsers))
                {
                    sql2.AssignParameter("RoleName", rolename);
                    sql2.ExecuteNonQuery();
                }
                sql.AssignParameter("RoleName", rolename);
                sql.ExecuteNonQuery();
            }
            return true;
        }
        
        public override string[] GetAllRoles()
        {
            List<string> roles = new List<string>();
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.GetAllRoles))
            	while (sql.Read())
                	roles.Add(Convert.ToString(sql["RoleName"]));
            return roles.ToArray();
        }
        
        public override string[] GetRolesForUser(string username)
        {
            List<string> roles = null;
            string userRolesKey = String.Format("ApplicationRoleProvider_{0}_Roles", username);
            bool contextIsAvailable = (HttpContext.Current != null);
            if (contextIsAvailable)
            	roles = ((List<string>)(HttpContext.Current.Items[userRolesKey]));
            if (roles == null)
            {
                roles = new List<string>();
                using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.GetRolesForUser))
                {
                    sql.AssignParameter("UserName", username);
                    while (sql.Read())
                    	roles.Add(Convert.ToString(sql["RoleName"]));
                    if (contextIsAvailable)
                    	HttpContext.Current.Items[userRolesKey] = roles;
                }
            }
            return roles.ToArray();
        }
        
        public virtual void ForgetUserRoles(string username)
        {
            if (HttpContext.Current != null)
            	HttpContext.Current.Items.Remove(String.Format("ApplicationRoleProvider_{0}_Roles", username));
        }
        
        public override string[] GetUsersInRole(string rolename)
        {
            List<string> users = new List<string>();
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.GetUsersInRole))
            {
                sql.AssignParameter("RoleName", rolename);
                while (sql.Read())
                	users.Add(Convert.ToString(sql["UserName"]));
            }
            return users.ToArray();
        }
        
        public override bool IsUserInRole(string username, string rolename)
        {
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.IsUserInRole))
            {
                sql.AssignParameter("UserName", username);
                sql.AssignParameter("RoleName", rolename);
                return (Convert.ToInt32(sql.ExecuteScalar()) > 0);
            }
        }
        
        public override void RemoveUsersFromRoles(string[] usernames, string[] rolenames)
        {
            foreach (string rolename in rolenames)
            	if (!(RoleExists(rolename)))
                	throw new ProviderException(String.Format("Role \'{0}\' not found.", rolename));
            foreach (string username in usernames)
            	foreach (string rolename in rolenames)
                	if (!(IsUserInRole(username, rolename)))
                    	throw new ProviderException(String.Format("User \'{0}\' is not in role \'{1}\'.", username, rolename));
            foreach (string username in usernames)
            {
                ForgetUserRoles(username);
                foreach (string rolename in rolenames)
                	using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.RemoveUserFromRole))
                    {
                        sql.AssignParameter("UserName", username);
                        sql.AssignParameter("RoleName", rolename);
                        sql.ExecuteNonQuery();
                    }
            }
        }
        
        public override bool RoleExists(string rolename)
        {
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.RoleExists))
            {
                sql.AssignParameter("RoleName", rolename);
                return (Convert.ToInt32(sql.ExecuteScalar()) > 0);
            }
        }
        
        public override string[] FindUsersInRole(string rolename, string usernameToMatch)
        {
            List<string> users = new List<string>();
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.FindUsersInRole))
            {
                sql.AssignParameter("UserName", usernameToMatch);
                sql.AssignParameter("RoleName", rolename);
                while (sql.Read())
                	users.Add(Convert.ToString(sql["UserName"]));
            }
            return users.ToArray();
        }
    }
}
