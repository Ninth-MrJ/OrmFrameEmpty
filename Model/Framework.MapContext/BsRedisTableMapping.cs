using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// reids缓存表
    /// </summary>
    public partial class BsRedisTableMapping : ClassMap<BsRedisTable>
    {
        /// <summary>
        /// reids缓存表
        /// </summary>
        public BsRedisTableMapping()
        {
            this.TableName("BsRedisTable").Schema("orm");
            this.Column(p => p.TableName).ColumnName("TableName");
            this.Ignore(p => p.IsModify);
        }
    }
}
