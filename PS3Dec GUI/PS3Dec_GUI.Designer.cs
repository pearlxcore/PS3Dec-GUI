namespace PS3Dec_GUI;

partial class PS3Dec_GUI
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PS3Dec_GUI));
        tbEncryptedPs3IsoDirectory = new TextBox();
        label1 = new Label();
        tbDkeyDirectory = new TextBox();
        label2 = new Label();
        btnDecryptedPs3IsoDirectory = new Button();
        tbDecryptedPs3IsoDirectory = new TextBox();
        label3 = new Label();
        cbDeleteEncryptedPs3IsoAfterDecrypt = new CheckBox();
        gbPs3IsoExtract = new GroupBox();
        cbDeletePs3UpdateFolder = new CheckBox();
        cbDeleteDecryptedIsoAfterExtract = new CheckBox();
        label4 = new Label();
        tbExtractLocation = new TextBox();
        btnExtractLocation = new Button();
        cbExtractDecryptedIsoAfterDecryption = new CheckBox();
        gbMultipleIsos = new GroupBox();
        gbSingleIso = new GroupBox();
        label6 = new Label();
        label5 = new Label();
        tbEncryptedIsoFile = new TextBox();
        tbDkeyFile = new TextBox();
        rbtnMultipleIsos = new RadioButton();
        rbtnSingleIso = new RadioButton();
        btnStart = new Button();
        textBox1 = new TextBox();
        progressBar1 = new ProgressBar();
        statusStrip1 = new StatusStrip();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        toolStrip1 = new ToolStrip();
        toolStripButton1 = new ToolStripDropDownButton();
        buyMeCoffeeToolStripMenuItem = new ToolStripMenuItem();
        supportMeWithPayPalToolStripMenuItem = new ToolStripMenuItem();
        gbPs3IsoExtract.SuspendLayout();
        gbMultipleIsos.SuspendLayout();
        gbSingleIso.SuspendLayout();
        statusStrip1.SuspendLayout();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // tbEncryptedPs3IsoDirectory
        // 
        tbEncryptedPs3IsoDirectory.AllowDrop = true;
        tbEncryptedPs3IsoDirectory.ForeColor = SystemColors.ScrollBar;
        tbEncryptedPs3IsoDirectory.Location = new Point(187, 60);
        tbEncryptedPs3IsoDirectory.Name = "tbEncryptedPs3IsoDirectory";
        tbEncryptedPs3IsoDirectory.ReadOnly = true;
        tbEncryptedPs3IsoDirectory.Size = new Size(247, 23);
        tbEncryptedPs3IsoDirectory.TabIndex = 1;
        tbEncryptedPs3IsoDirectory.Text = "Drag and drop PS3 ISO directory here";
        tbEncryptedPs3IsoDirectory.DragDrop += tbEncryptedPs3IsoDirectory_DragDrop;
        tbEncryptedPs3IsoDirectory.DragEnter += Directory_DragEnter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 64);
        label1.Name = "label1";
        label1.Size = new Size(159, 15);
        label1.TabIndex = 2;
        label1.Text = "Encrypted PS3 ISO directory :";
        // 
        // tbDkeyDirectory
        // 
        tbDkeyDirectory.AllowDrop = true;
        tbDkeyDirectory.ForeColor = SystemColors.ScrollBar;
        tbDkeyDirectory.Location = new Point(187, 24);
        tbDkeyDirectory.Name = "tbDkeyDirectory";
        tbDkeyDirectory.ReadOnly = true;
        tbDkeyDirectory.Size = new Size(247, 23);
        tbDkeyDirectory.TabIndex = 1;
        tbDkeyDirectory.Text = "Drag and drop DKEY directory here";
        tbDkeyDirectory.DragDrop += tbDkeyDirectory_DragDrop;
        tbDkeyDirectory.DragEnter += Directory_DragEnter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(20, 28);
        label2.Name = "label2";
        label2.Size = new Size(91, 15);
        label2.TabIndex = 2;
        label2.Text = "DKEY directory :";
        // 
        // btnDecryptedPs3IsoDirectory
        // 
        btnDecryptedPs3IsoDirectory.Location = new Point(411, 294);
        btnDecryptedPs3IsoDirectory.Name = "btnDecryptedPs3IsoDirectory";
        btnDecryptedPs3IsoDirectory.Size = new Size(42, 23);
        btnDecryptedPs3IsoDirectory.TabIndex = 0;
        btnDecryptedPs3IsoDirectory.Text = "...";
        btnDecryptedPs3IsoDirectory.UseVisualStyleBackColor = true;
        btnDecryptedPs3IsoDirectory.Click += btnDecryptedPs3IsoDirectory_Click;
        // 
        // tbDecryptedPs3IsoDirectory
        // 
        tbDecryptedPs3IsoDirectory.Location = new Point(206, 294);
        tbDecryptedPs3IsoDirectory.Name = "tbDecryptedPs3IsoDirectory";
        tbDecryptedPs3IsoDirectory.ReadOnly = true;
        tbDecryptedPs3IsoDirectory.Size = new Size(199, 23);
        tbDecryptedPs3IsoDirectory.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(19, 298);
        label3.Name = "label3";
        label3.Size = new Size(160, 15);
        label3.TabIndex = 2;
        label3.Text = "Decrypted PS3 ISO directory :";
        // 
        // cbDeleteEncryptedPs3IsoAfterDecrypt
        // 
        cbDeleteEncryptedPs3IsoAfterDecrypt.AutoSize = true;
        cbDeleteEncryptedPs3IsoAfterDecrypt.Location = new Point(19, 327);
        cbDeleteEncryptedPs3IsoAfterDecrypt.Name = "cbDeleteEncryptedPs3IsoAfterDecrypt";
        cbDeleteEncryptedPs3IsoAfterDecrypt.Size = new Size(245, 19);
        cbDeleteEncryptedPs3IsoAfterDecrypt.TabIndex = 5;
        cbDeleteEncryptedPs3IsoAfterDecrypt.Text = "Delete encrypted PS3 ISO after decryption";
        cbDeleteEncryptedPs3IsoAfterDecrypt.UseVisualStyleBackColor = true;
        // 
        // gbPs3IsoExtract
        // 
        gbPs3IsoExtract.Controls.Add(cbDeletePs3UpdateFolder);
        gbPs3IsoExtract.Controls.Add(cbDeleteDecryptedIsoAfterExtract);
        gbPs3IsoExtract.Controls.Add(label4);
        gbPs3IsoExtract.Controls.Add(tbExtractLocation);
        gbPs3IsoExtract.Controls.Add(btnExtractLocation);
        gbPs3IsoExtract.Enabled = false;
        gbPs3IsoExtract.Location = new Point(19, 393);
        gbPs3IsoExtract.Name = "gbPs3IsoExtract";
        gbPs3IsoExtract.Size = new Size(455, 124);
        gbPs3IsoExtract.TabIndex = 4;
        gbPs3IsoExtract.TabStop = false;
        gbPs3IsoExtract.Text = "PS3 Iso Extract";
        // 
        // cbDeletePs3UpdateFolder
        // 
        cbDeletePs3UpdateFolder.AutoSize = true;
        cbDeletePs3UpdateFolder.Location = new Point(21, 88);
        cbDeletePs3UpdateFolder.Name = "cbDeletePs3UpdateFolder";
        cbDeletePs3UpdateFolder.Size = new Size(228, 19);
        cbDeletePs3UpdateFolder.TabIndex = 7;
        cbDeletePs3UpdateFolder.Text = "Delete PS3_UPDATE folder after extract";
        cbDeletePs3UpdateFolder.UseVisualStyleBackColor = true;
        // 
        // cbDeleteDecryptedIsoAfterExtract
        // 
        cbDeleteDecryptedIsoAfterExtract.AutoSize = true;
        cbDeleteDecryptedIsoAfterExtract.Location = new Point(21, 56);
        cbDeleteDecryptedIsoAfterExtract.Name = "cbDeleteDecryptedIsoAfterExtract";
        cbDeleteDecryptedIsoAfterExtract.Size = new Size(223, 19);
        cbDeleteDecryptedIsoAfterExtract.TabIndex = 6;
        cbDeleteDecryptedIsoAfterExtract.Text = "Delete decrypted PS3 ISO after extract";
        cbDeleteDecryptedIsoAfterExtract.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(21, 28);
        label4.Name = "label4";
        label4.Size = new Size(94, 15);
        label4.TabIndex = 5;
        label4.Text = "Extract location :";
        // 
        // tbExtractLocation
        // 
        tbExtractLocation.Location = new Point(187, 24);
        tbExtractLocation.Name = "tbExtractLocation";
        tbExtractLocation.ReadOnly = true;
        tbExtractLocation.Size = new Size(199, 23);
        tbExtractLocation.TabIndex = 4;
        // 
        // btnExtractLocation
        // 
        btnExtractLocation.Location = new Point(392, 24);
        btnExtractLocation.Name = "btnExtractLocation";
        btnExtractLocation.Size = new Size(42, 23);
        btnExtractLocation.TabIndex = 3;
        btnExtractLocation.Text = "...";
        btnExtractLocation.UseVisualStyleBackColor = true;
        btnExtractLocation.Click += btnExtractLocation_Click;
        // 
        // cbExtractDecryptedIsoAfterDecryption
        // 
        cbExtractDecryptedIsoAfterDecryption.AutoSize = true;
        cbExtractDecryptedIsoAfterDecryption.Location = new Point(19, 360);
        cbExtractDecryptedIsoAfterDecryption.Name = "cbExtractDecryptedIsoAfterDecryption";
        cbExtractDecryptedIsoAfterDecryption.Size = new Size(247, 19);
        cbExtractDecryptedIsoAfterDecryption.TabIndex = 3;
        cbExtractDecryptedIsoAfterDecryption.Text = "Extract decrypted PS3 ISO after decryption";
        cbExtractDecryptedIsoAfterDecryption.UseVisualStyleBackColor = true;
        cbExtractDecryptedIsoAfterDecryption.CheckedChanged += cbExtractIsoAfterDecryption_CheckedChanged;
        // 
        // gbMultipleIsos
        // 
        gbMultipleIsos.Controls.Add(label2);
        gbMultipleIsos.Controls.Add(tbEncryptedPs3IsoDirectory);
        gbMultipleIsos.Controls.Add(tbDkeyDirectory);
        gbMultipleIsos.Controls.Add(label1);
        gbMultipleIsos.Enabled = false;
        gbMultipleIsos.Location = new Point(19, 184);
        gbMultipleIsos.Name = "gbMultipleIsos";
        gbMultipleIsos.Size = new Size(455, 100);
        gbMultipleIsos.TabIndex = 6;
        gbMultipleIsos.TabStop = false;
        gbMultipleIsos.Text = "Multiple ISOs";
        // 
        // gbSingleIso
        // 
        gbSingleIso.Controls.Add(label6);
        gbSingleIso.Controls.Add(label5);
        gbSingleIso.Controls.Add(tbEncryptedIsoFile);
        gbSingleIso.Controls.Add(tbDkeyFile);
        gbSingleIso.Location = new Point(19, 70);
        gbSingleIso.Name = "gbSingleIso";
        gbSingleIso.Size = new Size(455, 100);
        gbSingleIso.TabIndex = 7;
        gbSingleIso.TabStop = false;
        gbSingleIso.Text = "Single ISO";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(20, 28);
        label6.Name = "label6";
        label6.Size = new Size(60, 15);
        label6.TabIndex = 2;
        label6.Text = "DKEY file :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 64);
        label5.Name = "label5";
        label5.Size = new Size(128, 15);
        label5.TabIndex = 2;
        label5.Text = "Encrypted PS3 ISO file :";
        // 
        // tbEncryptedIsoFile
        // 
        tbEncryptedIsoFile.AllowDrop = true;
        tbEncryptedIsoFile.Font = new Font("Segoe UI", 9F);
        tbEncryptedIsoFile.ForeColor = SystemColors.ScrollBar;
        tbEncryptedIsoFile.Location = new Point(187, 60);
        tbEncryptedIsoFile.Name = "tbEncryptedIsoFile";
        tbEncryptedIsoFile.ReadOnly = true;
        tbEncryptedIsoFile.Size = new Size(247, 23);
        tbEncryptedIsoFile.TabIndex = 1;
        tbEncryptedIsoFile.Text = "Drag and drop PS3 ISO file here";
        tbEncryptedIsoFile.DragDrop += tbEncryptedIsoFile_DragDrop;
        tbEncryptedIsoFile.DragEnter += dkeyFile_DragEnter;
        // 
        // tbDkeyFile
        // 
        tbDkeyFile.AllowDrop = true;
        tbDkeyFile.Font = new Font("Segoe UI", 9F);
        tbDkeyFile.ForeColor = SystemColors.ScrollBar;
        tbDkeyFile.Location = new Point(187, 24);
        tbDkeyFile.Name = "tbDkeyFile";
        tbDkeyFile.ReadOnly = true;
        tbDkeyFile.Size = new Size(247, 23);
        tbDkeyFile.TabIndex = 1;
        tbDkeyFile.Text = "Drag and drop DKEY file here";
        tbDkeyFile.DragDrop += tbDkeyFile_DragDrop;
        tbDkeyFile.DragEnter += dkeyFile_DragEnter;
        // 
        // rbtnMultipleIsos
        // 
        rbtnMultipleIsos.AutoSize = true;
        rbtnMultipleIsos.Location = new Point(162, 37);
        rbtnMultipleIsos.Name = "rbtnMultipleIsos";
        rbtnMultipleIsos.Size = new Size(139, 19);
        rbtnMultipleIsos.TabIndex = 10;
        rbtnMultipleIsos.Text = "Decrypt multiple ISOs";
        rbtnMultipleIsos.UseVisualStyleBackColor = true;
        // 
        // rbtnSingleIso
        // 
        rbtnSingleIso.AutoSize = true;
        rbtnSingleIso.Checked = true;
        rbtnSingleIso.Location = new Point(19, 37);
        rbtnSingleIso.Name = "rbtnSingleIso";
        rbtnSingleIso.Size = new Size(121, 19);
        rbtnSingleIso.TabIndex = 11;
        rbtnSingleIso.TabStop = true;
        rbtnSingleIso.Text = "Decrypt single ISO";
        rbtnSingleIso.UseVisualStyleBackColor = true;
        rbtnSingleIso.CheckedChanged += rbtnSingleIso_CheckedChanged;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(19, 523);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(455, 47);
        btnStart.TabIndex = 12;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(52, 81);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(373, 476);
        textBox1.TabIndex = 13;
        textBox1.Visible = false;
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(19, 577);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(455, 16);
        progressBar1.TabIndex = 14;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
        statusStrip1.Location = new Point(0, 608);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(492, 22);
        statusStrip1.TabIndex = 15;
        statusStrip1.Text = "statusStrip1";
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(16, 17);
        toolStripStatusLabel1.Text = "...";
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(492, 25);
        toolStrip1.TabIndex = 16;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripButton1
        // 
        toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { buyMeCoffeeToolStripMenuItem, supportMeWithPayPalToolStripMenuItem });
        toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
        toolStripButton1.ImageTransparentColor = Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new Size(48, 22);
        toolStripButton1.Text = "More";
        // 
        // buyMeCoffeeToolStripMenuItem
        // 
        buyMeCoffeeToolStripMenuItem.Name = "buyMeCoffeeToolStripMenuItem";
        buyMeCoffeeToolStripMenuItem.Size = new Size(200, 22);
        buyMeCoffeeToolStripMenuItem.Text = "Buy me a coffee!";
        buyMeCoffeeToolStripMenuItem.Click += buyMeCoffeeToolStripMenuItem_Click;
        // 
        // supportMeWithPayPalToolStripMenuItem
        // 
        supportMeWithPayPalToolStripMenuItem.Name = "supportMeWithPayPalToolStripMenuItem";
        supportMeWithPayPalToolStripMenuItem.Size = new Size(200, 22);
        supportMeWithPayPalToolStripMenuItem.Text = "Support me with PayPal";
        supportMeWithPayPalToolStripMenuItem.Click += supportMeWithPayPalToolStripMenuItem_Click;
        // 
        // PS3Dec_GUI
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(492, 630);
        Controls.Add(toolStrip1);
        Controls.Add(statusStrip1);
        Controls.Add(progressBar1);
        Controls.Add(btnStart);
        Controls.Add(rbtnSingleIso);
        Controls.Add(rbtnMultipleIsos);
        Controls.Add(gbSingleIso);
        Controls.Add(gbMultipleIsos);
        Controls.Add(cbDeleteEncryptedPs3IsoAfterDecrypt);
        Controls.Add(gbPs3IsoExtract);
        Controls.Add(cbExtractDecryptedIsoAfterDecryption);
        Controls.Add(btnDecryptedPs3IsoDirectory);
        Controls.Add(label3);
        Controls.Add(tbDecryptedPs3IsoDirectory);
        Controls.Add(textBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "PS3Dec_GUI";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PS3Dec GUI by pearlxcore";
        Load += Form1_Load;
        gbPs3IsoExtract.ResumeLayout(false);
        gbPs3IsoExtract.PerformLayout();
        gbMultipleIsos.ResumeLayout(false);
        gbMultipleIsos.PerformLayout();
        gbSingleIso.ResumeLayout(false);
        gbSingleIso.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox tbEncryptedPs3IsoDirectory;
    private Label label1;
    private TextBox tbDkeyDirectory;
    private Label label2;
    private Button btnDecryptedPs3IsoDirectory;
    private TextBox tbDecryptedPs3IsoDirectory;
    private Label label3;
    private CheckBox cbExtractDecryptedIsoAfterDecryption;
    private GroupBox gbPs3IsoExtract;
    private Label label4;
    private TextBox tbExtractLocation;
    private Button btnExtractLocation;
    private CheckBox cbDeleteDecryptedIsoAfterExtract;
    private CheckBox cbDeleteEncryptedPs3IsoAfterDecrypt;
    private GroupBox gbMultipleIsos;
    private GroupBox gbSingleIso;
    private Label label6;
    private Label label5;
    private TextBox tbEncryptedIsoFile;
    private TextBox tbDkeyFile;
    private RadioButton rbtnMultipleIsos;
    private RadioButton rbtnSingleIso;
    private Button btnStart;
    private TextBox textBox1;
    private ProgressBar progressBar1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStrip toolStrip1;
    private ToolStripDropDownButton toolStripButton1;
    private ToolStripMenuItem buyMeCoffeeToolStripMenuItem;
    private ToolStripMenuItem supportMeWithPayPalToolStripMenuItem;
    private CheckBox cbDeletePs3UpdateFolder;
}
