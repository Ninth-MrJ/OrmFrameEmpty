using System;

namespace Orm.Model
{
    /// <summary>
    ///��������
    /// </summary>
    [Serializable]
    public partial class BsDeptType : BaseModel
    {
        private string _code;
        private string _name;
        private string _pyCode;
        private string _wbCode;
        private int _orderBy;
        private bool _isActive;
        private int _iconIndex;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsDeptType()
        {
        }



        /// <summary>
        /// ����.
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
        /// ����.
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
        /// ƴ����.
        /// </summary>
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode = value;
            }
        }

        /// <summary>
        /// �����.
        /// </summary>
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode = value;
            }
        }

        /// <summary>
        /// ��ʾ˳��.
        /// </summary>
        public int OrderBy
        {
            get
            {
                return this._orderBy;
            }
            set
            {
                this._orderBy = value;
            }
        }

        /// <summary>
        /// ��Ч��־.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// ͼ��.
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



