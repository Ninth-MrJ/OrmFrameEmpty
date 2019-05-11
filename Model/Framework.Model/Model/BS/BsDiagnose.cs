using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// ��ϱ�
    /// </summary>
    [Serializable]
    public partial class BsDiagnose : BaseModel
    {
        string _diagnose;
        string _history;
        string _examine;
        bool _isCommon;
        int _orderby;

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsDiagnose()
        {
            mainList = new List<BsDiagnoseDtl>();
            otherList = new List<BsDiagnoseDtl>();
        }

        /// <summary>
        /// ��Ҫ���
        /// </summary>
        public List<BsDiagnoseDtl> mainList { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public List<BsDiagnoseDtl> otherList { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public int OrderBy
        {
            get
            {
                return _orderby;
            }
            set
            {
                _orderby = value;
            }
        }

        /// <summary>
        /// ������true/������false
        /// </summary>
        public bool IsCommon
        {
            get
            {
                return _isCommon;
            }
            set
            {
                _isCommon = value;
            }
        }

        /// <summary>
        /// ���
        /// </summary>
        public string Examine
        {
            get
            {
                return _examine;
            }
            set
            {
                _examine = value;
            }
        }

        /// <summary>
        /// ��ʷ
        /// </summary>
        public string History
        {
            get
            {
                return _history;
            }
            set
            {
                _history = value;
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string Diagnose
        {
            get
            {
                return _diagnose;
            }
            set
            {
                _diagnose = value;
            }
        }
        private string _xmlId;

        public string XmlId
        {
            get { return _xmlId; }
            set { _xmlId = value; }
        }

    }
}



