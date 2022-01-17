namespace Kutuphane.Presentation.KitapHareketleri
{
    partial class FRMKitapAlislem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtKitapAdi = new System.Windows.Forms.TextBox();
            this.TxtUyeadi = new System.Windows.Forms.TextBox();
            this.TxtUyeSoy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtVerilisSure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalenderVerilis = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnOnay = new System.Windows.Forms.Button();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBorc = new System.Windows.Forms.TextBox();
            this.RtZamanDeger = new DevExpress.XtraEditors.RatingControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalenderVerilis.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtZamanDeger.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKitapAdi
            // 
            this.TxtKitapAdi.Location = new System.Drawing.Point(101, 20);
            this.TxtKitapAdi.Name = "TxtKitapAdi";
            this.TxtKitapAdi.ReadOnly = true;
            this.TxtKitapAdi.Size = new System.Drawing.Size(100, 21);
            this.TxtKitapAdi.TabIndex = 0;
            // 
            // TxtUyeadi
            // 
            this.TxtUyeadi.Location = new System.Drawing.Point(101, 50);
            this.TxtUyeadi.Name = "TxtUyeadi";
            this.TxtUyeadi.ReadOnly = true;
            this.TxtUyeadi.Size = new System.Drawing.Size(100, 21);
            this.TxtUyeadi.TabIndex = 1;
            // 
            // TxtUyeSoy
            // 
            this.TxtUyeSoy.Location = new System.Drawing.Point(293, 50);
            this.TxtUyeSoy.Name = "TxtUyeSoy";
            this.TxtUyeSoy.ReadOnly = true;
            this.TxtUyeSoy.Size = new System.Drawing.Size(100, 21);
            this.TxtUyeSoy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üye Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uye SoyAdı";
            // 
            // DtVerilisTarihi
            // 
            this.DtVerilisTarihi.Enabled = false;
            this.DtVerilisTarihi.Location = new System.Drawing.Point(101, 80);
            this.DtVerilisTarihi.Name = "DtVerilisTarihi";
            this.DtVerilisTarihi.Size = new System.Drawing.Size(146, 21);
            this.DtVerilisTarihi.TabIndex = 6;
            // 
            // TxtVerilisSure
            // 
            this.TxtVerilisSure.Location = new System.Drawing.Point(101, 110);
            this.TxtVerilisSure.Name = "TxtVerilisSure";
            this.TxtVerilisSure.ReadOnly = true;
            this.TxtVerilisSure.Size = new System.Drawing.Size(100, 21);
            this.TxtVerilisSure.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Veriliş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Veriliş Süresi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtKitapAdi);
            this.groupBox1.Controls.Add(this.TxtVerilisSure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtUyeadi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtUyeSoy);
            this.groupBox1.Controls.Add(this.DtVerilisTarihi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçili İşlem Özeti";
            // 
            // CalenderVerilis
            // 
            this.CalenderVerilis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CalenderVerilis.Location = new System.Drawing.Point(12, 189);
            this.CalenderVerilis.Name = "CalenderVerilis";
            this.CalenderVerilis.ReadOnly = true;
            this.CalenderVerilis.ShowFooter = false;
            this.CalenderVerilis.ShowMonthHeaders = false;
            this.CalenderVerilis.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.CalenderVerilis.Size = new System.Drawing.Size(248, 204);
            this.CalenderVerilis.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(12, 170);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(248, 20);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Teslim Tarihi";
            // 
            // BtnOnay
            // 
            this.BtnOnay.Location = new System.Drawing.Point(299, 370);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(106, 23);
            this.BtnOnay.TabIndex = 12;
            this.BtnOnay.Text = "Onayla ve Kaydet";
            this.BtnOnay.UseVisualStyleBackColor = true;
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(423, 370);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(75, 23);
            this.BtnIptal.TabIndex = 13;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(283, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 49);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(283, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 68);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Borç";
            // 
            // TxtBorc
            // 
            this.TxtBorc.Location = new System.Drawing.Point(329, 292);
            this.TxtBorc.Name = "TxtBorc";
            this.TxtBorc.Size = new System.Drawing.Size(196, 21);
            this.TxtBorc.TabIndex = 17;
            // 
            // RtZamanDeger
            // 
            this.RtZamanDeger.Location = new System.Drawing.Point(407, 323);
            this.RtZamanDeger.Name = "RtZamanDeger";
            this.RtZamanDeger.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.RtZamanDeger.Size = new System.Drawing.Size(87, 16);
            this.RtZamanDeger.TabIndex = 18;
            this.RtZamanDeger.Text = "ratingControl1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Teslim Degerlendirmesi";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(332, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FRMKitapAlislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 415);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RtZamanDeger);
            this.Controls.Add(this.TxtBorc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.CalenderVerilis);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRMKitapAlislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim Al";
            this.Load += new System.EventHandler(this.FRMKitapAlislem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalenderVerilis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtZamanDeger.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKitapAdi;
        private System.Windows.Forms.TextBox TxtUyeadi;
        private System.Windows.Forms.TextBox TxtUyeSoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtVerilisTarihi;
        private System.Windows.Forms.TextBox TxtVerilisSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.Controls.CalendarControl CalenderVerilis;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button BtnOnay;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBorc;
        private DevExpress.XtraEditors.RatingControl RtZamanDeger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}