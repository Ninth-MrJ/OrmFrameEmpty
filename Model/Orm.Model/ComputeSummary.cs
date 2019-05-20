namespace Orm.Model
{
    /// <summary>
    /// 分组类
    /// </summary>
    public class ComputeSummary
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 总和
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// 平均值
        /// </summary>
        public decimal Avg { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        public decimal Max { get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        public decimal Min { get; set; }

        /// <summary>
        /// 分组个数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 分组Key值
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LimitGroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double LimitFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DocLevId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GroupBy { get; set; }
    }
}
