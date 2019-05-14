using System.Runtime.InteropServices;

namespace Orm.Client.Common
{
    public class RegEmrOcx
    {

        [DllImport("EHREditor.ocx")]
        public static extern int DllRegisterServer();//注册时用
        [DllImport("EHREditor.ocx")]
        public static extern int DllUnregisterServer();//取消注册时用接下来就不难啦：
    }
}
