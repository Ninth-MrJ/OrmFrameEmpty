using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��ɫȨ�������Ϣ��
    /// </summary>
    [Serializable]
    public class uspRoleModuleQry
    {
        private bool _isChecked;
        private bool _isModify;
        private bool _rawIsChecked;
        /// <summary>
        /// ID
        /// </summary>
        public   string ID { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ��ID
        /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        /// ָʾ�������Ƿ�ѡ��״̬
        /// </summary>
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_rawIsChecked == value)
                {
                    _isModify = false;
                }
                else
                {
                    _isModify = true;
                }
                _isChecked = value;
            }
        }
        /// <summary>
        /// ָʾ������ԭʼѡ��״̬
        /// </summary>
        public bool RawIsChecked
        {
            get { return _rawIsChecked; }
            set
            {
                _rawIsChecked = value;
            }
        }
        /// <summary>
        /// ָʾ������Ŀǰ״̬�Ƿ���ԭʼ״̬��ͬ
        /// </summary>
        public bool IsModify { get { return _isModify; } set { _isModify = value; } }
        /// <summary>
        ///  ����˵������ַ
        /// </summary>
        public string HelpAddress { get; set; }
        /// <summary>
        /// �˵�id
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// Ȩ��id
        /// </summary>
        public string ModuleID { get; set; }
        /// <summary>
        /// ��ɫȨ��id
        /// </summary>
        public string RoleModuleID { get; set; }
        /// <summary>
        /// �����ֶ�
        /// </summary>
        public int Order { get; set; }
    }
}

