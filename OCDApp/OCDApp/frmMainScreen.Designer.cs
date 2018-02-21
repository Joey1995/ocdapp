namespace OCDApp
{
    partial class frmMainScreen
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
            this.btnERP = new System.Windows.Forms.Button();
            this.btnIntThghts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnERP
            // 
            this.btnERP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERP.Location = new System.Drawing.Point(1, 2);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(83, 28);
            this.btnERP.TabIndex = 0;
            this.btnERP.Text = "ERP Log";
            this.btnERP.UseVisualStyleBackColor = true;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click);
            // 
            // btnIntThghts
            // 
            this.btnIntThghts.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntThghts.Location = new System.Drawing.Point(90, 2);
            this.btnIntThghts.Name = "btnIntThghts";
            this.btnIntThghts.Size = new System.Drawing.Size(123, 28);
            this.btnIntThghts.TabIndex = 1;
            this.btnIntThghts.Text = "Intrusive Thoughts";
            this.btnIntThghts.UseVisualStyleBackColor = true;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 265);
            this.Controls.Add(this.btnIntThghts);
            this.Controls.Add(this.btnERP);
            this.Name = "frmMainScreen";
            this.Text = "OCD Exposure and response prevention";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Button btnIntThghts;
    }
}

