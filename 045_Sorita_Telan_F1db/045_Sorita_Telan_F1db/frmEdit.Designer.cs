namespace _045_Sorita_Telan_F1db
{
    partial class frmEdit
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
            this.btnUpCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUpBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpPrice = new System.Windows.Forms.TextBox();
            this.txtUpModelDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpCancel
            // 
            this.btnUpCancel.Location = new System.Drawing.Point(170, 255);
            this.btnUpCancel.Name = "btnUpCancel";
            this.btnUpCancel.Size = new System.Drawing.Size(96, 33);
            this.btnUpCancel.TabIndex = 15;
            this.btnUpCancel.Text = "Cancel";
            this.btnUpCancel.UseVisualStyleBackColor = true;
            this.btnUpCancel.Click += new System.EventHandler(this.btnUpCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(46, 255);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 33);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Brand";
            // 
            // cboUpBrand
            // 
            this.cboUpBrand.FormattingEnabled = true;
            this.cboUpBrand.Location = new System.Drawing.Point(46, 213);
            this.cboUpBrand.Name = "cboUpBrand";
            this.cboUpBrand.Size = new System.Drawing.Size(230, 21);
            this.cboUpBrand.TabIndex = 12;
            this.cboUpBrand.SelectedIndexChanged += new System.EventHandler(this.cboUpBrand_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model Description";
            // 
            // txtUpPrice
            // 
            this.txtUpPrice.Location = new System.Drawing.Point(46, 136);
            this.txtUpPrice.Name = "txtUpPrice";
            this.txtUpPrice.Size = new System.Drawing.Size(230, 20);
            this.txtUpPrice.TabIndex = 9;
            // 
            // txtUpModelDesc
            // 
            this.txtUpModelDesc.Location = new System.Drawing.Point(46, 68);
            this.txtUpModelDesc.Name = "txtUpModelDesc";
            this.txtUpModelDesc.Size = new System.Drawing.Size(230, 20);
            this.txtUpModelDesc.TabIndex = 8;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 415);
            this.Controls.Add(this.btnUpCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboUpBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpPrice);
            this.Controls.Add(this.txtUpModelDesc);
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUpBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpPrice;
        private System.Windows.Forms.TextBox txtUpModelDesc;
    }
}