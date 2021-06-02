
namespace NotDefteriUygulamasi
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.cbYildiz = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmsNotlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFavori = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(490, 44);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 31);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstNotlar
            // 
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 23;
            this.lstNotlar.Location = new System.Drawing.Point(37, 110);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(447, 234);
            this.lstNotlar.TabIndex = 1;
            this.lstNotlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstNotlar_KeyDown);
            this.lstNotlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNotlar_MouseDown);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(37, 45);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(447, 30);
            this.txtMetin.TabIndex = 2;
            this.txtMetin.TextChanged += new System.EventHandler(this.txtMetin_TextChanged);
            this.txtMetin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMetin_KeyDown);
            // 
            // cbYildiz
            // 
            this.cbYildiz.AutoSize = true;
            this.cbYildiz.Location = new System.Drawing.Point(37, 78);
            this.cbYildiz.Name = "cbYildiz";
            this.cbYildiz.Size = new System.Drawing.Size(158, 27);
            this.cbYildiz.TabIndex = 3;
            this.cbYildiz.Text = "Yıldızlıları Göster";
            this.cbYildiz.UseVisualStyleBackColor = true;
            this.cbYildiz.CheckedChanged += new System.EventHandler(this.cbYildiz_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not:";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(512, 246);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(120, 40);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(512, 304);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 40);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmsNotlar
            // 
            this.cmsNotlar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNotlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSil,
            this.tsmiDuzenle,
            this.tsmiFavori});
            this.cmsNotlar.Name = "cmsNotlar";
            this.cmsNotlar.Size = new System.Drawing.Size(213, 104);
            this.cmsNotlar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsNotlar_ItemClicked);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(212, 24);
            this.tsmiSil.Text = "Sil";
            // 
            // tsmiDuzenle
            // 
            this.tsmiDuzenle.Name = "tsmiDuzenle";
            this.tsmiDuzenle.Size = new System.Drawing.Size(212, 24);
            this.tsmiDuzenle.Text = "Düzenle";
            // 
            // tsmiFavori
            // 
            this.tsmiFavori.Name = "tsmiFavori";
            this.tsmiFavori.Size = new System.Drawing.Size(212, 24);
            this.tsmiFavori.Text = "Favorilere Ekle/Çıkar";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 394);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYildiz);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AnaForm";
            this.Text = "NOT DEFTERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.cmsNotlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.CheckBox cbYildiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ContextMenuStrip cmsNotlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
        private System.Windows.Forms.ToolStripMenuItem tsmiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmiFavori;
    }
}