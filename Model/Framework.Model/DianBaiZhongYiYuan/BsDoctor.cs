﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.DianBaiZhongYiYuan
{
    /// <summary>
    /// 
    /// </summary>
    public class BsDoctor : BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeptId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Decsription { get; set; }
    }
}
