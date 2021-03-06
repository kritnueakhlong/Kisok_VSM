
/*!
* Data Aquarium Framework - Resources
* Copyright 2008-2017 Code On Time LLC; Licensed MIT; http://codeontime.com/license
*/
(function () {
    Type.registerNamespace('Web');

    var _dvr = Web.DataViewResources = {};

    _dvr.Common = {
        WaitHtml: '<div class="Wait"></div>'
    };

    _dvr.Pager = {
        ItemsPerPage: 'รายการต่อหนึ่งหน้า :',
        PageSizes: [10, 15, 20, 25],
        ShowingItems: 'แสดง \u003cb\u003e{0}\u003c/b\u003e \u003cb\u003e{1}\u003c/b\u003e ของรายการ \u003cb\u003e{2}\u003c/b\u003e',
        SelectionInfo: ' (<b>{0}</b> selected)',
        Refresh: 'รีเฟรช',
        Next: 'ถัดไป »',
        Previous: '« ก่อนหน้า',
        Page: 'หน้า',
        PageButtonCount: 10
    };

    _dvr.ActionBar = {
        View: 'ดู'
    };

    _dvr.ModalPopup = {
        Close: 'ปิด',
        MaxWidth: 800,
        MaxHeight: 600,
        OkButton: 'ตกลง',
        CancelButton: 'ยกเลิก',
        SaveButton: 'บันทึก',
        SaveAndNewButton: 'บันทึกและใหม่'
    };

    _dvr.Menu = {
        SiteActions: 'การกระทำในไซต์',
        SeeAlso: 'ดูเพิ่มเติม',
        Summary: 'ข้อมูลอย่างย่อ',
        Tasks: 'งาน',
        About: 'เกี่ยวกับ'
    };

    _dvr.HeaderFilter = {
        GenericSortAscending: 'ที่เล็กที่สุดในยอดนิยม',
        GenericSortDescending: 'ที่ใหญ่ที่สุดบนยอด',
        StringSortAscending: 'จากน้อยไปมาก',
        StringSortDescending: 'มากไปน้อย',
        DateSortAscending: 'เร็วที่สุดด้านบน',
        DateSortDescending: 'ล่าสุดด้านบน',
        EmptyValue: '(ว่าง)',
        BlankValue: '(ว่าง)',
        Loading: 'กำลังโหลด ...',
        ClearFilter: 'ล้างตัวกรองจาก {0}',
        SortBy: 'เรียงตาม {0}',
        MaxSampleTextLen: 80,
        CustomFilterOption: 'ตัวกรอง ...'
    };

    _dvr.InfoBar = {
        FilterApplied: 'ตัวกรองจะถูกนำไปใช้',
        ValueIs: ' <span class="Highlight">{0}</span> ',
        Or: ' หรือ ',
        And: ' และ ',
        EqualTo: 'จะมีค่าเท่ากับ ',
        LessThan: 'มีค่าน้อยกว่า ',
        LessThanOrEqual: 'มีค่าน้อยกว่าหรือเท่ากับ ',
        GreaterThan: 'มีค่ามากกว่า ',
        GreaterThanOrEqual: 'มีค่ามากกว่าหรือเท่ากับ ',
        Like: 'เป็นเหมือน ',
        StartsWith: 'เริ่มต้นด้วย ',
        Empty: 'ว่างเปล่า',
        QuickFind: ' สาขาใดสาขาหนึ่งที่มี '
    };

    _dvr.Lookup = {
        SelectToolTip: 'เลือก {0}',
        ClearToolTip: '{0} ที่ชัดเจน',
        NewToolTip: '{0} ใหม่',
        SelectLink: '(เลือก)',
        ShowActionBar: true,
        DetailsToolTip: 'ดูรายละเอียดสำหรับ {0}',
        ShowDetailsInPopup: true,
        GenericNewToolTip: 'สร้างใหม่',
        AddItem: 'Add Item'
    };

    _dvr.Validator = {
        Required: 'Required',
        RequiredField: 'กรุณากรอกข้อมูลให้ครบถ้วน',
        EnforceRequiredFieldsWithDefaultValue: false,
        NumberIsExpected: 'จำนวนคาดว่าจะ',
        BooleanIsExpected: 'ค่าตรรกะเป็นที่คาดหวัง',
        DateIsExpected: 'วันที่คาดว่าจะ',
        Optional: 'Optional'
    };

    var _mn = Sys.CultureInfo.CurrentCulture.dateTimeFormat.MonthNames;

    _dvr.Data = {
        ConnectionLost: 'การเชื่อมต่อเครือข่ายได้รับการสูญหาย ลองอีกครั้งหรือไม่',
        AnyValue: '(any)',
        NullValue: '<span class="NA">n / a</span>',
        NullValueInForms: 'N / A',
        BooleanDefaultStyle: 'DropDownList',
        BooleanOptionalDefaultItems: [[null, 'N / A'], [false, 'ไม่มี'], [true, 'ใช่']],
        BooleanDefaultItems: [[false, 'ไม่มี'], [true, 'ใช่']],
        MaxReadOnlyStringLen: 600,
        NoRecords: 'ระเบียนไม่พบ',
        BlobHandler: 'Blob.ashx',
        BlobDownloadLink: 'ดาวน์โหลด',
        BlobDownloadLinkReadOnly: '<span style="color:gray;">ดาวน์โหลด</span>',
        BlobDownloadHint: 'คลิกที่นี่เพื่อดาวน์โหลดไฟล์ต้นฉบับ',
        BatchUpdate: 'การปรับปรุง',
        NoteEditLabel: 'แก้ไข',
        NoteDeleteLabel: 'ลบ',
        NoteDeleteConfirm: 'ลบ?',
        UseLEV: 'วาง \u0026quot;{0}\u0026quot;',
        DiscardChanges: 'Discard changes?',
        Import: {
            UploadInstruction: 'โปรดเลือกไฟล์ที่จะอัปโหลด แฟ้มจะต้องอยู่ใน \u003cb\u003eCSV\u003c/b\u003e, \u003cb\u003eXLS\u003c/b\u003e หรือรูปแบบ \u003cb\u003eXLSX\u003c/b\u003e',
            DownloadTemplate: 'ดาวน์โหลดแบบฟอร์มนำเข้าไฟล์',
            Uploading: 'ไฟล์ของคุณจะถูกอัพโหลดไปยังเซิร์ฟเวอร์ กรุณารอสักครู่ ...',
            MappingInstruction: 'มีบันทึก \u003cb\u003e{0}\u003c/b\u003e (s) ใน \u003cb\u003e{1}\u003c/b\u003e ไฟล์ที่พร้อมที่จะ processed.\u003cbr/\u003ePlease แผนที่เขตข้อมูลที่นำเข้าจากแฟ้มข้อมูลไปยังเขตข้อมูลใบสมัครและคลิก \u003ci\u003eImport\u003c/i\u003e เพื่อเริ่มต้นการประมวลผล',
            StartButton: 'นำเข้า',
            AutoDetect: '(อัตโนมัติตรวจสอบ)',
            Processing: 'การประมวลผลนำเข้าไฟล์ที่ได้รับการริเริ่ม ที่นำเข้าบันทึกข้อมูลจะกลายเป็นใช้ได้กับการประมวลผลที่ประสบความสำเร็จ คุณอาจจะต้องฟื้นฟูมุมมองที่เกี่ยวข้อง / หน้าจะดูระเบียนที่นำเข้า',
            Email: 'ส่งเข้าสู่ระบบนำเข้าเพื่อที่อยู่อีเมลต่อไปนี้ (เลือกได้)',
            EmailNotSpecified: 'ผู้รับการเข้าสู่ระบบการนำเข้าที่ไม่ได้รับการระบุไว้ ดำเนินการต่อไปหรือไม่?'
        },
        Filters: {
            Labels: {
                And: 'และ',
                Or: 'หรือ',
                Equals: 'เท่ากับ',
                Clear: 'ล้าง',
                SelectAll: '(เลือกทั้งหมด)',
                Includes: 'รวมถึงการ',
                FilterToolTip: 'เปลี่ยน'
            },
            Number: {
                Text: 'ตัวกรองตัวเลข',
                Kind: 'Number',
                List: [
                    { Function: '=', Text: 'เท่ากับ', Prompt: true },
                    { Function: '<>', Text: 'ไม่เท่ากับ', Prompt: true },
                    { Function: '<', Text: 'น้อยกว่า', Prompt: true },
                    { Function: '>', Text: 'ที่สูงกว่า', Prompt: true },
                    { Function: '<=', Text: 'Less Than Or Equal', Prompt: true },
                    { Function: '>=', Text: 'Greater Than Or Equal', Prompt: true },
                    { Function: '$between', Text: 'ระหว่าง', Prompt: true },
                    { Function: '$in', Text: 'รวมถึงการ', Prompt: true, Hidden: true },
                    { Function: '$notin', Text: 'ไม่รวมถึง', Prompt: true, Hidden: true },
                    { Function: '$isnotempty', Text: 'Not Empty' },
                    { Function: '$isempty', Text: 'Empty' }
                ]
            },
            Text: {
                Text: 'ตัวกรองข้อความ',
                Kind: 'Text',
                List: [
                    { Function: '=', Text: 'เท่ากับ', Prompt: true },
                    { Function: '<>', Text: 'ไม่เท่ากับ', Prompt: true },
                    { Function: '$beginswith', Text: 'เริ่มต้นด้วย', Prompt: true },
                    { Function: '$doesnotbeginwith', Text: 'ไม่ได้เริ่มต้นด้วย', Prompt: true },
                    { Function: '$contains', Text: 'ประกอบด้วย', Prompt: true },
                    { Function: '$doesnotcontain', Text: 'ไม่ได้มี', Prompt: true },
                    { Function: '$endswith', Text: 'ลงท้ายด้วย', Prompt: true },
                    { Function: '$doesnotendwith', Text: 'ไม่ได้สิ้นสุดด้วย', Prompt: true },
                    { Function: '$in', Text: 'รวมถึงการ', Prompt: true, Hidden: true },
                    { Function: '$notin', Text: 'ไม่รวมถึง', Prompt: true, Hidden: true },
                    { Function: '$isnotempty', Text: 'Not Empty' },
                    { Function: '$isempty', Text: 'Empty' }
                ]
            },
            Boolean: {
                Text: 'กรองตรรกะ',
                Kind: 'Logical',
                List: [
                    { Function: '$true', Text: 'ใช่' },
                    { Function: '$false', Text: 'ไม่มี' },
                    { Function: '$isnotempty', Text: 'Not Empty' },
                    { Function: '$isempty', Text: 'Empty' }
                ]
            },
            Date: {
                Text: 'ตัวกรองวันที่',
                Kind: 'Date',
                List: [
                    { Function: '=', Text: 'เท่ากับ', Prompt: true },
                    { Function: '<>', Text: 'ไม่เท่ากับ', Prompt: true },
                    { Function: '<', Text: 'ก่อนที่จะ', Prompt: true },
                    { Function: '>', Text: 'หลังจากที่', Prompt: true },
                    { Function: '<=', Text: 'On or Before', Prompt: true },
                    { Function: '>=', Text: 'On or After', Prompt: true },
                    { Function: '$between', Text: 'ระหว่าง', Prompt: true },
                    { Function: '$in', Text: 'รวมถึงการ', Prompt: true, Hidden: true },
                    { Function: '$notin', Text: 'ไม่รวมถึง', Prompt: true, Hidden: true },
                    { Function: '$isnotempty', Text: 'Not Empty' },
                    { Function: '$isempty', Text: 'Empty' },
                    null,
                    { Function: '$tomorrow', Text: 'วันพรุ่งนี้' },
                    { Function: '$today', Text: 'วันนี้' },
                    { Function: '$yesterday', Text: 'เมื่อวาน' },
                    null,
                    { Function: '$nextweek', Text: 'สัปดาห์ถัดไป' },
                    { Function: '$thisweek', Text: 'สัปดาห์นี้' },
                    { Function: '$lastweek', Text: 'สัปดาห์สุดท้าย' },
                    null,
                    { Function: '$nextmonth', Text: 'เดือนถัดไป' },
                    { Function: '$thismonth', Text: 'เดือนนี้เดือนนี้' },
                    { Function: '$lastmonth', Text: 'เดือนสุดท้าย' },
                    null,
                    { Function: '$nextquarter', Text: 'ไตรมาสถัดไป' },
                    { Function: '$thisquarter', Text: 'ไตรมาสนี้' },
                    { Function: '$lastquarter', Text: 'ไตรมาสสุดท้าย' },
                    null,
                    { Function: '$nextyear', Text: 'ปีถัดไป' },
                    { Function: '$thisyear', Text: 'เดือนนี้ปีนี้' },
                    { Function: '$yeartodate', Text: 'ปีในวันที่' },
                    { Function: '$lastyear', Text: 'ปีสุดท้าย' },
                    null,
                    { Function: '$past', Text: 'ที่ผ่านมา' },
                    { Function: '$future', Text: 'อนาคต' },
                    null,
                    {
                        Text: 'วันที่ทั้งหมดในระยะเวลา',
                        List: [
                            { Function: '$quarter1', Text: 'ไตรมาสที่ 1' },
                            { Function: '$quarter2', Text: 'ไตรมาสที่ 2' },
                            { Function: '$quarter3', Text: 'ไตรมาสที่ 3' },
                            { Function: '$quarter4', Text: 'ไตรมาส 4' },
                            null,
                            { Function: '$month1', Text: _mn[0] },
                            { Function: '$month2', Text: _mn[1] },
                            { Function: '$month3', Text: _mn[2] },
                            { Function: '$month4', Text: _mn[3] },
                            { Function: '$month5', Text: _mn[4] },
                            { Function: '$month6', Text: _mn[5] },
                            { Function: '$month7', Text: _mn[6] },
                            { Function: '$month8', Text: _mn[7] },
                            { Function: '$month9', Text: _mn[8] },
                            { Function: '$month10', Text: _mn[9] },
                            { Function: '$month11', Text: _mn[10] },
                            { Function: '$month12', Text: _mn[11] }
                        ]
                    }
            ]
            }
        }
    };


    _dvr.Form = {
        ShowActionBar: true,
        ShowCalendarButton: true,
        RequiredFieldMarker: '<span class="Required">*</span>',
        RequiredFiledMarkerFootnote: '* - บ่งชี้ถึงข้อมูลที่จำเป็นต้อง',
        SingleButtonRowFieldLimit: 7,
        GeneralTabText: 'ทั่วไป',
        Minimize: 'ยุบ',
        Maximize: 'ขยาย'
    };

    _dvr.Grid = {
        InPlaceEditContextMenuEnabled: true,
        QuickFindText: 'ค้นหา',
        QuickFindToolTip: 'พิมพ์เพื่อค้นหาระเบียนและกด Enter',
        ShowAdvancedSearch: 'แสดงการค้นหาขั้นสูง',
        VisibleSearchBarFields: 3,
        DeleteSearchBarField: '(ลบ)',
        //AddSearchBarField: 'เขตข้อมูลการค้นหาเพิ่มเติม',
        HideAdvancedSearch: 'ซ่อนการค้นหาขั้นสูง',
        PerformAdvancedSearch: 'ค้นหา',
        ResetAdvancedSearch: 'ตั้งค่าใหม่',
        NewRowLink: 'คลิกที่นี่เพื่อสร้างระเบียนใหม่',
        RootNodeText: 'ระดับสูงสุด',
        FlatTreeToggle: 'เปลี่ยนไปเป็นลำดับชั้น',
        HierarchyTreeModeToggle: 'สลับไปที่รายการแบบเรียบ',
        AddConditionText: 'เพิ่มเงื่อนไขการค้นหา',
        AddCondition: 'เพิ่มเงื่อนไข',
        RemoveCondition: 'เอาสภาพ',
        ActionColumnHeaderText: 'การกระทำ',
        Aggregates: {
            None: { FmtStr: '', ToolTip: '' },
            Sum: { FmtStr: 'ผลรวม : {0}', ToolTip: 'ผลรวมของ {0}' },
            Count: { FmtStr: 'Re : {0}', ToolTip: 'นับจาก {0}' },
            Avg: { FmtStr: 'เฉลี่ย : {0}', ToolTip: 'ค่าเฉลี่ยของ {0}' },
            Max: { FmtStr: 'สูงสุด : {0}', ToolTip: 'สูงสุดของ {0}' },
            Min: { FmtStr: 'ขั้นต่ำ : {0}', ToolTip: 'ขั้นต่ำของ {0}' }
        },
        Freeze: 'แข็ง',
        Unfreeze: 'ทำน้ำแข็งให้ละลาย'
    };

    _dvr.Views = {
        DefaultDescriptions: {
            '$DefaultGridViewDescription': 'นี่คือรายการของ {0}',
            '$DefaultEditViewDescription': 'กรุณาตรวจสอบข้อมูลด้านล่าง {0} คลิกที่แก้ไขเพื่อบัน​​ทึกการเปลี่ยนแปลงนี้ให้คลิกลบเพื่อลบการบันทึกหรือคลิกยกเลิก / ปิดเพื่อกลับกลับ',
            '$DefaultCreateViewDescription': 'กรุณากรอกแบบฟอร์มนี้และคลิกปุ่ม OK เพื่อสร้างระเบียนใหม่ {0} คลิกยกเลิกเพื่อกลับไปยังหน้าจอ'
        },
        DefaultCategoryDescriptions: {
            '$DefaultEditDescription': 'เหล่านี้เป็นเขตข้อมูลของระเบียน {0} ที่สามารถแก้ไขได้',
            '$DefaultNewDescription': 'กรอกแบบฟอร์ม ให้แน่ใจว่าจะใส่ฟิลด์ที่จำเป็นทั้งหมด',
            '$DefaultReferenceDescription': 'รายละเอียดเพิ่มเติมเกี่ยวกับ {0} มีให้ในส่วนของข้อมูลอ้างอิง'
        }
    };

    _dvr.Actions = {
        Scopes: {
            'Grid': {
                'Select': {
                    HeaderText: 'เลือก'
                },
                'Edit': {
                    HeaderText: 'แก้ไข'
                },
                'Delete': {
                    HeaderText: 'ลบ',
                    Confirmation: 'ลบ?',
                    Notify: '{$selected} deleted'
                },
                'Duplicate': {
                    HeaderText: 'ซ้ำ'
                },
                'New': {
                    HeaderText: 'ใหม่'
                },
                'BatchEdit': {
                    HeaderText: 'แก้ไขเป็นกลุ่ม'
                    //                    ,CommandArgument: {
                    //                        'editForm1': {
                    //                            HeaderText: 'ชุดแก้ไข (แบบฟอร์ม)'
                    //                        }
                    //                    }
                },
                'Open': {
                    HeaderText: 'เปิด'
                }
            },
            'Form': {
                'Edit': {
                    HeaderText: 'แก้ไข'
                },
                'Delete': {
                    HeaderText: 'ลบ',
                    Confirmation: 'ลบ?',
                    Notify: '{$selected} deleted'
                },
                'Cancel': {
                    HeaderText: 'ปิด',
                    WhenLastCommandName: {
                        'Duplicate': {
                            HeaderText: 'ยกเลิก'
                        },
                        'Edit': {
                            HeaderText: 'ยกเลิก'
                        },
                        'New': {
                            HeaderText: 'ยกเลิก'
                        }

                    }
                },
                'Update': {
                    HeaderText: 'ตกลง',
                    Notify: 'Saved - {0}',
                    CommandArgument: {
                        'Save': {
                            HeaderText: 'บันทึก',
                            Notify: 'Saved - {0}'
                        }
                    },
                    WhenLastCommandName: {
                        'BatchEdit': {
                            HeaderText: 'การคัดเลือกปรับปรุง',
                            Confirmation: 'ปรับปรุง?',
                            Notify: 'Saved - {0}'
                        }
                    }
                },
                'Insert': {
                    HeaderText: 'ตกลง',
                    Notify: 'Saved - {0}',
                    CommandArgument: {
                        'Save': {
                            HeaderText: 'บันทึก',
                            Notify: 'Saved - {0}'
                        },
                        'SaveAndNew': {
                            HeaderText: 'บันทึกและใหม่',
                            Notify: 'Saved - {0}'
                        }
                    }
                },
                'Confirm': {
                    HeaderText: 'ตกลง'
                },
                'Navigate': {
                    Controller: {
                        'SiteContent': {
                            HeaderText: 'Add System Identity'
                        }
                    }
                }
            },
            'ActionBar': {
                _Self: {
                    'Actions': {
                        HeaderText: 'การกระทำ'
                    },
                    'Report': {
                        HeaderText: 'รายงาน'
                    },
                    'Record': {
                        HeaderText: 'บันทึก'
                    }
                },
                'New': {
                    HeaderText: '{0} ใหม่',
                    Description: 'สร้างระเบียนใหม่ {0}',
                    HeaderText2: 'ใหม่',
                    VarMaxLen: 15
                },
                'Edit': {
                    HeaderText: 'แก้ไข'
                },
                'Delete': {
                    HeaderText: 'ลบ',
                    Confirmation: 'ลบ?',
                    Notify: '{$selected} deleted'
                },
                'ExportCsv': {
                    HeaderText: 'ดาวน์โหลด',
                    Description: 'รายการดาวน์โหลดในรูปแบบ CSV'
                },
                'ExportRowset': {
                    HeaderText: 'การส่งออกไปยังกระดาษคำนวณ',
                    Description: 'วิเคราะห์รายการที่มี spreadsheet\u003cbr/\u003eapplication'
                },
                'ExportRss': {
                    HeaderText: 'ดู RSS ฟีด',
                    Description: 'รายการซินดิเคกับตัวอ่าน RSS'
                },
                'Import': {
                    HeaderText: 'นำเข้าจากไฟล์',
                    Description: 'อัปโหลดไฟล์ CSV, XLS, หรือ XLSX ระเบียน file\u003cbr/\u003eto นำเข้า'
                },
                'Update': {
                    HeaderText: 'บันทึก',
                    Description: 'บันทึกการเปลี่ยนแปลงไปยังฐานข้อมูล',
                    Notify: 'Saved - {0}'
                },
                'Insert': {
                    HeaderText: 'บันทึก',
                    Description: 'บันทึกบันทึกใหม่ไปยังฐานข้อมูล',
                    Notify: 'Saved - {0}'
                },
                'Cancel': {
                    HeaderText: 'ยกเลิก',
                    WhenLastCommandName: {
                        'Edit': {
                            HeaderText: 'ยกเลิก',
                            Description: 'ยกเลิกการเปลี่ยนแปลงการบันทึกทั้งหมด'
                        },
                        'New': {
                            HeaderText: 'ยกเลิก',
                            Description: 'ยกเลิกการบันทึกใหม่'
                        }
                    }
                },
                'Report': {
                    HeaderText: 'รายงาน',
                    Description: 'แสดงรายงานในรูปแบบ PDF'
                },
                'ReportAsPdf': {
                    HeaderText: 'เอกสาร PDF',
                    Description: 'ดูรายการที่เป็น Adob​​e PDF document.\u003cbr/\u003eRequires เป็นผู้อ่านที่เข้ากันได้'
                },
                'ReportAsImage': {
                    HeaderText: 'มีหลายภาพ',
                    Description: 'ดูรายการเป็นภาพที่มีหลายรูปแบบ TIFF'
                },
                'ReportAsExcel': {
                    HeaderText: 'สเปรดชีท',
                    Description: 'ดูรายการในกระดาษคำนวณ Excel formatted\u003cbr/\u003eMicrosoft'
                },
                'ReportAsWord': {
                    HeaderText: 'โปรแกรม Microsoft Word',
                    Description: 'ดูรายการในเอกสาร Word formatted\u003cbr/\u003eMicrosoft'
                },
                'DataSheet': {
                    HeaderText: 'แสดง F ใน Data Sheet',
                    Description: 'รายการแสดงการใช้ sheet\u003cbr/\u003eformat ข้อมูล'
                },
                'Grid': {
                    HeaderText: 'แสดงในมุมมองมาตรฐาน',
                    Description: 'รายการที่แสดงในรูปแบบ standard\u003cbr/\u003elist'
                },
                'Tree': {
                    HeaderText: 'แสดงลำดับชั้น',
                    Description: 'แสดงความสัมพันธ์แบบลำดับชั้น'
                },
                'Search': {
                    HeaderText: 'ค้นหา',
                    Description: 'ค้นหา {0}'
                }
            },
            'Row': {
                'Update': {
                    HeaderText: 'บันทึก',
                    Notify: 'Saved - {0}',
                    WhenLastCommandName: {
                        'BatchEdit': {
                            HeaderText: 'การคัดเลือกปรับปรุง',
                            Confirmation: 'ปรับปรุง?'
                        }
                    }
                },
                'Insert': {
                    HeaderText: 'แทรก',
                    Notify: 'Saved - {0}'
                },
                'Cancel': {
                    HeaderText: 'ยกเลิก'
                }
            },
            'ActionColumn': {
                'Edit': {
                    HeaderText: 'แก้ไข'
                },
                'Delete': {
                    HeaderText: 'ลบ',
                    Confirmation: 'ลบ?',
                    Notify: '{$selected} deleted'
                }
            }
        }
    };

    _dvr.Editor = {
        Undo: 'แก้',
        Redo: 'ทำซ้ำ',
        Bold: 'กล้าหาญ',
        Italic: 'ตัวเอียง',
        Underline: 'ขีดเส้นใต้',
        Strikethrough: 'Strike ผ่าน',
        Subscript: 'สคริปต์ย่อย',
        Superscript: 'สคริปต์ซุปเปอร์',
        JustifyLeft: 'ปรับซ้าย',
        JustifyCenter: 'แสดงให้เห็นถึงศูนย์',
        JustifyRight: 'แสดงให้เห็นถึงขวา',
        JustifyFull: 'ให้เห็นถึงความเต็ม',
        InsertOrderedList: 'ใส่รายชื่อสั่งซื้อ',
        InsertUnorderedList: 'แทรกรายการเรียงลำดับ',
        CreateLink: 'สร้างการเชื่อมโยง',
        UnLink: 'ยกเลิกการเชื่อมโยง',
        RemoveFormat: 'ลบรูปแบบ',
        SelectAll: 'เลือกทั้งหมด',
        UnSelect: 'ยกเลิกการเลือก',
        Delete: 'ลบ',
        Cut: 'ตัด',
        Copy: 'คัดลอก',
        Paste: 'แปะ',
        BackColor: 'สีกลับ',
        ForeColor: 'สี Fore',
        FontName: 'ชื่อ Font',
        FontSize: 'ขนาดตัวอักษร',
        Indent: 'ย่อหน้า',
        Outdent: 'เยื้องออก',
        InsertHorizontalRule: 'ใส่กฎแนวนอน',
        HorizontalSeparator: 'เครื่องสกัด',
        Format: 'Format',
        FormatBlock: {
            p: 'Paragraph',
            blockquote: 'Quotation',
            h1: 'Heading 1',
            h2: 'Heading 2',
            h3: 'Heading 3',
            h4: 'Heading 4',
            h5: 'Heading 5',
            h6: 'Heading 6'
        },
        Rtf: {
            editor: 'Fullscreen'
        }
    };

    _dvr.Mobile = {
        UpOneLevel: 'ขึ้นหนึ่งระดับ',
        Back: 'กลับ',
        BatchEdited: '{0} updated',
        Sort: 'แยกกลุ่ม',
        Sorted: 'Sorted',
        SortedDefault: 'Default sort order.',
        SortByField: 'เลือกเขตข้อมูลที่จะเปลี่ยนลำดับการจัดเรียงของ \u003cb\u003e{0}\u003c/b\u003e',
        SortByOptions: 'เลือกลำดับการจัดเรียงของ \u003cb\u003e{0}\u003c/b\u003e โดยสนาม \u003cb\u003e{1}\u003c/b\u003e ในรายการของตัวเลือกด้านล่าง',
        DefaultOption: 'มาตรฐาน',
        Auto: 'Auto',
        Filter: 'กรอง',
        List: 'List',
        Cards: 'บัตร',
        Grid: 'ตะแกรง',
        Map: 'Map',
        Calendar: 'Calendar',
        ZoomIn: 'Zoom in',
        ZoomOut: 'Zoom out',
        Directions: 'Directions',
        AlternativeView: 'เลือกมุมมองทางเลือกของข้อมูล',
        PresentationStyle: 'เลือกรูปแบบการนำเสนอข้อมูล',
        LookupViewAction: 'ดู',
        LookupSelectAction: 'เลือก',
        LookupClearAction: 'ล้าง',
        LookupNewAction: 'ใหม่',
        LookupInstruction: 'กรุณาเลือก \u003cb\u003e{0}\u003c/b\u003e ในรายการ',
        LookupOriginalSelection: 'เลือกเดิม \u003cb\u003e\u0026quot;{0}\u0026quot;\u003c/b\u003e',
        EmptyContext: 'การกระทำที่ไม่สามารถใช้ได้',
        Favorites: 'รายการโปรด',
        History: 'ประวัติ',
        FilterSiteMap: 'แผนที่เว็บไซต์กรอง ...',
        ResumeLookup: 'Resume Lookup',
        ResumeEntering: 'Resume Entering',
        ResumeEditing: 'Resume Editing',
        ResumeBrowsing: 'Resume Browsing',
        ResumeViewing: 'Resume Viewing',
        Menu: 'Menu',
        Home: 'Home',
        Settings: 'Settings',
        Sidebar: 'Sidebar',
        Landscape: 'Landscape',
        Portrait: 'Portrait',
        Never: 'Never',
        Always: 'Always',
        ShowSystemButtons: 'Show System Buttons',
        OnHover: 'On Hover',
        ButtonShapes: 'Button Shapes',
        PromoteActions: 'Promote Actions',
        ConfirmReload: 'Reload?',
        ClearText: 'Clear Text',
        SeeAll: 'See All',
        More: 'More',
        TouchUINotSupported: 'Touch UI is not supported in this browser.',
        ShowingItemsInfo: 'Showing _____ items.',
        FilterByField: 'Select a field to apply a filter to _______________.',
        Apply: 'Apply',
        FilterByOptions: 'Select one or more options in the list below and press _______________ to filter _______________ by the field _______________.',
        Suggestions: 'Suggestions',
        UnSelect: 'ยกเลิกการเลือก',
        AdvancedSearch: 'Advanced Search',
        QuickFindScope: 'Search in...',
        AddMatchingGroup: 'Add matching group',
        MatchAll: 'Match all conditions',
        MatchAny: 'Match any conditions',
        DoNotMatchAll: 'Do not match all conditions',
        DoNotMatchAny: 'Do not match any conditions',
        MatchAllPastTense: 'Matched all conditions',
        MatchAnyPastTense: 'Matched any conditions',
        DoNotMatchAllPastTense: 'Did not match all conditions',
        DoNotMatchAnyPastTense: 'Did not match any conditions',
        In: 'in',
        Recent: 'Recent',
        Matched: 'Matched',
        DidNotMatch: 'Did not match',
        ClearFilter: 'Clear Filter',
        ResetSearchConfirm: 'Reset search conditions?',
        FilterCleared: 'Cleared all filters.',
        AdvancedSearchInstruction: 'Enter conditions that must be matched and press search button.',
        Refreshed: 'Refreshed',
        Group: 'Group',
        Grouped: 'Grouped',
        UnGrouped: 'Grouping has been removed',
        GroupedBy: 'Grouped by',
        GroupByField: 'Select a field to group \u003cb\u003e{0}\u003c/b\u003e.',
        Show: 'Show',
        Hide: 'Hide',
        None: 'None',
        Next: 'Next',
        Prev: 'Prev',
        FitToWidth: 'Fit To Width',
        MultiSelection: 'Multi Selection',
        ItemsSelectedOne: '{0} item selected',
        ItemsSelectedMany: '{0} items selected',
        TypeToSearch: 'Type to Search',
        NoMatches: 'No matches.',
        ShowingItemsRange: 'Showing {0} of {1} items',
        Finish: 'Finish',
        ShowOptions: 'Show Options',
        ConfirmContinue: 'Continue?',
        AddAccount: 'Add Account',
        Fullscreen: 'Fullscreen',
        ExitFullscreen: 'Exit Fullscreen',
        Apps: 'Apps',
        Forget: 'Forget',
        ManageAccounts: 'Manage Accounts',
        SignedOut: 'Signed Out',
        Submit: 'Submit',
        Error: 'Error',
        Line: 'Line',
        Download: 'Download',
        Orientation: 'Orientation',
        Device: 'Device',
        ShowMore: 'Show More',
        ShowLess: 'Show Less',
        WithSpecifiedFilters: 'With Specified Filters',
        WithSelectedValues5: 'With Selected Values (Top 5)',
        WithSelectedValues10: 'With Selected Values (Top 10)',
        DisplayDensity: {
            Label: 'Display Density',
            List: {
                Tiny: 'Tiny',
                Condensed: 'Condensed',
                Compact: 'Compact',
                Comfortable: 'Comfortable'
            }
        },
        Files: {
            KB: 'KB',
            MB: 'MB',
            Bytes: 'bytes',
            Drop: 'Drop a file here',
            DropMany: 'Drop files here',
            Tap: 'Tap to select a file',
            TapMany: 'Tap to select files',
            Click: 'Click to select a file',
            ClickMany: 'Click to select files',
            Clear: 'Clear',
            ClearConfirm: 'Clear?',
            Sign: 'Sign here'
        },
        Import: {
            SelectFile: 'Select a data file in CSV, XLS, or XLSX format.',
            NotSupported: 'Data format of \"{0}\" is not supported.',
            NotMatched: '(not matched)',
            FileStats: 'There are \u003cb\u003e{0}\u003c/b\u003e records in the file \u003cb\u003e{1}\u003c/b\u003e ready to be processed. Please match the field names.',
            Importing: 'Importing',
            Into: 'into',
            StartImport: 'Start Import',
            InsertingRecords: 'Inserting records',
            TestingRecords: 'Testing records',
            ResolvingReferences: 'Resolving references',
            Complete: 'complete',
            Expected: 'Expected to complete',
            Remaining: 'Remaining',
            Done: 'Completed importing',
            Duplicates: 'Duplicates'
        },
        Themes: {
            Label: 'Theme',
            Accent: 'Accent',
            List: {
                None: 'None',
                Light: 'Light',
                Dark: 'Dark',
                Aquarium: 'Aquarium',
                Azure: 'Azure',
                Belltown: 'Belltown',
                Berry: 'Berry',
                Bittersweet: 'Bittersweet',
                Cay: 'Cay',
                Citrus: 'Citrus',
                Classic: 'Classic',
                Construct: 'Construct',
                Convention: 'Convention',
                DarkKnight: 'Dark Knight',
                Felt: 'Felt',
                Graham: 'Graham',
                Granite: 'Granite',
                Grapello: 'Grapello',
                Gravity: 'Gravity',
                Lacquer: 'Lacquer',
                Laminate: 'Laminate',
                Lichen: 'Lichen',
                Mission: 'Mission',
                Modern: 'Modern',
                ModernRose: 'Modern Rose',
                Municipal: 'Municipal',
                Petal: 'Petal',
                Pinnate: 'Pinnate',
                Plastic: 'Plastic',
                Ricasso: 'Ricasso',
                Simple: 'Simple',
                Social: 'Social',
                Summer: 'Summer',
                Vantage: 'Vantage',
                Verdant: 'Verdant',
                Viewpoint: 'Viewpoint',
                WhiteSmoke: 'White Smoke',
                Yoshi: 'Yoshi'
            }
        },
        Transitions: {
            Label: 'Transitions',
            List: {
                none: 'None',
                slide: 'Slide',
                fade: 'Fade',
                pop: 'Pop',
                flip: 'Flip',
                turn: 'Turn',
                flow: 'Flow',
                slideup: 'Slide Up',
                slidedown: 'Slide Down'
            }
        },
        LabelsInList: {
            Label: 'Labels In List',
            List: {
                DisplayedAbove: 'Displayed Above',
                DisplayedBelow: 'Displayed Below'
            }
        },
        InitialListMode: {
            Label: 'Initial List Mode',
            List: {
                SeeAll: 'See All',
                Summary: 'ข้อมูลอย่างย่อ'
            }
        },
        Dates: {
            SmartDates: 'Smart Dates',
            Yesterday: 'Yesterday',
            Last: 'Last',
            Today: 'Today',
            OneHour: 'an hour ago',
            MinAgo: '{0} min ago',
            AMinAgo: 'a minute ago',
            InHour: 'in an hour',
            InMin: 'in {0} min',
            InAMin: 'in a minute',
            Now: 'Now',
            JustNow: 'Just now',
            Tomorrow: 'Tomorrow',
            Next: 'Next'
        },
        Develop: {
            Tools: 'Developer Tools',
            Explorer: 'Project Explorer',
            FormLayout: 'Form Layout',
            FormLayoutInstr: 'Select screen sizes to be included in the layout.'
        }
    };

    _dvr.Presenters = {
        Charts: {
            Text: 'Charts',
            DataWarning: 'The maximum number of items to process is {0:d}. Please apply a filter to reduce the number of items.',
            ShowData: 'Show Data',
            ShowChart: 'Show Chart',
            Sizes: {
                Label: 'Size',
                Small: 'Small',
                Medium: 'Medium',
                Large: 'Large'
            },
            ChartLabels: {
                By: 'by',
                Top: 'top',
                Other: 'Other',
                Blank: 'Blank',
                GrandTotals: 'Grand Totals',
                CountOf: 'Count of',
                SumOf: 'Total of',
                AvgOf: 'Average of',
                MinOf: 'Minimum of',
                MaxOf: 'Maximum of',
                Quarter: 'Quarter',
                Week: 'Week'
            }
        },
        Calendar: {
            Text: 'Calendar',
            Today: 'วันนี้',
            Noon: 'Noon',
            Year: 'Year',
            Month: 'Month',
            Week: 'Week',
            Day: 'Day',
            Agenda: 'Agenda',
            Sync: 'Sync',
            Less: 'Less'
        }
    };

    // membership resources

    var _mr = Web.MembershipResources = {};

    _mr.Bar = {
        LoginLink: 'เข้าสู่ระบบ',
        LoginText: ' ไปที่เว็บไซต์นี้',
        HelpLink: 'ช่วยเหลือ',
        UserName: 'ชื่อผู้ใช้:',
        Password: 'รหัสผ่าน:',
        RememberMe: 'จำฉันไว้ในครั้งถัดไป',
        ForgotPassword: 'ลืมรหัสผ่าน?',
        SignUp: 'Sign up now',
        LoginButton: 'เข้าสู่ระบบ',
        MyAccount: 'บัญชีของฉัน',
        LogoutLink: 'ออกจากระบบ',
        HelpCloseButton: 'ปิด',
        HelpFullScreenButton: 'เต็มหน้าจอ',
        UserIdle: 'คุณจะยังคงมี? กรุณาเข้าสู่ระบบอีกครั้ง',
        History: 'ประวัติ',
        Permalink: 'ความคิดเห็น',
        AddToFavorites: 'เพิ่มในรายการโปรด',
        RotateHistory: 'หมุน',
        Welcome: 'ยินดีต้อนรับคุณ <b>{0}</b>, วันนี้ {1:D}',
        ChangeLanguageToolTip: 'Change your language',
        PermalinkToolTip: 'สร้างการเชื่อมโยงอย่างถาวรสำหรับการบันทึกที่เลือก',
        HistoryToolTip: 'ดูประวัติของระเบียนที่เลือกก่อนหน้านี้',
        AutoDetectLanguageOption: 'Auto Detect'
    };

    _mr.Messages = {
        InvalidUserNameAndPassword: 'ชื่อผู้ใช้และรหัสผ่านของคุณจะไม่ถูกต้อง',
        BlankUserName: 'ชื่อผู้ใช้ต้องไม่ว่างเปล่า',
        BlankPassword: 'รหัสผ่านไม่สามารถที่ว่างเปล่า',
        PermalinkUnavailable: 'เพราะไม่สามารถใช้ได้ กรุณาเลือกบันทึก',
        HistoryUnavailable: 'ประวัติความเป็นมาไม่สามารถใช้ได้'
    };

    _mr.Manager = {
        UsersTab: 'ผู้ใช้งาน',
        RolesTab: 'บทบาท',
        UsersInRole: 'ผู้ใช้ในบทบาท'
    };

    if (typeof Sys !== 'undefined') Sys.Application.notifyScriptLoaded();
})();