namespace NetworkSwitcher
{
    partial class NotifyIconWrapper
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AdapterName1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AdapterName2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AdapterName3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NetworkSwitcher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Exit,
            this.toolStripMenuItem_AdapterName1,
            this.toolStripMenuItem_AdapterName2,
            this.toolStripMenuItem_AdapterName3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem_Open
            // 
            this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            this.toolStripMenuItem_Open.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem_Open.Text = "設定";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem_Exit.Text = "終了";
            // 
            // toolStripMenuItem_AdapterName1
            // 
            this.toolStripMenuItem_AdapterName1.Name = "toolStripMenuItem_AdapterName1";
            this.toolStripMenuItem_AdapterName1.Size = new System.Drawing.Size(98, 22);
            // 
            // toolStripMenuItem_AdapterName2
            // 
            this.toolStripMenuItem_AdapterName2.Name = "toolStripMenuItem_AdapterName2";
            this.toolStripMenuItem_AdapterName2.Size = new System.Drawing.Size(98, 22);
            // 
            // toolStripMenuItem_AdapterName3
            // 
            this.toolStripMenuItem_AdapterName3.Name = "toolStripMenuItem_AdapterName3";
            this.toolStripMenuItem_AdapterName3.Size = new System.Drawing.Size(98, 22);
            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AdapterName1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AdapterName3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AdapterName2;
    }
}
