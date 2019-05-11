﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class OaDocReaderMapping: ClassMap<OaDocReader>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public OaDocReaderMapping()
		{
			this.TableName("OADOCREADER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DocId).ColumnName("DOCID");
			  
			this.Column(p =>p.AllowOperId).ColumnName("ALLOWOPERID");
			  
			this.Column(p =>p.ExpireTime).ColumnName("EXPIRETIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

