using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �ɹ��ƻ��б�
    /// </summary>
    [Serializable]
    #region class of Model:QSBillInfoQry
    
    public class QSBillInfoQry : BaseModel
    {
         
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private string _applyTime;
        private string _valideTime;
        private string _applyIdea = String.Empty;
        private string _applyHander = String.Empty;
        private string _operId;
        private string _operTime;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail; 
        private int _proAreaId;
        private string _manuId;
        private string _passNo = String.Empty;
        private double _saleNum;
        private string _f1 = String.Empty;
        private DateTime _orderByTime; //����ʱ��
        private double _underLineKc;
        private double _uperLineKc;
        /// <summary>
        /// �ɹ��ƻ��б�
        /// </summary>
        public QSBillInfoQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// �ɹ�ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// �ɹ����ݺ�
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        /// <summary>
        /// ҩ��ID
        /// </summary>
        public string  HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string ApplyTime
        {
            get { return _applyTime; }
            set { _applyTime = value; }
        }

        /// <summary>
        /// ��Ч����.
        /// </summary>
        public string ValideTime
        {
            get { return _valideTime; }
            set { _valideTime = value; }
        }

        /// <summary>
        /// �������.
        /// </summary>
        public string ApplyIdea
        {
            get { return _applyIdea; }
            set { _applyIdea = value; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string ApplyHander
        {
            get { return _applyHander; }
            set { _applyHander = value; }
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
        /// ����ʱ��
        /// </summary>
        public string OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
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
        /// �ɹ���
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }

        /// <summary>
        /// �ɹ���
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
        /// ��λ����
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// ���
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
        /// ����������
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }

        /// <summary>
        /// �ɹ����
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        /// <summary>
        /// ���۽��
        /// (���ۼ�*�ɹ�����)
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }

       /// <summary>
       /// ��������
       /// </summary>
        public double SaleNum
        {
            get { return _saleNum; }
            set { _saleNum = value; }
        }

        /// <summary>
        /// ��澯������
        /// </summary>
        public double UnderLineKc
        {
            get { return _underLineKc; }
            set { _underLineKc = value; }
        }


        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OrderByTime
        {
            get { return _orderByTime; }
            set { _orderByTime = value; }
        }
        /// <summary>
        /// ��澯������.
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
        }

        
        /// <summary>
        /// ������ID
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }
      
       
        #endregion
    }
    #endregion
}







