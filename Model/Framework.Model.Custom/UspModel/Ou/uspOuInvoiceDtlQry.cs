using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �շѵ�����ϸ
    /// </summary>
    [Serializable]
    #region class of Model:uspOuInvoiceDtlQry

    public class uspOuInvoiceDtlQry : BaseModel
    {
        private int _lsGroupType;
        private string _code = String.Empty;
        private string _name = String.Empty;
        private string _spec = String.Empty;
        private int _lsGfType;
        private double _limitTotalMz;
        private string _typeGFXEId;
        private string _invoId;
        private string _itemId;
        private double _totality;
        private string _unitId;
        private double _price;
        private double _discDiag; private bool _isModiDisc;
        private double _discSelf;
        private double _amount; private bool _isIssue;
        private double _amountFact;
        private double _amountSelf;
        private double _amountPay;
        private double _amountTally; private double _amountInsurance;
        private int _lsPerform;
        private string _limitGroupId;
        private double _limitFee;
        private string _execLocId;
        private string _doctorId;
        private string _invItemId;
        private string _feeId; private string _feeHsId;
        private string _xDRpId; private int _lsReportType;
        private string _memo = String.Empty;
        private string _recipeItemId;
        private DateTime _f1;
        private bool _f2;
        private bool _f3;
        private string _f4 = String.Empty;
        private DateTime _invoTime;
        private string _recipeGroupId;
        private string _unitDiagName = String.Empty;
        private string _feeName = String.Empty;
        private string _invMzItemName = String.Empty;
        private string _feeHsMzName = String.Empty;
        private string _doctorName = String.Empty;
        private string _locationName = String.Empty;
        private int _lsAdviceType;
        private int _lsRpType;
        private bool _isDoctorInput;
        private bool _isBack;
        private bool _isToBack;
        private string _prepareTime = String.Empty;
        private bool _isOtherFee;
        private string _recipeGroupIds = String.Empty;
        private bool _isPriority;
        private string _roomId;
        private int _listNum;
        private string _recipeId;
        private int _lsRepType;
        private string _f5 = String.Empty;
        private string _patName = "";
        private string _operName = "";
        private string _sex = string.Empty;
        private string _medicare = string.Empty;
        private string _cookType;
        private string _isnegative;
        private int _days;
        private string _ageString;

        public uspOuInvoiceDtlQry()
        {
        }

        #region Public Properties
        /// <summary>
        /// ��������
        /// </summary>
        public string Isnegative
        {
            get { return _isnegative; }
            set { _isnegative = value; }
        }
        /// <summary>
        /// ��Ŀ���ࣺ1-ҩƷ��2-���ƣ�3-���ʲ���
        /// </summary>
        public int LsGroupType
        {
            get { return _lsGroupType; }
            set { _lsGroupType = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        /// <summary>
        /// �Ƿ��������
        /// </summary>
        public bool IsIssue
        {
            get { return _isIssue; }
            set { _isIssue = value; }
        }
        /// <summary>
        ///�շ���Ŀ����
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// �����Ա�M��F��O.
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        /// <summary>
        /// ��� 
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// �շ����1-���ѣ�2-�Էѣ�3-���̶��Ը�����.
        /// </summary>
        public int LsGfType
        {
            get { return _lsGfType; }
            set { _lsGfType = value; }
        }
        /// <summary>
        /// ���ȣ�1-���ȣ�0-��ͨ
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        /// <summary>
        /// ����������
        /// </summary>
        public double LimitTotalMz
        {
            get { return _limitTotalMz; }
            set { _limitTotalMz = value; }
        }
        /// <summary>
        /// �����޶����
        /// </summary>
        public string TypeGFXEId
        {
            get { return _typeGFXEId; }
            set { _typeGFXEId = value; }
        }


        /// <summary>
        /// ��Ʊid
        /// </summary>
        public string InvoId
        {
            get { return _invoId; }
            set { _invoId = value; }
        }
        /// <summary>
        /// ��Ŀid
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public double Totality
        {
            get { return _totality; }
            set { _totality = value; }
        }
        /// <summary>
        /// ��λid
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// �÷�����,BsUsage
        /// </summary>
        public string UsageName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        /// <summary>
        /// �Żݣ�%��
        /// </summary>
        public double DiscDiag
        {
            get { return _discDiag; }
            set { _discDiag = value; }
        }
        /// <summary>
        /// �Ƿ��޸��Ը�����
        /// </summary>
        public bool IsModiDisc
        {
            get { return _isModiDisc; }
            set { _isModiDisc = value; }
        }
        /// <summary>
        /// �ԷѲ��ֵĴ��۱���
        /// </summary>
        public double DiscSelf
        {
            get { return _discSelf; }
            set { _discSelf = value; }
        }

        /// <summary>
        /// ʵ�ս��
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// �Ը�������(�Ը����+�Էѽ��)
        /// </summary>
        public double AmountFact
        {
            get { return _amountFact; }
            set { _amountFact = value; }
        }
        /// <summary>
        /// �Ը����
        /// </summary>
        public double AmountSelf
        {
            get { return _amountSelf; }
            set { _amountSelf = value; }
        }
        /// <summary>
        /// Ӧ�����
        /// </summary>
        public double AmountPay
        {
            get { return _amountPay; }
            set { _amountPay = value; }
        }
        /// <summary>
        /// �ɼ��ʽ��
        /// </summary>
        public double AmountTally
        {
            get { return _amountTally; }
            set { _amountTally = value; }
        }

        /// <summary>
        /// ���ս��
        /// </summary>
        public double AmountInsurance
        {
            get { return _amountInsurance; }
            set { _amountInsurance = value; }
        }

        /// <summary>
        /// ִ�����1-�շѣ�2-�˷�.
        /// </summary>
        public int LsPerform
        {
            get { return _lsPerform; }
            set { _lsPerform = value; }
        }

        /// <summary>
        /// ���������޶���������BsLimitGroup.GUID
        /// </summary>
        public string LimitGroupId
        {
            get { return _limitGroupId; }
            set { _limitGroupId = value; }
        }
        /// <summary>
        /// �����޶�
        /// </summary>
        public double LimitFee
        {
            get { return _limitFee; }
            set { _limitFee = value; }
        }


        /// <summary>
        /// ִ���������ID
        /// </summary>
        public string ExecLocId
        {
            get { return _execLocId; }
            set { _execLocId = value; }
        }
        /// <summary>
        /// ҽ��id
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        /// <summary>
        /// ��Ʊ��Ŀid
        /// </summary>
        public string InvItemId
        {
            get { return _invItemId; }
            set { _invItemId = value; }
        }
        /// <summary>
        /// �����շ�������������BsMzFeety.GUID.
        /// </summary>
        public string FeeId
        {
            get { return _feeId; }
            set { _feeId = value; }
        }
        /// <summary>
        /// �����շ����ID
        /// </summary>
        public string FeeHsId
        {
            get { return _feeHsId; }
            set { _feeHsId = value; }
        }

        /// <summary>
        /// Э������ID
        /// </summary>
        public string XDRpId
        {
            get { return _xDRpId; }
            set { _xDRpId = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public int LsReportType
        {
            get { return _lsReportType; }
            set { _lsReportType = value; }
        }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        /// <summary>
        /// ��ע1
        /// </summary>
        public string Memo1 { get; set; }
        /// <summary>
        /// ������Ŀid
        /// </summary>
        public string RecipeItemId
        {
            get { return _recipeItemId; }
            set { _recipeItemId = value; }
        }
        /// <summary>
        /// ¼��ʱ��
        /// </summary>
        public DateTime InputTime
        {
            get { return _f1; }
            set { _f1 = value; }
        }
        /// <summary>
        /// F2
        /// </summary>
        public bool ISMUTITimeS
        {
            get { return _f2; }
            set { _f2 = value; }
        }
        /// <summary>
        /// F3
        /// </summary>
        public bool ISRoomDrug
        {
            get { return _f3; }
            set { _f3 = value; }
        }
        /// <summary>
        ///  F3�Ƿ��Զ��գ�����ISRoomDrug��.
        /// </summary>
        public bool IsAutoCharge { get; set; }
        /// <summary>
        /// F4
        /// </summary>
        public string RecipeGroupIds
        {
            get { return _f4; }
            set { _f4 = value; }
        }
        /// <summary>
        /// F4ҽ���������֣�RECIPEGROUPIDS��
        /// </summary>
        public string YbDesc { get; set; }

        /// <summary>
        /// F4������ ���֣�RECIPEGROUPIDS��YBDESC��
        /// </summary>
        public string RecipeNum { get; set; }

        public string F5
        {
            get { return _f5; }
            set { _f5 = value; }
        }
        /// <summary>
        /// ����ҩ��
        /// </summary>
        public string RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        /// <summary>
        /// ��Ʊʱ�䡣���������Bspatient.GUID
        /// </summary>
        public DateTime InvoTime
        {
            get { return _invoTime; }
            set { _invoTime = value; }
        }
        /// <summary>
        /// ��������id
        /// </summary>
        public string RecipeGroupId
        {
            get { return _recipeGroupId; }
            set { _recipeGroupId = value; }
        }
        /// <summary>
        /// ҩƷ��λ����
        /// </summary>
        public string UnitDiagName
        {
            get { return _unitDiagName; }
            set { _unitDiagName = value; }
        }
        /// <summary>
        /// �����������.
        /// </summary>
        public string FeeName
        {
            get { return _feeName; }
            set { _feeName = value; }
        }
        /// <summary>
        /// ��Ʊ��Ŀ.
        /// </summary>
        public string InvMzItemName
        {
            get { return _invMzItemName; }
            set { _invMzItemName = value; }
        }
        /// <summary>
        /// �����Ŀ
        /// </summary>
        public string FeeHsMzName
        {
            get { return _feeHsMzName; }
            set { _feeHsMzName = value; }
        }
        /// <summary>
        /// ҽ������
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
        /// <summary>
        /// ֪ͨ����
        /// </summary>
        public int LsAdviceType
        {
            get { return _lsAdviceType; }
            set { _lsAdviceType = value; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public int ListNum
        {
            get { return _listNum; }
            set { _listNum = value; }
        }
        /// <summary>
        /// ����id
        /// </summary>
        public string RecipeId
        {
            get { return _recipeId; }
            set { _recipeId = value; }
        }
        /// <summary>
        /// �������ࣺ1-������Ŀ��2-������Ŀ��3-�����Ŀ��4-�в�ҩ����. 5-��ҩ
        /// </summary>
        public int LsRepType
        {
            get { return _lsRepType; }
            set { _lsRepType = value; }
        }
        /// <summary>
        /// ͬ��Ŀ��
        /// </summary>
        public int LsRpType
        {
            get { return _lsRpType; }
            set { _lsRpType = value; }
        }
        /// <summary>
        /// F4�Ƿ�ҽ���Һ�
        /// </summary>
        public bool IsDoctorInput
        {
            get { return _isDoctorInput; }
            set { _isDoctorInput = value; }
        }
        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool IsBack
        {
            get { return _isBack; }
            set { _isBack = value; }
        }
        /// <summary>
        /// �Ƿ�ط�
        /// </summary>
        public bool IsToBack
        {
            get { return _isToBack; }
            set { _isToBack = value; }
        }
        /// <summary>
        /// F1¼��ʱ��.
        /// </summary>
        public string PrepareTime
        {
            get { return _prepareTime; }
            set { _prepareTime = value; }
        }
        /// <summary>
        ///  �Ƿ񸽼���Ŀ
        /// </summary>
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string PatName { get { return _patName; } set { _patName = value; } }
        /// <summary>
        /// ������
        /// </summary>
        public string OperName { get { return _operName; } set { _operName = value; } }

        private bool _canChangeAmount = true;
        /// <summary>
        /// �����޸�����
        /// </summary>
        public bool CanChangeAmount
        {
            get { return _canChangeAmount; }
            set { _canChangeAmount = value; }
        }

        private string _tjLocationID;
        /// <summary>  
        ///  ������
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }
        /// <summary>
        /// ҽ������
        /// </summary>
        public string Medicare
        {
            get { return this._medicare; }
            set { this._medicare = value; }
        }

        /// <summary>
        /// ��Ա�ۼ�����
        /// </summary>
        public int VipDeductionCount { get; set; }
        /// <summary>
        /// �������ҽ��/��ҽ����
        /// </summary>
        public string FeeType { get; set; }
        /// <summary>
        /// ��λ��
        /// </summary>
        public string BedNo { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// �ٴ����
        /// </summary>
        public string ClinicalDiagnosis { get; set; }
        /// <summary>
        /// Ƥ�Խ��
        /// </summary>
        public string SkinTestResults { get; set; }
        /// <summary>
        /// �����ID
        /// </summary>
        public string CheckedOperID { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public string CheckedOperName { get; set; }
        /// <summary>
        /// ������ID
        /// </summary>
        public string AllocateManID { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string AllocateManName { get; set; }
        /// <summary>
        /// ��ҩ��
        /// </summary>
        public string MedicineManName { get; set; }
        /// <summary>
        /// Ƶ�ʣ�BsFrequency
        /// </summary>
        public string FrequencyName { get; set; }
        /// <summary>
        /// ����.
        /// </summary>
        public double Dosage { get; set; }
        /// <summary>
        /// ������λ/��ҩ��λ
        /// </summary>
        public string UnitTakeName { get; set; }
        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public string InvoNo { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// ��ҩ����1
        /// </summary>
        public string Name1 { get; set; }
        /// <summary>
        /// ��ҩ����2
        /// </summary>
        public string Name2 { get; set; }
        /// <summary>
        /// ��ҩ����1
        /// </summary>
        public double Totality1 { get; set; }
        /// <summary>
        /// ��ҩ����2
        /// </summary>
        public double Totality2 { get; set; }
        /// <summary>
        /// ��ҩ��λ1
        /// </summary>
        public string UnitTakeName1 { get; set; }
        /// <summary>
        /// ��ҩ��λ2
        /// </summary>
        public string UnitTakeName2 { get; set; }

        /// <summary>
        /// ��ҩ��ʽ
        /// </summary>
        public string CookType
        {
            get { return this._cookType; }
            set { this._cookType = value; }
        }
        /// <summary>
        /// ��ҩ��ҩ��ʽ
        /// </summary>
        public string CookType1 { get; set; }
        /// <summary>
        /// �Ƿ�ע��
        /// </summary>
        public bool IsCancel { get; set; }
        /// <summary>
        /// �Ƿ������
        /// </summary>
        public bool IsVerify { get; set; }

        /// <summary>  
        ///   ���
        /// </summary>  
        public string Diagnosis
        {
            get;
            set;
        }


        /// <summary>
        /// ���.
        /// </summary>
        public int  GroupNum
        {
            get;
            set;
        }
        public string PatId { get; set; }


        /// <summary>
        /// ����
        /// </summary>
        public int Days
        {
            get { return this._days; }
            set { this._days = value; }
        }

        /// <summary>
        /// ���䣨�����ꡢ�¡�������
        /// </summary>
        public string AgeString
        {
            get { return this._ageString; }
            set { this._ageString = value; }
        }

        public double AllAmount { get; set; }
        public bool IsUsageItem { get; set; }
        #endregion
    }
    #endregion
}







