using ELinq;
using Orm.MapContext.Maping;

namespace Orm.MapContext
{
    /// <summary>
    ///
    /// </summary>
    public class RegisterMapContext : BaseDbContext
    {
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public RegisterMapContext(string Provider, string ConnectString)
        : base(Provider, ConnectString)
        {
        }
        /// <summary>
        /// ORM注册类入口.
        /// </summary>
        public override void RegisterMapping(DbConfiguration DbConfiguration)
        {
            DbConfiguration.AddClass(new BsHospitalMapping());
            DbConfiguration.AddClass(new BsRedisTableMapping());

        }
    }
}