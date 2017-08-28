namespace PA5_WrightLauren_PokeDexWithClasses
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
            this.PokeDexDgv = new System.Windows.Forms.DataGridView();
            this.PokeDexLbl = new System.Windows.Forms.Label();
            this.NameBtn = new System.Windows.Forms.Button();
            this.HPBtn = new System.Windows.Forms.Button();
            this.TypeBtn = new System.Windows.Forms.Button();
            this.WeightBtn = new System.Windows.Forms.Button();
            this.HeightBtn = new System.Windows.Forms.Button();
            this.SortByGrpBx = new System.Windows.Forms.GroupBox();
            this.NameRBtn = new System.Windows.Forms.RadioButton();
            this.HPRBtn = new System.Windows.Forms.RadioButton();
            this.TypeRBtn = new System.Windows.Forms.RadioButton();
            this.WeightRBtn = new System.Windows.Forms.RadioButton();
            this.HeightRBtn = new System.Windows.Forms.RadioButton();
            this.CurrentSortGrBox = new System.Windows.Forms.GroupBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.HPLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.HeightTxtBox = new System.Windows.Forms.TextBox();
            this.WeightTxtBox = new System.Windows.Forms.TextBox();
            this.TypeTxtBox = new System.Windows.Forms.TextBox();
            this.HPTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataFillBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.numPokemonLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PokeDexDgv)).BeginInit();
            this.SortByGrpBx.SuspendLayout();
            this.CurrentSortGrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PokeDexDgv
            // 
            this.PokeDexDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokeDexDgv.Location = new System.Drawing.Point(22, 38);
            this.PokeDexDgv.Name = "PokeDexDgv";
            this.PokeDexDgv.ReadOnly = true;
            this.PokeDexDgv.Size = new System.Drawing.Size(588, 188);
            this.PokeDexDgv.TabIndex = 0;
            this.PokeDexDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PokeDexDgv_CellClick);
            // 
            // PokeDexLbl
            // 
            this.PokeDexLbl.AutoSize = true;
            this.PokeDexLbl.Location = new System.Drawing.Point(19, 22);
            this.PokeDexLbl.Name = "PokeDexLbl";
            this.PokeDexLbl.Size = new System.Drawing.Size(49, 13);
            this.PokeDexLbl.TabIndex = 1;
            this.PokeDexLbl.Text = "PokeDex";
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(12, 14);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(75, 23);
            this.NameBtn.TabIndex = 2;
            this.NameBtn.Text = "Name";
            this.NameBtn.UseVisualStyleBackColor = true;
            this.NameBtn.Click += new System.EventHandler(this.NameBtn_Click);
            // 
            // HPBtn
            // 
            this.HPBtn.Location = new System.Drawing.Point(12, 43);
            this.HPBtn.Name = "HPBtn";
            this.HPBtn.Size = new System.Drawing.Size(75, 23);
            this.HPBtn.TabIndex = 3;
            this.HPBtn.Text = "HP";
            this.HPBtn.UseVisualStyleBackColor = true;
            this.HPBtn.Click += new System.EventHandler(this.HPBtn_Click);
            // 
            // TypeBtn
            // 
            this.TypeBtn.Location = new System.Drawing.Point(12, 72);
            this.TypeBtn.Name = "TypeBtn";
            this.TypeBtn.Size = new System.Drawing.Size(75, 23);
            this.TypeBtn.TabIndex = 4;
            this.TypeBtn.Text = "Type";
            this.TypeBtn.UseVisualStyleBackColor = true;
            this.TypeBtn.Click += new System.EventHandler(this.TypeBtn_Click);
            // 
            // WeightBtn
            // 
            this.WeightBtn.Location = new System.Drawing.Point(93, 14);
            this.WeightBtn.Name = "WeightBtn";
            this.WeightBtn.Size = new System.Drawing.Size(75, 23);
            this.WeightBtn.TabIndex = 5;
            this.WeightBtn.Text = "Weight";
            this.WeightBtn.UseVisualStyleBackColor = true;
            this.WeightBtn.Click += new System.EventHandler(this.WeightBtn_Click);
            // 
            // HeightBtn
            // 
            this.HeightBtn.Location = new System.Drawing.Point(93, 43);
            this.HeightBtn.Name = "HeightBtn";
            this.HeightBtn.Size = new System.Drawing.Size(75, 23);
            this.HeightBtn.TabIndex = 6;
            this.HeightBtn.Text = "Height";
            this.HeightBtn.UseVisualStyleBackColor = true;
            this.HeightBtn.Click += new System.EventHandler(this.HeightBtn_Click);
            // 
            // SortByGrpBx
            // 
            this.SortByGrpBx.Controls.Add(this.HeightBtn);
            this.SortByGrpBx.Controls.Add(this.WeightBtn);
            this.SortByGrpBx.Controls.Add(this.TypeBtn);
            this.SortByGrpBx.Controls.Add(this.HPBtn);
            this.SortByGrpBx.Controls.Add(this.NameBtn);
            this.SortByGrpBx.Location = new System.Drawing.Point(616, 22);
            this.SortByGrpBx.Name = "SortByGrpBx";
            this.SortByGrpBx.Size = new System.Drawing.Size(182, 113);
            this.SortByGrpBx.TabIndex = 7;
            this.SortByGrpBx.TabStop = false;
            this.SortByGrpBx.Text = "Sort By";
            // 
            // NameRBtn
            // 
            this.NameRBtn.AutoSize = true;
            this.NameRBtn.Location = new System.Drawing.Point(12, 33);
            this.NameRBtn.Name = "NameRBtn";
            this.NameRBtn.Size = new System.Drawing.Size(52, 17);
            this.NameRBtn.TabIndex = 8;
            this.NameRBtn.TabStop = true;
            this.NameRBtn.Text = "Name";
            this.NameRBtn.UseVisualStyleBackColor = true;
            // 
            // HPRBtn
            // 
            this.HPRBtn.AutoSize = true;
            this.HPRBtn.Location = new System.Drawing.Point(12, 56);
            this.HPRBtn.Name = "HPRBtn";
            this.HPRBtn.Size = new System.Drawing.Size(38, 17);
            this.HPRBtn.TabIndex = 9;
            this.HPRBtn.TabStop = true;
            this.HPRBtn.Text = "HP";
            this.HPRBtn.UseVisualStyleBackColor = true;
            // 
            // TypeRBtn
            // 
            this.TypeRBtn.AutoSize = true;
            this.TypeRBtn.Location = new System.Drawing.Point(12, 79);
            this.TypeRBtn.Name = "TypeRBtn";
            this.TypeRBtn.Size = new System.Drawing.Size(49, 17);
            this.TypeRBtn.TabIndex = 10;
            this.TypeRBtn.TabStop = true;
            this.TypeRBtn.Text = "Type";
            this.TypeRBtn.UseVisualStyleBackColor = true;
            // 
            // WeightRBtn
            // 
            this.WeightRBtn.AutoSize = true;
            this.WeightRBtn.Location = new System.Drawing.Point(12, 102);
            this.WeightRBtn.Name = "WeightRBtn";
            this.WeightRBtn.Size = new System.Drawing.Size(59, 17);
            this.WeightRBtn.TabIndex = 11;
            this.WeightRBtn.TabStop = true;
            this.WeightRBtn.Text = "Weight";
            this.WeightRBtn.UseVisualStyleBackColor = true;
            // 
            // HeightRBtn
            // 
            this.HeightRBtn.AutoSize = true;
            this.HeightRBtn.Location = new System.Drawing.Point(12, 125);
            this.HeightRBtn.Name = "HeightRBtn";
            this.HeightRBtn.Size = new System.Drawing.Size(56, 17);
            this.HeightRBtn.TabIndex = 12;
            this.HeightRBtn.TabStop = true;
            this.HeightRBtn.Text = "Height";
            this.HeightRBtn.UseVisualStyleBackColor = true;
            // 
            // CurrentSortGrBox
            // 
            this.CurrentSortGrBox.Controls.Add(this.HeightRBtn);
            this.CurrentSortGrBox.Controls.Add(this.WeightRBtn);
            this.CurrentSortGrBox.Controls.Add(this.TypeRBtn);
            this.CurrentSortGrBox.Controls.Add(this.HPRBtn);
            this.CurrentSortGrBox.Controls.Add(this.NameRBtn);
            this.CurrentSortGrBox.Location = new System.Drawing.Point(617, 149);
            this.CurrentSortGrBox.Name = "CurrentSortGrBox";
            this.CurrentSortGrBox.Size = new System.Drawing.Size(181, 162);
            this.CurrentSortGrBox.TabIndex = 13;
            this.CurrentSortGrBox.TabStop = false;
            this.CurrentSortGrBox.Text = "Current Sort";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(30, 19);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(34, 13);
            this.NameLbl.TabIndex = 14;
            this.NameLbl.Text = "Name";
            // 
            // HPLbl
            // 
            this.HPLbl.AutoSize = true;
            this.HPLbl.Location = new System.Drawing.Point(30, 53);
            this.HPLbl.Name = "HPLbl";
            this.HPLbl.Size = new System.Drawing.Size(20, 13);
            this.HPLbl.TabIndex = 15;
            this.HPLbl.Text = "HP";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(30, 87);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(31, 13);
            this.TypeLbl.TabIndex = 16;
            this.TypeLbl.Text = "Type";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(30, 122);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(41, 13);
            this.WeightLbl.TabIndex = 17;
            this.WeightLbl.Text = "Weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(30, 154);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(38, 13);
            this.HeightLbl.TabIndex = 18;
            this.HeightLbl.Text = "Height";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(148, 12);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 21);
            this.NameTxtBox.TabIndex = 19;
            // 
            // HeightTxtBox
            // 
            this.HeightTxtBox.Location = new System.Drawing.Point(148, 147);
            this.HeightTxtBox.Name = "HeightTxtBox";
            this.HeightTxtBox.Size = new System.Drawing.Size(100, 21);
            this.HeightTxtBox.TabIndex = 20;
            // 
            // WeightTxtBox
            // 
            this.WeightTxtBox.Location = new System.Drawing.Point(148, 115);
            this.WeightTxtBox.Name = "WeightTxtBox";
            this.WeightTxtBox.Size = new System.Drawing.Size(100, 21);
            this.WeightTxtBox.TabIndex = 21;
            // 
            // TypeTxtBox
            // 
            this.TypeTxtBox.Location = new System.Drawing.Point(148, 80);
            this.TypeTxtBox.Name = "TypeTxtBox";
            this.TypeTxtBox.Size = new System.Drawing.Size(100, 21);
            this.TypeTxtBox.TabIndex = 22;
            // 
            // HPTxtBox
            // 
            this.HPTxtBox.Location = new System.Drawing.Point(148, 46);
            this.HPTxtBox.Name = "HPTxtBox";
            this.HPTxtBox.Size = new System.Drawing.Size(100, 21);
            this.HPTxtBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HPTxtBox);
            this.groupBox1.Controls.Add(this.TypeTxtBox);
            this.groupBox1.Controls.Add(this.WeightTxtBox);
            this.groupBox1.Controls.Add(this.HeightTxtBox);
            this.groupBox1.Controls.Add(this.NameTxtBox);
            this.groupBox1.Controls.Add(this.HeightLbl);
            this.groupBox1.Controls.Add(this.WeightLbl);
            this.groupBox1.Controls.Add(this.TypeLbl);
            this.groupBox1.Controls.Add(this.HPLbl);
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Location = new System.Drawing.Point(27, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 177);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // DataFillBtn
            // 
            this.DataFillBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DataFillBtn.Location = new System.Drawing.Point(535, 435);
            this.DataFillBtn.Name = "DataFillBtn";
            this.DataFillBtn.Size = new System.Drawing.Size(75, 23);
            this.DataFillBtn.TabIndex = 25;
            this.DataFillBtn.Text = "Data Fill";
            this.DataFillBtn.UseVisualStyleBackColor = true;
            this.DataFillBtn.Click += new System.EventHandler(this.DataFillBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.AutoSize = true;
            this.AddBtn.Location = new System.Drawing.Point(632, 435);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 26;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(732, 435);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 27;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // numPokemonLbl
            // 
            this.numPokemonLbl.AutoSize = true;
            this.numPokemonLbl.Location = new System.Drawing.Point(24, 445);
            this.numPokemonLbl.Name = "numPokemonLbl";
            this.numPokemonLbl.Size = new System.Drawing.Size(147, 13);
            this.numPokemonLbl.TabIndex = 28;
            this.numPokemonLbl.Text = "PokeDex contains 0 Pokemon";
            // 
            // frmMain
            // 
            this.AcceptButton = this.AddBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(819, 470);
            this.Controls.Add(this.numPokemonLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DataFillBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentSortGrBox);
            this.Controls.Add(this.SortByGrpBx);
            this.Controls.Add(this.PokeDexLbl);
            this.Controls.Add(this.PokeDexDgv);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PA5 Wright Lauren PokeDex";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokeDexDgv)).EndInit();
            this.SortByGrpBx.ResumeLayout(false);
            this.CurrentSortGrBox.ResumeLayout(false);
            this.CurrentSortGrBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PokeDexDgv;
        private System.Windows.Forms.Label PokeDexLbl;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.Button HPBtn;
        private System.Windows.Forms.Button TypeBtn;
        private System.Windows.Forms.Button WeightBtn;
        private System.Windows.Forms.Button HeightBtn;
        private System.Windows.Forms.GroupBox SortByGrpBx;
        private System.Windows.Forms.RadioButton NameRBtn;
        private System.Windows.Forms.RadioButton HPRBtn;
        private System.Windows.Forms.RadioButton TypeRBtn;
        private System.Windows.Forms.RadioButton WeightRBtn;
        private System.Windows.Forms.RadioButton HeightRBtn;
        private System.Windows.Forms.GroupBox CurrentSortGrBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label HPLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox HeightTxtBox;
        private System.Windows.Forms.TextBox WeightTxtBox;
        private System.Windows.Forms.TextBox TypeTxtBox;
        private System.Windows.Forms.TextBox HPTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DataFillBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label numPokemonLbl;
    }
}

