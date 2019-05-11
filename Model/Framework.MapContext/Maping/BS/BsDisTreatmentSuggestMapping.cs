using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///�������ƽ��ܱ�
    /// </summary>
    public partial class BsDisTreatmentSuggestMapping : ClassMap<BsDisTreatmentSuggest>
    {
        /// <summary>
        ///�������ƽ��ܱ�
        /// </summary>
        public BsDisTreatmentSuggestMapping()
        {
            this.TableName("BsDisTreatmentSuggest").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Name).ColumnName("NAME");
            this.Column(p => p.Describe).ColumnName("Describe");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


