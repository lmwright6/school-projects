namespace FinalExam_WrightLauren_GiftsList
{
    partial class frmShoppingList
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
            this.txtBoxShoppingList = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxShoppingList
            // 
            this.txtBoxShoppingList.Location = new System.Drawing.Point(20, 16);
            this.txtBoxShoppingList.Multiline = true;
            this.txtBoxShoppingList.Name = "txtBoxShoppingList";
            this.txtBoxShoppingList.ReadOnly = true;
            this.txtBoxShoppingList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxShoppingList.Size = new System.Drawing.Size(370, 294);
            this.txtBoxShoppingList.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(329, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(433, 355);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBoxShoppingList);
            this.Name = "frmShoppingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gift List";
            this.Load += new System.EventHandler(this.frmShoppingList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxShoppingList;
        private System.Windows.Forms.Button btnClose;
    }
}