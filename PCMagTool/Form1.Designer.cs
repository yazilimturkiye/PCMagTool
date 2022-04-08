
namespace PCMagTool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ağ", 6, 6);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Anakart", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Batarya", 12, 12);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CPU", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Depolama", 8, 8);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ekran", 16, 16);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Fan", 13, 13);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("GPU", 3, 3);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Klavye", 14, 14);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Optik Sürücü", 15, 15);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("RAM", 4, 4);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Ses", 9, 9);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Bilgisayar", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Bios", 7, 7);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Kullanıcılar", 11, 11);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("İşletim Sistemi", 5, 5);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_ustbaslik = new System.Windows.Forms.Label();
            this.label_altbaslik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar_islem = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_sistem = new System.Windows.Forms.TabPage();
            this.button_DisariAktar = new System.Windows.Forms.Button();
            this.button_genislet = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage_donanim = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox_hata = new System.Windows.Forms.PictureBox();
            this.label_hata = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_sistem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hata)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.White;
            this.pictureBox_logo.Image = global::PCMagTool.Properties.Resources.pcmagtool_fw;
            this.pictureBox_logo.Location = new System.Drawing.Point(646, 19);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_ustbaslik
            // 
            this.label_ustbaslik.AutoSize = true;
            this.label_ustbaslik.BackColor = System.Drawing.Color.White;
            this.label_ustbaslik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ustbaslik.ForeColor = System.Drawing.Color.Crimson;
            this.label_ustbaslik.Location = new System.Drawing.Point(14, 9);
            this.label_ustbaslik.Name = "label_ustbaslik";
            this.label_ustbaslik.Size = new System.Drawing.Size(144, 28);
            this.label_ustbaslik.TabIndex = 3;
            this.label_ustbaslik.Text = "PCMagTool";
            // 
            // label_altbaslik
            // 
            this.label_altbaslik.AutoSize = true;
            this.label_altbaslik.BackColor = System.Drawing.Color.White;
            this.label_altbaslik.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_altbaslik.Location = new System.Drawing.Point(14, 37);
            this.label_altbaslik.Name = "label_altbaslik";
            this.label_altbaslik.Size = new System.Drawing.Size(242, 19);
            this.label_altbaslik.TabIndex = 4;
            this.label_altbaslik.Text = "Bilgisayar Yönetim ve Kontrol Aracı";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 141);
            this.label3.TabIndex = 5;
            // 
            // progressBar_islem
            // 
            this.progressBar_islem.Location = new System.Drawing.Point(-1, 133);
            this.progressBar_islem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_islem.Name = "progressBar_islem";
            this.progressBar_islem.Size = new System.Drawing.Size(736, 8);
            this.progressBar_islem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "v1.0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_sistem);
            this.tabControl1.Controls.Add(this.tabPage_donanim);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(10, 146);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(5, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 587);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage_sistem
            // 
            this.tabPage_sistem.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_sistem.Controls.Add(this.button_DisariAktar);
            this.tabPage_sistem.Controls.Add(this.button_genislet);
            this.tabPage_sistem.Controls.Add(this.treeView1);
            this.tabPage_sistem.Location = new System.Drawing.Point(4, 33);
            this.tabPage_sistem.Name = "tabPage_sistem";
            this.tabPage_sistem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sistem.Size = new System.Drawing.Size(707, 550);
            this.tabPage_sistem.TabIndex = 0;
            this.tabPage_sistem.Text = "Sistem";
            // 
            // button_DisariAktar
            // 
            this.button_DisariAktar.Location = new System.Drawing.Point(639, 62);
            this.button_DisariAktar.Name = "button_DisariAktar";
            this.button_DisariAktar.Size = new System.Drawing.Size(50, 50);
            this.button_DisariAktar.TabIndex = 19;
            this.button_DisariAktar.Text = "dış";
            this.button_DisariAktar.UseVisualStyleBackColor = true;
            this.button_DisariAktar.Click += new System.EventHandler(this.button_DisariAktar_Click);
            // 
            // button_genislet
            // 
            this.button_genislet.Location = new System.Drawing.Point(639, 6);
            this.button_genislet.Name = "button_genislet";
            this.button_genislet.Size = new System.Drawing.Size(50, 50);
            this.button_genislet.TabIndex = 18;
            this.button_genislet.Text = "ex";
            this.button_genislet.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 10;
            this.treeView1.ImageList = this.ımageList1;
            this.treeView1.Indent = 30;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(-2, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 6;
            treeNode1.Name = "altdugum_ag";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Ağ";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "altdugum_anakart";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "Anakart";
            treeNode3.ImageIndex = 12;
            treeNode3.Name = "altdugum_batarya";
            treeNode3.SelectedImageIndex = 12;
            treeNode3.Text = "Batarya";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "altdugum_islemci";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "CPU";
            treeNode5.ImageIndex = 8;
            treeNode5.Name = "altdugum_depolama";
            treeNode5.SelectedImageIndex = 8;
            treeNode5.Text = "Depolama";
            treeNode6.ImageIndex = 16;
            treeNode6.Name = "altdugum_ekran";
            treeNode6.SelectedImageIndex = 16;
            treeNode6.Text = "Ekran";
            treeNode7.ImageIndex = 13;
            treeNode7.Name = "altdugum_fan";
            treeNode7.SelectedImageIndex = 13;
            treeNode7.Text = "Fan";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "altdugum_ekran";
            treeNode8.SelectedImageIndex = 3;
            treeNode8.Text = "GPU";
            treeNode9.ImageIndex = 14;
            treeNode9.Name = "altdugum_klavye";
            treeNode9.SelectedImageIndex = 14;
            treeNode9.Text = "Klavye";
            treeNode10.ImageIndex = 15;
            treeNode10.Name = "altdugum_suruculer";
            treeNode10.SelectedImageIndex = 15;
            treeNode10.Text = "Optik Sürücü";
            treeNode11.ImageIndex = 4;
            treeNode11.Name = "altdugum_ram";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "RAM";
            treeNode12.ImageIndex = 9;
            treeNode12.Name = "altdugum_ses";
            treeNode12.SelectedImageIndex = 9;
            treeNode12.Text = "Ses";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "kokdugum_bilgisayar";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "Bilgisayar";
            treeNode14.ImageIndex = 7;
            treeNode14.Name = "kokdugum_bios";
            treeNode14.SelectedImageIndex = 7;
            treeNode14.Text = "Bios";
            treeNode15.ImageIndex = 11;
            treeNode15.Name = "kokdugum_kullanici";
            treeNode15.SelectedImageIndex = 11;
            treeNode15.Text = "Kullanıcılar";
            treeNode16.ImageIndex = 5;
            treeNode16.Name = "kokdugum_isletimsistemi";
            treeNode16.SelectedImageIndex = 5;
            treeNode16.Text = "İşletim Sistemi";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView1.SelectedImageIndex = 10;
            this.treeView1.Size = new System.Drawing.Size(713, 550);
            this.treeView1.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "anakart.png");
            this.ımageList1.Images.SetKeyName(1, "bilgisayar.png");
            this.ımageList1.Images.SetKeyName(2, "cpu.png");
            this.ımageList1.Images.SetKeyName(3, "gpu.png");
            this.ımageList1.Images.SetKeyName(4, "ram.png");
            this.ımageList1.Images.SetKeyName(5, "windows.png");
            this.ımageList1.Images.SetKeyName(6, "ag.png");
            this.ımageList1.Images.SetKeyName(7, "chip.png");
            this.ımageList1.Images.SetKeyName(8, "hdd.png");
            this.ımageList1.Images.SetKeyName(9, "ses.png");
            this.ımageList1.Images.SetKeyName(10, "pcmagtool.fw.png");
            this.ımageList1.Images.SetKeyName(11, "kullanici.png");
            this.ımageList1.Images.SetKeyName(12, "Batarya.png");
            this.ımageList1.Images.SetKeyName(13, "fan.png");
            this.ımageList1.Images.SetKeyName(14, "klavye.png");
            this.ımageList1.Images.SetKeyName(15, "optik.png");
            this.ımageList1.Images.SetKeyName(16, "ekran.png");
            // 
            // tabPage_donanim
            // 
            this.tabPage_donanim.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_donanim.Location = new System.Drawing.Point(4, 33);
            this.tabPage_donanim.Name = "tabPage_donanim";
            this.tabPage_donanim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_donanim.Size = new System.Drawing.Size(707, 550);
            this.tabPage_donanim.TabIndex = 1;
            this.tabPage_donanim.Text = "Donanım";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 13;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(242, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 14;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(298, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 15;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(354, 68);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 16;
            this.button7.Text = "x";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(410, 68);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 17;
            this.button8.Text = "x";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox_hata
            // 
            this.pictureBox_hata.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_hata.Image = global::PCMagTool.Properties.Resources.hata;
            this.pictureBox_hata.Location = new System.Drawing.Point(12, 736);
            this.pictureBox_hata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_hata.Name = "pictureBox_hata";
            this.pictureBox_hata.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_hata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hata.TabIndex = 18;
            this.pictureBox_hata.TabStop = false;
            this.pictureBox_hata.Visible = false;
            // 
            // label_hata
            // 
            this.label_hata.AutoSize = true;
            this.label_hata.BackColor = System.Drawing.SystemColors.Control;
            this.label_hata.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hata.Location = new System.Drawing.Point(34, 736);
            this.label_hata.Name = "label_hata";
            this.label_hata.Size = new System.Drawing.Size(214, 19);
            this.label_hata.TabIndex = 19;
            this.label_hata.Text = "Bazı sistem bilgileri çekilemedi.";
            this.label_hata.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(599, 738);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yazilimturkiye.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 761);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_hata);
            this.Controls.Add(this.pictureBox_hata);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_islem);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_ustbaslik);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PC Management Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_sistem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_ustbaslik;
        private System.Windows.Forms.Label label_altbaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar_islem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_sistem;
        private System.Windows.Forms.TabPage tabPage_donanim;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_genislet;
        private System.Windows.Forms.PictureBox pictureBox_hata;
        private System.Windows.Forms.Label label_hata;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_DisariAktar;
    }
}

