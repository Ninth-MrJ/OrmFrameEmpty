using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///  ��ӡ��Ʒ����
    /// </summary>
    [Serializable]
    #region class of Model:RptBSBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptBSBillInfo.
    /// </summary>
    public class RptBSBillInfoQry : BaseModel
    {
         
        private string _inBatchId;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _reason = String.Empty;
        private string _billId;
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private string _memo = String.Empty;
        private string _unitName = String.Empty;
        private string _dRUGS_ID = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private string _pNo = String.Empty;
        private DateTime _limitDate;
        private string _houseName = String.Empty;
        private string _operName = String.Empty;
        private string _bsItemId;

        /// <summary>
        ///  ��ӡ��Ʒ����
        /// </summary>
        public RptBSBillInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// ��ҩ����ID.
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }
        /// <summary>
        /// /��ĿID
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
        /// ����
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// �����
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
        /// ����ԭ��.
        /// </summary>
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
        /// <summary>
        /// �������ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }
        /// <summary>
        /// ������ⵥ��
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
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
        /// ��ע
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
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
        public string DRUGS_ID
        {
            get { return _dRUGS_ID; }
            set { _dRUGS_ID = value; }
        }
        /// <summary>
        /// ��Ŀ��
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
        /// <summary>
        /// ����
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }
        /// <summary>
        /// ʧ������
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// �ֿ�����
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public string BsItemId
        {
            get { return _bsItemId; }
            set { _bsItemId = value; }
        }
        #endregion
    }
    #endregion
}







