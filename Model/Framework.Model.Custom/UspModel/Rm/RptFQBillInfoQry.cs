using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��ӡ��Ʒ������Ϣ
    /// </summary>
    [Serializable]
    #region class of Model:RptFQBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptFQBillInfo.
    /// </summary>
    public class RptFQBillInfoQry : BaseModel
    {
        private double _dRUG_NUM;
        private string _drugs_ID = String.Empty;
        private string _sHORT_NAME = String.Empty;
        private string _sPECS = String.Empty;
        private string _unit_name = String.Empty;
        private string _apply_id = String.Empty;
        private DateTime _app_DATE;
        private string _house_Name = String.Empty;
        private string _fILLS_MAN = String.Empty;
        private string _billId;
        private double _price;
        private string _name = String.Empty;

        /// <summary>
        /// ��ӡ��Ʒ������Ϣ
        /// </summary>
        public RptFQBillInfoQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// .ҩ����ҩ��������
        /// </summary>
        public double DRUG_NUM
        {
            get { return _dRUG_NUM; }
            set { _dRUG_NUM = value; }
        }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Drugs_ID
        {
            get { return _drugs_ID; }
            set { _drugs_ID = value; }
        }

        /// <summary>
        /// ���
        /// </summary>
        public string SHORT_NAME
        {
            get { return _sHORT_NAME; }
            set { _sHORT_NAME = value; }
        }

        /// <summary>
        /// ���
        /// </summary>

        public string SPECS
        {
            get { return _sPECS; }
            set { _sPECS = value; }
        }

        /// <summary>
        /// ��λ
        /// </summary>
        public string unit_name
        {
            get { return _unit_name; }
            set { _unit_name = value; }
        }

        /// <summary>
        /// ���ݺ�
        /// </summary>
        public string Apply_id
        {
            get { return _apply_id; }
            set { _apply_id = value; }
        }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime App_DATE
        {
            get { return _app_DATE; }
            set { _app_DATE = value; }
        }

        /// <summary>
        /// ҩ��
        /// </summary>
        public string House_Name
        {
            get { return _house_Name; }
            set { _house_Name = value; }
        }

        /// <summary>
        /// ��Ӧ��
        /// </summary>
        public string FILLS_MAN
        {
            get { return _fILLS_MAN; }
            set { _fILLS_MAN = value; }
        }

        /// <summary>
        /// ҩ������ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// ���ۼ۸�
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// ҩƷ������
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
    }
    #endregion
}



