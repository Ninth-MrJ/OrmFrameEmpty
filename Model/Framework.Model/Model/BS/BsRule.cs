using System;

namespace Orm.Model
{
    [Serializable]
    /// <summary>
    /// ��ɹ����
    /// </summary>
    public partial class BsRule : BaseModel
    {

        private int _diagnosisBasetArget;
        private decimal _diagnosisRoyalty;
        private int _diagnosisTndtArget;
        private string _docLevID;
        private int _drugfeeBasetArget;
        private decimal _drugfeeRoyalty;
        private int _drugfeeStandArget;
        private int _exdrugfeeBasetArget;
        private decimal _exdrugfeeRoyalty;
        private int _exdrugfeeStandtArget;
        private DateTime _insertTime;
        private bool _isActive;
        private string _remark;
        private int _royaltyLevel;
        private int _treatmentBasetArget;
        private decimal _treatmentRoyalty;
        private int _treatmentStandardtArget;
        private string _code;

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsRule()
        {
        }
        /// <summary>
        /// ����
        /// </summary>
        [Collumn(HeaderName = "����", RelatedTableType = null, Length = 6)]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// ������Ŀ��
        /// </summary>
        [Collumn(HeaderName = "������Ŀ��", RelatedTableType = null, Length = 6)]
        public int DiagnosisBasetarget
        {
            get { return _diagnosisBasetArget; }
            set { _diagnosisBasetArget = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        [Collumn(HeaderName = "��������", RelatedTableType = null, Length = 6)]
        public decimal DiagnosisRoyalty 
        {
            get { return _diagnosisRoyalty; }
            set { _diagnosisRoyalty = value; }
        }

        /// <summary>
        /// �����Ŀ��
        /// </summary>
        [Collumn(HeaderName = "�����Ŀ��", RelatedTableType = null, Length = 6)]
        public int DiagnosisTndtArget
        {
            get { return _diagnosisTndtArget; }
            set { _diagnosisTndtArget = value; }
        }

        /// <summary>
        /// ְ��ID
        /// </summary>
        [Collumn(HeaderName = "ְ��", RelatedTableType = typeof(BsDocLevel))]
        public string DocLevID
        {
            get { return _docLevID; }
            set { _docLevID = value; }
        }

        /// <summary>
        /// ҩ�ѻ���Ŀ�꣨�����ڲ���
        /// </summary>
        [Collumn(HeaderName = "���Ų�ҵҩ��Ŀ��", RelatedTableType = null, Length = 6)]
        public int DrugfeeBasetArget 
        {
            get { return _drugfeeBasetArget; }
            set { _drugfeeBasetArget = value; }
        }

        /// <summary>
        /// ҩ�Ѵ����ɣ������ڲ���
        /// </summary>
        [Collumn(HeaderName = "���Ų�ҵҩ�����", RelatedTableType = null, Length = 6)]
        public decimal DrugfeeRoyalty
        {
            get { return _drugfeeRoyalty; }
            set { _drugfeeRoyalty = value; }
        }

        /// <summary>
        /// ҩ�Ѵ��Ŀ�꣨�����ڲ���
        /// </summary>
        [Collumn(HeaderName = "���Ų�ҵҩ�Ѵ��Ŀ��", RelatedTableType = null, Length = 6)]
        public int DrugfeeStandArget
        {
            get { return _drugfeeStandArget; }
            set { _drugfeeStandArget = value; }
        }

        /// <summary>
        /// ҩ�ѻ���Ŀ�꣨�����ⲿ��
        /// </summary>
        [Collumn(HeaderName = "������ҵҩ��Ŀ��", RelatedTableType = null, Length = 6)]
        public int ExdrugfeeBasetArget
        {
            get { return _exdrugfeeBasetArget; }
            set { _exdrugfeeBasetArget = value; }
        }

        /// <summary>
        /// ҩ�Ѵ����ɣ������ⲿ��
        /// </summary>
        [Collumn(HeaderName = "������ҵ���", RelatedTableType = null, Length = 6)]
        public decimal ExdrugfeeRoyalty
        {
            get { return _exdrugfeeRoyalty; }
            set { _exdrugfeeRoyalty = value; }
        }

        /// <summary>
        /// ҩ�Ѵ��Ŀ�꣨�����ⲿ��
        /// </summary>
        [Collumn(HeaderName = "������ҵ���Ŀ��", RelatedTableType = null, Length = 6)]
        public int ExdrugfeeStandtArget
        {
            get { return _exdrugfeeStandtArget; }
            set { _exdrugfeeStandtArget = value; }
        }

        /// <summary>
        /// ¼��ʱ��
        /// </summary>
        //[Collumn(HeaderName = "¼��ʱ��", RelatedTableType = null, Length = 6)]
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// ˵��
        /// </summary>
        [Collumn(HeaderName = "����˵��", RelatedTableType = null, Length = 6)]
        public string Remark 
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// �ȼ�
        /// </summary>
        [Collumn(HeaderName = "����ȼ�", RelatedTableType = null, Length = 6)]
        public int RoyaltyLevel 
        {
            get { return _royaltyLevel; }
            set { _royaltyLevel = value; }
        }

        /// <summary>
        /// ���ƻ���Ŀ��
        /// </summary>
        [Collumn(HeaderName = "���ƻ���Ŀ��", RelatedTableType = null, Length = 6)]
        public int TreatmentBasetArget
        {
            get { return _treatmentBasetArget; }
            set { _treatmentBasetArget = value; }
        }

        /// <summary>
        /// ���ƴ�����
        /// </summary>
        [Collumn(HeaderName = "���ƴ�����", RelatedTableType = null, Length = 6)]
        public decimal TreatmentRoyalty
        {
            get { return _treatmentRoyalty; }
            set { _treatmentRoyalty = value; }
        }

        /// <summary>
        /// ���ƴ��Ŀ��
        /// </summary>
        [Collumn(HeaderName = "���ƴ��Ŀ��", RelatedTableType = null, Length = 6)]
        public int TreatmentStandardtArget
        {
            get { return _treatmentStandardtArget; }
            set { _treatmentStandardtArget = value; }
        }
    }
}



