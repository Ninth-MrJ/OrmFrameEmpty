using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �û���Ӧ�Ŀɲ������ܼ�����
    /// </summary>
    [Serializable]
    public partial class uspWindowOperFunctionQry : BaseModel
    {
        /// <summary>
        /// �˵�id
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// ������id
        /// </summary>
        public string OperId { get; set; }
        /// <summary>
        /// ����id
        /// </summary>
        public string FunctionId { get; set; }
    }
}

