using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �˻س�����Ʒ�б�
    /// </summary>
    [Serializable]
    #region class of Model:THBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a THBillInfo.
    /// </summary>
    public class THBillInfoQry : BaseModel
    {
         
        private string _inBatchId;
        private string _inBatchNo = String.Empty;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _memo = String.Empty;
        private string _voucherNo = String.Empty;
        private bool _isMargin;
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private string _compId;
        private DateTime _operTime;
        private string _operId;
        private bool _isSign;
        private DateTime _signTime;
        private string _signOperId;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _deltaAmount;
        private string _PNo = String.Empty;
        public DateTime LimitDate { get; set; }
        public double StockNum { get; set; }

        /// <summary>
        /// �˻س�����Ʒ��Ϣ
        /// </summary>
        public THBillInfoQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// ҩƷ����ID
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }
        /// <summary>
        /// �ܽ��
        /// </summary>
        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }
        /// <summary>
        /// ���ݺ�
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
        /// ����
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
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
        /// �����
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// ��Ʊ��
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }

        /// <summary>
        /// ������˻�
        /// </summary>
        public bool IsMargin
        {
            get { return _isMargin; }
            set { _isMargin = value; }
        }
        /// <summary>
        /// �˻�����ID
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
        /// ҽҩ��˾ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
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
        /// �Ʊ���ID
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
        /// ��λ
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        /// <summary>
        /// ��Ʒ���
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// ��Ʒ����
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
        /// ����
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
        /// ���۽��
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
            get { return _PNo; }
            set { _PNo = value; }
        }
        #endregion
    }
    #endregion
}






