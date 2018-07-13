namespace OLT_Control
{
    partial class frmZTENoAvailablePort
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
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.rtxtLogInfo = new System.Windows.Forms.RichTextBox();
            this.dgvOnuList = new System.Windows.Forms.DataGridView();
            this.txtFrame = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnuList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIPAddress.Location = new System.Drawing.Point(12, 12);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(139, 29);
            this.txtIPAddress.TabIndex = 0;
            this.txtIPAddress.Text = "134.185.20.18";
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(12, 47);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(265, 29);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "查询";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // rtxtLogInfo
            // 
            this.rtxtLogInfo.Location = new System.Drawing.Point(283, 12);
            this.rtxtLogInfo.Name = "rtxtLogInfo";
            this.rtxtLogInfo.Size = new System.Drawing.Size(564, 330);
            this.rtxtLogInfo.TabIndex = 2;
            this.rtxtLogInfo.Text = "";
            // 
            // dgvOnuList
            // 
            this.dgvOnuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnuList.Location = new System.Drawing.Point(12, 82);
            this.dgvOnuList.Name = "dgvOnuList";
            this.dgvOnuList.RowTemplate.Height = 23;
            this.dgvOnuList.Size = new System.Drawing.Size(265, 260);
            this.dgvOnuList.TabIndex = 3;
            // 
            // txtFrame
            // 
            this.txtFrame.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFrame.Location = new System.Drawing.Point(157, 12);
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Size = new System.Drawing.Size(36, 29);
            this.txtFrame.TabIndex = 4;
            this.txtFrame.Text = "1";
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCard.Location = new System.Drawing.Point(199, 12);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(36, 29);
            this.txtCard.TabIndex = 5;
            this.txtCard.Text = "4";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPort.Location = new System.Drawing.Point(241, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(36, 29);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "2";
            // 
            // frmZTENoAvailablePort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 354);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtFrame);
            this.Controls.Add(this.dgvOnuList);
            this.Controls.Add(this.rtxtLogInfo);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtIPAddress);
            this.Name = "frmZTENoAvailablePort";
            this.Text = "中兴设备-端口已满-查询不在线OID";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.RichTextBox rtxtLogInfo;
        private System.Windows.Forms.DataGridView dgvOnuList;
        private System.Windows.Forms.TextBox txtFrame;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtPort;

    }
}