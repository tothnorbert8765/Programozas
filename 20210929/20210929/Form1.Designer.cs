namespace _20210929
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
            this.lblsorszam = new System.Windows.Forms.Label();
            this.lblevszak = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btnevszak = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsorszam
            // 
            this.lblsorszam.AutoSize = true;
            this.lblsorszam.Location = new System.Drawing.Point(172, 179);
            this.lblsorszam.Name = "lblsorszam";
            this.lblsorszam.Size = new System.Drawing.Size(97, 13);
            this.lblsorszam.TabIndex = 0;
            this.lblsorszam.Text = "A hónap sorszáma:";
            // 
            // lblevszak
            // 
            this.lblevszak.AutoSize = true;
            this.lblevszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblevszak.Location = new System.Drawing.Point(289, 235);
            this.lblevszak.Name = "lblevszak";
            this.lblevszak.Size = new System.Drawing.Size(75, 24);
            this.lblevszak.TabIndex = 1;
            this.lblevszak.Text = "Évszak";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(293, 179);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 20);
            this.txtbox.TabIndex = 2;
            // 
            // btnevszak
            // 
            this.btnevszak.Location = new System.Drawing.Point(221, 318);
            this.btnevszak.Name = "btnevszak";
            this.btnevszak.Size = new System.Drawing.Size(75, 23);
            this.btnevszak.TabIndex = 3;
            this.btnevszak.Text = "Évszak";
            this.btnevszak.UseVisualStyleBackColor = true;
            this.btnevszak.Click += new System.EventHandler(this.Btnevszak_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(366, 318);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 23);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnevszak);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lblevszak);
            this.Controls.Add(this.lblsorszam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsorszam;
        private System.Windows.Forms.Label lblevszak;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btnevszak;
        private System.Windows.Forms.Button btnKilepes;
    }
}

