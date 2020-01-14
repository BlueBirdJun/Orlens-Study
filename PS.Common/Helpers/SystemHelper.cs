using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PS.Common.Helpers
{
    public static class SystemHelper
    {
        public static WindowsVersions GetWindowVersion()
        {
            RegistryKey reg = RegistryKey.OpenBaseKey(
                RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey regTemp = null;
            regTemp = reg.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", false);
            if (regTemp == null) { return WindowsVersions.Unknown; }
            else { reg = regTemp; }

            int major, minor, build;
            var value = reg.GetValue("CurrentVersion");
            var temp = Convert.ToString(value);
            var vers = temp.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            major = int.Parse(vers[0]);
            minor = int.Parse(vers[1]);

            value = reg.GetValue("CurrentBuildNumber");
            temp = Convert.ToString(value);
            if (string.IsNullOrEmpty(temp))
            {
                build = -1;
            }
            else
            {
                build = int.Parse(temp);
            }

            return DetermineVersion(major, minor, build);
        }

        private static WindowsVersions DetermineVersion(int major, int minor, int build = -1, int revision = -1)
        {
            if (major == 6)
            {
                if (minor == 3)
                {
                    if (build >= 10240)
                    {
                        return WindowsVersions.Windows10;
                    }
                    else
                    {
                        return WindowsVersions.Windows8_1;
                    }
                }
                else if (minor == 2)
                {
                    if (build >= 9200)
                    {
                        return WindowsVersions.Windows8;
                    }
                }
                else if (minor == 1)
                {
                    return WindowsVersions.Windows7;
                }
                else if (minor == 0)
                {
                    return WindowsVersions.WindowsVista;
                }
            }
            else if (major == 5)
            {
                if (minor == 1)
                {
                    if (build == 2600)
                    {
                        return WindowsVersions.WindowsXpWithSP3;
                    }
                }
            }
            return WindowsVersions.Unknown;
        }


        public static string GetIPAddress()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
    }

    public enum WindowsVersions
    {
        [VersionInfo(0, 0)]
        Unknown,
        [VersionInfo(10, 0)]
        Windows10,
        [VersionInfo(6, 3)]
        Windows8_1,
        [VersionInfo(6, 2, 9200)]
        Windows8,
        [VersionInfo(6, 1)]
        Windows7,
        [VersionInfo(6, 0)]
        WindowsVista,
        [VersionInfo(5, 1, 2600)]
        WindowsXpWithSP3,
    }

    public class VersionInfoAttribute : Attribute
    {
        private Version _version;
        public Version Version
        {
            get
            {
                return _version;
            }
            private set
            {
                _version = value;
            }
        }

        public VersionInfoAttribute(int major, int minor, int build = 0, int revision = 0)
        {
            _version = new Version(major, minor, build, revision);
        }
    }
}
