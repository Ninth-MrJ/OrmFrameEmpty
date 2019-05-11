using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ������־��Ϣ
    /// </summary>
    [Serializable]
    #region class of Model:uspHuStoreLogQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreLogQry.
    /// </summary>
    public class uspHuStoreLogQry : BaseModel
    {
        private DateTime _happenTime;
        private string _itemId;
        private string _itemCode;
        private string _itemName;
        private string _pNo;
        private DateTime _limitDate;
        private string _manufacturerName;
        private double _beforeStockNum;
        private double _beforeTotalStockNum;
        private double _happenNum;
        private double _afterStockNum;
        private double _afterTotalStockNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _billNo;
        private string _lsActType;
        private string _memo;
        private string _houseId;
        private string _unitId;
        /// <summary>
        /// ������־��Ϣ
        /// </summary>
        public uspHuStoreLogQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// ��λ
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// �ֿ�
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime HappenTime
        {
            get { return _happenTime; }
            set { _happenTime = value; }
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
        /// ��ҩ��˾����
        /// </summary>
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { _manufacturerName = value; }
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
        /// ���������
        /// </summary>
        public string LsActType
        {
            get { return _lsActType; }
            set { _lsActType = value; }
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
        /// ʧ������
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// ����ǰ�����εĿ������
        /// </summary>
        public double BeforeStockNum
        {
            get { return _beforeStockNum; }
            set { _beforeStockNum = value; }
        }
        /// <summary>
        /// ����ǰ��ҩƷ���������ε��ܿ������
        /// </summary>
        public double BeforeTotalStockNum
        {
            get { return _beforeTotalStockNum; }
            set { _beforeTotalStockNum = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public double HappenNum
        {
            get { return _happenNum; }
            set { _happenNum = value; }
        }
        /// <summary>
        /// /������ҩƷ�Ŀ������
        /// </summary>
        public double AfterStockNum
        {
            get { return _afterStockNum; }
            set { _afterStockNum = value; }
        }
        /// <summary>
        /// �������ҩƷ���������ε��ܿ������
        /// </summary>
        public double AfterTotalStockNum
        {
            get { return _afterTotalStockNum; }
            set { _afterTotalStockNum = value; }
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
        /// �����
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }

        /// <summary>
        /// �����б�������
        /// </summary>
        public int RowCount { get; set; }

        #endregion
    }
    #endregion
}