using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3Dec_GUI;
public class DecryptionHistory
{
    public string EncryptedIsoPath { get; set; }
    public DateTime Timestamp { get; set; }

    public DecryptionHistory(string encryptedIsoPath)
    {
        EncryptedIsoPath = encryptedIsoPath;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{EncryptedIsoPath}|{Timestamp}";
    }

    public static DecryptionHistory FromString(string historyEntry)
    {
        var parts = historyEntry.Split('|');
        return new DecryptionHistory(parts[0])
        {
            Timestamp = DateTime.Parse(parts[1])
        };
    }
}
