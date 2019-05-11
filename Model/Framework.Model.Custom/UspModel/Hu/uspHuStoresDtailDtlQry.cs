using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
/// <summary>
/// ��������¼����
/// </summary>
    [Serializable]
    #region class of Model:uspHuStoresDtailDtlQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoresDtailDtl.
    /// </summary>
    public class uspHuStoresDtailDtlQry : BaseModel
    {
         
        private DateTime _happenTime;
        private string _inBatchNo = String.Empty;
        private string _pNo = String.Empty;
        private double _happenNumIn;
        private double _happenNumOut;
        private double _afterStockNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _memo = String.Empty;

        /// <summary>
        /// ��������¼����
        public uspHuStoresDtailDtlQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime HappenTime
        {
            get { return _happenTime; }
            set { _happenTime = value; }
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
        /// ��ⷢ������
        /// </summary>
        public double HappenNumIn
        {
            get { return _happenNumIn; }
            set { _happenNumIn = value; }
        }
        /// <summary>
        ///  ���ⷢ������
        /// </summary>
        public double HappenNumOut
        {
            get { return _happenNumOut; }
            set { _happenNumOut = value; }
        }
        /// <summary>
        /// ������ҩƷ�Ŀ������
        /// </summary>
        public double AfterStockNum
        {
            get { return _afterStockNum; }
            set { _afterStockNum = value; }
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
        /// ����(����)��
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
        #endregion
    }
    #endregion
}







