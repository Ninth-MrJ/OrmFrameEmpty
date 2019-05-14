﻿

using System;
namespace Orm.Model
{
    /// <summary>
    /// 分院 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsHospital : BaseModel
    {

        private string _code;  //注册登记号

        private string _name;  //分院名称

        private string _areaId;  //地区编码

        private string _pyCode;  //拼音码

        private string _wbCode;  //五笔码

        private int _orderBy;  //显示顺序

        private bool _isActive;  //有效标志

        private double _area;  //单位面积（平方公里）

        private int _farthest;  //最远距离（公里）

        private string _address;  //联系人地址

        private string _phone;  //联系人的电话

        private string _email;  //电子邮件

        private int _residentPopulation;  //法定常住人口

        private int _tentPopulation;  //法定暂住人口

        private string _memo;  //备注

        private int _iconIndex;  //图标类型

        private string _centralCode;  //F1中心编码

        private string _medicalCode;  //F2医疗机构编码

        private string _regionId;  //市

        private byte[] _certificate;  //执业证书

        private string _provinceId;  //省

        private string _userId;  //管理员ID

        private string _engDesc;  //英文名

        private byte[] _license;  //营业执照


        private string _manageUser;  //负责人、法定人

        private bool _isAudit;  //是否审核

        private string _cashierReport;/// 收费打印报表名

        private string _bsSpecialistNames;//专家名称(多名)

        private string _bsSpecialistIDs;//专家ID（多名）
        private string _unionId;//医联体GUID
        private int _hisType;//产品类型

        private bool _isInterface;
        private bool _isInterUMP;
        private string _reportTitle;
        private bool _isEnableInventory;
        private bool _isEnableFreshInventory;

        private string _contrastCode;


        /// <summary>
        /// 对比编码
        /// </summary>
        public string ContrastCode
        {
            get { return _contrastCode; }
            set { _contrastCode = value; }
        }
        /// <summary>
        /// 是否启用药品库存
        /// </summary>
        public bool IsEnableInventory
        {
            get { return _isEnableInventory; }
            set { _isEnableInventory = value; }
        }
        /// <summary>
        /// 是否启用生鲜库存
        /// </summary>
        public bool IsEnableFreshInventory
        {
            get { return _isEnableFreshInventory; }
            set { _isEnableFreshInventory = value; }
        }


        /// <summary>
        /// 药房编码
        /// </summary>
        public string ReportTitle
        {
            get
            {
                return _reportTitle;
            }
            set
            {
                _reportTitle = value;
            }
        }
        /// <summary>
        /// 药品对接版本
        /// </summary>
        public bool IsInterUMP
        {
            get { return _isInterUMP; }
            set { _isInterUMP = value; }
        }
        /// <summary>
        /// 药品对接（是否启用接口）
        /// </summary>
        public bool IsInterface
        {
            get { return _isInterface; }
            set { _isInterface = value; }
        }

        /// <summary>
        /// 专家名称(多名)
        /// </summary>
        public string BsSpeciaNameLists
        {
            get { return _bsSpecialistNames; }
            set { _bsSpecialistNames = value; }
        }

        /// <summary>
        /// 专家ID
        /// </summary>
        public string BsSpeciaIDLists
        {
            get { return _bsSpecialistIDs; }
            set { _bsSpecialistIDs = value; }
        }


        /// <summary>
        /// 注册登记号
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 分院名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 地区编码
        /// </summary>
        public string AreaId
        {
            get { return _areaId; }
            set { _areaId = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 有效标志
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 单位面积（平方公里）
        /// </summary>
        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        /// 最远距离（公里）
        /// </summary>
        public int Farthest
        {
            get { return _farthest; }
            set { _farthest = value; }
        }

        /// <summary>
        /// 联系人地址
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// 联系人的电话
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// 法定常住人口
        /// </summary>
        public int ResidentPopulation
        {
            get { return _residentPopulation; }
            set { _residentPopulation = value; }
        }

        /// <summary>
        /// 法定暂住人口
        /// </summary>
        public int TentPopulation
        {
            get { return _tentPopulation; }
            set { _tentPopulation = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 图标类型
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }

        /// <summary>
        /// F1中心编码
        /// </summary>
        public string CentralCode
        {
            get { return _centralCode; }
            set { _centralCode = value; }
        }

        /// <summary>
        /// F2医疗机构编码
        /// </summary>
        public string MedicalCode
        {
            get { return _medicalCode; }
            set { _medicalCode = value; }
        }

        /// <summary>
        /// 市
        /// </summary>
        public string RegionId
        {
            get { return _regionId; }
            set { _regionId = value; }
        }

        /// <summary>
        /// 执业证书
        /// </summary>
        public byte[] Certificate
        {
            get { return _certificate; }
            set { _certificate = value; }
        }

        /// <summary>
        /// 省
        /// </summary>
        public string ProvinceId
        {
            get { return _provinceId; }
            set { _provinceId = value; }
        }

        /// <summary>
        /// 管理员ID
        /// </summary>
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        /// 英文名
        /// </summary>
        public string EngDesc
        {
            get { return _engDesc; }
            set { _engDesc = value; }
        }

        /// <summary>
        /// 营业执照
        /// </summary>
        public byte[] License
        {
            get { return _license; }
            set { _license = value; }
        }

        /// <summary>
        /// 负责人、法定人
        /// </summary>
        public string ManageUser
        {
            get { return _manageUser; }
            set { _manageUser = value; }
        }

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsAudit
        {
            get { return _isAudit; }
            set { _isAudit = value; }
        }

        /// <summary>
        /// 收费打印报表名
        /// </summary>
        public string CashierReport
        {
            get { return _cashierReport; }
            set { _cashierReport = value; }
        }
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        private string _unionName;

        /// <summary>
        /// 所属医联体名称
        /// </summary>
        public string UnionName
        {
            get { return _unionName; }
            set { _unionName = value; }
        }

        private string _areaStr;

        /// <summary>
        /// 地区名称
        /// </summary>
        public string AreaStr
        {
            get { return _areaStr; }
            set { _areaStr = value; }
        }


        /// <summary>  
        /// 市名称
        /// </summary>  
        public string RegIonStr { get; set; }

        /// <summary>                              
        /// 省名称                                    
        /// </summary>                             
        public string ProvinceStr { get; set; }


        /// <summary>
        /// 是否选中 当次使用
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// 医联体GUID
        /// </summary>
        public string UnionId
        {
            get
            {
                return _unionId;
            }

            set
            {
                _unionId = value;
            }
        }

        private string _userName;

        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

    }
}


