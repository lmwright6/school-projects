namespace PokemonStatConverter
{
    partial class frmMain
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
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.InputLbl = new System.Windows.Forms.Label();
            this.ConvertedLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.ConvWeightLbl = new System.Windows.Forms.Label();
            this.WeightClassLbl = new System.Windows.Forms.Label();
            this.ConvHeightLbl = new System.Windows.Forms.Label();
            this.HeightClassLbl = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.WeightTxtBox = new System.Windows.Forms.TextBox();
            this.HeightTxtBox = new System.Windows.Forms.TextBox();
            this.ConvWeightTxtBox = new System.Windows.Forms.TextBox();
            this.WeightClassTxtBox = new System.Windows.Forms.TextBox();
            this.ConvHeightTxtBox = new System.Windows.Forms.TextBox();
            this.HeightClassTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertBtn.Enabled = false;
            this.ConvertBtn.Location = new System.Drawing.Point(367, 474);
            this.ConvertBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(100, 27);
            this.ConvertBtn.TabIndex = 0;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.Convert_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(502, 474);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(102, 25);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.clickCloseBtn);
            // 
            // InputLbl
            // 
            this.InputLbl.AutoSize = true;
            this.InputLbl.Location = new System.Drawing.Point(42, 30);
            this.InputLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputLbl.Name = "InputLbl";
            this.InputLbl.Size = new System.Drawing.Size(39, 15);
            this.InputLbl.TabIndex = 2;
            this.InputLbl.Text = "Input";
            // 
            // ConvertedLbl
            // 
            this.ConvertedLbl.AutoSize = true;
            this.ConvertedLbl.Location = new System.Drawing.Point(42, 243);
            this.ConvertedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConvertedLbl.Name = "ConvertedLbl";
            this.ConvertedLbl.Size = new System.Drawing.Size(71, 15);
            this.ConvertedLbl.TabIndex = 3;
            this.ConvertedLbl.Text = "Converted";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(168, 30);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 15);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Name";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(168, 77);
            this.WeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(80, 15);
            this.WeightLbl.TabIndex = 5;
            this.WeightLbl.Text = "Weight (kg)";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(168, 137);
            this.HeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(75, 15);
            this.HeightLbl.TabIndex = 6;
            this.HeightLbl.Text = "Height (m)";
            // 
            // ConvWeightLbl
            // 
            this.ConvWeightLbl.AutoSize = true;
            this.ConvWeightLbl.Location = new System.Drawing.Point(170, 243);
            this.ConvWeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConvWeightLbl.Name = "ConvWeightLbl";
            this.ConvWeightLbl.Size = new System.Drawing.Size(80, 15);
            this.ConvWeightLbl.TabIndex = 7;
            this.ConvWeightLbl.Text = "Weight (oz)";
            // 
            // WeightClassLbl
            // 
            this.WeightClassLbl.AutoSize = true;
            this.WeightClassLbl.Location = new System.Drawing.Point(170, 297);
            this.WeightClassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightClassLbl.Name = "WeightClassLbl";
            this.WeightClassLbl.Size = new System.Drawing.Size(90, 15);
            this.WeightClassLbl.TabIndex = 8;
            this.WeightClassLbl.Text = "Weight Class";
            // 
            // ConvHeightLbl
            // 
            this.ConvHeightLbl.AutoSize = true;
            this.ConvHeightLbl.Location = new System.Drawing.Point(168, 355);
            this.ConvHeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConvHeightLbl.Name = "ConvHeightLbl";
            this.ConvHeightLbl.Size = new System.Drawing.Size(75, 15);
            this.ConvHeightLbl.TabIndex = 9;
            this.ConvHeightLbl.Text = "Height (in)";
            // 
            // HeightClassLbl
            // 
            this.HeightClassLbl.AutoSize = true;
            this.HeightClassLbl.Location = new System.Drawing.Point(168, 419);
            this.HeightClassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightClassLbl.Name = "HeightClassLbl";
            this.HeightClassLbl.Size = new System.Drawing.Size(88, 15);
            this.HeightClassLbl.TabIndex = 10;
            this.HeightClassLbl.Text = "Height Class";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(292, 22);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(312, 21);
            this.NameTxtBox.TabIndex = 11;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NameTxtBox_TextChanged);
            // 
            // WeightTxtBox
            // 
            this.WeightTxtBox.Enabled = false;
            this.WeightTxtBox.Location = new System.Drawing.Point(292, 69);
            this.WeightTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WeightTxtBox.Name = "WeightTxtBox";
            this.WeightTxtBox.Size = new System.Drawing.Size(312, 21);
            this.WeightTxtBox.TabIndex = 12;
            // 
            // HeightTxtBox
            // 
            this.HeightTxtBox.Enabled = false;
            this.HeightTxtBox.Location = new System.Drawing.Point(292, 129);
            this.HeightTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HeightTxtBox.Name = "HeightTxtBox";
            this.HeightTxtBox.Size = new System.Drawing.Size(312, 21);
            this.HeightTxtBox.TabIndex = 13;
            // 
            // ConvWeightTxtBox
            // 
            this.ConvWeightTxtBox.Enabled = false;
            this.ConvWeightTxtBox.Location = new System.Drawing.Point(292, 243);
            this.ConvWeightTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConvWeightTxtBox.Name = "ConvWeightTxtBox";
            this.ConvWeightTxtBox.Size = new System.Drawing.Size(312, 21);
            this.ConvWeightTxtBox.TabIndex = 14;
            // 
            // WeightClassTxtBox
            // 
            this.WeightClassTxtBox.Enabled = false;
            this.WeightClassTxtBox.Location = new System.Drawing.Point(292, 291);
            this.WeightClassTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WeightClassTxtBox.Name = "WeightClassTxtBox";
            this.WeightClassTxtBox.Size = new System.Drawing.Size(312, 21);
            this.WeightClassTxtBox.TabIndex = 15;
            // 
            // ConvHeightTxtBox
            // 
            this.ConvHeightTxtBox.Enabled = false;
            this.ConvHeightTxtBox.Location = new System.Drawing.Point(292, 347);
            this.ConvHeightTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConvHeightTxtBox.Name = "ConvHeightTxtBox";
            this.ConvHeightTxtBox.Size = new System.Drawing.Size(312, 21);
            this.ConvHeightTxtBox.TabIndex = 16;
            // 
            // HeightClassTxtBox
            // 
            this.HeightClassTxtBox.Enabled = false;
            this.HeightClassTxtBox.Location = new System.Drawing.Point(292, 419);
            this.HeightClassTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HeightClassTxtBox.Name = "HeightClassTxtBox";
            this.HeightClassTxtBox.Size = new System.Drawing.Size(312, 21);
            this.HeightClassTxtBox.TabIndex = 17;
            // 
            // frmMain
            // 
            this.AcceptButton = this.ConvertBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(646, 517);
            this.Controls.Add(this.HeightClassTxtBox);
            this.Controls.Add(this.ConvHeightTxtBox);
            this.Controls.Add(this.WeightClassTxtBox);
            this.Controls.Add(this.ConvWeightTxtBox);
            this.Controls.Add(this.HeightTxtBox);
            this.Controls.Add(this.WeightTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.HeightClassLbl);
            this.Controls.Add(this.ConvHeightLbl);
            this.Controls.Add(this.WeightClassLbl);
            this.Controls.Add(this.ConvWeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.ConvertedLbl);
            this.Controls.Add(this.InputLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Stat Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label InputLbl;
        private System.Windows.Forms.Label ConvertedLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.Label ConvWeightLbl;
        private System.Windows.Forms.Label WeightClassLbl;
        private System.Windows.Forms.Label ConvHeightLbl;
        private System.Windows.Forms.Label HeightClassLbl;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox WeightTxtBox;
        private System.Windows.Forms.TextBox HeightTxtBox;
        private System.Windows.Forms.TextBox ConvWeightTxtBox;
        private System.Windows.Forms.TextBox WeightClassTxtBox;
        private System.Windows.Forms.TextBox ConvHeightTxtBox;
        private System.Windows.Forms.TextBox HeightClassTxtBox;
    }
}

