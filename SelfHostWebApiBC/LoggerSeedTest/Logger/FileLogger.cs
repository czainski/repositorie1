using System.IO;

namespace SelfHostWebApiBC.LoggerSeedTest.Logger
{
    public static class FileLogger
    {
        public static void Log(string file, string logInfo)
        {
            File.AppendAllText(@"../../"+file, logInfo);
        }
    }
}
