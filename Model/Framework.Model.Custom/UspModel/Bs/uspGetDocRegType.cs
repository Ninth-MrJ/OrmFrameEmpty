using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ҽ���Ű���Ϣ��
    /// </summary>
    [Serializable]
    
    public class uspGetDocRegTypeQry : BaseModel
    {
         
        private int _hasDiagNum;
        private int _waitDiagNum;
        private string _name = String.Empty;
        private string _sex = String.Empty;
        private string _locationName = String.Empty;
        private string _regType = String.Empty;
        private string _timeSpanId;
        private string _timeSpanName = String.Empty;
        private string _weekTime = String.Empty;
        private int _weekDay;
        private bool _isActive;
        private int _limitNum;
        private DateTime _lastLimitDate;
        private int _lastLimitNum;
        private string _doctorId;
        private string _locationId;
        private string _regTypeId;
        private string _memo = String.Empty;
        private string _timeBegin = String.Empty;
        private string _timeEnd = String.Empty;
        private string _f2 = String.Empty;
        private string _f3 = String.Empty;
        private string _f1 = String.Empty;
        private string _f4 = String.Empty;
        private string _roomNo = String.Empty;
        private string _diagRoomId;
        private string _operId;
        private DateTime _operTime;
        private string _MDInfo = String.Empty;
        private string _TDInfo = String.Empty;
        private string _WDInfo = String.Empty;
        private string _TUDInfo = String.Empty;
        private string _FDInfo = String.Empty;
        private string _STDInfo = String.Empty;
        private string _SUDInfo = String.Empty;
        private string _doctorName = String.Empty;

        public uspGetDocRegTypeQry()
        {
        }



        #region Public Properties

        /// <summary>
        /// ��������
        /// </summary>
        public int HasDiagNum
        {
            get { return _hasDiagNum; }
            set { _hasDiagNum = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public int WaitDiagNum
        {
            get { return _waitDiagNum; }
            set { _waitDiagNum = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        /// ����
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        /// <summary>
        /// �Һ����
        /// </summary>
        public string RegType
        {
            get { return _regType; }
            set { _regType = value; }
        }

        /// <summary>
        /// ���id
        /// </summary>
        public string   TimeSpanId
        {
            get { return _timeSpanId; }
            set { _timeSpanId = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string TimeSpanName
        {
            get { return _timeSpanName; }
            set { _timeSpanName = value; }
        }

        /// <summary>
        /// ��ʱ��
        /// </summary>
        public string WeekTime
        {
            get { return _weekTime; }
            set { _weekTime = value; }
        }

        /// <summary>
        /// ���ڼ�
        /// </summary>
        public int WeekDay
        {
            get { return _weekDay; }
            set { _weekDay = value; }
        }

        /// <summary>
        /// �Ƿ񼤻�
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public int LimitNum
        {
            get { return _limitNum; }
            set { _limitNum = value; }
        }

        /// <summary>
        /// �ϴ���������
        /// </summary>
        public DateTime LastLimitDate
        {
            get { return _lastLimitDate; }
            set { _lastLimitDate = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// �ϴ���������
        /// </summary>
        public int LastLimitNum
        {
            get { return _lastLimitNum; }
            set { _lastLimitNum = value; }
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
        /// ҽ������
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }
        /// <summary>
        /// �Һ�����
        /// </summary>
        public string RegTypeId
        {
            get { return _regTypeId; }
            set { _regTypeId = value; }
        }
        /// <summary>
        /// �������id
        /// </summary>

        public string DiagRoomId
        {
            get { return _diagRoomId; }
            set { _diagRoomId = value; }
        }
        /// <summary>
        /// ����ԱID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
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
        /// ��ʼʱ��
        /// </summary>
        public string TimeBegin
        {
            get { return _timeBegin; }
            set { _timeBegin = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string TimeEnd
        {
            get { return _timeEnd; }
            set { _timeEnd = value; }
        }

      

        /// <summary>
        /// ҽ������+�Һ�����(����һ)
        /// </summary>

        public string MDInfo
        {
            get { return _MDInfo; }
            set { _MDInfo = value; }
        }

        /// <summary>
        /// ҽ������+�Һ�����(���ڶ�)
        /// </summary>

        public string TDInfo
        {
            get { return _TDInfo; }
            set { _TDInfo = value; }
        }
        /// <summary>
        /// ҽ������+�Һ�����(������)
        /// </summary> 
        public string WDInfo
        {
            get { return _WDInfo; }
            set { _WDInfo = value; }
        }

        /// <summary>
        /// ҽ������+�Һ�����(������)
        /// </summary>

        public string TUDInfo
        {
            get { return _TUDInfo; }
            set { _TUDInfo = value; }
        }

        /// <summary>
        /// ҽ������+�Һ�����(������)
        /// </summary>

        public string FDInfo
        {
            get { return _FDInfo; }
            set { _FDInfo = value; }
        }

        /// <summary>
        /// ҽ������+�Һ�����(������)
        /// </summary>

        public string STDInfo
        {
            get { return _STDInfo; }
            set { _STDInfo = value; }
        }

        /// <summary>
        /// ҽ������+�Һ�����(������)
        /// </summary>

        public string SUDInfo
        {
            get { return _SUDInfo; }
            set { _SUDInfo = value; }
        }

        #endregion
    }
  
}







