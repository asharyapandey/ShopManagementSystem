namespace frmBBMS
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnItemD = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCustomerD = new System.Windows.Forms.Button();
            this.ttCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 824);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 217);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(159, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "BHAT-BHATENI DASHBOARD";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 217);
            this.panel2.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::frmBBMS.Properties.Resources.Close_2_icon1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(891, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 153);
            this.btnClose.TabIndex = 5;
            this.ttCustomer.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnItemD
            // 
            this.btnItemD.BackgroundImage = global::frmBBMS.Properties.Resources.Add_item_icon;
            this.btnItemD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnItemD.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnItemD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnItemD.Location = new System.Drawing.Point(869, 269);
            this.btnItemD.Name = "btnItemD";
            this.btnItemD.Size = new System.Drawing.Size(192, 182);
            this.btnItemD.TabIndex = 1;
            this.ttCustomer.SetToolTip(this.btnItemD, "Add Items ");
            this.btnItemD.UseVisualStyleBackColor = true;
            this.btnItemD.Click += new System.EventHandler(this.btnItemD_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackgroundImage = global::frmBBMS.Properties.Resources.invoice_icon;
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBill.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(359, 580);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(205, 153);
            this.btnBill.TabIndex = 0;
            this.ttCustomer.SetToolTip(this.btnBill, "Generate Bill");
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCustomerD
            // 
            this.btnCustomerD.BackColor = System.Drawing.Color.DimGray;
            this.btnCustomerD.BackgroundImage = global::frmBBMS.Properties.Resources.Office_Customer_Male_Light_icon;
            this.btnCustomerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomerD.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCustomerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerD.Location = new System.Drawing.Point(359, 276);
            this.btnCustomerD.Name = "btnCustomerD";
            this.btnCustomerD.Size = new System.Drawing.Size(205, 178);
            this.btnCustomerD.TabIndex = 2;
            this.btnCustomerD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttCustomer.SetToolTip(this.btnCustomerD, "Add Customer Details");
            this.btnCustomerD.UseVisualStyleBackColor = false;
            this.btnCustomerD.Click += new System.EventHandler(this.btnCustomerD_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1191, 824);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnItemD);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnCustomerD);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnItemD;
        private System.Windows.Forms.Button btnCustomerD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip ttCustomer;
    }
}