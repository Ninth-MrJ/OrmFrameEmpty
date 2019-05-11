using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��ӡ�հ��̵㵥  ����
    /// </summary>
    [Serializable]
    #region class of Model:RptHuInventoriesDeatilQry
    /// <summary>
    /// This object represents the properties and methods of a RptHuInventoriesDeatil.
    /// </summary>
    public class RptHuInventoriesDeatilQry : BaseModel
    {
         
        private string _inBatchId;
        private double _balanceNum;
        private double _stcokNum;
        private double _instoreNum;
        private double _checkNum;
        private double _pkNum;
        private double _stockPrice;
        private double _retailPrice;
        private double _retailPricePk;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _pNo = String.Empty;
        private string _itemType = String.Empty;
        private DateTime _limitDate;
        private string _formName = String.Empty;
        private string _unitName = String.Empty;
        private DateTime _checkTime;
        private string _checkName = String.Empty;
        private string _spec = String.Empty;
        private string _houseName = String.Empty;
        private string _compName = string.Empty;
        private bool _optionPrice;
        private bool _isSpecSum;
        private bool _isCheched;
        private string _code = String.Empty;

        /// <summary>
        /// ��ӡ�հ��̵㵥  ����
        /// </summary>
        public RptHuInventoriesDeatilQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// �Ƿ��ѽ�ת���ˣ�0-δ���� 1-�Ѽ���
        /// </summary>
        public bool IsChecked
        {
            get { return _isCheched; }
            set { _isCheched = value; }
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
        /// .�������
        /// </summary>
        public double BalanceNum
        {
            get { return _balanceNum; }
            set { _balanceNum = value; }
        }
        /// <summary>
        /// �������.
        /// </summary>
        public double StcokNum
        {
            get { return _stcokNum; }
            set { _stcokNum = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public double InstoreNum
        {
            get { return _instoreNum; }
            set { _instoreNum = value; }
        }
        /// <summary>
        /// �̵�����.
        /// </summary>
        public double CheckNum
        {
            get { return _checkNum; }
            set { _checkNum = value; }
        }
        /// <summary>
        /// ӯ������
        /// </summary>
        public double PkNum
        {
            get { return _pkNum; }
            set { _pkNum = value; }
        }
        /// <summary>
        /// ʵ��
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
        /// ���ۼ��̿�
        /// </summary>
        public double RetailPricePk
        {
            get { return _retailPricePk; }
            set { _retailPricePk = value; }
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
        /// ����
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ItemType
        {
            get { return _itemType; }
            set { _itemType = value; }
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
        /// �������
        /// </summary>
        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
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
        /// �̵�ʱ��
        /// </summary>
        public DateTime CheckTime
        {
            get { return _checkTime; }
            set { _checkTime = value; }
        }
        /// <summary>
        /// �̵���
        /// </summary>
        public string CheckName
        {
            get { return _checkName; }
            set { _checkName = value; }
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
        public string Code
        {
            get { return _code; }
            set { _code = value; }
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
        /// ҽҩ��˾����
        /// </summary>
        public string CompName
        {
            get { return _compName; }
            set { _compName = value; }
        }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId { get; set; }
        /// <summary>
        /// ������ID
        /// </summary>
        public string OperId { get; set; }
        /// <summary>
        /// ҽҩ��˾ID
        /// </summary>
        public string CompId { get; set; }
        /// <summary>
        /// ��λID
        /// </summary>
        public string UnitId { get; set; }

        #endregion
    }
    #endregion
}







