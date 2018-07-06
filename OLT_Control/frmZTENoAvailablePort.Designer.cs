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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnuList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIPAddress.Location = new System.Drawing.Point(12, 12);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(222, 29);
            this.txtIPAddress.TabIndex = 0;
            this.txtIPAddress.Text = "192.168.1.1";
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(240, 12);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(84, 29);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "查询";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // rtxtLogInfo
            // 
            this.rtxtLogInfo.Location = new System.Drawing.Point(12, 47);
            this.rtxtLogInfo.Name = "rtxtLogInfo";
            this.rtxtLogInfo.Size = new System.Drawing.Size(312, 295);
            this.rtxtLogInfo.TabIndex = 2;
            this.rtxtLogInfo.Text = "";
            // 
            // dgvOnuList
            // 
            this.dgvOnuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnuList.Location = new System.Drawing.Point(330, 12);
            this.dgvOnuList.Name = "dgvOnuList";
            this.dgvOnuList.RowTemplate.Height = 23;
            this.dgvOnuList.Size = new System.Drawing.Size(359, 330);
            this.dgvOnuList.TabIndex = 3;
            // 
            // frmZTENoAvailablePort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 354);
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

    }
}