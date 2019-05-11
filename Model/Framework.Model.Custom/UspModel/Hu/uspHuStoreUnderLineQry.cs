using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��澯������
    /// </summary>
    [Serializable]
    #region class of Model:uspHuStoreUnderLineQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreUnderLine.
    /// </summary>
    public class uspHuStoreUnderLineQry : BaseModel
    {
         
        private string _itemName = String.Empty;
        private string _companyName = String.Empty;
        private string _unitName = String.Empty;
        private string _areaName = String.Empty;
        private string _compId;
        private string _spec = String.Empty;
        private double _underLine;
        private double _uperLine;
        private double _stockPriceKc;
        private double _retailPriceKc;
        private string _houseName = String.Empty;
        private double _normalLineKc;
        private string _itemId;
        private int _orderBy;
        private string _itemCode = String.Empty;

        /// <summary>
        /// ��澯������
        /// </summary>
        public uspHuStoreUnderLineQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// ��Ŀ��
        /// </summary>
            public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// ҽҩ��˾����
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
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
        /// ��������
        /// </summary>
        public string AreaName
        {
            get { return _areaName; }
            set { _areaName = value; }
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
        /// ���
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// ��澯������
        /// </summary>
        public double UnderLine
        {
            get { return _underLine; }
            set { _underLine = value; }
        }
        /// <summary>
        /// ��澯������
        /// </summary>
        public double UperLine
        {
            get { return _uperLine; }
            set { _uperLine = value; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public double StockPriceKc
        {
            get { return _stockPriceKc; }
            set { _stockPriceKc = value; }
        }
        /// <summary>
        /// ���ۼ۸�
        /// </summary>
        public double RetailPriceKc
        {
            get { return _retailPriceKc; }
            set { _retailPriceKc = value; }
        }
        /// <summary>
        /// �ֿ���
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// �ɹ�ά�ֿ����
        /// </summary>
        public double NormalLineKc
        {
            get { return _normalLineKc; }
            set { _normalLineKc = value; }
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
        /// ����
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }
        /// <summary>
        /// ��ҩ��˾ID
        /// </summary>
        public string ManuId { set; get; }
        /// <summary>
        /// ҩ�ⵥλ
        /// </summary>
        public int UnitKc { set; get; }
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId { set; get; }
       
        #endregion
    }
    #endregion
}







