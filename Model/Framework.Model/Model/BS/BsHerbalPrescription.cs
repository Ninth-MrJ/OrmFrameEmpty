using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// ��ҩ����(��֤����/������ҽ)
    /// </summary>
    [Serializable]
    public partial class BsHerbalPrescription : BaseModel
    {
        string _illName;
        /// <summary>
        /// ��������
        /// </summary>
        public string IllName
        {
            get
            {
                return _illName;
            }
            set
            {
                _illName = value;
            }
        }

        string _illDetial;
        /// <summary>
        /// ������ϸ
        /// </summary>
        public string IllDetial
        {
            get
            {
                return _illDetial;
            }
            set
            {
                _illDetial = value;
            }
        }
        string _author;
        /// <summary>
        /// ������ҽ
        /// </summary>
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        string _typeOfSyndrome;
        /// <summary>
        /// ֤��
        /// </summary>
        public string TypeOfSyndrome
        {
            get
            {
                return _typeOfSyndrome;
            }
            set
            {
                _typeOfSyndrome = value;
            }
        }
        string _therapy;
        /// <summary>
        /// �η�
        /// </summary>
        public string Therapy
        {
            get
            {
                return _therapy;
            }
            set
            {
                _therapy = value;
            }
        }
        string _prescription;
        /// <summary>
        /// �Ƽ�����
        /// </summary>
        public string Prescription
        {
            get
            {
                return _prescription;
            }
            set
            {
                _prescription = value;
            }
        }
        string _authorIntro;
        /// <summary>
        /// ������ҽ���
        /// </summary>
        public string AuthorIntro
        {
            get
            {
                return _authorIntro;
            }
            set
            {
                _authorIntro = value;
            }
        }
        string _explain;
        /// <summary>
        /// ˵��
        /// </summary>
        public string Explain
        {
            get
            {
                return _explain;
            }
            set
            {
                _explain = value;
            }
        }
        string _experience;
        /// <summary>
        /// ���鷽
        /// </summary>
        public string Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;
            }
        }
        string _addAndSubtract;
        /// <summary>
        /// �Ӽ�������
        /// </summary>
        public string AddAndSubtract
        {
            get
            {
                return _addAndSubtract;
            }
            set
            {
                _addAndSubtract = value;
            }
        }
        int _prescriptionType;
        /// <summary>
        /// 0.��֤�Ʒ� 1.������ҽ���鷽
        /// </summary>
        public int PrescriptionType
        {
            get
            {
                return _prescriptionType;
            }
            set
            {
                _prescriptionType = value;
            }
        }
        int _orderby;
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
        string _usage;
        /// <summary>
        /// ��֤�����÷�
        /// </summary>
        public string Usage
        {
            get { return _usage; }
            set { _usage = value; }
        }
        /// <summary>
        /// ��ϸ�������� ��������
        /// </summary>
        public List<BsHerbalPrescriptionDtl> LstBase { get; set; }
        /// <summary>
        /// ��ϸ�������� �Ӽ���
        /// </summary>
        public List<BsHerbalPrescriptionDtl> LstAddAndSub { get; set; }
    }
}



