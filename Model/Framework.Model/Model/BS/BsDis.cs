using System;

namespace Orm.Model
{
    /// <summary>
    /// BP����������
    /// </summary>
    [Serializable]
    public partial class BsDis : BaseModel
    {
        string _name;
        /// <summary>
        /// ��������
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _orderby;
        /// <summary>
        /// ����
        /// </summary>
        public int Orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }

        /// <summary>
        /// ƴ����
        /// </summary>
        string _pyCode = string.Empty;
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        string _wbCode = string.Empty;
        /// <summary>
        /// �����
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        private string _icdName;
        /// <summary>
        /// ICD��������
        /// </summary>
        public string ICDName
        {
            get { return _icdName; }
            set { _icdName = value; }
        }

        private string _bpIllId;
        /// <summary>
        /// BP��ӦXmlID
        /// </summary>
        public string BpIllId
        {
            get { return _bpIllId; }
            set { _bpIllId = value; }
        }

        private string _icd;
        /// <summary>
        /// ICD����
        /// </summary>
        public string ICD
        {
            get { return _icd; }
            set { _icd = value; }
        }

        private bool _existBP;
        /// <summary>
        /// �Ƿ����bp����
        /// </summary>
        public bool ExistBP
        {
            get { return _existBP; }
            set { _existBP = value; }
        }

        private bool _existChinaMed;
        /// <summary>
        /// �Ƿ������ҩ����
        /// </summary>
        public bool ExistChinaMed
        {
            get { return _existChinaMed; }
            set { _existChinaMed = value; }
        }

        private bool _existPatentMed;
        /// <summary>
        /// �Ƿ�����г�ҩ����
        /// </summary>
        public bool ExistPatentMed
        {
            get { return _existPatentMed; }
            set { _existPatentMed = value; }
        }
    }
}



