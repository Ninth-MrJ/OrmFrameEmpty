

using System;
using System.Text.RegularExpressions;
namespace Orm.Model
{
    /// <summary>
    /// ���ﴦ����ϸ - ʵ����
    /// </summary>
    [Serializable]
    public partial class OuRecipeDtl : BaseModel
    {
        private int _frequencyCount; //Ƶ������
        
        private string _recipeId;  //����ID

        private int _listNum;  //���

        private string _itemId;  //��Ŀ

        private int _groupNum;  //���

        private double _dosage;  //����

        private string _unitTakeId;  //ʹ�õ�λ

        private string _frequencyId;  //Ƶ��

        private string _usageId;  //�÷�

        private int _days;  //����

        private double _totality;  //����

        private string _unitDiagId;  //���ﵥλ

        private bool _isAttach;  //�Ƿ�ִ��isNoAttach

        private bool _isOtherFee;  //�Ƿ񸽼���Ŀ

        private string _xDRpId;  //Э������Id,BsXdRp.Id

        private string _memo;  //��ע

        private bool _isCharged;  //�Ƿ��ѽ���

        private bool _isCancel;  //�Ƿ�����

        private DateTime _cancelTime;  //ȡ��ʱ��

        private string _cancelOperId;  //ȡ����ID

        private bool _isPrint;  //��ʿ�Ƿ��Ѿ����

        private DateTime _printTime;  //���ʱ��

        private string _printOperId;  //�����

        private bool _isPrepared;  //�Ƿ�׼��

        private string _prepareTime;  //׼��ʱ��

        private string _prepareOperId;  //׼����ID

        private bool _isIssue;  //�Ƿ�ҩ

        private DateTime _issueTime;  //��ҩʱ��

        private string _issueOperId;  //��ҩ��

        private bool _isToBack;  //ҽ���Ƿ�ȷ����ҩ

        private bool _isBack;  //�Ƿ����ˣ�

        private bool _isDoctorInput;  //�Ƿ���ҽ��¼�룿

        private int _recNum;  //�����ź�

        private DateTime _recipeTime;  //��������

        private string _locationId;  //������LOCATION��

        private string _doctorId;  //������DOCTOR��

        private int _allPageNo;  //

        private int _pageNo;  //

        private string _cureDtlId;  //BP���Ʒ�����ϸID��Ӧ��BsBPCureDtl

        private bool _isBP;  //�Ƿ�BP

        private string _bPReason;  //BP����

        private string _ybType;  //ҽ�����

        private string _invoNo;  //�շѷ�Ʊ��

        private bool _isAutoCharged;  //�Ƿ��Զ���

        private bool _isForCharge;  //�Ƿ�������շѵ���¼��

        private string _applyId;  //������뵥Id

        private double _price;  //����

        private string _tempStr;  //������ʱʹ��

        private double _discountAoumt;  //�ۿ۽��

        private double _childPrice;  //��ͯ�۸�

        private double _discountPrice;  //�ۿۼ۸�

        private bool _isAuthed;  //�Ѿ���棬���ɸ�ɾ

        private double _oldDiscDiag;  //������:ԭ�Żݣ�%��

        private string _addMemo;  //������:���ӷѱ�ע

        private string _dripRates;  //������:����

        private string _skinTestCondition;  //������:Ƥ�����

        private DateTime _planExecuteTime;  //������:�ƻ�ִ��ʱ��

        private DateTime _completeTime;  //������:���ʱ��

        private double _discDiag;  //������:�Żݣ�%��

        private string _patTypeName;  //������:�����������

        private int _samlingType;  //������: 

        private string _execOperID;  //������:ִ����

        private bool _isShow;  //������:�Ƿ���ʾ�ײ�

        private bool _isVipDeduction;  //������:�Ƿ��Ա���ѿۼ���Ŀ

        private bool _isUsageItem;  //������:�Ƿ��÷�������Ŀ

        private DateTime _chargeDtime;  //�շ�ʱ��

        private string _sourceName;

        private string _labID;   // ����걾iD

        private string _operId;

        private string _backCancelOperId;
        private DateTime _backCancelTime;

        private string _cookType;

        private string _recipeNum; //������

        private int _chargeCount;
         
        private bool _aka185;      //�Ƿ�������ҩ

        private bool _isYbItems;   //�Ƿ�ҽ����Ŀ

        /// <summary>
        /// �Ƿ�������ҩ
        /// </summary>
        public bool AKA185
        {
            get { return _aka185; }
            set
            {
                _aka185 = value;
            }
        }

        /// <summary>
        /// �Ƿ�������ҩ
        /// </summary>
        public bool IsYbItems
        {
            get { return _isYbItems; }
            set
            {
                _isYbItems = value;
            }
        }

        private string _joinExecOperID;
        /// <summary>
        /// ����ִ����ID
        /// </summary>
        public string JoinExecOperID
        {
            get { return _joinExecOperID; }
            set { _joinExecOperID = value; }
        }


        private string _strTotality;
        /// <summary>
        ///  ��������
        /// </summary>
        public string StrTotality
        {
            get { return _strTotality; }
            set
            {
                _strTotality = value;
                 
            }
        }

        /// <summary>
        /// ��ҩʱ��
        /// </summary>
        public DateTime BackCancelTime
        {
            get { return _backCancelTime; }
            set { _backCancelTime = value; }
        }
        /// <summary>
        /// ��ҩ������
        /// </summary>
        public string BackCancelOperId
        {
            get { return _backCancelOperId; }
            set { _backCancelOperId = value; }
        }

        /// <summary>
        /// ����ID
        /// </summary>
        public string RecipeId
        {
            get { return _recipeId; }
            set { _recipeId = value; }
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
        /// ��Ŀ
        /// </summary>
        public string ItemID
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// ���  id 
        /// </summary>
        public int GroupNum
        {
            get { return _groupNum; }
            set { _groupNum = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public double Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }

        /// <summary>
        /// ʹ�õ�λ
        /// </summary>
        public string UnitTakeId
        {
            get { return _unitTakeId; }
            set { _unitTakeId = value; }
        }

        /// <summary>
        /// Ƶ��
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }

        /// <summary>
        /// �÷�
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public int Days
        {
            get { return _days; }
            set { _days = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public double Totality
        {
            get { return _totality; }
            set { _totality = value;
                //StrTotality = _totality.ToString();
            }


        }

        /// <summary>
        /// ���ﵥλ
        /// </summary>
        public string UnitDiagId
        {
            get { return _unitDiagId; }
            set { _unitDiagId = value; }
        }

        /// <summary>
        /// �Ƿ�ִ��isNoAttach
        /// </summary>
        public bool IsAttach
        {
            get { return _isAttach; }
            set { _isAttach = value; }
        }

        /// <summary>
        /// �Ƿ񸽼���Ŀ
        /// </summary>
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
        }

        /// <summary>
        /// Э������Id,BsXdRp.Id
        /// </summary>
        public string XDRpId
        {
            get { return _xDRpId; }
            set { _xDRpId = value; }
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
        /// �Ƿ��ѽ���
        /// </summary>
        public bool IsCharged
        {
            get { return _isCharged; }
            set { _isCharged = value; }
        }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool IsCancel
        {
            get { return _isCancel; }
            set { _isCancel = value; }
        }

        /// <summary>
        /// ȡ��ʱ��
        /// </summary>
        public DateTime CancelTime
        {
            get { return _cancelTime; }
            set { _cancelTime = value; }
        }

        /// <summary>
        /// ȡ����ID
        /// </summary>
        public string CancelOperId
        {
            get { return _cancelOperId; }
            set { _cancelOperId = value; }
        }

        /// <summary>
        /// ��ʿ�Ƿ��Ѿ����
        /// </summary>
        public bool IsPrint
        {
            get { return _isPrint; }
            set { _isPrint = value; }
        }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime PrintTime
        {
            get { return _printTime; }
            set { _printTime = value; }
        }

        /// <summary>
        /// �����
        /// </summary>
        public string PrintOperId
        {
            get { return _printOperId; }
            set { _printOperId = value; }
        }

        /// <summary>
        /// �Ƿ�׼��
        /// </summary>
        public bool IsPrepared
        {
            get { return _isPrepared; }
            set { _isPrepared = value; }
        }

        /// <summary>
        /// ׼��ʱ��
        /// </summary>
        public string PrepareTime
        {
            get { return _prepareTime; }
            set { _prepareTime = value; }
        }

        /// <summary>
        /// ׼����ID
        /// </summary>
        public string PrepareOperId
        {
            get { return _prepareOperId; }
            set { _prepareOperId = value; }
        }

        /// <summary>
        /// �Ƿ�ҩ
        /// </summary>
        public bool IsIssue
        {
            get { return _isIssue; }
            set { _isIssue = value; }
        }

        /// <summary>
        /// ��ҩʱ��
        /// </summary>
        public DateTime IssueTime
        {
            get { return _issueTime; }
            set { _issueTime = value; }
        }

        /// <summary>
        /// ��ҩ��
        /// </summary>
        public string IssueOperId
        {
            get { return _issueOperId; }
            set { _issueOperId = value; }
        }

        /// <summary>
        /// ҽ���Ƿ�ȷ����ҩ
        /// </summary>
        public bool IsToBack
        {
            get { return _isToBack; }
            set { _isToBack = value; }
        }

        /// <summary>
        /// �Ƿ����ˣ�
        /// </summary>
        public bool IsBack
        {
            get { return _isBack; }
            set { _isBack = value; }
        }

        /// <summary>
        /// �Ƿ���ҽ��¼�룿
        /// </summary>
        public bool IsDoctorInput
        {
            get { return _isDoctorInput; }
            set { _isDoctorInput = value; }
        }

        /// <summary>
        /// �����ź�
        /// </summary>
        public int RecNum
        {
            get { return _recNum; }
            set { _recNum = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime RecipeTime
        {
            get { return _recipeTime; }
            set { _recipeTime = value; }
        }

        /// <summary>
        /// ��ҩ����
        /// </summary>
        public string CookType
        {
            get { return _cookType; }
            set { _cookType = value; }
        }

        /// <summary>
        /// ������LOCATION��
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// ������DOCTOR��
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int AllPageNo
        {
            get { return _allPageNo; }
            set { _allPageNo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int PageNo
        {
            get { return _pageNo; }
            set { _pageNo = value; }
        }

        /// <summary>
        /// BP���Ʒ�����ϸID��Ӧ��BsBPCureDtl
        /// </summary>
        public string CureDtlId
        {
            get { return _cureDtlId; }
            set { _cureDtlId = value; }
        }

        /// <summary>
        /// �Ƿ�BP
        /// </summary>
        public bool IsBP
        {
            get { return _isBP; }
            set { _isBP = value; }
        }

        /// <summary>
        /// BP����
        /// </summary>
        public string BPReason
        {
            get { return _bPReason; }
            set { _bPReason = value; }
        }

        /// <summary>
        /// ҽ�����
        /// </summary>
        public string YbType
        {
            get { return _ybType; }
            set { _ybType = value; }
        }

        /// <summary>
        /// �շѷ�Ʊ��
        /// </summary>
        public string InvoNo
        {
            get { return _invoNo; }
            set { _invoNo = value; }
        }

        /// <summary>
        /// �Ƿ��Զ���
        /// </summary>
        public bool IsAutoCharged
        {
            get { return _isAutoCharged; }
            set { _isAutoCharged = value; }
        }

        /// <summary>
        /// �Ƿ�������շѵ���¼��
        /// </summary>
        public bool IsForCharge
        {
            get { return _isForCharge; }
            set { _isForCharge = value; }
        }

        /// <summary>
        /// ������뵥Id
        /// </summary>
        public string ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// ������ʱʹ��
        /// </summary>
        public string TempStr
        {
            get { return _tempStr; }
            set { _tempStr = value; }
        }

        /// <summary>
        /// �ۿ۽��
        /// </summary>
        public double DiscountAoumt
        {
            get { return _discountAoumt; }
            set { _discountAoumt = value; }
        }

        /// <summary>
        /// ��ͯ�۸�
        /// </summary>
        public double ChildPrice
        {
            get { return _childPrice; }
            set { _childPrice = value; }
        }

        /// <summary>
        /// �ۿۼ۸�
        /// </summary>
        public double DiscountPrice
        {
            get { return _discountPrice; }
            set { _discountPrice = value; }
        }

        /// <summary>
        /// �Ѿ���棬���ɸ�ɾ
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// ������:ԭ�Żݣ�%��
        /// </summary>
        public double OldDiscDiag
        {
            get { return _oldDiscDiag; }
            set { _oldDiscDiag = value; }
        }

        /// <summary>
        /// ������:���ӷѱ�ע
        /// </summary>
        public string AddMemo
        {
            get { return _addMemo; }
            set { _addMemo = value; }
        }

        /// <summary>
        /// ������:����
        /// </summary>
        public string DripRates
        {
            get { return _dripRates; }
            set { _dripRates = value; }
        }

        /// <summary>
        /// ������:Ƥ�����
        /// </summary>
        public string SkinTestCondition
        {
            get { return _skinTestCondition; }
            set { _skinTestCondition = value; }
        }

        /// <summary>
        /// ������:�ƻ�ִ��ʱ��
        /// </summary>
        public DateTime PlanExecuteTime
        {
            get { return _planExecuteTime; }
            set { _planExecuteTime = value; }
        }

        /// <summary>
        /// ������:���ʱ��
        /// </summary>
        public DateTime CompleteTime
        {
            get { return _completeTime; }
            set { _completeTime = value; }
        }


        /// <summary>
        /// ������:�Żݣ�%��
        /// </summary>
        public double DiscDiag
        {
            get { return _discDiag; }
            set { _discDiag = value; }
        }

        /// <summary>
        /// ������:�����������
        /// </summary>
        public string PatTypeName
        {
            get { return _patTypeName; }
            set { _patTypeName = value; }
        }

        /// <summary>
        /// ������: ��ʿ�ɼ�
        /// </summary>
        public int SamlingType
        {
            get { return _samlingType; }
            set { _samlingType = value; }
        }

        /// <summary>
        /// ������:ִ����
        /// </summary>
        public string ExecOperID
        {
            get { return _execOperID; }
            set { _execOperID = value; }
        }

        /// <summary>
        /// ������:�Ƿ���ʾ�ײ�
        /// </summary>
        public bool IsShow
        {
            get { return _isShow; }
            set { _isShow = value; }
        }

        /// <summary>
        /// ������:�Ƿ��Ա���ѿۼ���Ŀ
        /// </summary>
        public bool IsVipDeduction
        {
            get { return _isVipDeduction; }
            set { _isVipDeduction = value; }
        }

        /// <summary>
        /// ������:�Ƿ��÷�������Ŀ
        /// </summary>
        public bool IsUsageItem
        {
            get { return _isUsageItem; }
            set { _isUsageItem = value; }
        }

        /// <summary>
        /// �շ�ʱ��
        /// </summary>
        public DateTime ChargeDtime
        {
            get { return _chargeDtime; }
            set { _chargeDtime = value; }
        }
        /// <summary>
        /// ����걾
        /// </summary>
        public string LabId
        {
            get { return _labID; }
            set { _labID = value; }
        }

        /// <summary>
        /// �걾����Name
        /// </summary>
        public string SourceName
        {
            get { return _sourceName; }
            set { _sourceName = value; }
        }

        private int _ckItemType;
        /// <summary>
        /// �����������:1.�����Ŀ 2.������Ŀ
        /// </summary>
        public int CkItemType
        {
            get { return _ckItemType; }
            set { _ckItemType = value; }
        }
        /// <summary>
        /// �ڼ����շ�
        /// </summary>
        public int ChargeCount
        {
            get { return _chargeCount; }
            set { _chargeCount = value; }
        }
          
        public int VipLeftCount { get; set; }
        public string TjPackageID { get; set; }
        public bool IsPage { get; set; }
        public double PagePrice { get; set; }
        public object ItemTypeName { get; set; }

        /// <summary>
        /// Ƶ������
        /// </summary>
        public int FrequencyCount
        {
            get { return _frequencyCount; }
            set { _frequencyCount = value; }
        }

        public string OperId
        {
            get { return _operId; }
            set
            {
                _operId = value;
            }
        }

      
        /// <summary>
        /// �������ࣺ1-������Ŀ��2-������Ŀ��3-�����Ŀ��4-�в�ҩ����. 5-��ҩ
        /// </summary>
        public string RecipeNum
        {
            get { return _recipeNum; }
            set { _recipeNum = value; }
        }
        private bool _isFrequencyId = false;
        public bool u_IsFrequencyId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FrequencyId))
                {
                    _isFrequencyId = true;
                }
                else
                {
                    _isFrequencyId = false;
                }
                return _isFrequencyId;
            }
            set { _isFrequencyId = value; }
        }
        private bool _isUnitDiagId = false;
        public bool u_IsUnitDiagId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UnitDiagId))
                {
                    _isUnitDiagId = true;
                }
                else
                {
                    _isUnitDiagId = false;
                }
                return _isUnitDiagId;
            }
            set { _isUnitDiagId = value; }
        }
        private bool _isUnitTakeId = false;
        public bool u_IsUnitTakeId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UnitTakeId))
                {
                    _isUnitTakeId = true;
                }
                else
                {
                    _isUnitTakeId = false;
                }
                return _isUnitTakeId;
            }
            set { _isUnitTakeId = value; }
        }
    }
}


