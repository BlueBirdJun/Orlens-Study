using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace PS.Common.Helpers
{
    public class IOHelper
    {
        public static bool ExistsFile(Environment.SpecialFolder folder, string name)
        {
            var szDirPath = Environment.GetFolderPath(folder);
            var szFileName = name;
            var szFullPath = System.IO.Path.Combine(szDirPath, szFileName);
            return File.Exists(szFullPath);
        }

        /// <summary>
        /// 파일이 이미 존재할 경우 파일 이름에 번호를 붙인다.
        /// </summary>
        public static string GenerateFilePath(string szDir, string name, string ext, int number = 0)
        {
            string szFileName = number > 0 ?
                string.Format("{0}({1}){2}", name, number, ext) : string.Format("{0}{1}", name, ext);
            string szFilePath = System.IO.Path.Combine(szDir, szFileName);
            if (File.Exists(szFilePath))
            {
                return GenerateFilePath(szDir, name, ext, ++number);
            }
            return szFilePath;
        }

        public static double GetFreeSpace(string path)
        {
            try
            {

                //bool success = GetDiskFreeSpaceEx(Path.GetDirectoryName(path), out FreeBytesAvailable, out TotalNumberOfBytes,
                //  out TotalNumberOfFreeBytes);
                bool success = GetDiskFreeSpaceEx(Path.GetDirectoryName(path), out ulong FreeBytesAvailable, out ulong TotalNumberOfBytes,
                    out ulong TotalNumberOfFreeBytes);
                if (success)
                    return FreeBytesAvailable;

            }
            catch (Exception e)
            {
            }
            return -1;
        }

        /// <summary>
        /// 폴더를 오픈합니다
        /// </summary>
        /// <param name="sFullPath"></param>
        public static void OpenFolder(String sFullPath)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo("explorer.exe")
                {
                    UseShellExecute = true,
                    //processInfo.Arguments = String.Format("/open,\"{0}\" /select,\"{1}\"", Path.GetDirectoryName(sFullPath) , Path.GetFileName(sFullPath));
                    Arguments = String.Format("/select,\"{0}\"", sFullPath)
                };
                System.Diagnostics.Process.Start(processInfo);
            }
            catch { }
        }


        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
        out ulong lpFreeBytesAvailable,
        out ulong lpTotalNumberOfBytes,
        out ulong lpTotalNumberOfFreeBytes);

    }
}
