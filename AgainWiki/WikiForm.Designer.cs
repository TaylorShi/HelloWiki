namespace AgainWiki
{
    partial class WinFormWiki
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.wbs_Content = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.btn_Navigate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbs_Content)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wbs_Content);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 740);
            this.panel2.TabIndex = 3;
            // 
            // wbs_Content
            // 
            this.wbs_Content.AllowExternalDrop = false;
            this.wbs_Content.CreationProperties = null;
            this.wbs_Content.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbs_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbs_Content.Location = new System.Drawing.Point(0, 0);
            this.wbs_Content.Name = "wbs_Content";
            this.wbs_Content.Size = new System.Drawing.Size(372, 740);
            this.wbs_Content.TabIndex = 0;
            this.wbs_Content.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Navigate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 38);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_Address);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Size = new System.Drawing.Size(300, 38);
            this.panel3.TabIndex = 2;
            // 
            // txb_Address
            // 
            this.txb_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_Address.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Address.Location = new System.Drawing.Point(4, 2);
            this.txb_Address.Multiline = true;
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(292, 34);
            this.txb_Address.TabIndex = 0;
            // 
            // btn_Navigate
            // 
            this.btn_Navigate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Navigate.Location = new System.Drawing.Point(300, 0);
            this.btn_Navigate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Navigate.Name = "btn_Navigate";
            this.btn_Navigate.Size = new System.Drawing.Size(72, 38);
            this.btn_Navigate.TabIndex = 1;
            this.btn_Navigate.Text = "前往";
            this.btn_Navigate.UseVisualStyleBackColor = true;
            this.btn_Navigate.Click += new System.EventHandler(this.btn_Navigate_Click);
            // 
            // WinFormWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "WinFormWiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wikipedia -  Webview2";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wbs_Content)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Button btn_Navigate;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbs_Content;
    }
}

