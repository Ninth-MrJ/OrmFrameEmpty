namespace Orm.Framework.Services
{
    /// <summary>
    /// ���Ͷ���ؽӿڣ�ֻ����Դ�����Ƚϴ�Ķ������Ҫ�ػ���
    /// </summary>
    public interface IObjectPool<T> where T : class
    {
        /// <summary>
        /// �Ӷ�����л�ȡһ�����ö���
        /// </summary>
        /// <returns></returns>
        T Get();

        /// <summary>
        /// �ͷ�һ������ص������(���ǴӶ���س�ȥ�Ķ������ͷŻض����)
        /// </summary>
        /// <param name="target"></param>
        bool Release(T target);

        /// <summary>
        /// �رն���ز����ٳ���ȫ������
        /// </summary>
        void Close();

        /// <summary>
        /// ��ǰ�����Ѿ�ʹ�õĶ������
        /// </summary>
        int ActiveObjects { get; }

        /// <summary>
        /// ��ǰ���л��ж��ٸ����ö���
        /// </summary>
        int IdleObjects { get; }
    }
}
