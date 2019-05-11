using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// �����ϸ
    /// </summary>
    [Serializable]
   
    public partial class BsDiagnoseDtl : BaseModel
    {
        string _diagnoseDtl;
        string _checkType;
        string _commonName;
        string _relust;
        string _diagnoseId;
        string _commonNameId;

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsDiagnoseDtl()
        {
            LstItem = new List<BsItem>();
        }
        private int _orderBy;

        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// ��Ŀ�б�
        /// </summary>
        public List<BsItem> LstItem { get; set; }

        /// <summary>
        /// ��Ŀ
        /// </summary>
        public BsItem Item { get; set; }

        /// <summary>
        /// ͨ����id
        /// </summary>
        public string CommonNameId
        {
            get
            {
                return _commonNameId;
            }
            set
            {
                _commonNameId = value;
            }
        }

        /// <summary>
        /// ��Ӧ�����������id
        /// </summary>
        public string DiagnoseId
        {
            get
            {
                return _diagnoseId;
            }
            set
            {
                _diagnoseId = value;
            }
        }

        /// <summary>
        /// ���
        /// </summary>
        public string Relust
        {
            get
            {
                return _relust;
            }
            set
            {
                _relust = value;
            }
        }

        /// <summary>
        /// ͨ������
        /// </summary>
        public string CommonName
        {
            get
            {
                return _commonName;
            }
            set
            {
                _commonName = value;
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string CheckType
        {
            get
            {
                return _checkType;
            }
            set
            {
                _checkType = value;
            }
        }

        /// <summary>
        /// ������� ��ϸ
        /// </summary>
        public string DiagnoseDtl
        {
            get
            {
                return _diagnoseDtl;
            }
            set
            {
                _diagnoseDtl = value;
            }
        }

    }
}



