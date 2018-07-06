namespace OLT_Control
{
    partial class frmOLTMain
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
            this.dgvOltList = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOLTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOltList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOltList
            // 
            this.dgvOltList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOltList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colOLTName,
            this.colIP,
            this.colPort,
            this.colUserName,
            this.colPassword});
            this.dgvOltList.Location = new System.Drawing.Point(12, 12);
            this.dgvOltList.Name = "dgvOltList";
            this.dgvOltList.RowTemplate.Height = 23;
            this.dgvOltList.Size = new System.Drawing.Size(729, 323);
            this.dgvOltList.TabIndex = 0;
            // 
            // colType
            // 
            this.colType.HeaderText = "类型";
            this.colType.Name = "colType";
            // 
            // colOLTName
            // 
            this.colOLTName.HeaderText = "名称";
            this.colOLTName.Name = "colOLTName";
            // 
            // colIP
            // 
            this.colIP.HeaderText = "IP地址";
            this.colIP.Name = "colIP";
            // 
            // colPort
            // 
            this.colPort.HeaderText = "端口";
            this.colPort.Name = "colPort";
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "用户名";
            this.colUserName.Name = "colUserName";
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "密码";
            this.colPassword.Name = "colPassword";
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSearch.Location = new System.Drawing.Point(12, 341);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(729, 50);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "查    询";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // frmOLTMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 400);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.dgvOltList);
            this.Name = "frmOLTMain";
            this.Text = "frmOLTMain";
            this.Load += new System.EventHandler(this.frmOLTMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOltList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOltList;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOLTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;

    }
}