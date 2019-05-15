using System;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class BsRedisTable : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        public BsRedisTable() { }

        private string _tableName;  //表名称


        /// <summary>
		/// 表名称
		/// </summary>
		public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }


    }
}
