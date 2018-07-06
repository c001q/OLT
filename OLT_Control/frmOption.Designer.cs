namespace OLT_Control
{
    partial class frmOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOption));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOltTxtPath = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "OLT列表：";
            // 
            // txtOltTxtPath
            // 
            this.txtOltTxtPath.Location = new System.Drawing.Point(75, 12);
            this.txtOltTxtPath.Name = "txtOltTxtPath";
            this.txtOltTxtPath.Size = new System.Drawing.Size(270, 21);
            this.txtOltTxtPath.TabIndex = 1;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(212, 314);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "保存设置";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butQuit
            // 
            this.butQuit.Location = new System.Drawing.Point(293, 314);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(75, 23);
            this.butQuit.TabIndex = 3;
            this.butQuit.Text = "退出";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 349);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtOltTxtPath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOption";
            this.Text = "frmOption";
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOltTxtPath;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butQuit;
    }
}