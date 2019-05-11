

using System;
namespace Orm.Model
{
    /// <summary>
    /// ���ﲡ�˹Һ���Ϣ�� - ʵ����
    /// </summary> 
    public partial class OuHosInfo
    {
        private string _timeBegin; 
        private bool _iSInputBYRegMAN; // �����Ƿ�����ԤԼ
        private string _consultDetail; // ��������
        private string _mainInform = string.Empty;
        private DateTime _endMenstruationTime;
        private string _deptmentId;
        private string _participants;//������Ա

        private string _nurseName;  //��ʿ����

        /// <summary>
        /// ��ʿ����
        /// </summary>
        public string NurseName
        {
            get { return _nurseName; }
            set { _nurseName = value; }
        }
        /// <summary>
        /// ������Ա
        /// </summary>
        public string Participants
        {
            get
            {
                return this._participants;
            }
            set
            {
                this._participants = value;
            }
        }


        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public string TimeBegin
        {
            get
            {
                return this._timeBegin;
            }
            set
            {
                this._timeBegin = value;
            }
        }

        /// <summary>
        /// F8ԤԼ�Һ�ʱ��.
        /// </summary>
        public DateTime PRERegTime
        {
            get;set;
        }

        /// <summary>
        ///����վ����ԤԼ��Ϣ (ԭ��F1�Ƿ�ҺŴ�¼��.)
        /// </summary>
        public bool ISInputBYRegMAN
        {
            get
            {
                return this._iSInputBYRegMAN;
            }
            set
            {
                this._iSInputBYRegMAN = value;
            }
        }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string TimeEnd { get; set; }

        /// <summary>
        ///  ��������
        /// </summary>
        public string ConsultDetail
        {
            get
            {
                return this._consultDetail;
            }
            set
            {
                this._consultDetail = value;
            }
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

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool IsLL { get; set; }


        /// <summary>
        /// ����
        /// </summary>
        public string MainInform
        {
            get
            {
                return this._mainInform;
            }
            set
            {
                this._mainInform = value;
            }
        }

        /// <summary>
        /// ĩ���¾�
        /// </summary>
        public DateTime EndMenstruationTime
        {
            get { return this._endMenstruationTime == DateTime.MinValue ? DateTime.Now : this._endMenstruationTime; }
            set { this._endMenstruationTime = value; }
        }

        /// <summary>
        /// �Һſ���id
        /// </summary>
        public string DepartmentId
        {
            get { return _deptmentId; }
            set  { _deptmentId = value; }
        }

        private string _bookingpurpose;
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

        private string _patTypeName;
        /// <summary>
        /// �������.
        /// </summary>
        public string PatTypeName
        {
            get
            {
                return this._patTypeName;
            }
            set
            {
                this._patTypeName = value;
            }
        }

        /// <summary>
        /// ԤԼʱ�������
        /// </summary>
        public string TimeSpanSubName { get; set; }

        bool _isHideIllness;
        /// <summary>
        /// �Ƿ��ص��ע����
        /// </summary>
        public bool IsHideIllness
        {
            get
            {
                return _isHideIllness;
            }
            set
            {
                _isHideIllness = value;
            }
        }

  
        /// <summary>
        /// �Һſ���
        /// </summary>
        public string LocationName { set; get; }
     
        /// <summary>
        /// ��������
        /// </summary>
        public string RegTypeName { set; get; }
        /// <summary>
        /// ҩ�����ʷ
        /// </summary>
        public string Sensitive { set; get; }
        /// <summary>
        /// �������� 
        /// </summary>
        public string PatientName { set; get; }
        /// <summary>
        /// ��������ID
        /// </summary>
        public int TallyTypeId { set; get; }
        /// <summary>
        /// ��������
        /// </summary>
        public string TallyTypeName { set; get; }
        /// <summary>
        /// ��������ID
        /// </summary>
        public int TallyGroupId { set; get; }
        /// <summary>
        /// ��������
        /// </summary>
        public int TallyGroupName { set; get; }
        /// <summary>
        /// ����״̬(0:δ��,1:����)
        /// </summary>
        public int IsDiagnosed { set; get; }
        /// <summary>
        /// ����״̬
        /// </summary>
        public string DiagStatus { set; get; }

        #region  �����ƹҺ������ֶ�
        /// <summary>
        /// ������1-���2-����;3-���4-���Է���
        /// </summary>
        public int PatientStatus { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int SortNo { get; set; }
        #endregion
    }
}


