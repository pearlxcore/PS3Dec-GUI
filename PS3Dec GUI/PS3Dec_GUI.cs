using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PS3Dec_GUI;

public partial class PS3Dec_GUI : Form
{
    public PS3Dec_GUI()
    {
        InitializeComponent();
    }

    private void rbtnSingleIso_CheckedChanged(object sender, EventArgs e)
    {
        if (rbtnSingleIso.Checked)
        {
            gbSingleIso.Enabled = true;
            gbMultipleIsos.Enabled = false;
        }
        else
        {
            gbSingleIso.Enabled = false;
            gbMultipleIsos.Enabled = true;
        }
    }

    private void dkeyFile_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && File.Exists(files[0]))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    private void tbDkeyFile_DragDrop(object sender, DragEventArgs e)
    {
        tbDkeyFile.Clear();
        Helper.Tool.DkeyList = new List<string>();
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        if (files.Length > 0)
        {
            string fileContent = File.ReadAllText(files[0]).Trim();

            if (Helper.Tool.IsValidHexString(fileContent))
            {
                Helper.Tool.DkeyList.Add(files[0]);
                tbDkeyFile.Text = files[0];
            }
            else
            {
                MessageBox.Show("Invalid DKEY file.", "Error");
                tbDkeyFile.Text = "Drag and drop PS3 ISO file here";
            }
        }
    }

    private void tbEncryptedIsoFile_DragDrop(object sender, DragEventArgs e)
    {
        tbEncryptedIsoFile.Clear();
        Helper.Tool.IsoList = new List<string>();
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        if (files.Length > 0)
        {
            //validate ps3 iso
            FileInfo fileInfo = new FileInfo(files[0]);
            bool result = Helper.Tool.ValidatePS3Iso(fileInfo);
            if (result)
            {
                Helper.Tool.IsoList.Add(files[0]);
                tbEncryptedIsoFile.Text = files[0];
            }
            else
            {
                MessageBox.Show("Invalid PS3 ISO file.", "Error");
                tbEncryptedIsoFile.Text = "Drag and drop PS3 ISO file here";
            }
        }
    }

    private void Directory_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (items.Length > 0 && Directory.Exists(items[0]))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    private void tbDkeyDirectory_DragDrop(object sender, DragEventArgs e)
    {
        tbDkeyDirectory.Clear();
        Helper.Tool.DkeyList = new List<string>();
        string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);

        if (items.Length > 0 && Directory.Exists(items[0]))
        {
            // validate dkey
            List<string> itemList = new List<string>(Directory.GetFiles(items[0], "*.dkey", SearchOption.TopDirectoryOnly));
            List<string> dkeyList = new List<string>(ValidateDkey(itemList));

            if (dkeyList.Count > 0)
            {
                Helper.Tool.DkeyList = dkeyList;
                MessageBox.Show($"Found {dkeyList.Count} DKEY files.", "Info");
                tbDkeyDirectory.Text = items[0];
            }
            else
            {
                MessageBox.Show("No DKEY file found.", "Info");
                tbDkeyDirectory.Text = "Drag and drop DKEY directory here";
            }
        }
    }

    private IEnumerable<string> ValidateDkey(List<string> itemList)
    {
        List<string> dkeyList = new List<string>();
        foreach (var item in itemList)
        {
            string fileContent = File.ReadAllText(item).Trim();

            if (Helper.Tool.IsValidHexString(fileContent))
            {
                dkeyList.Add(item);
            }
        }
        return dkeyList;
    }

    private void tbEncryptedPs3IsoDirectory_DragDrop(object sender, DragEventArgs e)
    {
        tbEncryptedPs3IsoDirectory.Clear();
        Helper.Tool.IsoList = new List<string>();
        string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);

        if (items.Length > 0 && Directory.Exists(items[0]))
        {
            // validate ps3 iso

            List<string> itemList = new List<string>(Directory.GetFiles(items[0], "*.iso", SearchOption.TopDirectoryOnly));
            List<string> isoList = new List<string>(ValidatePs3Iso(itemList));


            if (isoList.Count > 0)
            {
                Helper.Tool.IsoList = isoList;
                MessageBox.Show($"Found {isoList.Count} PS3 ISO files.", "Info");
                tbEncryptedPs3IsoDirectory.Text = items[0];
            }
            else
            {
                MessageBox.Show("No PS3 ISO file found.", "Info");
                tbDkeyDirectory.Text = "Drag and drop PS3 ISO directory here";
            }
        }
    }

    private IEnumerable<string> ValidatePs3Iso(List<string> itemList)
    {
        List<string> isoList = new List<string>();
        foreach (var item in itemList)
        {
            FileInfo iso = new FileInfo(item);
            var result = Helper.Tool.ValidatePS3Iso(iso);
            if (result)
                isoList.Add(iso.FullName);
        }

        return isoList;
    }

    private void btnDecryptedPs3IsoDirectory_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbDecryptedPs3IsoDirectory.Text = Helper.Tool.DecryptedIsoDirectory= folderBrowser.SelectedPath;
            }
        }
    }

    private void cbExtractIsoAfterDecryption_CheckedChanged(object sender, EventArgs e)
    {
        gbPs3IsoExtract.Enabled = cbExtractDecryptedIsoAfterDecryption.Checked;
    }

    private void btnExtractLocation_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbExtractLocation.Text = folderBrowser.SelectedPath;
            }
        }
    }

    private async Task ProcessDecryptionAsync(FileInfo fileInfo, string decryptionDirectory, string dkeyString, int index, int totalIso, bool extractDecryptedIsoAfterDecryption, List<DecryptionHistory> historyList)
    {
        textBox1.Text += $"d key {dkeyString} \"{fileInfo.FullName}\" \"{decryptionDirectory}\\{Path.GetFileNameWithoutExtension(fileInfo.FullName)} (decrypted){fileInfo.Extension}\"\n\n";

        string fileName = "PS3Dec.exe";  
        string arguments = $"d key {dkeyString} \"{fileInfo.FullName}\" \"{decryptionDirectory}\\{Path.GetFileNameWithoutExtension(fileInfo.FullName)} (decrypted){fileInfo.Extension}\"";

        Process process = new Process();

        process.StartInfo.FileName = fileName;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.UseShellExecute = true;
        //process.StartInfo.RedirectStandardOutput = true;
        //process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = false;

        try
        {
            process.Start();

            //string output = await process.StandardOutput.ReadToEndAsync();
            //string errorOutput = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            if (process.ExitCode == 0)
            {
                if (!extractDecryptedIsoAfterDecryption)
                {
                    //var percentage = (double)index / totalIso * 100;
                    //textBox1.Text += $"{percentage:F2}% ({index}/{totalIso})\n";
                }
                historyList.Add(new DecryptionHistory(fileInfo.FullName));
            }
            else
            {
                textBox1.Text += $"\nDecryption failed with exit code {process.ExitCode}.";
                //textBox1.Text += "\nError Output:\n\n" + errorOutput;
            }
        }
        catch (Exception ex)
        {
            textBox1.Text += "\nAn error occurred during decryption process: " + ex.Message;
        }
        finally
        {
            process.Dispose();
        }
    }

    private List<DecryptionHistory> LoadHistory(string historyFilePath)
    {
        var historyList = new List<DecryptionHistory>();
        if (File.Exists(historyFilePath))
        {
            var lines = File.ReadAllLines(historyFilePath);
            foreach (var line in lines)
            {
                historyList.Add(DecryptionHistory.FromString(line));
            }
        }
        return historyList;
    }

    private void SaveHistory(List<DecryptionHistory> historyList, string historyFilePath)
    {
        var lines = historyList.Select(h => h.ToString());
        File.WriteAllLines(historyFilePath, lines);
    }


    private bool IsAlreadyDecrypted(string encryptedIsoPath, List<DecryptionHistory> historyList)
    {
        return historyList.Any(h => h.EncryptedIsoPath == encryptedIsoPath);
    }


    private async void btnStart_Click(object sender, EventArgs e)
    {

        if (rbtnSingleIso.Checked && (tbDkeyFile.Text.Contains("Drag and drop") || tbEncryptedIsoFile.Text.Contains("Drag and drop")))
        {
            MessageBox.Show("Specify DKEY/PS3 ISO file", "Warning");
            return;
        }

        if (rbtnMultipleIsos.Checked && (tbDkeyDirectory.Text.Contains("Drag and drop") || tbEncryptedPs3IsoDirectory.Text.Contains("Drag and drop")))
        {
            MessageBox.Show("Specify DKEY/PS3 ISO directory", "Warning");
            return;
        }


        string historyFilePath = "History.txt"; 
        var historyList = LoadHistory(historyFilePath);

        textBox1.Clear();
        List<string> dkeyList = new List<string>();
        List<string> isoList = new List<string>();

        if (rbtnMultipleIsos.Checked)
        {
            List<string> itemList = new List<string>(Directory.GetFiles(tbDkeyDirectory.Text, "*.dkey", SearchOption.TopDirectoryOnly));
            dkeyList = new List<string>(ValidateDkey(itemList));

            List<string> itemList_ = new List<string>(Directory.GetFiles(tbEncryptedPs3IsoDirectory.Text, "*.iso", SearchOption.TopDirectoryOnly));
            isoList = new List<string>(ValidatePs3Iso(itemList_));
        }
        else
        {
            List<string> itemList = new List<string>();
            itemList.Add(tbDkeyFile.Text);
            dkeyList = new List<string>(ValidateDkey(itemList));

            List<string> itemList_ = new List<string>();
            itemList_.Add(tbEncryptedIsoFile.Text);
            isoList = new List<string>(ValidatePs3Iso(itemList_));
        }

        // Validate source, target directories, and decryption keys
        if (!File.Exists("PS3Dec.exe"))
        {
            MessageBox.Show("Place PS3Dec.exe in the same directory as PS3Dec GUI", "Warning");
            return;
        }



        if (tbDecryptedPs3IsoDirectory.Text == "")
        {
            MessageBox.Show("Specify decrypted ISO directory", "Warning");
            return;
        }

        if (cbExtractDecryptedIsoAfterDecryption.Checked && tbExtractLocation.Text == "")
        {
            MessageBox.Show("Specify extract location", "Warning");
            return;
        }

        if (dkeyList.Count == 0)
        {
            MessageBox.Show("DKEY not found from the provided directory", "Warning");
            return;
        }

        if (isoList.Count == 0)
        {
            MessageBox.Show("PS3 ISO not found from the provided directory", "Warning");
            return;
        }

        try
        {
            var decryptionDirectory = tbDecryptedPs3IsoDirectory.Text;
            var extractIsoDirectory = tbExtractLocation.Text;
            bool deleteEncryptedIsoAfterDecrypt = cbDeleteEncryptedPs3IsoAfterDecrypt.Checked;
            bool deleteDecryptedIsoAfterExtract = cbDeleteDecryptedIsoAfterExtract.Checked;
            bool extractDecryptedIsoAfterDecryption = cbExtractDecryptedIsoAfterDecryption.Checked;
            int totalIso = isoList.Count;
            int index = 1;
            progressBar1.Maximum = totalIso;
            progressBar1.Value = 0;

            foreach (var iso in isoList)
            {
                if (IsAlreadyDecrypted(iso, historyList))
                {
                    var result = MessageBox.Show($"The ISO \"{iso}\" has already been decrypted. Do you still want to decrypt it?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        index++;
                        progressBar1.Increment(1); 
                        continue;
                    }
                }

                foreach (var dkey in dkeyList)
                {
                    FileInfo iso_ = new FileInfo(iso);
                    var isoFileName = Path.GetFileNameWithoutExtension(iso_.FullName);
                    var dkeyFileName = Path.GetFileNameWithoutExtension(dkey);

                    if (isoFileName == dkeyFileName)
                    {
                        var dkeyString = File.ReadAllText(dkey).Trim('\r', '\n');

                        toolStripStatusLabel1.Text = $"Decrypting PS3 ISO.. ({index}/{totalIso})";
                        await ProcessDecryptionAsync(iso_, decryptionDirectory, dkeyString, index, totalIso, extractDecryptedIsoAfterDecryption, historyList);

                        if (deleteEncryptedIsoAfterDecrypt)
                            DeleteEncryptedIsoAfterDecryption(iso_);

                        if (extractDecryptedIsoAfterDecryption)
                        {
                            toolStripStatusLabel1.Text = $"Extracting PS3 ISO.. ({index}/{totalIso})";
                            await ExtractDecryptedIsoAfterDecryptionAsync(iso_, decryptionDirectory, extractIsoDirectory, deleteDecryptedIsoAfterExtract, index, totalIso);
                        }


                    }
                }
                index++;
                progressBar1.Increment(1); 
            }

            progressBar1.Value = 0;
            toolStripStatusLabel1.Text = "...";
            MessageBox.Show("Done", "Info");
            SaveHistory(historyList, historyFilePath);
        }
        catch (Exception ex)
        {
            textBox1.Text += $"An error occured : {ex.Message}";
        }
    }

    private void DeleteEncryptedIsoAfterDecryption(FileInfo iso)
    {
        try
        {
            if (File.Exists(iso.FullName))
                File.Delete(iso.FullName);
        }
        catch (Exception ex)
        {
            textBox1.Text += $"Error occured while deleting {iso.FullName} : {ex.Message}";
        }
    }

    private async Task ExtractDecryptedIsoAfterDecryptionAsync(FileInfo iso, string decryptionDirectory, string extractIsoDirectory, bool deleteDecryptedIsoAfterExtract, int index, int totalIso)
    {
        string fullname = $"{decryptionDirectory}\\{Path.GetFileNameWithoutExtension(iso.FullName)} (decrypted){iso.Extension}";

        try
        {
            string fileName = "extractps3iso.exe";  
            string arguments = $"\"{fullname}\" \"{extractIsoDirectory}\"";

            Process process = new Process();

            process.StartInfo.FileName = fileName;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = true;
            //process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = false;

            try
            {
                process.Start();

                //string output = await process.StandardOutput.ReadToEndAsync();
                //string errorOutput = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                if (process.ExitCode == 0)
                {
                    //var percentage = (double)index / totalIso * 100;
                    //textBox1.Text += $"{percentage:F2}% ({index}/{totalIso})\n";
                }
                else
                {
                    textBox1.Text += $"\nExtraction process failed with exit code {process.ExitCode}.";
                    //textBox1.Text += "\nError Output:\n\n" + errorOutput;
                }
            }
            catch (Exception ex)
            {
                textBox1.Text += "\nAn error occurred during extraction process: " + ex.Message;
            }
            finally
            {
                process.Dispose();
            }

            if (deleteDecryptedIsoAfterExtract)
                DeleteDecryptedIso(fullname);
        }
        catch (Exception ex) { textBox1.Text += $"Error occured : {ex.Message}"; }
    }

    private void DeleteDecryptedIso(string fullname)
    {
        try
        {
            if (File.Exists(fullname))
                File.Delete(fullname);
        }
        catch (Exception ex)
        {
            textBox1.Text += $"Error occured while deleting {fullname} : {ex.Message}";
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        string historyFilePath = "History.txt";  

        if (!File.Exists(historyFilePath))
        {
            File.WriteAllText(historyFilePath, string.Empty);
            textBox1.Text += "History file created successfully.";
        }
    }

    private void buyMeCoffeeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string url = "https://ko-fi.com/pearlxcore";
        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    }

    private void supportMeWithPayPalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string url = "https://www.paypal.com/paypalme/pearlxcoree";
        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    }
}