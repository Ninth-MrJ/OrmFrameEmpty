using System;

namespace Orm.Model
{
    /// <summary>
    /// ��ҩ����(��֤����/������ҽ)ϸ��
    /// </summary>
    [Serializable]
    public partial class BsHerbalPrescriptionDtl : BaseModel
    {
        string _itemName;
        /// <summary>
        /// ҩƷ����
        /// </summary>
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
            }
        }
        string _remark;
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark
        {
            get
            {
                return _remark;
            }
            set
            {
                _remark = value;
            }
        }
        int _prescriptionType;
        /// <summary>
        /// 0�������� 1�Ӽ���
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
        string _bsHerbalPrescriptionId;
        /// <summary>
        /// ��ҩ��������id
        /// </summary>
        public string BsHerbalPrescriptionId
        {
            get
            {
                return _bsHerbalPrescriptionId;
            }
            set
            {
                _bsHerbalPrescriptionId = value;
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

        /// <summary>
        /// ��ǰ�Ƿ�ѡ��
        /// </summary>
        public bool IsSelect { get; set; }
    }
}



