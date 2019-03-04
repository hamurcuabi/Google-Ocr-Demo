namespace Google_Orc
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txt4a = new System.Windows.Forms.TextBox();
            this.txt4c = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt4b = new System.Windows.Forms.TextBox();
            this.txt4d = new System.Windows.Forms.TextBox();
            this.txtBornDate = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 13);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(159, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Ehliyet Resiminizi Seçin\r\n";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pxImage
            // 
            this.pxImage.BackColor = System.Drawing.SystemColors.Info;
            this.pxImage.Location = new System.Drawing.Point(12, 53);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(330, 292);
            this.pxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(353, 121);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Yazıyı Getir";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(441, 53);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(330, 292);
            this.txtResult.TabIndex = 3;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Checked = true;
            this.rbText.Location = new System.Drawing.Point(367, 163);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 4;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbJson
            // 
            this.rbJson.AutoSize = true;
            this.rbJson.Location = new System.Drawing.Point(367, 198);
            this.rbJson.Name = "rbJson";
            this.rbJson.Size = new System.Drawing.Size(47, 17);
            this.rbJson.TabIndex = 4;
            this.rbJson.Text = "Json";
            this.rbJson.UseVisualStyleBackColor = true;
            this.rbJson.CheckedChanged += new System.EventHandler(this.rbJson_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dil";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(650, 14);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbLanguage.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.txt9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBornDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt4d, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt4b, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt4c, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt4a, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSurname, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 351);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 116);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Location = new System.Drawing.Point(3, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(246, 20);
            this.txtSurname.TabIndex = 0;
            // 
            // txt4a
            // 
            this.txt4a.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4a.Location = new System.Drawing.Point(255, 3);
            this.txt4a.Name = "txt4a";
            this.txt4a.Size = new System.Drawing.Size(247, 20);
            this.txt4a.TabIndex = 1;
            // 
            // txt4c
            // 
            this.txt4c.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4c.Location = new System.Drawing.Point(508, 3);
            this.txt4c.Name = "txt4c";
            this.txt4c.Size = new System.Drawing.Size(248, 20);
            this.txt4c.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(3, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 3;
            // 
            // txt4b
            // 
            this.txt4b.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4b.Location = new System.Drawing.Point(255, 41);
            this.txt4b.Name = "txt4b";
            this.txt4b.Size = new System.Drawing.Size(247, 20);
            this.txt4b.TabIndex = 4;
            // 
            // txt4d
            // 
            this.txt4d.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4d.Location = new System.Drawing.Point(508, 41);
            this.txt4d.Name = "txt4d";
            this.txt4d.Size = new System.Drawing.Size(248, 20);
            this.txt4d.TabIndex = 5;
            // 
            // txtBornDate
            // 
            this.txtBornDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBornDate.Location = new System.Drawing.Point(3, 79);
            this.txtBornDate.Name = "txtBornDate";
            this.txtBornDate.Size = new System.Drawing.Size(246, 20);
            this.txtBornDate.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt5.Location = new System.Drawing.Point(255, 79);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(247, 20);
            this.txt5.TabIndex = 7;
            // 
            // txt9
            // 
            this.txt9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt9.Location = new System.Drawing.Point(508, 79);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(248, 20);
            this.txt9.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbJson);
            this.Controls.Add(this.rbText);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Google Ocr Demo Ehliyet ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pxImage;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txtBornDate;
        private System.Windows.Forms.TextBox txt4d;
        private System.Windows.Forms.TextBox txt4b;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt4c;
        private System.Windows.Forms.TextBox txt4a;
        private System.Windows.Forms.TextBox txtSurname;
    }
}

