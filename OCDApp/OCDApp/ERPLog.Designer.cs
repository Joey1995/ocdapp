namespace OCDApp
{
    partial class ERPLog
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
            this.dataGrdERPLog = new System.Windows.Forms.DataGridView();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.lblMid = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnAddERPLog = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdERPLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrdERPLog
            // 
            this.dataGrdERPLog.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGrdERPLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdERPLog.Location = new System.Drawing.Point(12, 12);
            this.dataGrdERPLog.Name = "dataGrdERPLog";
            this.dataGrdERPLog.Size = new System.Drawing.Size(547, 155);
            this.dataGrdERPLog.TabIndex = 0;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(12, 183);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(102, 20);
            this.txtStart.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(9, 170);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(120, 183);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(102, 20);
            this.txtMiddle.TabIndex = 3;
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Location = new System.Drawing.Point(120, 170);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(38, 13);
            this.lblMid.TabIndex = 4;
            this.lblMid.Text = "Middle";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(228, 183);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(102, 20);
            this.txtEnd.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(228, 170);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(336, 183);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(207, 20);
            this.txtComments.TabIndex = 7;
            // 
            // btnAddERPLog
            // 
            this.btnAddERPLog.Location = new System.Drawing.Point(350, 218);
            this.btnAddERPLog.Name = "btnAddERPLog";
            this.btnAddERPLog.Size = new System.Drawing.Size(112, 27);
            this.btnAddERPLog.TabIndex = 8;
            this.btnAddERPLog.Text = "Add To Log";
            this.btnAddERPLog.UseVisualStyleBackColor = true;
            this.btnAddERPLog.Click += new System.EventHandler(this.btnAddERPLog_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(336, 170);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Comments";
            // 
            // ERPLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 257);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.btnAddERPLog);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.dataGrdERPLog);
            this.Name = "ERPLog";
            this.Text = "ERPLog";
            this.Load += new System.EventHandler(this.ERPLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdERPLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdERPLog;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnAddERPLog;
        private System.Windows.Forms.Label lblComments;
    }
}