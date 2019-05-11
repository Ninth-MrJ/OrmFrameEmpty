using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ����̵��¼
    /// </summary>
    [Serializable]
    #region class of Model:uspHuStoreLogBatchActtypeSumQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreLogBatchActtypeSum.
    /// </summary>
    public class uspHuStoreLogBatchActtypeSumQry : BaseModel
    {
         
        private double _totalRetail;
        private int _lsacttype;

        /// <summary>
        /// ����̵��¼
        /// </summary>
        public uspHuStoreLogBatchActtypeSumQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// ҩ����ҩ.
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public int lsacttype
        {
            get { return _lsacttype; }
            set { _lsacttype = value; }
        }
        #endregion
    }
    #endregion
}







