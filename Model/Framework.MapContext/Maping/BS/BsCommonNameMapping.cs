using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///BPͨ������
    /// </summary>
    public partial class BsCommonNameMapping : ClassMap<BsCommonName>
    {
        /// <summary>
        /// BPͨ������
        /// </summary>
        public BsCommonNameMapping()
        {
            this.TableName("BsCommonName").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.CommonName).ColumnName("CommonName");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


