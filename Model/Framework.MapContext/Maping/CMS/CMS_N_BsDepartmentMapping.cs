﻿using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Model.CMS;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_N_BsDepartmentMapping : ClassMap<CMS_N_BsDepartment>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_N_BsDepartmentMapping()
        {
            this.TableName("CMS_N_BSDEPARTMENT").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.DeptId).ColumnName("DEPTID");
            this.Column(p => p.DeptName).ColumnName("DEPTNAME");
            this.Column(p => p.ParentId).ColumnName("PARENTID");
            this.Column(p => p.Bookable).ColumnName("BOOKABLE");
            this.Column(p => p.DoctorLocation).ColumnName("DOCTORLOCATION");
            this.Column(p => p.Description).ColumnName("DESCRIPTION");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
