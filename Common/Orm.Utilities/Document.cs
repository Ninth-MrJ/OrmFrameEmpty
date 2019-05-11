using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Orm.Utilities
{
    /// <summary>
    /// Summary description for Document.
    /// </summary>
    public class Document
    {
        StringBuilder sb;
        public Document()
        {
            sb = new StringBuilder();
        }


        /// <summary>
        /// ����·��
        /// </summary>
        private string _baseFolder;

        public string BaseFolder
        {
            set { _baseFolder = value; }
            get { return _baseFolder; }
        }

        /// <summary>
        /// ����
        /// </summary>
        private StringBuilder _content;

        public StringBuilder Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// д���ļ�
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        public void Create(string fileName, string encoding)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            Encoding e = Encoding.GetEncoding(encoding);
            StreamWriter file = new StreamWriter(fileName, false, e);
            try
            {
                file.Write(this.Content);
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
                file.Close();
            }

        }

        /// <summary>
        /// д���ļ�
        /// </summary>
        /// <param name="fileName">�ļ���</param>
        /// <param name="append">�Ƿ�׷��</param>
        public void Create(string fileName, bool append)
        {
            StreamWriter file = new StreamWriter(fileName, append);
            file.Write(this.Content);
            file.Close();
        }

        /// <summary>
        /// ��ָ����URLд���ļ�
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        public string Create(string url, string fileName, string encoding, int bufferSize)
        {
            Encoding e = Encoding.GetEncoding(encoding);
            StreamWriter writer = new StreamWriter(fileName, false, e, bufferSize);
            Stream stream;

            try
            {
                System.Uri objUri = new Uri(url);
                System.Net.WebRequest objRequest = System.Net.WebRequest.Create(objUri);
                System.Net.WebResponse objResponse = objRequest.GetResponse();
                stream = objResponse.GetResponseStream();
                objResponse.Close();
                int len = 4096;
                byte[] read = new byte[len];
                int bytes = stream.Read(read, 0, len);

                while (bytes > 0)
                {
                    writer.Write(e.GetString(read, 0, bytes));
                    bytes = stream.Read(read, 0, len);
                }
                stream.Flush();
                stream.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                writer.Flush();
                writer.Close();

            }
            return "OK";

        }
        /// <summary>
        /// ��URLȡ���ļ�
        /// </summary>
        /// <param name="url">ָ����URL</param>
        /// <param name="fileName">�ļ���</param>
        /// <param name="encoding">����</param>
        public string Create(string url, string fileName, string encoding)
        {
            Encoding e = Encoding.GetEncoding(encoding.ToLower());
            StreamWriter writer = new StreamWriter(fileName, false, e);
            Stream stream;

            try
            {
                System.Uri objUri = new Uri(url);
                System.Net.WebRequest objRequest = System.Net.WebRequest.Create(objUri);
                System.Net.WebResponse objResponse = objRequest.GetResponse();
                stream = objResponse.GetResponseStream();

                System.IO.StreamReader reader = new StreamReader(stream, e);

                writer.Write(reader.ReadToEnd());
                stream.Flush();
                stream.Close();
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
                writer.Flush();
                writer.Close();
            }
            return "OK";
        }
        /// <summary>
        /// ��Url��ȡ����
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public StringBuilder ReadUrl(string url, string encoding)
        {
            Encoding e = Encoding.GetEncoding(encoding.ToLower());

            Stream stream;
            string temp = string.Empty;
            try
            {
                System.Uri objUri = new Uri(url);
                System.Net.WebRequest objRequest = System.Net.WebRequest.Create(objUri);
                System.Net.WebResponse objResponse = objRequest.GetResponse();
                stream = objResponse.GetResponseStream();

                System.IO.StreamReader reader = new StreamReader(stream, e);

                temp = reader.ReadToEnd();
                stream.Flush();
                stream.Close();

            }
            catch (System.Exception ex)
            {
                throw (ex);
            }

            return new StringBuilder(temp);
        }

        public string Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return string.Empty;
            }
            Encoding e = Encoding.GetEncoding("gb2312");
            System.IO.StreamReader file = new StreamReader(fileName, e);
            string str = file.ReadToEnd();
            file.Close();
            return str;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public void CreateHTML(string fileName)
        {
            this.Create(fileName, "gb2312");
        }

        /// <summary>
        /// ȡ������ļ�ȫ��
        /// </summary>
        /// <returns>SHTML�ļ���</returns>
        public string GetFullRndName()
        {
            return this.GetFullPath() + this.GetRandName() + ".shtml";
        }
        /// <summary>
        /// ȡ��ȫ·��
        /// </summary>
        /// <returns></returns>

        public string GetFullPath()
        {
            string str = this.BaseFolder + this.GetDayFolderName() + "\\";
            if (!Directory.Exists(str)) Directory.CreateDirectory(str);
            return str;
        }

        public string GetRandName()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            string temp = (rnd.NextDouble() * 100000000000).ToString();
            temp = temp.Substring(0, 4);
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + temp;
        }
        public string GetDayFolderName()
        {
            string strFolder = DateTime.Today.ToString("yyyyMMdd");
            return strFolder;
        }
        public string GetMonthFoldName()
        {
            return DateTime.Today.ToString("yyyy-MM");
        }
        public long GetTimeNumer(DateTime time)
        {
            return long.Parse(time.Hour.ToString() + formatNum(time.Minute, 2) + formatNum(time.Second, 2) + formatNum(time.Millisecond, 3));
        }
        private string formatNum(int num, int len)
        {
            string temp = num.ToString();
            for (int i = 0; i < len - num.ToString().Length; i++)
            {
                temp = "0" + temp;
            }
            return temp;
        }
        /// <summary>
        /// ������־
        /// </summary>
        /// <param name="logTxt"></param>
        /// <param name="filePath"></param>
        public void SaveLog(string logTxt, string filePath)
        {
            try
            {
                this.Content = new StringBuilder(logTxt);
                this.Create(filePath, true);
                this.Content = new StringBuilder(string.Empty);
            }
            catch
            {

            }
        }
        /// <summary>
        /// �����ļ�
        /// </summary>
        /// <param name="sourceFileName">Դ�ļ�</param>
        /// <param name="targetName">Ŀ���ļ�</param>
        public void Copy(string sourceFileName, string targetName)
        {
            File.Copy(sourceFileName, targetName, true);
        }

        /// <summary>
        /// ��ָ����������ȡ
        /// </summary>
        /// <param name="content">����</param>
        /// <param name="rex">������ʽ</param>
        /// <returns></returns>
        public ArrayList GetParts(string content, string rex)
        {
            ArrayList list = new ArrayList();

            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(rex, System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(content);
            for (m = r.Match(content); m.Success; m = m.NextMatch())
            {
                list.Add(m.Groups[1].Value);
            }
            return list;
        }

        /// <summary>
        /// ��������ʽ�滻
        /// </summary>
        /// <param name="input">�����ַ�</param>
        /// <param name="findRegEx">���ұ��ʽ</param>
        /// <param name="replaceEx">�滻���ʽ</param>
        /// <returns>�������ַ�</returns>
        public static string Replace(string input, string findRegEx, string replaceEx)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, findRegEx, replaceEx, System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// ��̬����:��ָ���ļ����������������copy��Ŀ���ļ�������
        /// </summary>
        /// <param name="srcPath">Դ�ļ���</param>
        /// <param name="aimPath">Ŀ���ļ���</param>
        public static void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                // ���Ŀ��Ŀ¼�Ƿ���Ŀ¼�ָ��ַ�����������������֮
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // �ж�Ŀ��Ŀ¼�Ƿ����������������½�֮
                if (!Directory.Exists(aimPath)) Directory.CreateDirectory(aimPath);
                // �õ�ԴĿ¼���ļ��б��������ǰ����ļ��Լ�Ŀ¼·����һ������
                // ���ָ��copyĿ���ļ�������ļ���������Ŀ¼��ʹ������ķ���
                // string[] fileList = Directory.GetFiles(srcPath);
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                // �������е��ļ���Ŀ¼
                //Utilities.Information.ShowMsgBox(srcPath+"������������վ" + aimPath);
                foreach (string file in fileList)
                {
                    if (file.IndexOf("Utilities.") > 0 || file.IndexOf("AutoUpdate.") > 0 || file.IndexOf("HIS3.") > 0 || file.Trim() == "His2.exe" || file.Trim() == "His2.pdb")
                    {
                        Utilities.Document.currentCount++;
                        continue;
                    }
                    // �ȵ���Ŀ¼��������������Ŀ¼�͵ݹ�Copy��Ŀ¼������ļ�
                    //Utilities.Information.ShowMsgBox("���ڸ����ļ���" + file);
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    }
                    // ����ֱ��Copy�ļ�
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                        Utilities.Document.currentCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        ///  ��ǰ�Ѿ������ļ�����
        /// </summary>
        private static int currentCount = 0;

        public static int CurrentCount
        {
            get { return Document.currentCount; }
        }
        /// <summary>
        /// �ļ��ܸ���
        /// </summary>
        private static int count = 0;

        public static int Count
        {
            get { return Document.count; }
        }
        /// <summary>
        /// ��ȡĿ¼���ļ�����
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static void GetAllFiles(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Utilities.Document.count += dir.GetFiles().Length;
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                //GetAllFiles(di);
            }
        }

        /// <summary>
        /// ��̬����:��ָ���ļ����������������Detele
        /// </summary>
        /// <param name="aimPath"></param>
        public static void DeleteDir(string aimPath)
        {
            try
            {
                // ���Ŀ��Ŀ¼�Ƿ���Ŀ¼�ָ��ַ�����������������֮
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // �õ�ԴĿ¼���ļ��б��������ǰ����ļ��Լ�Ŀ¼·����һ������
                // ���ָ��DeleteĿ���ļ�������ļ���������Ŀ¼��ʹ������ķ���
                // string[] fileList = Directory.GetFiles(aimPath);
                string[] fileList = Directory.GetFileSystemEntries(aimPath);
                // �������е��ļ���Ŀ¼
                foreach (string file in fileList)
                {
                    // �ȵ���Ŀ¼��������������Ŀ¼�͵ݹ�Delete��Ŀ¼������ļ�
                    if (Directory.Exists(file))
                    {

                        DeleteDir(aimPath + Path.GetFileName(file));
                    }
                    // ����ֱ��Delete�ļ�
                    else
                    {
                        File.Delete(aimPath + Path.GetFileName(file));
                    }
                }
                //ɾ���ļ���

                System.IO.Directory.Delete(aimPath, true);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// ȡ���ļ�����չ��
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetExtention(string file)
        {
            int start = file.LastIndexOf(".");
            if (start < 0) return string.Empty;
            string ext = file.Substring(start, file.Length - start);
            return ext;
        }

        /// <summary>
        /// ȡ���ļ�����չ��
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static bool IsExistFile(string path, string fileName)
        {
            foreach (string f in Directory.GetFiles(path, fileName))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// ����������Byte[]�����ļ�
        /// </summary>
        /// <param name="FileFullPath">Ҫ���ɵ��ļ�ȫ·��</param>
        /// <param name="StreamByte">Ҫ�����ļ��Ķ����� Byte ����</param>
        /// <returns>bool �Ƿ����ɳɹ�</returns>
        public static bool ByteStreamToFile(string FileFullPath, byte[] StreamByte)
        {
            try
            {
                if (File.Exists(FileFullPath) == true)  //�ж�Ҫ�������ļ��Ƿ���ڣ�����������ɾ��
                {
                    File.Delete(FileFullPath);
                }
                FileStream FS = new FileStream(FileFullPath, FileMode.OpenOrCreate);  //�����ļ���(�򿪻򴴽��ķ�ʽ)
                FS.Write(StreamByte, 0, StreamByte.Length);  //���ļ���д���ļ���
                FS.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// ɾ���ļ��м����ļ���
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder(string dir)
        {
            if (Directory.Exists(dir)) //�����������ļ���ɾ��֮ 
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                    {
                        File.Delete(d); //ֱ��ɾ�����е��ļ� 
                    }
                    else
                    {
                        DeleteFolder(d); //�ݹ�ɾ�����ļ��� 
                    }
                }
                Directory.Delete(dir); //ɾ���ѿ��ļ��� 
            }
        }
    }
}
