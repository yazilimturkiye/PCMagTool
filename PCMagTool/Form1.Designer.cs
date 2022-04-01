
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bilgisayar Adı");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Domain");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sistem Tipi");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Kullanıcı Adı");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bilgisayar", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Düğüm5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Düğüm6");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Düğüm7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("İşletim Sistemi", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Düğüm0");
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_kapat = new System.Windows.Forms.Button();
            this.button_kucult = new System.Windows.Forms.Button();
            this.label_ustbaslik = new System.Windows.Forms.Label();
            this.label_altbaslik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar_islem = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_sistem = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage_donanim = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_sistem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(10, 9);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_kapat.BackgroundImage = global::PCMagTool.Properties.Resources.kapat;
            this.button_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_kapat.FlatAppearance.BorderSize = 0;
            this.button_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kapat.Location = new System.Drawing.Point(663, 9);
            this.button_kapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(26, 22);
            this.button_kapat.TabIndex = 1;
            this.button_kapat.UseVisualStyleBackColor = false;
            // 
            // button_kucult
            // 
            this.button_kucult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_kucult.BackgroundImage = global::PCMagTool.Properties.Resources.kucult;
            this.button_kucult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_kucult.FlatAppearance.BorderSize = 0;
            this.button_kucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kucult.Location = new System.Drawing.Point(631, 9);
            this.button_kucult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_kucult.Name = "button_kucult";
            this.button_kucult.Size = new System.Drawing.Size(26, 23);
            this.button_kucult.TabIndex = 2;
            this.button_kucult.UseVisualStyleBackColor = false;
            // 
            // label_ustbaslik
            // 
            this.label_ustbaslik.AutoSize = true;
            this.label_ustbaslik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_ustbaslik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ustbaslik.ForeColor = System.Drawing.Color.Crimson;
            this.label_ustbaslik.Location = new System.Drawing.Point(91, 9);
            this.label_ustbaslik.Name = "label_ustbaslik";
            this.label_ustbaslik.Size = new System.Drawing.Size(144, 28);
            this.label_ustbaslik.TabIndex = 3;
            this.label_ustbaslik.Text = "PCMagTool";
            // 
            // label_altbaslik
            // 
            this.label_altbaslik.AutoSize = true;
            this.label_altbaslik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_altbaslik.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_altbaslik.Location = new System.Drawing.Point(93, 42);
            this.label_altbaslik.Name = "label_altbaslik";
            this.label_altbaslik.Size = new System.Drawing.Size(242, 19);
            this.label_altbaslik.TabIndex = 4;
            this.label_altbaslik.Text = "Bilgisayar Yönetim ve Kontrol Aracı";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(700, 94);
            this.label3.TabIndex = 5;
            // 
            // progressBar_islem
            // 
            this.progressBar_islem.Location = new System.Drawing.Point(-1, 93);
            this.progressBar_islem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_islem.Name = "progressBar_islem";
            this.progressBar_islem.Size = new System.Drawing.Size(703, 8);
            this.progressBar_islem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 19);
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
            this.tabControl1.Location = new System.Drawing.Point(10, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(5, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 482);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage_sistem
            // 
            this.tabPage_sistem.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_sistem.Controls.Add(this.treeView1);
            this.tabPage_sistem.Location = new System.Drawing.Point(4, 33);
            this.tabPage_sistem.Name = "tabPage_sistem";
            this.tabPage_sistem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sistem.Size = new System.Drawing.Size(671, 445);
            this.tabPage_sistem.TabIndex = 0;
            this.tabPage_sistem.Text = "Sistem";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(-2, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "altdugum_bilgisayaradi";
            treeNode1.Text = "Bilgisayar Adı";
            treeNode2.Name = "altdugum_domain";
            treeNode2.Text = "Domain";
            treeNode3.Name = "altdugum_sistemtipi";
            treeNode3.Text = "Sistem Tipi";
            treeNode4.Name = "altdugum_kullanici";
            treeNode4.Text = "Kullanıcı Adı";
            treeNode5.Name = "dugum_bilgisayar";
            treeNode5.Text = "Bilgisayar";
            treeNode6.Name = "Düğüm5";
            treeNode6.Text = "Düğüm5";
            treeNode7.Name = "Düğüm6";
            treeNode7.Text = "Düğüm6";
            treeNode8.Name = "Düğüm7";
            treeNode8.Text = "Düğüm7";
            treeNode9.Name = "dugum_OS";
            treeNode9.Text = "İşletim Sistemi";
            treeNode10.Name = "Dugum_";
            treeNode10.Text = "Düğüm0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(674, 448);
            this.treeView1.TabIndex = 1;
            // 
            // tabPage_donanim
            // 
            this.tabPage_donanim.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_donanim.Location = new System.Drawing.Point(4, 33);
            this.tabPage_donanim.Name = "tabPage_donanim";
            this.tabPage_donanim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_donanim.Size = new System.Drawing.Size(671, 445);
            this.tabPage_donanim.TabIndex = 1;
            this.tabPage_donanim.Text = "Donanım";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(671, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_islem);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_ustbaslik);
            this.Controls.Add(this.button_kucult);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCMagTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_sistem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.Button button_kucult;
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
    }
}

