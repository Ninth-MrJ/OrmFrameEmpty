using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ����¼����Ԥ��
    /// </summary>  
    [Serializable]
    #region class of Model:uspHuStoreUnderLineWarningQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreUnderLineWarning.
    /// </summary>
    public class uspHuStoreUnderLineWarningQry : BaseModel
    {
        private string _houseId;
        private string _itemId;
        private string _itemCode;
        private string _unitId;
        private string _compId;
        private string _itemName = String.Empty;
        private string _companyName = String.Empty;
        private string _unitName = String.Empty;
        private string _spec = String.Empty;
        private double _stockPrice;
        private double _retailPrice;
        private double _underLineKc;
        private double _uperLineKc;
        private bool _selected;
        private double _stockNum;
        private double _normalLinekc;
        private string _groupId;
        private string _groupName = String.Empty;
        private bool _isOnlyForSys;
        private string _memo=string.Empty;
        public int Status { get; set; }

        /// <summary>
        /// ����¼����Ԥ��
        /// </summary>  
        public uspHuStoreUnderLineWarningQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// �ֿ�ID
        /// </summary>
            public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
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
        /// ��ĿID
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
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
        /// ҽҩ��˾ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }
        /// <summary>
        /// �����Ŀ����ID
        /// </summary>
        public string GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        /// <summary>
        /// �����Ŀ��������
        /// </summary>
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
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
        /// ���
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// ��Ŀ����(���)
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// ��λ
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
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
        /// ��澯������
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
        }
        /// <summary>
        /// �ɹ�ά�ֿ����
        /// </summary>
        public double NormalLinekc
        {
            get { return _normalLinekc; }
            set { _normalLinekc = value; }
        }
        /// <summary>
        /// �Ƿ�ѡ��(����ʹ��)
        /// </summary>
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
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
        /// �Ƿ���
        /// </summary>
        public bool IsOnlyForSys
        {
            get { return _isOnlyForSys; }
            set { _isOnlyForSys = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        #endregion
    }
    #endregion
}







