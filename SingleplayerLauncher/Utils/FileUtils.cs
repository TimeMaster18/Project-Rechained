using System.Diagnostics;
using System.IO;

namespace SingleplayerLauncher.Utils
{
    public static class FileUtils
    {

        public const string SPITFIREGAME_UPK_PATH = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        public const string SPITFIREGAME_UPK_FILENAME = "SpitfireGame.upk";
        public const int SPITFIREGAME_UPK_ORG_SIZE = 100225213;

        public const string SPITFIREGAME_EXE_FILENAME = "SpitfireGame.exe";
        public const string SPITFIREGAME_EXE_WIN32_FILEPATH = "./Win32/";

        private const string SPITFIREGAME_UPK_DECOMPRESS_PATH = ".//UE Extractor//SpitfireGame.upk";
        private const string SPITFIREGAME_UPK_DECOMPRESSED_PATH = ".//UE Extractor//unpacked//SpitfireGame.upk";
        private const string DECOMPRESSOR_PATH = ".//UE Extractor//decompress.exe";

        private const string BackupFolderPath = "..//OMDU_Offline_Backups";

        public static void CreateBackup(string fileName, string path)
        {
            bool backupFolderExists = System.IO.Directory.Exists(BackupFolderPath);

            if (!backupFolderExists)
            {
                System.IO.Directory.CreateDirectory(BackupFolderPath);
            }

            if (!File.Exists(BackupFolderPath + "//" + fileName))
            {
                File.Copy(path, BackupFolderPath + "//" + fileName);
            }
        }

        public static void DecompressUPKFile(string upkFilePath, int upkFileOriginalSize)
        {
            FileInfo spitfireGameUPKFileInfo = new FileInfo(upkFilePath);
            string fileName = spitfireGameUPKFileInfo.Name;
            if (spitfireGameUPKFileInfo.Length == upkFileOriginalSize)
            {
                FileUtils.CreateBackup(fileName, upkFilePath);

                if (!File.Exists(SPITFIREGAME_UPK_DECOMPRESS_PATH))
                {
                    File.Copy(upkFilePath, SPITFIREGAME_UPK_DECOMPRESS_PATH);
                }

                // Decompress
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = Path.GetFileName(DECOMPRESSOR_PATH),
                    WorkingDirectory = Path.GetDirectoryName(DECOMPRESSOR_PATH),
                    Arguments = "\"" + Path.GetFileName(SPITFIREGAME_UPK_DECOMPRESS_PATH) + "\""
                };
                Process process = Process.Start(psi);
                process.WaitForExit();
                File.Delete(upkFilePath);
                File.Move(SPITFIREGAME_UPK_DECOMPRESSED_PATH, upkFilePath); //TODO I think decompress.exe can get output folder as parameter 
            }
        }
    }
}
