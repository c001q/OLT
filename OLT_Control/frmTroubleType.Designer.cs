namespace OLT_Control
{
    partial class frmTroubleType
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
            this.butLogicIDUsed = new System.Windows.Forms.Button();
            this.butVlanUsed = new System.Windows.Forms.Button();
            this.butRegTwentyPercent = new System.Windows.Forms.Button();
            this.cmboxOltType = new System.Windows.Forms.ComboBox();
            this.butService = new System.Windows.Forms.Button();
            this.butNoAvailablePort = new System.Windows.Forms.Button();
            this.butOltList = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butOption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butLogicIDUsed
            // 
            this.butLogicIDUsed.Enabled = false;
            this.butLogicIDUsed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butLogicIDUsed.Location = new System.Drawing.Point(12, 51);
            this.butLogicIDUsed.Name = "butLogicIDUsed";
            this.butLogicIDUsed.Size = new System.Drawing.Size(167, 41);
            this.butLogicIDUsed.TabIndex = 0;
            this.butLogicIDUsed.Text = "逻辑ID占用";
            this.butLogicIDUsed.UseVisualStyleBackColor = true;
            // 
            // butVlanUsed
            // 
            this.butVlanUsed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butVlanUsed.Location = new System.Drawing.Point(12, 98);
            this.butVlanUsed.Name = "butVlanUsed";
            this.butVlanUsed.Size = new System.Drawing.Size(167, 41);
            this.butVlanUsed.TabIndex = 1;
            this.butVlanUsed.Text = "VLAN占用";
            this.butVlanUsed.UseVisualStyleBackColor = true;
            // 
            // butRegTwentyPercent
            // 
            this.butRegTwentyPercent.Enabled = false;
            this.butRegTwentyPercent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRegTwentyPercent.Location = new System.Drawing.Point(12, 192);
            this.butRegTwentyPercent.Name = "butRegTwentyPercent";
            this.butRegTwentyPercent.Size = new System.Drawing.Size(167, 41);
            this.butRegTwentyPercent.TabIndex = 2;
            this.butRegTwentyPercent.Text = "注册20%";
            this.butRegTwentyPercent.UseVisualStyleBackColor = true;
            // 
            // cmboxOltType
            // 
            this.cmboxOltType.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmboxOltType.FormattingEnabled = true;
            this.cmboxOltType.Items.AddRange(new object[] {
            "HUAWEI",
            "ZTE"});
            this.cmboxOltType.Location = new System.Drawing.Point(12, 12);
            this.cmboxOltType.Name = "cmboxOltType";
            this.cmboxOltType.Size = new System.Drawing.Size(167, 33);
            this.cmboxOltType.TabIndex = 3;
            this.cmboxOltType.Text = "ZTE";
            // 
            // butService
            // 
            this.butService.Enabled = false;
            this.butService.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butService.Location = new System.Drawing.Point(12, 239);
            this.butService.Name = "butService";
            this.butService.Size = new System.Drawing.Size(167, 41);
            this.butService.TabIndex = 4;
            this.butService.Text = "已开通业务查询";
            this.butService.UseVisualStyleBackColor = true;
            // 
            // butNoAvailablePort
            // 
            this.butNoAvailablePort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butNoAvailablePort.Location = new System.Drawing.Point(12, 145);
            this.butNoAvailablePort.Name = "butNoAvailablePort";
            this.butNoAvailablePort.Size = new System.Drawing.Size(167, 41);
            this.butNoAvailablePort.TabIndex = 5;
            this.butNoAvailablePort.Text = "PON口满了";
            this.butNoAvailablePort.UseVisualStyleBackColor = true;
            this.butNoAvailablePort.Click += new System.EventHandler(this.butNoAvailablePort_Click);
            // 
            // butOltList
            // 
            this.butOltList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butOltList.Location = new System.Drawing.Point(12, 286);
            this.butOltList.Name = "butOltList";
            this.butOltList.Size = new System.Drawing.Size(167, 41);
            this.butOltList.TabIndex = 6;
            this.butOltList.Text = "OLT列表";
            this.butOltList.UseVisualStyleBackColor = true;
            this.butOltList.Click += new System.EventHandler(this.butOltList_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butExit.Location = new System.Drawing.Point(12, 380);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(167, 41);
            this.butExit.TabIndex = 7;
            this.butExit.Text = "退出";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butOption
            // 
            this.butOption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butOption.Location = new System.Drawing.Point(12, 333);
            this.butOption.Name = "butOption";
            this.butOption.Size = new System.Drawing.Size(167, 41);
            this.butOption.TabIndex = 8;
            this.butOption.Text = "程序设置";
            this.butOption.UseVisualStyleBackColor = true;
            this.butOption.Click += new System.EventHandler(this.butOption_Click);
            // 
            // frmTroubleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 430);
            this.Controls.Add(this.butOption);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOltList);
            this.Controls.Add(this.butNoAvailablePort);
            this.Controls.Add(this.butService);
            this.Controls.Add(this.cmboxOltType);
            this.Controls.Add(this.butRegTwentyPercent);
            this.Controls.Add(this.butVlanUsed);
            this.Controls.Add(this.butLogicIDUsed);
            this.Name = "frmTroubleType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "问题种类";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLogicIDUsed;
        private System.Windows.Forms.Button butVlanUsed;
        private System.Windows.Forms.Button butRegTwentyPercent;
        private System.Windows.Forms.ComboBox cmboxOltType;
        private System.Windows.Forms.Button butService;
        private System.Windows.Forms.Button butNoAvailablePort;
        private System.Windows.Forms.Button butOltList;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butOption;
    }
}