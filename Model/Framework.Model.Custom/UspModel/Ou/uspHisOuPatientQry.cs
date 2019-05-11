using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ���ˣ������������Ϣ����
    /// </summary>
    [Serializable]
    public class uspHisOuPatientQry : BaseModel
    {
        private string _mzRegNo = String.Empty;
        private string _idCardNo = String.Empty;
        private string _patientName = String.Empty;
        private string _patId;
        private string _cardNo = String.Empty;
        private string _sex = String.Empty;
        private DateTime _birthDate;
        private int _age;
        private DateTime _regTime;
        private string _regTypeId;
        private string _regTypeName = String.Empty;
        private string _nurseId;
        private string _doctorId;
        private string _regDept;
        private string _locationName = String.Empty;
        private string _diagnDept;
        private bool _isCancel;
        private string _doctorCode = String.Empty;
        private string _locationCode = String.Empty;
        private string _doctorName = String.Empty;
        private string _patTypeId;
        private string _patTypeName = String.Empty;
        private string _tallyTypeId;
        private string _tallyTypeName = String.Empty;
        private string _tallyGroupName = String.Empty;
        private string _getTallyType = String.Empty;
        private string _getTallyTypeName = String.Empty;
        private double _arrearAmount;
        private string _mobile = String.Empty;
        private string _hosId;
        private string _timeSpanId;
        private string _medicareNo = String.Empty;
        private string _MzRegNoOri = String.Empty;
        private string _ageString = String.Empty;
        private string _bookingpurpose;
        private string _comments = string.Empty;
        private DateTime _lastSeeTime;
        private string _pyCode = " ";
        private string _wbCode = " ";
        private string _arrearsTypeId;
        private string _ArrearsTypeName;
        private double _prevArrears;
        private DateTime _checkTime;
        private string _tallyCancelOperName;
        private DateTime _endMenstruationTime;
        private bool _isHideIllness = false;
        private double _accountAmount;
        private string _habit = string.Empty;
        private string _familyHistory = string.Empty;
        private int _adviserStatus = 0;
        private string _nationId;
        private bool _isBaby;
        private int _ageMonth;
        private int _ageDay;
        private double _weight;
        private double _height;
        private int _rowCount;
        private bool _isDiadnosis;
        private string _refErral;
        private string _phoneHome;

        private string _hospitalizationTimes;

        /// <summary>
        /// ���סԺ������ת�ﲡ��
        /// </summary>
        public string HospitalizationTimes
        {
            get { return _hospitalizationTimes; }
            set { _hospitalizationTimes = value; }
        }

        public string PhoneHome
        {
            get { return this._phoneHome; }
            set { this._phoneHome = value; }
        }
        public string RefErral
        {
            get { return this._refErral; }
            set { this._refErral = value; }
        }
        public int Rowcount
        {
            get { return this._rowCount; }
            set { this._rowCount = value; }
        }

        public double _thePrice;
        private string _consultID;
        public uspHisOuPatientQry()
        {
        }
        /// <summary>
        /// ���͵�ַ
        /// </summary>
        public string DistributionAddress { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string DistributionPeriod { get; set; }
        /// <summary>
        /// 0 �ֳ�ȡҩ��1 ����
        /// </summary>
        public int IsTakeMedicine { get; set; }
        private int _isWaitUser;
        public int IsWaitUser { get { return this._isWaitUser; } set { this._isWaitUser = value; } }
        #region Public Properties

        /// <summary>
        /// ����Ŀ�ģ����룬��ʽ��1|2|3��
        /// </summary>
        public string BookingPurpose
        {
            get
            {
                return this._bookingpurpose;
            }
            set
            {
                this._bookingpurpose = value;
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string LocationCode
        {
            get { return this._locationCode; }
            set { this._locationCode = value; }
        }

        /// <summary>  
        ///   ��һ�ν���ʱ��
        /// </summary>  
        public DateTime LastSeeTime
        {
            get { return this._lastSeeTime; }
            set { this._lastSeeTime = value; }
        }

        /// <summary>
        /// ҽ�����
        /// </summary>
        public string DoctorCode
        {
            get { return this._doctorCode; }
            set { this._doctorCode = value; }
        }

        /// <summary>
        /// ����Ŀ������
        /// </summary>
        public string CnBookingPurpose
        {
            get;
            set;
        }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Comments
        {
            get
            {
                return this._comments;
            }

            set
            {
                this._comments = value;
            }
        }

        /// <summary>
        /// ������ˮ��

        /// </summary>
        public string MzRegNo
        {
            get {
                return _mzRegNo;
            }
            set {
                _mzRegNo = value;
            }
        }

        /// <summary>
        /// ���֤��
        /// </summary>
        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string  PatId
        {
            get { return _patId; }
            set { _patId = value; }
        }

        /// <summary>
        /// ���˿��� 
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        /// <summary>
        /// �Ա�
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        /// <summary>
        /// �����ַ���
        /// </summary>
        public string AgeString
        {
            get { return _ageString; }
            set { _ageString = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// �Һ�ʱ�� 
        /// </summary>
        public DateTime RegTime
        {
            get { return _regTime; }
            set { _regTime = value; }
        }


        /// <summary>
        /// �Һ����ID
        /// </summary>
        public string RegTypeId
        {
            get { return _regTypeId; }
            set { _regTypeId = value; }
        }
        /// <summary>
        /// �Һ����
        /// </summary>
        public string RegTypeName
        {
            get { return _regTypeName; }
            set { _regTypeName = value; }
        }
        /// <summary>
        /// ����ҽ��ID
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// �Һſ���
        /// </summary>
        public string RegDept
        {
            get { return _regDept; }
            set { _regDept = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
        /// <summary>
        /// ������ҡ����������BsLocation.GUID 
        /// </summary>
        public string DiagnDept
        {
            get { return _diagnDept; }
            set { _diagnDept = value; }
        }

        /// <summary>
        /// �Ƿ�ע�� 
        /// </summary>
        public bool IsCancel
        {
            get { return _isCancel; }
            set { _isCancel = value; }
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
        /// �������ID 
        /// </summary>
        public string PatTypeId
        {
            get { return _patTypeId; }
            set { _patTypeId = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string PatTypeName
        {
            get { return _patTypeName; }
            set { _patTypeName = value; }
        }

        /// <summary>
        /// ���ʷ�ʽID
        /// </summary>
        public string TallyTypeId
        {
            get { return _tallyTypeId; }
            set { _tallyTypeId = value; }
        }

        /// <summary>
        /// Ƿ�Ѷ��پ�����¼�����
        /// </summary>
        public double ArrearAmount
        {
            get { return _arrearAmount; }
            set { _arrearAmount = value; }
        }


        /// <summary>
        /// F1�Ƿ�ҺŴ�¼�� 
        /// </summary>
        public bool ISInputBYRegMAN
        { get; set; }


        /// <summary>
        /// �ֻ����� 
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }


        /// <summary>
        /// ����id 
        /// </summary>
        public string HosId
        {
            get { return _hosId; }
            set { _hosId = value; }
        }
        /// <summary>
        /// ���ID 
        /// </summary>
        public string TimeSpanId
        {
            get { return _timeSpanId; }
            set { _timeSpanId = value; }
        }

        /// <summary>
        /// ҽ��֤��/ҽ���� 
        /// </summary>
        public string MedicareNo
        {
            get { return _medicareNo; }
            set { _medicareNo = value; }
        }

        /// <summary>
        /// �к����� 
        /// </summary>
        public int Callorder { get; set; }

        /// <summary>
        /// �Ƿ�ΪԤԼ�ţ�0���ǣ�1�ǣ� 
        /// </summary>
        public bool IsPreReg { get; set; }
        public DateTime PreRegTime { get; set; }
        /// <summary>
        /// ��ƱID
        /// </summary>
        public string InvoceID { get; set; }
        /// <summary>
        /// ��Ʊ���
        /// </summary>
        public string InvoceNo { get; set; }

        /// <summary>
        /// ����Ȩ(�Ƿ�ҽ��)
        /// </summary>
        public bool IsRecipe { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// Ƿ��
        /// </summary>
        public double CurrentArrears { get; set; }
        /// <summary>
        /// ��Ʊʱ��
        /// </summary>
        public DateTime InvoTime { get; set; }

        /// <summary>
        /// ��Ʊʱ��
        /// </summary>
        public string _InvoTime { get; set; }
        /// <summary>
        /// �տ���
        /// </summary>
        public string InvoOperName { get; set; }

        /// <summary>
        /// ��ʿ����
        /// </summary>
        public string NurseName { get; set; }

        /// <summary>
        /// ��ʿID
        /// </summary>
        public string NurseId
        {
            get { return _nurseId; }
            set { _nurseId = value; }
        }

        /// <summary>
        /// ������1-���2-����
        /// </summary>
        public bool IsReturnVisit { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string VisitContent { get; set; }

        /// <summary>
        /// ƴ����
        /// </summary>
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode = value;
            }
        }

        /// <summary>
        /// ƴ����
        /// </summary>
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode = value;
            }
        }

        /// <summary>
        /// ������1-���2-����;3-���4-���Է���
        /// </summary>
        public int PatientStatus { get; set; }

        /// <summary>
        /// �Ƿ�Ƿ��
        /// </summary>
        public bool IsInArrears { get; set; }

        /// <summary>
        /// ����ʷ
        /// </summary>
        public string PersonHistory { get; set; }

        /// <summary>
        /// �Ƿ��շ�
        /// </summary>
        public bool IsCharge { get; set; }

        /// <summary>
        /// ԤԼ��ʼʱ��
        /// </summary>
        public string BeginTime { get; set; }

        /// <summary>
        /// ԤԼ����ʱ��
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// ԤԼ�Һ�ʱ���
        /// </summary>
        public string TimeSpanSubName { get; set; }

        /// <summary>
        /// ԤԼ���˵�ǰ״̬ �� 0 Ĭ�� 1 ���� 2����
        /// </summary>
        public int BookedPatientStatus { get; set; }

        /// <summary>
        /// ��λ��
        /// </summary>
        public string DiagPosition { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string DiagTimes { get; set; }

        /// <summary>
        /// ���η���
        /// </summary>
        public double CurrentPay { get; set; }
        /// <summary>
        /// ʵ�շ���
        /// </summary>
        public double FactPay { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string TimeQuantum { get; set; }

        /// <summary>
        /// Ƿ�����Name
        /// </summary>
        public string ArrearsTypeName
        {
            get
            {
                return this._ArrearsTypeName;
            }
            set
            {
                this._ArrearsTypeName = value;
            }
        }

        /// <summary>
        /// Ƿ�����id
        /// </summary>
        public string ArrearsTypeId
        {
            get
            {
                return this._arrearsTypeId;
            }
            set
            {
                this._arrearsTypeId = value;
            }
        }

        /// <summary>
        /// �ϴ�Ƿ�� 
        /// </summary>
        public double PrevArrears
        {
            get
            {
                return this._prevArrears;
            }
            set
            {
                this._prevArrears = value;
            }
        }

        /// <summary>
        /// �Ƿ��Ա
        /// </summary>
        public bool IsVip { get; set; }

        /// <summary>
        /// ��Ա�ۿ�
        /// </summary>
        public double VipDiscount { get; set; }

        /// <summary>
        /// ��Ա����
        /// </summary>
        public string VipCardNo
        {
            get;
            set;
        }
        /// <summary>
        /// ��ԱID
        /// </summary>
        public string VipCardID
        {
            get;
            set;
        }
        
        /// <summary>
        /// �����¼
        /// </summary>
        public string Pathography
        {
            get;
            set;
        }
        /// <summary>
        /// ���ƽ���ID
        /// </summary>
        public string TreatmentAdvise
        {
            get;
            set;
        }

        private string _sensitive;
        /// <summary>
        /// ����ʷ
        /// </summary>
        public string Sensitive
        {
            get
            {
                return this._sensitive;
            }
            set
            {
                this._sensitive = value;
            }
        }

        /// <summary>
        /// �Ƿ��������ܼ�
        /// </summary>
        public bool IsTjOver { get; set; }

        /// <summary>
        /// ���������Ŀ
        /// </summary>
        public bool IsTj { get; set; }

        /// <summary>
        /// ����������Ŀ
        /// </summary>
        public bool IsLL { get; set; }
        /// <summary>
        /// �Ƿ�ʹ�û�Ա��
        /// </summary>
        public bool IsVIPPrice { get; set; }

        #endregion

        /// <summary>
        /// ҽ������
        /// </summary>
        public string DoctorAssistant { get; set; }

        /// <summary>
        /// ���� 
        /// </summary>
        public string MainInform { get; set; }

        public string PatDespcription { get; set; }
        public string Memo { get; set; }

        /// <summary>  
        ///   ����ʱ��
        /// </summary>  
        public DateTime CheckTime
        {
            get { return this._checkTime; }
            set { this._checkTime = value; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string TallyCancelOperName
        {
            get
            {
                return this._tallyCancelOperName;
            }
            set
            {
                this._tallyCancelOperName = value;
            }
        }

        /// <summary>
        /// ĩ���¾�
        /// </summary>
        public DateTime EndMenstruationTime
        {
            get
            {
                return this._endMenstruationTime == DateTime.MinValue ? DateTime.Now : this._endMenstruationTime;
            }
            set
            {
                this._endMenstruationTime = value;
            }
        }

        /// <summary>
        /// ���
        /// </summary>
        public int SortNo { get; set; }

        /// <summary>
        /// �Ƿ����ⲡ��
        /// </summary>
        public bool IsHideIllness
        {
            get { return this._isHideIllness; }
            set { this._isHideIllness = value; }
        }

        /// <summary>
        /// ���˽��
        /// </summary>
        public double AccountAmount
        {
            get
            {
                return this._accountAmount;
            }
            set
            {
                this._accountAmount = value;
            }
        }
        /// <summary>
        /// ����ʷ
        /// </summary>
        public string Habit
        {
            get { return this._habit; }
            set { this._habit = value; }
        }

        /// <summary>
        /// ����ʷ
        /// </summary>
        public string FamilyHistory
        {
            get { return this._familyHistory; }
            set { this._familyHistory = value; }
        }
        /// <summary>
        /// ��������״̬: 1:��ԤԼ 2:�ѵ��� 3:�Ѿ��� 4:���շ� 5:�ѷ�ҩ 6:���������ѽ���
        /// </summary>
        public int AdviserStatus
        {
            get { return this._adviserStatus; }
            set { this._adviserStatus = value; }
        }
        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool IsVerify { get; set; }
        /// <summary>
        /// �Ƿ�ѡ��
        /// </summary>
        public bool IsChoose { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public string NationId
        {
            get
            {
                return _nationId;
            }

            set
            {
                _nationId = value;
            }
        }

        /// <summary>
        /// ��ͥ��ַ
        /// </summary>
        public string AddressHome { get; set; }

        /// <summary>
        /// �Ƿ�Ӥ��
        /// </summary>
        public bool IsBaby
        {
            get
            {
                return _isBaby;
            }

            set
            {
                _isBaby = value;
            }
        }

        /// <summary>
        /// �����·�
        /// </summary>
        public int AgeMonth
        {
            get
            {
                return _ageMonth;
            }

            set
            {
                _ageMonth = value;
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public int AgeDay
        {
            get
            {
                return _ageDay;
            }

            set
            {
                _ageDay = value;
            }
        }

        /// <summary>
        /// �Һ���ˮ��
        /// </summary>
        public string Ghregno { get; set; }

        /// <summary>
        /// ҽ���Һ���ˮ��
        /// </summary>
        public string YBMzRegid { get; set; }

        /// <summary>
        /// ������ˮ��
        /// </summary>
        public string DJRegid { get; set; }

        /// <summary>
        /// ҽ�����
        /// </summary>
        public double MedicalAmount { get; set; }
        /// <summary>
        /// �Һŷ���
        /// </summary>
        public double RegFee { get; set; }
        /// <summary>
        /// ��������ID
        /// </summary>
        public string DepartmentID { get; set; }
        public int RegionId { get; set; }
        #region ��ɽ
        /// <summary>
        /// �Ƿ�������
        /// </summary>
        public bool IsWebBinding { get; set; }
        /// <summary>
        /// �����ܷ���
        /// </summary>
        public double AmoutFactPay { get; set; }
        
        /// <summary>
        /// ���۽��
        /// </summary>
        public double PatPricereCord { get; set; }

        public string ConsultDocName { get; set; }
        /// <summary>
        /// ���ۼ�¼ID
        /// </summary>
        public int patPricereCordId { get; set; }

        /// <summary>
        /// ���۽��
        /// </summary>
        public double ThePrice
        {
            get { return this._thePrice; }
            set { this._thePrice = value; }
        }
        /// <summary>
        /// ��ѯʦid
        /// ��������id
        /// </summary>
        public string ConsultID
        {
            get { return _consultID; }
            set { _consultID = value; }
        }
        /// <summary>
        /// ��ѯʦ����
        /// </summary>
        public string ConsultName { get; set; }
        #endregion

        #region ����
        /// <summary>
        /// ����
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        /// <summary>
        /// �߶�
        /// </summary>
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public bool IsClose { get; set; }
        public int HospitalId { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsLocationDiagSee { get; set; }
        public bool IsPriority { get; set; }
        public int LineOrder { get; set; }
        public string RegLocation { get; set; }
        public string SpecialityId { get; set; }
        public bool Istally { get; set; }
        public string ConsultDetail { get; set; }

        public bool IsDiadnosis { get; set; }

        

        #endregion

        /// <summary>
        /// ר��ID
        /// </summary>
        public int SpecialistID { get; set; }
        private bool _isNurseId = false;
        public bool u_IsNurseId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(NurseId))
                {
                    _isNurseId = true;
                }
                else
                {
                    _isNurseId = false;
                }
                return _isNurseId;
            }
            set { _isNurseId = value; }
        }
    }
}







