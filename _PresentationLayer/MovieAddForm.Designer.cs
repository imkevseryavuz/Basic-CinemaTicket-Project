namespace _PresentationLayer
{
    partial class MovieAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtVisionSD = new System.Windows.Forms.TextBox();
            this.txtVisionFD = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filmin Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vizyona Girme Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vizyon Bitis Tarihi";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(189, 60);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(146, 23);
            this.txtMovieName.TabIndex = 5;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(189, 105);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(146, 23);
            this.txtDirector.TabIndex = 6;
            // 
            // txtVisionSD
            // 
            this.txtVisionSD.Location = new System.Drawing.Point(189, 184);
            this.txtVisionSD.Name = "txtVisionSD";
            this.txtVisionSD.Size = new System.Drawing.Size(146, 23);
            this.txtVisionSD.TabIndex = 7;
            // 
            // txtVisionFD
            // 
            this.txtVisionFD.Location = new System.Drawing.Point(189, 233);
            this.txtVisionFD.Name = "txtVisionFD";
            this.txtVisionFD.Size = new System.Drawing.Size(146, 23);
            this.txtVisionFD.TabIndex = 8;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(189, 146);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(150, 24);
            this.cmbGenre.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.Location = new System.Drawing.Point(143, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 62);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Kaydı Oluştur";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbGenre);
            this.panel1.Controls.Add(this.txtVisionFD);
            this.panel1.Controls.Add(this.txtVisionSD);
            this.panel1.Controls.Add(this.txtDirector);
            this.panel1.Controls.Add(this.txtMovieName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 407);
            this.panel1.TabIndex = 11;
            // 
            // MovieAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 574);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MovieAddForm";
            this.Text = "Yeni Film Ekle";
            this.Load += new System.EventHandler(this.MovieAddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtVisionSD;
        private System.Windows.Forms.TextBox txtVisionFD;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}