namespace FinalExam_WrightLauren_GiftsList
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.dgvGifts = new System.Windows.Forms.DataGridView();
            this.btnPersonAdd = new System.Windows.Forms.Button();
            this.btnPersonUpdate = new System.Windows.Forms.Button();
            this.btnPersonRemove = new System.Windows.Forms.Button();
            this.btnGiftAdd = new System.Windows.Forms.Button();
            this.btnGiftRemove = new System.Windows.Forms.Button();
            this.btnGiftPrint = new System.Windows.Forms.Button();
            this.btnDataFill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblGiftName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPersonBudget = new System.Windows.Forms.Label();
            this.lblPersonRel = new System.Windows.Forms.Label();
            this.txtBoxPersonName = new System.Windows.Forms.TextBox();
            this.txtBoxRemaining = new System.Windows.Forms.TextBox();
            this.txtBoxGiftName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxPersonRel = new System.Windows.Forms.TextBox();
            this.txtBoxPersonBudget = new System.Windows.Forms.TextBox();
            this.txtBoxTarget = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.gBoxBudget = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).BeginInit();
            this.gBoxBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(17, 19);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(262, 205);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.SelectionChanged += new System.EventHandler(this.dgvPeople_SelectionChanged);
            // 
            // dgvGifts
            // 
            this.dgvGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGifts.Location = new System.Drawing.Point(335, 19);
            this.dgvGifts.Name = "dgvGifts";
            this.dgvGifts.Size = new System.Drawing.Size(440, 205);
            this.dgvGifts.TabIndex = 1;
            this.dgvGifts.SelectionChanged += new System.EventHandler(this.dgvGifts_SelectionChanged);
            // 
            // btnPersonAdd
            // 
            this.btnPersonAdd.Location = new System.Drawing.Point(17, 230);
            this.btnPersonAdd.Name = "btnPersonAdd";
            this.btnPersonAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPersonAdd.TabIndex = 2;
            this.btnPersonAdd.Text = "Add";
            this.btnPersonAdd.UseVisualStyleBackColor = true;
            this.btnPersonAdd.Click += new System.EventHandler(this.btnPersonAdd_Click);
            // 
            // btnPersonUpdate
            // 
            this.btnPersonUpdate.Location = new System.Drawing.Point(179, 230);
            this.btnPersonUpdate.Name = "btnPersonUpdate";
            this.btnPersonUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPersonUpdate.TabIndex = 3;
            this.btnPersonUpdate.Text = "Update";
            this.btnPersonUpdate.UseVisualStyleBackColor = true;
            this.btnPersonUpdate.Click += new System.EventHandler(this.btnPersonUpdate_Click);
            // 
            // btnPersonRemove
            // 
            this.btnPersonRemove.Location = new System.Drawing.Point(98, 230);
            this.btnPersonRemove.Name = "btnPersonRemove";
            this.btnPersonRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPersonRemove.TabIndex = 4;
            this.btnPersonRemove.Text = "Remove";
            this.btnPersonRemove.UseVisualStyleBackColor = true;
            this.btnPersonRemove.Click += new System.EventHandler(this.btnPersonRemove_Click);
            // 
            // btnGiftAdd
            // 
            this.btnGiftAdd.Location = new System.Drawing.Point(335, 230);
            this.btnGiftAdd.Name = "btnGiftAdd";
            this.btnGiftAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGiftAdd.TabIndex = 5;
            this.btnGiftAdd.Text = "Add";
            this.btnGiftAdd.UseVisualStyleBackColor = true;
            this.btnGiftAdd.Click += new System.EventHandler(this.btnGiftAdd_Click);
            // 
            // btnGiftRemove
            // 
            this.btnGiftRemove.Location = new System.Drawing.Point(419, 230);
            this.btnGiftRemove.Name = "btnGiftRemove";
            this.btnGiftRemove.Size = new System.Drawing.Size(75, 23);
            this.btnGiftRemove.TabIndex = 6;
            this.btnGiftRemove.Text = "Remove";
            this.btnGiftRemove.UseVisualStyleBackColor = true;
            this.btnGiftRemove.Click += new System.EventHandler(this.btnGiftRemove_Click);
            // 
            // btnGiftPrint
            // 
            this.btnGiftPrint.Location = new System.Drawing.Point(500, 230);
            this.btnGiftPrint.Name = "btnGiftPrint";
            this.btnGiftPrint.Size = new System.Drawing.Size(75, 23);
            this.btnGiftPrint.TabIndex = 7;
            this.btnGiftPrint.Text = "Print";
            this.btnGiftPrint.UseVisualStyleBackColor = true;
            this.btnGiftPrint.Click += new System.EventHandler(this.btnGiftPrint_Click);
            // 
            // btnDataFill
            // 
            this.btnDataFill.Location = new System.Drawing.Point(672, 378);
            this.btnDataFill.Name = "btnDataFill";
            this.btnDataFill.Size = new System.Drawing.Size(75, 23);
            this.btnDataFill.TabIndex = 8;
            this.btnDataFill.Text = "Data Fill";
            this.btnDataFill.UseVisualStyleBackColor = true;
            this.btnDataFill.Click += new System.EventHandler(this.btnDataFill_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(763, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(14, 272);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(35, 13);
            this.lblPersonName.TabIndex = 10;
            this.lblPersonName.Text = "Name";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(26, 22);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(38, 13);
            this.lblTarget.TabIndex = 11;
            this.lblTarget.Text = "Target";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(26, 84);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(57, 13);
            this.lblRemaining.TabIndex = 13;
            this.lblRemaining.Text = "Remaining";
            // 
            // lblGiftName
            // 
            this.lblGiftName.AutoSize = true;
            this.lblGiftName.Location = new System.Drawing.Point(345, 272);
            this.lblGiftName.Name = "lblGiftName";
            this.lblGiftName.Size = new System.Drawing.Size(54, 13);
            this.lblGiftName.TabIndex = 14;
            this.lblGiftName.Text = "Gift Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(345, 302);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(345, 334);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPersonBudget
            // 
            this.lblPersonBudget.AutoSize = true;
            this.lblPersonBudget.Location = new System.Drawing.Point(14, 334);
            this.lblPersonBudget.Name = "lblPersonBudget";
            this.lblPersonBudget.Size = new System.Drawing.Size(41, 13);
            this.lblPersonBudget.TabIndex = 17;
            this.lblPersonBudget.Text = "Budget";
            // 
            // lblPersonRel
            // 
            this.lblPersonRel.AutoSize = true;
            this.lblPersonRel.Location = new System.Drawing.Point(14, 302);
            this.lblPersonRel.Name = "lblPersonRel";
            this.lblPersonRel.Size = new System.Drawing.Size(65, 13);
            this.lblPersonRel.TabIndex = 18;
            this.lblPersonRel.Text = "Relationship";
            // 
            // txtBoxPersonName
            // 
            this.txtBoxPersonName.Enabled = false;
            this.txtBoxPersonName.Location = new System.Drawing.Point(98, 272);
            this.txtBoxPersonName.Name = "txtBoxPersonName";
            this.txtBoxPersonName.Size = new System.Drawing.Size(154, 20);
            this.txtBoxPersonName.TabIndex = 19;
            // 
            // txtBoxRemaining
            // 
            this.txtBoxRemaining.Location = new System.Drawing.Point(89, 81);
            this.txtBoxRemaining.Name = "txtBoxRemaining";
            this.txtBoxRemaining.Size = new System.Drawing.Size(99, 20);
            this.txtBoxRemaining.TabIndex = 22;
            // 
            // txtBoxGiftName
            // 
            this.txtBoxGiftName.Location = new System.Drawing.Point(419, 269);
            this.txtBoxGiftName.Name = "txtBoxGiftName";
            this.txtBoxGiftName.Size = new System.Drawing.Size(154, 20);
            this.txtBoxGiftName.TabIndex = 23;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(419, 299);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(154, 20);
            this.txtBoxPrice.TabIndex = 24;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(419, 334);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(154, 20);
            this.txtBoxQuantity.TabIndex = 25;
            // 
            // txtBoxPersonRel
            // 
            this.txtBoxPersonRel.Enabled = false;
            this.txtBoxPersonRel.Location = new System.Drawing.Point(98, 301);
            this.txtBoxPersonRel.Name = "txtBoxPersonRel";
            this.txtBoxPersonRel.Size = new System.Drawing.Size(154, 20);
            this.txtBoxPersonRel.TabIndex = 26;
            // 
            // txtBoxPersonBudget
            // 
            this.txtBoxPersonBudget.Location = new System.Drawing.Point(98, 327);
            this.txtBoxPersonBudget.Name = "txtBoxPersonBudget";
            this.txtBoxPersonBudget.Size = new System.Drawing.Size(154, 20);
            this.txtBoxPersonBudget.TabIndex = 27;
            // 
            // txtBoxTarget
            // 
            this.txtBoxTarget.Location = new System.Drawing.Point(89, 19);
            this.txtBoxTarget.Name = "txtBoxTarget";
            this.txtBoxTarget.Size = new System.Drawing.Size(99, 20);
            this.txtBoxTarget.TabIndex = 28;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(89, 52);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(99, 20);
            this.txtBoxTotal.TabIndex = 29;
            // 
            // gBoxBudget
            // 
            this.gBoxBudget.Controls.Add(this.txtBoxTotal);
            this.gBoxBudget.Controls.Add(this.txtBoxTarget);
            this.gBoxBudget.Controls.Add(this.txtBoxRemaining);
            this.gBoxBudget.Controls.Add(this.lblRemaining);
            this.gBoxBudget.Controls.Add(this.lblTotal);
            this.gBoxBudget.Controls.Add(this.lblTarget);
            this.gBoxBudget.Location = new System.Drawing.Point(643, 250);
            this.gBoxBudget.Name = "gBoxBudget";
            this.gBoxBudget.Size = new System.Drawing.Size(194, 115);
            this.gBoxBudget.TabIndex = 30;
            this.gBoxBudget.TabStop = false;
            this.gBoxBudget.Text = "Budget";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(863, 413);
            this.Controls.Add(this.gBoxBudget);
            this.Controls.Add(this.txtBoxPersonBudget);
            this.Controls.Add(this.txtBoxPersonRel);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxGiftName);
            this.Controls.Add(this.txtBoxPersonName);
            this.Controls.Add(this.lblPersonRel);
            this.Controls.Add(this.lblPersonBudget);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGiftName);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDataFill);
            this.Controls.Add(this.btnGiftPrint);
            this.Controls.Add(this.btnGiftRemove);
            this.Controls.Add(this.btnGiftAdd);
            this.Controls.Add(this.btnPersonRemove);
            this.Controls.Add(this.btnPersonUpdate);
            this.Controls.Add(this.btnPersonAdd);
            this.Controls.Add(this.dgvGifts);
            this.Controls.Add(this.dgvPeople);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainLaurenWright";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).EndInit();
            this.gBoxBudget.ResumeLayout(false);
            this.gBoxBudget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridView dgvGifts;
        private System.Windows.Forms.Button btnPersonAdd;
        private System.Windows.Forms.Button btnPersonUpdate;
        private System.Windows.Forms.Button btnPersonRemove;
        private System.Windows.Forms.Button btnGiftAdd;
        private System.Windows.Forms.Button btnGiftRemove;
        private System.Windows.Forms.Button btnGiftPrint;
        private System.Windows.Forms.Button btnDataFill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblGiftName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPersonBudget;
        private System.Windows.Forms.Label lblPersonRel;
        private System.Windows.Forms.TextBox txtBoxPersonName;
        private System.Windows.Forms.TextBox txtBoxRemaining;
        private System.Windows.Forms.TextBox txtBoxGiftName;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.TextBox txtBoxPersonRel;
        private System.Windows.Forms.TextBox txtBoxPersonBudget;
        private System.Windows.Forms.TextBox txtBoxTarget;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.GroupBox gBoxBudget;
    }
}

