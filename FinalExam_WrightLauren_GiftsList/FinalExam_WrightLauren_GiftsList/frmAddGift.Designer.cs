namespace FinalExam_WrightLauren_GiftsList
{
    partial class frmAddGift
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
            this.lblGiftName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxGiftName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxBudget = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.txtBoxRemaining = new System.Windows.Forms.TextBox();
            this.numUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiftName
            // 
            this.lblGiftName.AutoSize = true;
            this.lblGiftName.Location = new System.Drawing.Point(37, 23);
            this.lblGiftName.Name = "lblGiftName";
            this.lblGiftName.Size = new System.Drawing.Size(54, 13);
            this.lblGiftName.TabIndex = 0;
            this.lblGiftName.Text = "Gift Name";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(37, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(37, 138);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(41, 13);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "Budget";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(37, 101);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(37, 208);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(57, 13);
            this.lblRemaining.TabIndex = 4;
            this.lblRemaining.Text = "Remaining";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxGiftName
            // 
            this.txtBoxGiftName.Location = new System.Drawing.Point(101, 20);
            this.txtBoxGiftName.Name = "txtBoxGiftName";
            this.txtBoxGiftName.Size = new System.Drawing.Size(222, 20);
            this.txtBoxGiftName.TabIndex = 6;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(105, 62);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(124, 20);
            this.txtBoxPrice.TabIndex = 7;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // txtBoxBudget
            // 
            this.txtBoxBudget.Location = new System.Drawing.Point(105, 138);
            this.txtBoxBudget.Name = "txtBoxBudget";
            this.txtBoxBudget.Size = new System.Drawing.Size(124, 20);
            this.txtBoxBudget.TabIndex = 8;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(105, 171);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(124, 20);
            this.txtBoxTotal.TabIndex = 9;
            // 
            // txtBoxRemaining
            // 
            this.txtBoxRemaining.Location = new System.Drawing.Point(105, 201);
            this.txtBoxRemaining.Name = "txtBoxRemaining";
            this.txtBoxRemaining.Size = new System.Drawing.Size(124, 20);
            this.txtBoxRemaining.TabIndex = 10;
            // 
            // numUDQuantity
            // 
            this.numUDQuantity.Location = new System.Drawing.Point(105, 101);
            this.numUDQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantity.Name = "numUDQuantity";
            this.numUDQuantity.Size = new System.Drawing.Size(127, 20);
            this.numUDQuantity.TabIndex = 12;
            this.numUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantity.ValueChanged += new System.EventHandler(this.numUDQuantity_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 29);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddGift
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numUDQuantity);
            this.Controls.Add(this.txtBoxRemaining);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxBudget);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxGiftName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGiftName);
            this.Name = "frmAddGift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Gift";
            this.Load += new System.EventHandler(this.frmAddGift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiftName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxGiftName;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxBudget;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.TextBox txtBoxRemaining;
        private System.Windows.Forms.NumericUpDown numUDQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}