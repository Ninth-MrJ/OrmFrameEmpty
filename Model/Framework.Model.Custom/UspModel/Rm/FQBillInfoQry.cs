using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��Ʒ�����б�
    /// </summary>
    [Serializable]
    #region class of Model:FQBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a FQBillInfo.
    /// </summary>
    public class FQBillInfoQry : BaseModel
    {
        private string _itemId;
        private double _drugNum;
        private string _unitId;
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private string _roomId;
        private DateTime _operTime;
        private string _operId;
        private bool _isAffirm;
        private DateTime _affirmTime;
        private string _affirmOperid;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _retailPrice;
        private double _totalRetail;
        private string _unitName = String.Empty;
        private string _huTotalSum = String.Empty;
        private string _rmTotalSum = String.Empty;
        private string _batchNo = String.Empty;
        private string _limitDate = String.Empty;

        /// <summary>
        /// ��Ʒ�����б�
        /// </summary>
        public FQBillInfoQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// ��ĿID
        /// </summary>
            public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// ҩ����ҩ��������
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// ��λId 
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// ����ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// ���ݺ�
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// ҩ��ID
        /// </summary>
        public string RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// ������ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// �Ƿ�ȷ��
        /// </summary>
        public bool IsAffirm
        {
            get { return _isAffirm; }
            set { _isAffirm = value; }
        }
        /// <summary>
        /// ȷ��ʱ��
        /// </summary>
        public DateTime AffirmTime
        {
            get { return _affirmTime; }
            set { _affirmTime = value; }
        }
        /// <summary>
        /// ȷ�ϲ�����ID
        /// </summary>
        public string AffirmOperid
        {
            get { return _affirmOperid; }
            set { _affirmOperid = value; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// ��ҩ��˾����
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }

        /// <summary>
        /// ���ۼ�
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        /// �����ܶ� 
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// ��λ��
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// ����ܽ��
        /// </summary>
        public string HuTotalSum
        {
            get { return _huTotalSum; }
            set { _huTotalSum = value; }
        }
        /// <summary>
        /// ҩ���ܽ��
        /// </summary>
        public string RmTotalSum
        {
            get { return _rmTotalSum; }
            set { _rmTotalSum = value; }
        }
        /// <summary>
        /// ���κ�
        /// </summary>
        public string BatchNo
        {
            get { return _batchNo; }
            set { _batchNo = value; }
        }
        /// <summary>
        /// ʧ������
        /// </summary>
        public string LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        #endregion
    }
    #endregion
}







