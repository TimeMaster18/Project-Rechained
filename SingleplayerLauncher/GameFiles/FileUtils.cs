﻿using System;
using System.Diagnostics;
using System.IO;

namespace SingleplayerLauncher.GameFiles
{
    public static class FileUtils
    {

        public const string SPITFIREGAME_UPK_PATH = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        public const string SPITFIREGAME_UPK_FILENAME = "SpitfireGame.upk";
        public const int SPITFIREGAME_UPK_ORG_SIZE = 100225213;

        public const string SPITFIREGAME_EXE_FILENAME = "SpitfireGame.exe";
        public const string SPITFIREGAME_EXE_WIN32_FILEPATH = "./Win32/";
        public const string SPITFIREGAME_EXE_WIN64_FILEPATH = "./Win64/";

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

        /// <summary>
        /// Rounds a given number to the nearest lower thousand, with a pessimistic adjustment to ensure robustness
        /// in case the file size changes.
        /// </summary>
        /// <param name="n">The number to round.</param>
        /// <returns>The rounded number.</returns>
        public static int RoundToNearestLowerThousandPessimistic(int n)
        {
            int result = n - 500;
            if (result <= 0)
                return 0;

            return (result / 1000) * 1000;
        }

        public static void CopyFileWithCheck(string sourcePath, string destinationPath, bool overwrite = false)
        {
            try
            {
                if (File.Exists(destinationPath))
                {
                    if (overwrite)
                    {
                        File.Copy(sourcePath, destinationPath, true);
                    }
                }
                else
                {
                    File.Copy(sourcePath, destinationPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while copying the file: {ex.Message}");
            }
        }
    }
}