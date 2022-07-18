
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Ağ", 6, 6);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Anakart", 0, 0);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Batarya", 12, 12);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("CPU", 2, 2);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Depolama", 8, 8);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Ekran", 16, 16);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Fan", 13, 13);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("GPU", 3, 3);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Klavye", 14, 14);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Optik Sürücü", 15, 15);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("RAM", 4, 4);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Ses", 9, 9);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Bilgisayar", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Bios", 7, 7);
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Kullanıcılar", 11, 11);
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("İşletim Sistemi", 5, 5);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_ustbaslik = new System.Windows.Forms.Label();
            this.label_altbaslik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar_islem = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_donanim = new System.Windows.Forms.TabPage();
            this.button_daralt = new System.Windows.Forms.Button();
            this.button_DisariAktar = new System.Windows.Forms.Button();
            this.button_genislet = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage_izleme = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_kopyatemizle = new System.Windows.Forms.Button();
            this.button_kopyacikar = new System.Windows.Forms.Button();
            this.button_kopyaekle = new System.Windows.Forms.Button();
            this.listView_kopya = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_internet = new System.Windows.Forms.Label();
            this.label_isletimsistemi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_bit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_mac = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_ipadresi = new System.Windows.Forms.Label();
            this.label_hostname = new System.Windows.Forms.Label();
            this.label_acikliksure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_disk = new System.Windows.Forms.PictureBox();
            this.pictureBox_ram = new System.Windows.Forms.PictureBox();
            this.pictureBox_cpu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_diskyuzde = new System.Windows.Forms.Label();
            this.progressBar_cpu = new System.Windows.Forms.ProgressBar();
            this.progressBar_disk = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar_ram = new System.Windows.Forms.ProgressBar();
            this.label_ramyuzde = new System.Windows.Forms.Label();
            this.label_cpuyuzde = new System.Windows.Forms.Label();
            this.tabPage_islemler = new System.Windows.Forms.TabPage();
            this.button_islemleryenile = new System.Windows.Forms.Button();
            this.button_islemsonlandir = new System.Windows.Forms.Button();
            this.listView_islemler = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.tabPage_hizmetler = new System.Windows.Forms.TabPage();
            this.button_hizmetbaslat = new System.Windows.Forms.Button();
            this.button_hizmetyenile = new System.Windows.Forms.Button();
            this.button_hizmetsonlandir = new System.Windows.Forms.Button();
            this.listView_hizmetler = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.button_ayarlar = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button_denetimmasasi = new System.Windows.Forms.Button();
            this.button_gezgin = new System.Windows.Forms.Button();
            this.button_hesapmakinasi = new System.Windows.Forms.Button();
            this.button_cmd = new System.Windows.Forms.Button();
            this.button_ekranyakala = new System.Windows.Forms.Button();
            this.button_disktemizleme = new System.Windows.Forms.Button();
            this.pictureBox_hata = new System.Windows.Forms.PictureBox();
            this.label_hata = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_paint = new System.Windows.Forms.Button();
            this.button_gorevyoneticisi = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_donanim.SuspendLayout();
            this.tabPage_izleme.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_disk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cpu)).BeginInit();
            this.tabPage_islemler.SuspendLayout();
            this.tabPage_hizmetler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hata)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage_donanim);
            this.tabControl1.Controls.Add(this.tabPage_izleme);
            this.tabControl1.Controls.Add(this.tabPage_islemler);
            this.tabControl1.Controls.Add(this.tabPage_hizmetler);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(10, 146);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(5, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 587);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage_donanim
            // 
            this.tabPage_donanim.BackColor = System.Drawing.Color.White;
            this.tabPage_donanim.Controls.Add(this.button_daralt);
            this.tabPage_donanim.Controls.Add(this.button_DisariAktar);
            this.tabPage_donanim.Controls.Add(this.button_genislet);
            this.tabPage_donanim.Controls.Add(this.treeView1);
            this.tabPage_donanim.Location = new System.Drawing.Point(4, 34);
            this.tabPage_donanim.Name = "tabPage_donanim";
            this.tabPage_donanim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_donanim.Size = new System.Drawing.Size(707, 549);
            this.tabPage_donanim.TabIndex = 0;
            this.tabPage_donanim.Text = "Donanım";
            // 
            // button_daralt
            // 
            this.button_daralt.BackgroundImage = global::PCMagTool.Properties.Resources.daralt;
            this.button_daralt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_daralt.Location = new System.Drawing.Point(651, 47);
            this.button_daralt.Name = "button_daralt";
            this.button_daralt.Size = new System.Drawing.Size(35, 35);
            this.button_daralt.TabIndex = 20;
            this.button_daralt.UseVisualStyleBackColor = true;
            this.button_daralt.Click += new System.EventHandler(this.button_daralt_Click);
            // 
            // button_DisariAktar
            // 
            this.button_DisariAktar.BackgroundImage = global::PCMagTool.Properties.Resources.indir;
            this.button_DisariAktar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_DisariAktar.Location = new System.Drawing.Point(651, 88);
            this.button_DisariAktar.Name = "button_DisariAktar";
            this.button_DisariAktar.Size = new System.Drawing.Size(35, 35);
            this.button_DisariAktar.TabIndex = 19;
            this.button_DisariAktar.UseVisualStyleBackColor = true;
            this.button_DisariAktar.Click += new System.EventHandler(this.button_DisariAktar_Click);
            // 
            // button_genislet
            // 
            this.button_genislet.BackgroundImage = global::PCMagTool.Properties.Resources.genislet;
            this.button_genislet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_genislet.Location = new System.Drawing.Point(651, 6);
            this.button_genislet.Name = "button_genislet";
            this.button_genislet.Size = new System.Drawing.Size(35, 35);
            this.button_genislet.TabIndex = 18;
            this.button_genislet.UseVisualStyleBackColor = true;
            this.button_genislet.Click += new System.EventHandler(this.button_genislet_Click);
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
            treeNode17.ImageIndex = 6;
            treeNode17.Name = "altdugum_ag";
            treeNode17.SelectedImageIndex = 6;
            treeNode17.Text = "Ağ";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "altdugum_anakart";
            treeNode18.SelectedImageIndex = 0;
            treeNode18.Text = "Anakart";
            treeNode19.ImageIndex = 12;
            treeNode19.Name = "altdugum_batarya";
            treeNode19.SelectedImageIndex = 12;
            treeNode19.Text = "Batarya";
            treeNode20.ImageIndex = 2;
            treeNode20.Name = "altdugum_islemci";
            treeNode20.SelectedImageIndex = 2;
            treeNode20.Text = "CPU";
            treeNode21.ImageIndex = 8;
            treeNode21.Name = "altdugum_depolama";
            treeNode21.SelectedImageIndex = 8;
            treeNode21.Text = "Depolama";
            treeNode22.ImageIndex = 16;
            treeNode22.Name = "altdugum_ekran";
            treeNode22.SelectedImageIndex = 16;
            treeNode22.Text = "Ekran";
            treeNode23.ImageIndex = 13;
            treeNode23.Name = "altdugum_fan";
            treeNode23.SelectedImageIndex = 13;
            treeNode23.Text = "Fan";
            treeNode24.ImageIndex = 3;
            treeNode24.Name = "altdugum_ekran";
            treeNode24.SelectedImageIndex = 3;
            treeNode24.Text = "GPU";
            treeNode25.ImageIndex = 14;
            treeNode25.Name = "altdugum_klavye";
            treeNode25.SelectedImageIndex = 14;
            treeNode25.Text = "Klavye";
            treeNode26.ImageIndex = 15;
            treeNode26.Name = "altdugum_suruculer";
            treeNode26.SelectedImageIndex = 15;
            treeNode26.Text = "Optik Sürücü";
            treeNode27.ImageIndex = 4;
            treeNode27.Name = "altdugum_ram";
            treeNode27.SelectedImageIndex = 4;
            treeNode27.Text = "RAM";
            treeNode28.ImageIndex = 9;
            treeNode28.Name = "altdugum_ses";
            treeNode28.SelectedImageIndex = 9;
            treeNode28.Text = "Ses";
            treeNode29.ImageIndex = 1;
            treeNode29.Name = "kokdugum_bilgisayar";
            treeNode29.SelectedImageIndex = 1;
            treeNode29.Text = "Bilgisayar";
            treeNode30.ImageIndex = 7;
            treeNode30.Name = "kokdugum_bios";
            treeNode30.SelectedImageIndex = 7;
            treeNode30.Text = "Bios";
            treeNode31.ImageIndex = 11;
            treeNode31.Name = "kokdugum_kullanici";
            treeNode31.SelectedImageIndex = 11;
            treeNode31.Text = "Kullanıcılar";
            treeNode32.ImageIndex = 5;
            treeNode32.Name = "kokdugum_isletimsistemi";
            treeNode32.SelectedImageIndex = 5;
            treeNode32.Text = "İşletim Sistemi";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            this.treeView1.SelectedImageIndex = 10;
            this.treeView1.Size = new System.Drawing.Size(713, 550);
            this.treeView1.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
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
            this.ımageList1.Images.SetKeyName(17, "kapat.png");
            this.ımageList1.Images.SetKeyName(18, "onay.png");
            // 
            // tabPage_izleme
            // 
            this.tabPage_izleme.BackColor = System.Drawing.Color.White;
            this.tabPage_izleme.Controls.Add(this.groupBox3);
            this.tabPage_izleme.Controls.Add(this.groupBox2);
            this.tabPage_izleme.Controls.Add(this.groupBox1);
            this.tabPage_izleme.Location = new System.Drawing.Point(4, 34);
            this.tabPage_izleme.Name = "tabPage_izleme";
            this.tabPage_izleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_izleme.Size = new System.Drawing.Size(707, 549);
            this.tabPage_izleme.TabIndex = 1;
            this.tabPage_izleme.Text = "İzleme";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_kopyatemizle);
            this.groupBox3.Controls.Add(this.button_kopyacikar);
            this.groupBox3.Controls.Add(this.button_kopyaekle);
            this.groupBox3.Controls.Add(this.listView_kopya);
            this.groupBox3.Location = new System.Drawing.Point(6, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 222);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // button_kopyatemizle
            // 
            this.button_kopyatemizle.BackgroundImage = global::PCMagTool.Properties.Resources.kapat;
            this.button_kopyatemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_kopyatemizle.Location = new System.Drawing.Point(624, 170);
            this.button_kopyatemizle.Name = "button_kopyatemizle";
            this.button_kopyatemizle.Size = new System.Drawing.Size(35, 35);
            this.button_kopyatemizle.TabIndex = 23;
            this.button_kopyatemizle.UseVisualStyleBackColor = true;
            this.button_kopyatemizle.Click += new System.EventHandler(this.button_kopyatemizle_Click);
            // 
            // button_kopyacikar
            // 
            this.button_kopyacikar.BackgroundImage = global::PCMagTool.Properties.Resources.cikar;
            this.button_kopyacikar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_kopyacikar.Location = new System.Drawing.Point(624, 66);
            this.button_kopyacikar.Name = "button_kopyacikar";
            this.button_kopyacikar.Size = new System.Drawing.Size(35, 35);
            this.button_kopyacikar.TabIndex = 22;
            this.button_kopyacikar.UseVisualStyleBackColor = true;
            this.button_kopyacikar.Click += new System.EventHandler(this.button_kopyacikar_Click);
            // 
            // button_kopyaekle
            // 
            this.button_kopyaekle.BackgroundImage = global::PCMagTool.Properties.Resources.ekle;
            this.button_kopyaekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_kopyaekle.Location = new System.Drawing.Point(624, 25);
            this.button_kopyaekle.Name = "button_kopyaekle";
            this.button_kopyaekle.Size = new System.Drawing.Size(35, 35);
            this.button_kopyaekle.TabIndex = 21;
            this.button_kopyaekle.UseVisualStyleBackColor = true;
            this.button_kopyaekle.Click += new System.EventHandler(this.button_kopyaekle_Click);
            // 
            // listView_kopya
            // 
            this.listView_kopya.CheckBoxes = true;
            this.listView_kopya.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_kopya.FullRowSelect = true;
            this.listView_kopya.GridLines = true;
            this.listView_kopya.HideSelection = false;
            this.listView_kopya.Location = new System.Drawing.Point(14, 25);
            this.listView_kopya.MultiSelect = false;
            this.listView_kopya.Name = "listView_kopya";
            this.listView_kopya.Size = new System.Drawing.Size(604, 180);
            this.listView_kopya.TabIndex = 12;
            this.listView_kopya.UseCompatibleStateImageBehavior = false;
            this.listView_kopya.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İçerik";
            this.columnHeader1.Width = 480;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saat";
            this.columnHeader2.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label_internet);
            this.groupBox2.Controls.Add(this.label_isletimsistemi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label_bit);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_mac);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label_ipadresi);
            this.groupBox2.Controls.Add(this.label_hostname);
            this.groupBox2.Controls.Add(this.label_acikliksure);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 151);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(357, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ağ Bağlantısı";
            // 
            // label_internet
            // 
            this.label_internet.AutoSize = true;
            this.label_internet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_internet.Location = new System.Drawing.Point(477, 81);
            this.label_internet.Name = "label_internet";
            this.label_internet.Size = new System.Drawing.Size(14, 20);
            this.label_internet.TabIndex = 24;
            this.label_internet.Text = "-";
            // 
            // label_isletimsistemi
            // 
            this.label_isletimsistemi.Location = new System.Drawing.Point(152, 105);
            this.label_isletimsistemi.Name = "label_isletimsistemi";
            this.label_isletimsistemi.Size = new System.Drawing.Size(501, 20);
            this.label_isletimsistemi.TabIndex = 24;
            this.label_isletimsistemi.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(14, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sistem Versiyonu";
            // 
            // label_bit
            // 
            this.label_bit.AutoSize = true;
            this.label_bit.Location = new System.Drawing.Point(477, 56);
            this.label_bit.Name = "label_bit";
            this.label_bit.Size = new System.Drawing.Size(14, 20);
            this.label_bit.TabIndex = 22;
            this.label_bit.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(357, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Sistem Türü";
            // 
            // label_mac
            // 
            this.label_mac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_mac.Location = new System.Drawing.Point(477, 31);
            this.label_mac.Name = "label_mac";
            this.label_mac.Size = new System.Drawing.Size(199, 20);
            this.label_mac.TabIndex = 20;
            this.label_mac.Text = "-";
            this.toolTip1.SetToolTip(this.label_mac, "MAC adresi kopyalamak için tıklayınız.");
            this.label_mac.Click += new System.EventHandler(this.label_mac_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(357, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "MAC Adresi";
            // 
            // label_ipadresi
            // 
            this.label_ipadresi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ipadresi.Location = new System.Drawing.Point(152, 81);
            this.label_ipadresi.Name = "label_ipadresi";
            this.label_ipadresi.Size = new System.Drawing.Size(162, 20);
            this.label_ipadresi.TabIndex = 18;
            this.label_ipadresi.Text = "-";
            this.toolTip1.SetToolTip(this.label_ipadresi, "IP adresini kopyalamak için tıklayınız.");
            this.label_ipadresi.Click += new System.EventHandler(this.label_ipadresi_Click);
            // 
            // label_hostname
            // 
            this.label_hostname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_hostname.Location = new System.Drawing.Point(152, 56);
            this.label_hostname.Name = "label_hostname";
            this.label_hostname.Size = new System.Drawing.Size(162, 20);
            this.label_hostname.TabIndex = 17;
            this.label_hostname.Text = "-";
            this.toolTip1.SetToolTip(this.label_hostname, "Hostname\'i kopyalamak için tıklayınız.");
            this.label_hostname.Click += new System.EventHandler(this.label_hostname_Click);
            // 
            // label_acikliksure
            // 
            this.label_acikliksure.AutoSize = true;
            this.label_acikliksure.Location = new System.Drawing.Point(152, 31);
            this.label_acikliksure.Name = "label_acikliksure";
            this.label_acikliksure.Size = new System.Drawing.Size(14, 20);
            this.label_acikliksure.TabIndex = 16;
            this.label_acikliksure.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Çalışma Süresi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "IP Adresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hostname ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_disk);
            this.groupBox1.Controls.Add(this.pictureBox_ram);
            this.groupBox1.Controls.Add(this.pictureBox_cpu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_diskyuzde);
            this.groupBox1.Controls.Add(this.progressBar_cpu);
            this.groupBox1.Controls.Add(this.progressBar_disk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.progressBar_ram);
            this.groupBox1.Controls.Add(this.label_ramyuzde);
            this.groupBox1.Controls.Add(this.label_cpuyuzde);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_disk
            // 
            this.pictureBox_disk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_disk.Image = global::PCMagTool.Properties.Resources.hdd;
            this.pictureBox_disk.Location = new System.Drawing.Point(15, 104);
            this.pictureBox_disk.Name = "pictureBox_disk";
            this.pictureBox_disk.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_disk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_disk.TabIndex = 12;
            this.pictureBox_disk.TabStop = false;
            // 
            // pictureBox_ram
            // 
            this.pictureBox_ram.Image = global::PCMagTool.Properties.Resources.ram;
            this.pictureBox_ram.Location = new System.Drawing.Point(15, 70);
            this.pictureBox_ram.Name = "pictureBox_ram";
            this.pictureBox_ram.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_ram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ram.TabIndex = 11;
            this.pictureBox_ram.TabStop = false;
            // 
            // pictureBox_cpu
            // 
            this.pictureBox_cpu.Image = global::PCMagTool.Properties.Resources.cpu;
            this.pictureBox_cpu.Location = new System.Drawing.Point(15, 32);
            this.pictureBox_cpu.Name = "pictureBox_cpu";
            this.pictureBox_cpu.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_cpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cpu.TabIndex = 10;
            this.pictureBox_cpu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cpu";
            // 
            // label_diskyuzde
            // 
            this.label_diskyuzde.AutoSize = true;
            this.label_diskyuzde.Location = new System.Drawing.Point(624, 113);
            this.label_diskyuzde.Name = "label_diskyuzde";
            this.label_diskyuzde.Size = new System.Drawing.Size(29, 20);
            this.label_diskyuzde.TabIndex = 8;
            this.label_diskyuzde.Text = "0%";
            // 
            // progressBar_cpu
            // 
            this.progressBar_cpu.Location = new System.Drawing.Point(93, 31);
            this.progressBar_cpu.Name = "progressBar_cpu";
            this.progressBar_cpu.Size = new System.Drawing.Size(525, 25);
            this.progressBar_cpu.TabIndex = 1;
            // 
            // progressBar_disk
            // 
            this.progressBar_disk.Location = new System.Drawing.Point(93, 108);
            this.progressBar_disk.Name = "progressBar_disk";
            this.progressBar_disk.Size = new System.Drawing.Size(525, 25);
            this.progressBar_disk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ram";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Disk";
            // 
            // progressBar_ram
            // 
            this.progressBar_ram.Location = new System.Drawing.Point(93, 69);
            this.progressBar_ram.Name = "progressBar_ram";
            this.progressBar_ram.Size = new System.Drawing.Size(525, 25);
            this.progressBar_ram.TabIndex = 3;
            // 
            // label_ramyuzde
            // 
            this.label_ramyuzde.AutoSize = true;
            this.label_ramyuzde.Location = new System.Drawing.Point(624, 74);
            this.label_ramyuzde.Name = "label_ramyuzde";
            this.label_ramyuzde.Size = new System.Drawing.Size(29, 20);
            this.label_ramyuzde.TabIndex = 5;
            this.label_ramyuzde.Text = "0%";
            // 
            // label_cpuyuzde
            // 
            this.label_cpuyuzde.AutoSize = true;
            this.label_cpuyuzde.Location = new System.Drawing.Point(624, 36);
            this.label_cpuyuzde.Name = "label_cpuyuzde";
            this.label_cpuyuzde.Size = new System.Drawing.Size(29, 20);
            this.label_cpuyuzde.TabIndex = 4;
            this.label_cpuyuzde.Text = "0%";
            // 
            // tabPage_islemler
            // 
            this.tabPage_islemler.BackColor = System.Drawing.Color.White;
            this.tabPage_islemler.Controls.Add(this.button_islemleryenile);
            this.tabPage_islemler.Controls.Add(this.button_islemsonlandir);
            this.tabPage_islemler.Controls.Add(this.listView_islemler);
            this.tabPage_islemler.Location = new System.Drawing.Point(4, 34);
            this.tabPage_islemler.Name = "tabPage_islemler";
            this.tabPage_islemler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_islemler.Size = new System.Drawing.Size(707, 549);
            this.tabPage_islemler.TabIndex = 2;
            this.tabPage_islemler.Text = "İşlemler";
            // 
            // button_islemleryenile
            // 
            this.button_islemleryenile.BackgroundImage = global::PCMagTool.Properties.Resources.yenile;
            this.button_islemleryenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_islemleryenile.Location = new System.Drawing.Point(431, 509);
            this.button_islemleryenile.Name = "button_islemleryenile";
            this.button_islemleryenile.Size = new System.Drawing.Size(35, 35);
            this.button_islemleryenile.TabIndex = 23;
            this.button_islemleryenile.UseVisualStyleBackColor = true;
            this.button_islemleryenile.Click += new System.EventHandler(this.button_islemleryenile_Click);
            // 
            // button_islemsonlandir
            // 
            this.button_islemsonlandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_islemsonlandir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_islemsonlandir.ImageIndex = 17;
            this.button_islemsonlandir.ImageList = this.ımageList1;
            this.button_islemsonlandir.Location = new System.Drawing.Point(472, 509);
            this.button_islemsonlandir.Name = "button_islemsonlandir";
            this.button_islemsonlandir.Size = new System.Drawing.Size(229, 35);
            this.button_islemsonlandir.TabIndex = 22;
            this.button_islemsonlandir.Text = "Seçili Görevi Sonlandır";
            this.button_islemsonlandir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_islemsonlandir.UseVisualStyleBackColor = true;
            this.button_islemsonlandir.Click += new System.EventHandler(this.button_islemsonlandir_Click);
            // 
            // listView_islemler
            // 
            this.listView_islemler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_islemler.FullRowSelect = true;
            this.listView_islemler.GridLines = true;
            this.listView_islemler.HideSelection = false;
            this.listView_islemler.Location = new System.Drawing.Point(0, 0);
            this.listView_islemler.Name = "listView_islemler";
            this.listView_islemler.Size = new System.Drawing.Size(707, 503);
            this.listView_islemler.TabIndex = 0;
            this.listView_islemler.UseCompatibleStateImageBehavior = false;
            this.listView_islemler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Adı";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.Width = 301;
            // 
            // tabPage_hizmetler
            // 
            this.tabPage_hizmetler.BackColor = System.Drawing.Color.White;
            this.tabPage_hizmetler.Controls.Add(this.button_hizmetbaslat);
            this.tabPage_hizmetler.Controls.Add(this.button_hizmetyenile);
            this.tabPage_hizmetler.Controls.Add(this.button_hizmetsonlandir);
            this.tabPage_hizmetler.Controls.Add(this.listView_hizmetler);
            this.tabPage_hizmetler.Location = new System.Drawing.Point(4, 34);
            this.tabPage_hizmetler.Name = "tabPage_hizmetler";
            this.tabPage_hizmetler.Size = new System.Drawing.Size(707, 549);
            this.tabPage_hizmetler.TabIndex = 3;
            this.tabPage_hizmetler.Text = "Hizmetler";
            // 
            // button_hizmetbaslat
            // 
            this.button_hizmetbaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hizmetbaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_hizmetbaslat.ImageIndex = 18;
            this.button_hizmetbaslat.ImageList = this.ımageList1;
            this.button_hizmetbaslat.Location = new System.Drawing.Point(196, 509);
            this.button_hizmetbaslat.Name = "button_hizmetbaslat";
            this.button_hizmetbaslat.Size = new System.Drawing.Size(229, 35);
            this.button_hizmetbaslat.TabIndex = 26;
            this.button_hizmetbaslat.Text = "Seçili Hizmeti Başlat";
            this.button_hizmetbaslat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hizmetbaslat.UseVisualStyleBackColor = true;
            this.button_hizmetbaslat.Click += new System.EventHandler(this.button_hizmetbaslat_Click);
            // 
            // button_hizmetyenile
            // 
            this.button_hizmetyenile.BackgroundImage = global::PCMagTool.Properties.Resources.yenile;
            this.button_hizmetyenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hizmetyenile.Location = new System.Drawing.Point(431, 509);
            this.button_hizmetyenile.Name = "button_hizmetyenile";
            this.button_hizmetyenile.Size = new System.Drawing.Size(35, 35);
            this.button_hizmetyenile.TabIndex = 25;
            this.button_hizmetyenile.UseVisualStyleBackColor = true;
            this.button_hizmetyenile.Click += new System.EventHandler(this.button_hizmetyenile_Click);
            // 
            // button_hizmetsonlandir
            // 
            this.button_hizmetsonlandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hizmetsonlandir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_hizmetsonlandir.ImageIndex = 17;
            this.button_hizmetsonlandir.ImageList = this.ımageList1;
            this.button_hizmetsonlandir.Location = new System.Drawing.Point(472, 509);
            this.button_hizmetsonlandir.Name = "button_hizmetsonlandir";
            this.button_hizmetsonlandir.Size = new System.Drawing.Size(229, 35);
            this.button_hizmetsonlandir.TabIndex = 24;
            this.button_hizmetsonlandir.Text = "Seçili Hizmeti Durdur";
            this.button_hizmetsonlandir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hizmetsonlandir.UseVisualStyleBackColor = true;
            this.button_hizmetsonlandir.Click += new System.EventHandler(this.button_hizmetsonlandir_Click);
            // 
            // listView_hizmetler
            // 
            this.listView_hizmetler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_hizmetler.FullRowSelect = true;
            this.listView_hizmetler.GridLines = true;
            this.listView_hizmetler.HideSelection = false;
            this.listView_hizmetler.Location = new System.Drawing.Point(0, 0);
            this.listView_hizmetler.Name = "listView_hizmetler";
            this.listView_hizmetler.Size = new System.Drawing.Size(707, 503);
            this.listView_hizmetler.TabIndex = 1;
            this.listView_hizmetler.UseCompatibleStateImageBehavior = false;
            this.listView_hizmetler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hizmet Adı";
            this.columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Durum";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Açıklama";
            this.columnHeader8.Width = 301;
            // 
            // button_ayarlar
            // 
            this.button_ayarlar.ImageIndex = 5;
            this.button_ayarlar.ImageList = this.ımageList2;
            this.button_ayarlar.Location = new System.Drawing.Point(18, 68);
            this.button_ayarlar.Name = "button_ayarlar";
            this.button_ayarlar.Size = new System.Drawing.Size(50, 50);
            this.button_ayarlar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button_ayarlar, "Ayarlar");
            this.button_ayarlar.UseVisualStyleBackColor = true;
            this.button_ayarlar.Click += new System.EventHandler(this.button_ayarlar_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "hdd.png");
            this.ımageList2.Images.SetKeyName(1, "hesap.png");
            this.ımageList2.Images.SetKeyName(2, "cmd.png");
            this.ımageList2.Images.SetKeyName(3, "ekranyakala.png");
            this.ımageList2.Images.SetKeyName(4, "klasor.png");
            this.ımageList2.Images.SetKeyName(5, "ayarlar.png");
            this.ımageList2.Images.SetKeyName(6, "kontrolpaneli.png");
            this.ımageList2.Images.SetKeyName(7, "gorev.png");
            this.ımageList2.Images.SetKeyName(8, "paint.png");
            // 
            // button_denetimmasasi
            // 
            this.button_denetimmasasi.ImageIndex = 6;
            this.button_denetimmasasi.ImageList = this.ımageList2;
            this.button_denetimmasasi.Location = new System.Drawing.Point(74, 68);
            this.button_denetimmasasi.Name = "button_denetimmasasi";
            this.button_denetimmasasi.Size = new System.Drawing.Size(50, 50);
            this.button_denetimmasasi.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button_denetimmasasi, "Denetim Masası");
            this.button_denetimmasasi.UseVisualStyleBackColor = true;
            this.button_denetimmasasi.Click += new System.EventHandler(this.button_denetimmasasi_Click);
            // 
            // button_gezgin
            // 
            this.button_gezgin.ImageIndex = 4;
            this.button_gezgin.ImageList = this.ımageList2;
            this.button_gezgin.Location = new System.Drawing.Point(130, 68);
            this.button_gezgin.Name = "button_gezgin";
            this.button_gezgin.Size = new System.Drawing.Size(50, 50);
            this.button_gezgin.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button_gezgin, "Dosya Yöneticisi");
            this.button_gezgin.UseVisualStyleBackColor = true;
            this.button_gezgin.Click += new System.EventHandler(this.button_gezgin_Click);
            // 
            // button_hesapmakinasi
            // 
            this.button_hesapmakinasi.ImageIndex = 1;
            this.button_hesapmakinasi.ImageList = this.ımageList2;
            this.button_hesapmakinasi.Location = new System.Drawing.Point(186, 68);
            this.button_hesapmakinasi.Name = "button_hesapmakinasi";
            this.button_hesapmakinasi.Size = new System.Drawing.Size(50, 50);
            this.button_hesapmakinasi.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button_hesapmakinasi, "Hesap Makinesi");
            this.button_hesapmakinasi.UseVisualStyleBackColor = true;
            this.button_hesapmakinasi.Click += new System.EventHandler(this.button_hesapmakinasi_Click);
            // 
            // button_cmd
            // 
            this.button_cmd.ImageIndex = 2;
            this.button_cmd.ImageList = this.ımageList2;
            this.button_cmd.Location = new System.Drawing.Point(242, 68);
            this.button_cmd.Name = "button_cmd";
            this.button_cmd.Size = new System.Drawing.Size(50, 50);
            this.button_cmd.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button_cmd, "Komut Penceresi");
            this.button_cmd.UseVisualStyleBackColor = true;
            this.button_cmd.Click += new System.EventHandler(this.button_cmd_Click);
            // 
            // button_ekranyakala
            // 
            this.button_ekranyakala.ImageIndex = 3;
            this.button_ekranyakala.ImageList = this.ımageList2;
            this.button_ekranyakala.Location = new System.Drawing.Point(298, 68);
            this.button_ekranyakala.Name = "button_ekranyakala";
            this.button_ekranyakala.Size = new System.Drawing.Size(50, 50);
            this.button_ekranyakala.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button_ekranyakala, "Ekran Yakalama Aracı");
            this.button_ekranyakala.UseVisualStyleBackColor = true;
            this.button_ekranyakala.Click += new System.EventHandler(this.button_ekranyakala_Click);
            // 
            // button_disktemizleme
            // 
            this.button_disktemizleme.ImageIndex = 0;
            this.button_disktemizleme.ImageList = this.ımageList2;
            this.button_disktemizleme.Location = new System.Drawing.Point(354, 68);
            this.button_disktemizleme.Name = "button_disktemizleme";
            this.button_disktemizleme.Size = new System.Drawing.Size(50, 50);
            this.button_disktemizleme.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button_disktemizleme, "Disk Temizleme");
            this.button_disktemizleme.UseVisualStyleBackColor = true;
            this.button_disktemizleme.Click += new System.EventHandler(this.button_disktemizleme_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // button_paint
            // 
            this.button_paint.ImageIndex = 8;
            this.button_paint.ImageList = this.ımageList2;
            this.button_paint.Location = new System.Drawing.Point(410, 68);
            this.button_paint.Name = "button_paint";
            this.button_paint.Size = new System.Drawing.Size(50, 50);
            this.button_paint.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button_paint, "Paint");
            this.button_paint.UseVisualStyleBackColor = true;
            this.button_paint.Click += new System.EventHandler(this.button_paint_Click);
            // 
            // button_gorevyoneticisi
            // 
            this.button_gorevyoneticisi.ImageIndex = 7;
            this.button_gorevyoneticisi.ImageList = this.ımageList2;
            this.button_gorevyoneticisi.Location = new System.Drawing.Point(466, 68);
            this.button_gorevyoneticisi.Name = "button_gorevyoneticisi";
            this.button_gorevyoneticisi.Size = new System.Drawing.Size(50, 50);
            this.button_gorevyoneticisi.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button_gorevyoneticisi, "Görev Yöneticisi");
            this.button_gorevyoneticisi.UseVisualStyleBackColor = true;
            this.button_gorevyoneticisi.Click += new System.EventHandler(this.button_gorevyoneticisi_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 761);
            this.Controls.Add(this.button_gorevyoneticisi);
            this.Controls.Add(this.button_paint);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_hata);
            this.Controls.Add(this.pictureBox_hata);
            this.Controls.Add(this.button_disktemizleme);
            this.Controls.Add(this.button_ekranyakala);
            this.Controls.Add(this.button_cmd);
            this.Controls.Add(this.button_hesapmakinasi);
            this.Controls.Add(this.button_gezgin);
            this.Controls.Add(this.button_denetimmasasi);
            this.Controls.Add(this.button_ayarlar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_islem);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_ustbaslik);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PC Management Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_donanim.ResumeLayout(false);
            this.tabPage_izleme.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_disk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cpu)).EndInit();
            this.tabPage_islemler.ResumeLayout(false);
            this.tabPage_hizmetler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ustbaslik;
        private System.Windows.Forms.Label label_altbaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar_islem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_donanim;
        private System.Windows.Forms.TabPage tabPage_izleme;
        private System.Windows.Forms.TabPage tabPage_islemler;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button_ayarlar;
        private System.Windows.Forms.Button button_denetimmasasi;
        private System.Windows.Forms.Button button_gezgin;
        private System.Windows.Forms.Button button_hesapmakinasi;
        private System.Windows.Forms.Button button_cmd;
        private System.Windows.Forms.Button button_ekranyakala;
        private System.Windows.Forms.Button button_disktemizleme;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_genislet;
        private System.Windows.Forms.PictureBox pictureBox_hata;
        private System.Windows.Forms.Label label_hata;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_DisariAktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar_ram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar_cpu;
        private System.Windows.Forms.Label label_ramyuzde;
        private System.Windows.Forms.Label label_cpuyuzde;
        private System.Windows.Forms.Label label_diskyuzde;
        private System.Windows.Forms.ProgressBar progressBar_disk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_disk;
        private System.Windows.Forms.PictureBox pictureBox_ram;
        private System.Windows.Forms.PictureBox pictureBox_cpu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_ipadresi;
        private System.Windows.Forms.Label label_hostname;
        private System.Windows.Forms.Label label_acikliksure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_mac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_bit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_daralt;
        private System.Windows.Forms.Label label_isletimsistemi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_internet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView_kopya;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_kopyatemizle;
        private System.Windows.Forms.Button button_kopyacikar;
        private System.Windows.Forms.Button button_kopyaekle;
        private System.Windows.Forms.Button button_islemsonlandir;
        private System.Windows.Forms.ListView listView_islemler;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_islemleryenile;
        private System.Windows.Forms.TabPage tabPage_hizmetler;
        private System.Windows.Forms.ListView listView_hizmetler;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button_hizmetyenile;
        private System.Windows.Forms.Button button_hizmetsonlandir;
        private System.Windows.Forms.Button button_hizmetbaslat;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button button_paint;
        private System.Windows.Forms.Button button_gorevyoneticisi;
    }
}

