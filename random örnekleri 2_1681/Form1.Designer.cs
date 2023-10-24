namespace random_örnekleri_2_1681
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblDuz = new System.Windows.Forms.Label();
            this.lblTesekur = new System.Windows.Forms.Label();
            this.btnÜret = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTaktir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotlar
            // 
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 24;
            this.lbNotlar.Location = new System.Drawing.Point(160, 12);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(120, 172);
            this.lbNotlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(157, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(157, 189);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(199, 24);
            this.lblKalan.TabIndex = 2;
            this.lblKalan.Text = "kalan öğrenci sayısı:";
            // 
            // lblDuz
            // 
            this.lblDuz.AutoSize = true;
            this.lblDuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuz.Location = new System.Drawing.Point(158, 217);
            this.lblDuz.Name = "lblDuz";
            this.lblDuz.Size = new System.Drawing.Size(198, 24);
            this.lblDuz.TabIndex = 3;
            this.lblDuz.Text = "düz geçen öğrenci ;";
            // 
            // lblTesekur
            // 
            this.lblTesekur.AutoSize = true;
            this.lblTesekur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesekur.Location = new System.Drawing.Point(158, 248);
            this.lblTesekur.Name = "lblTesekur";
            this.lblTesekur.Size = new System.Drawing.Size(141, 24);
            this.lblTesekur.TabIndex = 4;
            this.lblTesekur.Text = "teşekür sayısı:";
            // 
            // btnÜret
            // 
            this.btnÜret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜret.Location = new System.Drawing.Point(44, 24);
            this.btnÜret.Name = "btnÜret";
            this.btnÜret.Size = new System.Drawing.Size(89, 43);
            this.btnÜret.TabIndex = 5;
            this.btnÜret.Text = "ortalama not ";
            this.btnÜret.UseVisualStyleBackColor = true;
            this.btnÜret.Click += new System.EventHandler(this.btnÜret_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(44, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "geçme kalma durum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTaktir
            // 
            this.lblTaktir.AutoSize = true;
            this.lblTaktir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaktir.Location = new System.Drawing.Point(158, 280);
            this.lblTaktir.Name = "lblTaktir";
            this.lblTaktir.Size = new System.Drawing.Size(116, 24);
            this.lblTaktir.TabIndex = 7;
            this.lblTaktir.Text = "taktir sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 320);
            this.Controls.Add(this.lblTaktir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnÜret);
            this.Controls.Add(this.lblTesekur);
            this.Controls.Add(this.lblDuz);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNotlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblDuz;
        private System.Windows.Forms.Label lblTesekur;
        private System.Windows.Forms.Button btnÜret;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTaktir;
    }
}

