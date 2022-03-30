
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
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_kapat = new System.Windows.Forms.Button();
            this.button_kucult = new System.Windows.Forms.Button();
            this.label_ustbaslik = new System.Windows.Forms.Label();
            this.label_altbaslik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar_islem = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_surum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ipadres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_toplamcalisma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_hostname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_kapat.BackgroundImage = global::PCMagTool.Properties.Resources.kapat;
            this.button_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_kapat.FlatAppearance.BorderSize = 0;
            this.button_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kapat.Location = new System.Drawing.Point(758, 12);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(30, 30);
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
            this.button_kucult.Location = new System.Drawing.Point(722, 12);
            this.button_kucult.Name = "button_kucult";
            this.button_kucult.Size = new System.Drawing.Size(30, 30);
            this.button_kucult.TabIndex = 2;
            this.button_kucult.UseVisualStyleBackColor = false;
            // 
            // label_ustbaslik
            // 
            this.label_ustbaslik.AutoSize = true;
            this.label_ustbaslik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_ustbaslik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ustbaslik.ForeColor = System.Drawing.Color.Crimson;
            this.label_ustbaslik.Location = new System.Drawing.Point(118, 12);
            this.label_ustbaslik.Name = "label_ustbaslik";
            this.label_ustbaslik.Size = new System.Drawing.Size(182, 37);
            this.label_ustbaslik.TabIndex = 3;
            this.label_ustbaslik.Text = "PCMagTool";
            // 
            // label_altbaslik
            // 
            this.label_altbaslik.AutoSize = true;
            this.label_altbaslik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_altbaslik.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_altbaslik.Location = new System.Drawing.Point(122, 56);
            this.label_altbaslik.Name = "label_altbaslik";
            this.label_altbaslik.Size = new System.Drawing.Size(295, 21);
            this.label_altbaslik.TabIndex = 4;
            this.label_altbaslik.Text = "Bilgisayar Yönetim ve Kontrol Aracı";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 125);
            this.label3.TabIndex = 5;
            // 
            // progressBar_islem
            // 
            this.progressBar_islem.Location = new System.Drawing.Point(0, 124);
            this.progressBar_islem.Name = "progressBar_islem";
            this.progressBar_islem.Size = new System.Drawing.Size(800, 10);
            this.progressBar_islem.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_surum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_ipadres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_toplamcalisma);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_hostname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBox_surum
            // 
            this.textBox_surum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_surum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_surum.Location = new System.Drawing.Point(550, 53);
            this.textBox_surum.Name = "textBox_surum";
            this.textBox_surum.ReadOnly = true;
            this.textBox_surum.Size = new System.Drawing.Size(220, 21);
            this.textBox_surum.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(387, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sürüm";
            // 
            // textBox_ipadres
            // 
            this.textBox_ipadres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ipadres.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ipadres.Location = new System.Drawing.Point(129, 53);
            this.textBox_ipadres.Name = "textBox_ipadres";
            this.textBox_ipadres.ReadOnly = true;
            this.textBox_ipadres.Size = new System.Drawing.Size(220, 21);
            this.textBox_ipadres.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "IP Adresi";
            // 
            // textBox_toplamcalisma
            // 
            this.textBox_toplamcalisma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_toplamcalisma.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_toplamcalisma.Location = new System.Drawing.Point(550, 20);
            this.textBox_toplamcalisma.Name = "textBox_toplamcalisma";
            this.textBox_toplamcalisma.ReadOnly = true;
            this.textBox_toplamcalisma.Size = new System.Drawing.Size(220, 21);
            this.textBox_toplamcalisma.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(387, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Toplam Çalışma";
            // 
            // textBox_hostname
            // 
            this.textBox_hostname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hostname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_hostname.Location = new System.Drawing.Point(129, 20);
            this.textBox_hostname.Name = "textBox_hostname";
            this.textBox_hostname.ReadOnly = true;
            this.textBox_hostname.Size = new System.Drawing.Size(220, 21);
            this.textBox_hostname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bilgisayar Adı";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(69, 439);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 10);
            this.progressBar1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(423, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "v1.0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 75);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 85);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar_islem);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_ustbaslik);
            this.Controls.Add(this.button_kucult);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCMagTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_hostname;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_toplamcalisma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_surum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ipadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

