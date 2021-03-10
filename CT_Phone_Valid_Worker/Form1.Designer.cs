namespace CT_Phone_Valid_Worker
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtDebtor = new System.Windows.Forms.TextBox();
            this.lblDebtor = new System.Windows.Forms.Label();
            this.lblRemainingTotalCount = new System.Windows.Forms.Label();
            this.lblRemainingTotal = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(199, 83);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(136, 30);
            this.txtPhone.TabIndex = 23;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(12, 79);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 31);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Phone";
            // 
            // txtDebtor
            // 
            this.txtDebtor.BackColor = System.Drawing.SystemColors.Window;
            this.txtDebtor.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.txtDebtor.Location = new System.Drawing.Point(199, 10);
            this.txtDebtor.Name = "txtDebtor";
            this.txtDebtor.ReadOnly = true;
            this.txtDebtor.Size = new System.Drawing.Size(136, 30);
            this.txtDebtor.TabIndex = 21;
            // 
            // lblDebtor
            // 
            this.lblDebtor.AutoSize = true;
            this.lblDebtor.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblDebtor.Location = new System.Drawing.Point(12, 9);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(96, 31);
            this.lblDebtor.TabIndex = 20;
            this.lblDebtor.Text = "Debtor";
            // 
            // lblRemainingTotalCount
            // 
            this.lblRemainingTotalCount.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTotalCount.Location = new System.Drawing.Point(226, 233);
            this.lblRemainingTotalCount.Name = "lblRemainingTotalCount";
            this.lblRemainingTotalCount.Size = new System.Drawing.Size(133, 31);
            this.lblRemainingTotalCount.TabIndex = 26;
            // 
            // lblRemainingTotal
            // 
            this.lblRemainingTotal.AutoSize = true;
            this.lblRemainingTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblRemainingTotal.Location = new System.Drawing.Point(2, 233);
            this.lblRemainingTotal.Name = "lblRemainingTotal";
            this.lblRemainingTotal.Size = new System.Drawing.Size(218, 31);
            this.lblRemainingTotal.TabIndex = 25;
            this.lblRemainingTotal.Text = "Remaining Total:";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(71, 153);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(187, 60);
            this.btnDone.TabIndex = 24;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(362, 290);
            this.Controls.Add(this.lblRemainingTotalCount);
            this.Controls.Add(this.lblRemainingTotal);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtDebtor);
            this.Controls.Add(this.lblDebtor);
            this.Name = "Form1";
            this.Text = "CT Phone Valid Worker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtDebtor;
        private System.Windows.Forms.Label lblDebtor;
        private System.Windows.Forms.Label lblRemainingTotalCount;
        private System.Windows.Forms.Label lblRemainingTotal;
        private System.Windows.Forms.Button btnDone;
    }
}

