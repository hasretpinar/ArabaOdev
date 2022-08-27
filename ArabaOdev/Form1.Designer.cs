namespace ArabaOdev
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
            this.lb = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.lbMarka = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lbKapiSayisi = new System.Windows.Forms.Label();
            this.lbBeygirGucu = new System.Windows.Forms.Label();
            this.ddlKapiSayisi = new System.Windows.Forms.ComboBox();
            this.lbArabaTuru = new System.Windows.Forms.Label();
            this.lbMaksimumHiz = new System.Windows.Forms.Label();
            this.ddlArabaTuru = new System.Windows.Forms.ComboBox();
            this.lbCekis = new System.Windows.Forms.Label();
            this.lbSifirdanYuzeHizlanma = new System.Windows.Forms.Label();
            this.nudMaksimumHiz = new System.Windows.Forms.NumericUpDown();
            this.ddlCekis = new System.Windows.Forms.ComboBox();
            this.lbAgirlik = new System.Windows.Forms.Label();
            this.lbMotorHacmi = new System.Windows.Forms.Label();
            this.nudSifirdanYuzeHizlanma = new System.Windows.Forms.NumericUpDown();
            this.nudAgirlik = new System.Windows.Forms.NumericUpDown();
            this.nudMotorHacmi = new System.Windows.Forms.NumericUpDown();
            this.btKaydet = new System.Windows.Forms.Button();
            this.btGoster = new System.Windows.Forms.Button();
            this.nudBeygirGucu = new System.Windows.Forms.NumericUpDown();
            this.lbSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimumHiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifirdanYuzeHizlanma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMotorHacmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeygirGucu)).BeginInit();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lb.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb.Location = new System.Drawing.Point(77, 45);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(56, 46);
            this.lb.TabIndex = 0;
            this.lb.Text = "Id";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(529, 47);
            this.nudId.Name = "nudId";
            this.nudId.ReadOnly = true;
            this.nudId.Size = new System.Drawing.Size(402, 47);
            this.nudId.TabIndex = 1;
            this.nudId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbMarka
            // 
            this.lbMarka.AutoSize = true;
            this.lbMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbMarka.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMarka.Location = new System.Drawing.Point(77, 147);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(132, 46);
            this.lbMarka.TabIndex = 0;
            this.lbMarka.Text = "Marka";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbModel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbModel.Location = new System.Drawing.Point(77, 255);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(125, 46);
            this.lbModel.TabIndex = 0;
            this.lbModel.Text = "Model";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(529, 150);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(402, 47);
            this.tbMarka.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(529, 245);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(402, 47);
            this.tbModel.TabIndex = 2;
            // 
            // lbKapiSayisi
            // 
            this.lbKapiSayisi.AutoSize = true;
            this.lbKapiSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbKapiSayisi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbKapiSayisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbKapiSayisi.Location = new System.Drawing.Point(77, 361);
            this.lbKapiSayisi.Name = "lbKapiSayisi";
            this.lbKapiSayisi.Size = new System.Drawing.Size(206, 46);
            this.lbKapiSayisi.TabIndex = 0;
            this.lbKapiSayisi.Text = "Kapı Sayısı";
            // 
            // lbBeygirGucu
            // 
            this.lbBeygirGucu.AutoSize = true;
            this.lbBeygirGucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbBeygirGucu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbBeygirGucu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBeygirGucu.Location = new System.Drawing.Point(77, 476);
            this.lbBeygirGucu.Name = "lbBeygirGucu";
            this.lbBeygirGucu.Size = new System.Drawing.Size(231, 46);
            this.lbBeygirGucu.TabIndex = 0;
            this.lbBeygirGucu.Text = "Beygir Gücü";
            // 
            // ddlKapiSayisi
            // 
            this.ddlKapiSayisi.FormattingEnabled = true;
            this.ddlKapiSayisi.Items.AddRange(new object[] {
            "2 Kapılı",
            "4 Kapılı",
            "5 Kapılı"});
            this.ddlKapiSayisi.Location = new System.Drawing.Point(529, 360);
            this.ddlKapiSayisi.Name = "ddlKapiSayisi";
            this.ddlKapiSayisi.Size = new System.Drawing.Size(402, 49);
            this.ddlKapiSayisi.TabIndex = 3;
            // 
            // lbArabaTuru
            // 
            this.lbArabaTuru.AutoSize = true;
            this.lbArabaTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbArabaTuru.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbArabaTuru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbArabaTuru.Location = new System.Drawing.Point(77, 571);
            this.lbArabaTuru.Name = "lbArabaTuru";
            this.lbArabaTuru.Size = new System.Drawing.Size(217, 46);
            this.lbArabaTuru.TabIndex = 0;
            this.lbArabaTuru.Text = "Araba Türü";
            // 
            // lbMaksimumHiz
            // 
            this.lbMaksimumHiz.AutoSize = true;
            this.lbMaksimumHiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbMaksimumHiz.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbMaksimumHiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaksimumHiz.Location = new System.Drawing.Point(77, 672);
            this.lbMaksimumHiz.Name = "lbMaksimumHiz";
            this.lbMaksimumHiz.Size = new System.Drawing.Size(279, 46);
            this.lbMaksimumHiz.TabIndex = 0;
            this.lbMaksimumHiz.Text = "Maksimum Hız";
            // 
            // ddlArabaTuru
            // 
            this.ddlArabaTuru.FormattingEnabled = true;
            this.ddlArabaTuru.Items.AddRange(new object[] {
            "Binek",
            "Ticari"});
            this.ddlArabaTuru.Location = new System.Drawing.Point(529, 570);
            this.ddlArabaTuru.Name = "ddlArabaTuru";
            this.ddlArabaTuru.Size = new System.Drawing.Size(402, 49);
            this.ddlArabaTuru.TabIndex = 3;
            // 
            // lbCekis
            // 
            this.lbCekis.AutoSize = true;
            this.lbCekis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbCekis.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCekis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCekis.Location = new System.Drawing.Point(77, 775);
            this.lbCekis.Name = "lbCekis";
            this.lbCekis.Size = new System.Drawing.Size(112, 46);
            this.lbCekis.TabIndex = 0;
            this.lbCekis.Text = "Çekiş";
            // 
            // lbSifirdanYuzeHizlanma
            // 
            this.lbSifirdanYuzeHizlanma.AutoSize = true;
            this.lbSifirdanYuzeHizlanma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbSifirdanYuzeHizlanma.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbSifirdanYuzeHizlanma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSifirdanYuzeHizlanma.Location = new System.Drawing.Point(77, 881);
            this.lbSifirdanYuzeHizlanma.Name = "lbSifirdanYuzeHizlanma";
            this.lbSifirdanYuzeHizlanma.Size = new System.Drawing.Size(419, 46);
            this.lbSifirdanYuzeHizlanma.TabIndex = 0;
            this.lbSifirdanYuzeHizlanma.Text = "Sıfırdan Yüze Hızlanma";
            // 
            // nudMaksimumHiz
            // 
            this.nudMaksimumHiz.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaksimumHiz.Location = new System.Drawing.Point(529, 674);
            this.nudMaksimumHiz.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudMaksimumHiz.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaksimumHiz.Name = "nudMaksimumHiz";
            this.nudMaksimumHiz.Size = new System.Drawing.Size(402, 47);
            this.nudMaksimumHiz.TabIndex = 4;
            this.nudMaksimumHiz.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ddlCekis
            // 
            this.ddlCekis.FormattingEnabled = true;
            this.ddlCekis.Items.AddRange(new object[] {
            "Önden çekiş",
            "Arkadan itiş",
            "Dört çeker"});
            this.ddlCekis.Location = new System.Drawing.Point(529, 772);
            this.ddlCekis.Name = "ddlCekis";
            this.ddlCekis.Size = new System.Drawing.Size(402, 49);
            this.ddlCekis.TabIndex = 5;
            // 
            // lbAgirlik
            // 
            this.lbAgirlik.AutoSize = true;
            this.lbAgirlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbAgirlik.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAgirlik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAgirlik.Location = new System.Drawing.Point(77, 980);
            this.lbAgirlik.Name = "lbAgirlik";
            this.lbAgirlik.Size = new System.Drawing.Size(136, 46);
            this.lbAgirlik.TabIndex = 0;
            this.lbAgirlik.Text = "Ağırlık";
            // 
            // lbMotorHacmi
            // 
            this.lbMotorHacmi.AutoSize = true;
            this.lbMotorHacmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbMotorHacmi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbMotorHacmi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMotorHacmi.Location = new System.Drawing.Point(77, 1076);
            this.lbMotorHacmi.Name = "lbMotorHacmi";
            this.lbMotorHacmi.Size = new System.Drawing.Size(246, 46);
            this.lbMotorHacmi.TabIndex = 0;
            this.lbMotorHacmi.Text = "Motor Hacmi";
            // 
            // nudSifirdanYuzeHizlanma
            // 
            this.nudSifirdanYuzeHizlanma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSifirdanYuzeHizlanma.Location = new System.Drawing.Point(529, 883);
            this.nudSifirdanYuzeHizlanma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifirdanYuzeHizlanma.Name = "nudSifirdanYuzeHizlanma";
            this.nudSifirdanYuzeHizlanma.Size = new System.Drawing.Size(402, 47);
            this.nudSifirdanYuzeHizlanma.TabIndex = 6;
            this.nudSifirdanYuzeHizlanma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAgirlik
            // 
            this.nudAgirlik.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAgirlik.Location = new System.Drawing.Point(529, 979);
            this.nudAgirlik.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudAgirlik.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudAgirlik.Name = "nudAgirlik";
            this.nudAgirlik.Size = new System.Drawing.Size(402, 47);
            this.nudAgirlik.TabIndex = 6;
            this.nudAgirlik.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // nudMotorHacmi
            // 
            this.nudMotorHacmi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMotorHacmi.Location = new System.Drawing.Point(529, 1075);
            this.nudMotorHacmi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMotorHacmi.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.nudMotorHacmi.Name = "nudMotorHacmi";
            this.nudMotorHacmi.Size = new System.Drawing.Size(402, 47);
            this.nudMotorHacmi.TabIndex = 6;
            this.nudMotorHacmi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btKaydet
            // 
            this.btKaydet.Location = new System.Drawing.Point(553, 1199);
            this.btKaydet.Name = "btKaydet";
            this.btKaydet.Size = new System.Drawing.Size(188, 58);
            this.btKaydet.TabIndex = 7;
            this.btKaydet.Text = "Kaydet";
            this.btKaydet.UseVisualStyleBackColor = true;
            this.btKaydet.Click += new System.EventHandler(this.btKaydet_Click);
            // 
            // btGoster
            // 
            this.btGoster.Location = new System.Drawing.Point(872, 1199);
            this.btGoster.Name = "btGoster";
            this.btGoster.Size = new System.Drawing.Size(188, 58);
            this.btGoster.TabIndex = 8;
            this.btGoster.Text = "Göster";
            this.btGoster.UseVisualStyleBackColor = true;
            this.btGoster.Click += new System.EventHandler(this.btGoster_Click);
            // 
            // nudBeygirGucu
            // 
            this.nudBeygirGucu.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBeygirGucu.Location = new System.Drawing.Point(529, 475);
            this.nudBeygirGucu.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudBeygirGucu.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudBeygirGucu.Name = "nudBeygirGucu";
            this.nudBeygirGucu.Size = new System.Drawing.Size(402, 47);
            this.nudBeygirGucu.TabIndex = 4;
            this.nudBeygirGucu.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(91, 1216);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(232, 41);
            this.lbSonuc.TabIndex = 9;
            this.lbSonuc.Text = "Araba Özellikleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 1434);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btGoster);
            this.Controls.Add(this.btKaydet);
            this.Controls.Add(this.nudMotorHacmi);
            this.Controls.Add(this.nudAgirlik);
            this.Controls.Add(this.nudSifirdanYuzeHizlanma);
            this.Controls.Add(this.ddlCekis);
            this.Controls.Add(this.nudBeygirGucu);
            this.Controls.Add(this.nudMaksimumHiz);
            this.Controls.Add(this.ddlArabaTuru);
            this.Controls.Add(this.ddlKapiSayisi);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.lbSifirdanYuzeHizlanma);
            this.Controls.Add(this.lbMotorHacmi);
            this.Controls.Add(this.lbAgirlik);
            this.Controls.Add(this.lbCekis);
            this.Controls.Add(this.lbMaksimumHiz);
            this.Controls.Add(this.lbArabaTuru);
            this.Controls.Add(this.lbBeygirGucu);
            this.Controls.Add(this.lbKapiSayisi);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbMarka);
            this.Controls.Add(this.lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimumHiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifirdanYuzeHizlanma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMotorHacmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeygirGucu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb;
        private NumericUpDown nudId;
        private Label lbMarka;
        private Label lbModel;
        private TextBox tbMarka;
        private TextBox tbModel;
        private Label lbKapiSayisi;
        private Label lbBeygirGucu;
        private ComboBox ddlKapiSayisi;
        private Label lbArabaTuru;
        private Label lbMaksimumHiz;
        private ComboBox ddlArabaTuru;
        private Label lbCekis;
        private Label lbSifirdanYuzeHizlanma;
        private NumericUpDown nudMaksimumHiz;
        private ComboBox ddlCekis;
        private Label lbAgirlik;
        private Label lbMotorHacmi;
        private NumericUpDown nudSifirdanYuzeHizlanma;
        private NumericUpDown nudAgirlik;
        private NumericUpDown nudMotorHacmi;
        private Button btKaydet;
        private Button btGoster;
        private NumericUpDown nudBeygirGucu;
        private Label lbSonuc;
    }
}