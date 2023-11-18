// Класс записи сообщения в лог-файл по указанному пути.
using System;
using System.IO;

namespace ClientIP
{
    public static class LogLocal
    {
        public static string logDir { get; set; }
        #region Получаю имя сборки GetPOname()
        public static string GetPOname() 
        {
            return typeof(Program).Assembly.GetName().Name;
        }
        #endregion
        #region Получаю путь к каталогу для временного хранения служебной информации
        public static string GetLocalDirPath() 
        {
            if(string.IsNullOrEmpty(GetPOname()))
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MP_DKHZ" + "\\uncnown" + Guid.NewGuid().ToString();
            else
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MP_DKHZ" + "\\" + GetPOname();
        }
        #endregion
        #region Если директории для хранения служебной информации не существует - создаю 
        private static void CreateIfMissing(string path)
        {
            if (!Directory.Exists(path))
            {
                try 
                { 
                    Directory.CreateDirectory(path);
                }catch(Exception ex) { /* supress */ }
            }
        }
        #endregion
        #region Запись сообщения в файл WriteLogLocal()
        public static void WriteLogLocal(string path, string message)
        {
            CreateIfMissing(path); // проверяю на наличие директории и если её нет - создаю
            try
            {
                using (StreamWriter writer = new StreamWriter(path+"\\log.txt", true)) 
                {
                    writer.WriteLineAsync(DateTime.Now.ToString("yyyy.mm.dd hh:mm:ss.fff") + " " + message); // исправить на запись по синхронизации с другими участниками записи
                }
            }
            catch (Exception ex) { /* supress */ } 
        }
        #endregion
    }
}
