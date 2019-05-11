using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// ��ҩ����(��֤����/������ҽ)
    /// </summary>
    public partial class BsHerbalPrescriptionDtlMapping : ClassMap<BsHerbalPrescriptionDtl>
    {
        /// <summary>
        /// ��ҩ����(��֤����/������ҽ)
        /// </summary>
        public BsHerbalPrescriptionDtlMapping()
        {
            this.TableName("BsHerbalPrescriptionDtl").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.BsHerbalPrescriptionId).ColumnName("BsHerbalPrescriptionId");
            this.Column(p => p.ItemName).ColumnName("ItemName");
            this.Column(p => p.Orderby).ColumnName("Orderby");
            this.Column(p => p.PrescriptionType).ColumnName("PrescriptionType");
            this.Column(p => p.Remark).ColumnName("Remark");            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


