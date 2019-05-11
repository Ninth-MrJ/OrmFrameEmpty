using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��Ʒ��ӯ
    /// </summary>
    [Serializable]
    #region class of Model:KKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a KKBillInfo.
    /// </summary>
    public class KKBillInfoQry : BaseModel
    {
         
        private string _inBatchId;
        private string _inBatchNo = String.Empty;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private double _deltaAmount;
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private DateTime _operTime;
        private string _operId;
        private bool _isSign;
        private DateTime _signTime;
        private string _signOperId;
        private string _pNo = String.Empty;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        public DateTime LimitDate { get; set; }
        /// <summary>
        /// ��Ʒ��ӯ
        /// </summary>
        public KKBillInfoQry()
        {
        }
        #region Public Properties
        /// <summary>
        /// ӯ���ܽ��
        /// </summary>
        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }
        /// <summary>
        /// ҩƷ����ID.
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }
        /// <summary>
        ///ҩƷ����
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        /// <summary>
        /// ��λID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// ӯ������
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// ����(����)��.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// ӯ������ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }
        /// <summary>
        /// ӯ�����ݺ�
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// ҩ��ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
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
        /// ������
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// �Ƿ�����ˣ�0:δ���,1:�����.
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }
        /// <summary>
        /// �����ID
        /// </summary>
        public string SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
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
        /// ������
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        /// <summary>
        /// �ܽ��
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        #endregion
    }
    #endregion
}







