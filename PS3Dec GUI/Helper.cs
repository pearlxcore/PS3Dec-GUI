using DiscUtils.Iso9660;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PS3Dec_GUI;
public static class Helper
{
    public static class Tool
    {
        public static List<string> IsoList;
        public static List<string> DkeyList;
        public static string DecryptedIsoDirectory = "";
        public static string ExtractIsoDirectory = "";

        public static bool IsValidHexString(string input)
        {
            Regex hexRegex = new Regex("^[0-9A-Fa-f]{32}$");
            return hexRegex.IsMatch(input);
        }

        public static bool ValidatePS3Iso(FileInfo iso)
        {
            try
            {
                using (FileStream isoStream = File.OpenRead(iso.FullName))
                using (CDReader cd = new CDReader(isoStream, joliet: false))
                {
                    bool isExpectedClusterSize = cd.ClusterSize == 2048;

                    bool existsPS3GAMEDir =
                        cd.Root.GetDirectories("PS3_GAME", SearchOption.TopDirectoryOnly).Any();

                    if (!isExpectedClusterSize || !existsPS3GAMEDir)
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

    }
}
