using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;

namespace Orm.Model
{
    /// <summary>
    /// BP���Ʒ���˵��
    /// </summary>
    [Serializable]

    public partial class BsIll : BaseModel
    {
        string _name;
        string _patientGroup;
        string _treatment;
        string _detail;
        int _orderby;
        int _treatOrderby;

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsIll()
        {
            MethodGroup = new List<string>();
        }
        
        /// <summary>
        /// ������(������Ŀ)
        /// </summary>
        public List<BsItemList> LstItemList { get; set; }

        /// <summary>
        /// �ڼ�ѡ��
        /// </summary>
        public List<string> MethodGroup { get; set; }

        /// <summary>
        /// ����ԭ������
        /// </summary>
        public int TreatOrderby
        {
            get
            {
                return _treatOrderby;
            }
            set
            {
                _treatOrderby = value;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public int Orderby
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
        /// ����ԭ��
        /// </summary>
        public string Treatment
        {
            get
            {
                return _treatment;
            }
            set
            {
                _treatment = value;
            }
        }

        /// <summary>
        /// С��˵��
        /// </summary>
        public string Detail
        {
            get
            {
                return _detail;
            }
            set
            {
                _detail = value;
            }
        }

        /// <summary>
        /// ���߷���
        /// </summary>
        public string PatientGroup
        {
            get
            {
                return _patientGroup;
            }
            set
            {
                _patientGroup = value;
            }
        }
    }

}



