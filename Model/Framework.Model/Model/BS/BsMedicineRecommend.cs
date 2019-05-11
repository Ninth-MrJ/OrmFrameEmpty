using System;

namespace Orm.Model
{
    /// <summary>
    /// �г�ҩ�Ƽ��Ĺ�ϵ��
    /// (��Ӧ��ϵ����Ϊ ĳ��������ĳ�����߷��� ��Ӧ ĳ�������� �г�ҩ��Ŀ����+����id+ҩƷ���)
    /// </summary>
    [Serializable]
  
    public partial class BsMedicineRecommend : BaseModel
    {
        string _illName;        
        string _patientGroup = string.Empty;
        string _itemName;
        string _locationId;
        string _bsManufacturerID;
        string _indication;
        string _references;
        string _spec;
        string _phone;

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

        /// <summary>
        /// ���߷���
        /// </summary>
        public string PatientGroup
        {
            get { return _patientGroup; }
            set { _patientGroup = value; }
        }

        /// <summary>
        /// ��������ID
        /// </summary>
        public string BsManufacturerID {
            get { return _bsManufacturerID; }
            set { _bsManufacturerID = value; }
        } 

        /// <summary>
        /// ����id
        /// </summary>
        public string LocationID
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// �г�ҩ��Ŀ����
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        /// <summary>
        /// ��Ӧ֢
        /// </summary>
        public string Indication
        {
            get { return _indication; }
            set { _indication = value; }
        }

        /// <summary>
        /// �ο�����
        /// </summary>
        public string References
        {
            get { return _references; }
            set { _references = value; }
        }

        /// <summary>
        /// ���
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        /// <summary>
        /// �г�ҩ��Ŀ
        /// </summary>
        public BsItem Item { get; set; }

        /// <summary>
        /// �Ƿ�ѡ��
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// �Ƿ���ά��
        /// </summary>
        public bool IsMaintain { get; set; }
    }
}



