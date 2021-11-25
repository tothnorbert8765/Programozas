namespace hotellift_20211125
{
    partial class Form1
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblKartyasz = new System.Windows.Forms.Label();
            this.lblkezdo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtkartya = new System.Windows.Forms.TextBox();
            this.txtkezd = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lbx1 = new System.Windows.Forms.ListBox();
            this.btnFeltolt = new System.Windows.Forms.Button();
            this.btnKiír = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnbeir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(25, 34);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Dátum";
            // 
            // lblKartyasz
            // 
            this.lblKartyasz.AutoSize = true;
            this.lblKartyasz.Location = new System.Drawing.Point(25, 67);
            this.lblKartyasz.Name = "lblKartyasz";
            this.lblKartyasz.Size = new System.Drawing.Size(47, 13);
            this.lblKartyasz.TabIndex = 1;
            this.lblKartyasz.Text = "Kártyasz";
            // 
            // lblkezdo
            // 
            this.lblkezdo.AutoSize = true;
            this.lblkezdo.Location = new System.Drawing.Point(25, 103);
            this.lblkezdo.Name = "lblkezdo";
            this.lblkezdo.Size = new System.Drawing.Size(47, 13);
            this.lblkezdo.TabIndex = 2;
            this.lblkezdo.Text = "Kezdősz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Célsz";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(78, 27);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 4;
            // 
            // txtkartya
            // 
            this.txtkartya.Location = new System.Drawing.Point(78, 60);
            this.txtkartya.Name = "txtkartya";
            this.txtkartya.Size = new System.Drawing.Size(100, 20);
            this.txtkartya.TabIndex = 5;
            // 
            // txtkezd
            // 
            this.txtkezd.Location = new System.Drawing.Point(78, 96);
            this.txtkezd.Name = "txtkezd";
            this.txtkezd.Size = new System.Drawing.Size(100, 20);
            this.txtkezd.TabIndex = 6;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(78, 128);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 7;
            // 
            // lbx1
            // 
            this.lbx1.FormattingEnabled = true;
            this.lbx1.Location = new System.Drawing.Point(304, 27);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(120, 121);
            this.lbx1.TabIndex = 8;
            // 
            // btnFeltolt
            // 
            this.btnFeltolt.Location = new System.Drawing.Point(51, 183);
            this.btnFeltolt.Name = "btnFeltolt";
            this.btnFeltolt.Size = new System.Drawing.Size(75, 23);
            this.btnFeltolt.TabIndex = 9;
            this.btnFeltolt.Text = "Feltöltés";
            this.btnFeltolt.UseVisualStyleBackColor = true;
            this.btnFeltolt.Click += new System.EventHandler(this.BtnFeltolt_Click);
            // 
            // btnKiír
            // 
            this.btnKiír.Location = new System.Drawing.Point(158, 183);
            this.btnKiír.Name = "btnKiír";
            this.btnKiír.Size = new System.Drawing.Size(75, 23);
            this.btnKiír.TabIndex = 10;
            this.btnKiír.Text = "Kiír";
            this.btnKiír.UseVisualStyleBackColor = true;
            this.btnKiír.Click += new System.EventHandler(this.BtnKiír_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(261, 183);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 11;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(51, 235);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 12;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(158, 235);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 13;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.BtnKeres_Click);
            // 
            // btnbeir
            // 
            this.btnbeir.Location = new System.Drawing.Point(261, 235);
            this.btnbeir.Name = "btnbeir";
            this.btnbeir.Size = new System.Drawing.Size(75, 23);
            this.btnbeir.TabIndex = 14;
            this.btnbeir.Text = "Beír";
            this.btnbeir.UseVisualStyleBackColor = true;
            this.btnbeir.Click += new System.EventHandler(this.Btnbeir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 294);
            this.Controls.Add(this.btnbeir);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnKiír);
            this.Controls.Add(this.btnFeltolt);
            this.Controls.Add(this.lbx1);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtkezd);
            this.Controls.Add(this.txtkartya);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblkezdo);
            this.Controls.Add(this.lblKartyasz);
            this.Controls.Add(this.lblDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblKartyasz;
        private System.Windows.Forms.Label lblkezdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtkartya;
        private System.Windows.Forms.TextBox txtkezd;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.ListBox lbx1;
        private System.Windows.Forms.Button btnFeltolt;
        private System.Windows.Forms.Button btnKiír;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnbeir;
    }
}

