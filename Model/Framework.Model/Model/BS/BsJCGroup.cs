using System;

namespace Orm.Model
{
    /// <summary>
    /// ��鸽���շѷ����
    /// </summary>
    [Serializable]
    public partial class BsJCGroup : BaseModel
    {
        private string _code;
        private string _name;
        private int _iconIndex;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;

        /// <summary>
        /// ��鸽���շѷ���.
        /// </summary>
        public BsJCGroup()
        {
        }

        /// <summary>
        /// ��鸽���շѷ���ID.
        /// </summary>
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// ��鸽���շѷ���.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// ͼ������
        /// </summary>
        public int IconIndex
        {
            get
            {
                return this._iconIndex;
            }
            set
            {
                this._iconIndex = value;
            }
        }

        /// <summary>
        /// ����޸�ʱ��.
        /// </summary>
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime = value;
            }
        }

        /// <summary>
        /// ����޸���.
        /// </summary>
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId = value;
            }
        }

        /// <summary>
        /// ҽ����.
        /// </summary>
        public string YBCode
        {
            get
            {
                return this._yBCode;
            }
            set
            {
                this._yBCode = value;
            }
        }

        /// <summary>
        /// �ϱ���.
        /// </summary>
        public string UpCode
        {
            get
            {
                return this._upCode;
            }
            set
            {
                this._upCode = value;
            }
        }

    }
}



