using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ������¼
    /// </summary>
    [Serializable]
    #region class of Model:uspHustoresDtailQry
    /// <summary>
    /// This object represents the properties and methods of a uspHustoresDtail.
    /// </summary>
    public class uspHustoresDtailQry : BaseModel
    {
         
        private string _itemId;
        private string _inBatchNo = String.Empty;
        private string _pNo = String.Empty;
        private string _unitId;
        private string _unitName = String.Empty;
        private double _stockNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _storeDate;
        private string _produceDate;
        private string _limitDate;
        private double _retailTotal;
        private double _priceTotal;
        private double _priceDiag;
        private string _spec = String.Empty;

        /// <summary>
        /// ������¼
        /// </summary>
        public uspHustoresDtailQry()
        {
        }




        #region Public Properties
        /// <summary>
        ///��ĿID
        /// </summary>
            public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        /// <summary>
        /// ��ˮ��
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
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
        /// ��λID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// ��浥λ��(��λ)
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
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
        /// ���ۼ۸�
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }
        /// <summary>
        /// ʧЧ����
        /// </summary>
        public string LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// �����ܶ�
        /// </summary>
        public double RetailTotal
        {
            get { return _retailTotal; }
            set { _retailTotal = value; }
        }
        /// <summary>
        /// �ܼ۸�
        /// </summary>
        public double PriceTotal
        {
            get { return _priceTotal; }
            set { _priceTotal = value; }
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
        /// ����۸�
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }
        #endregion
    }
    #endregion
}







