using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetworkSwitcher
{

    public partial class NotifyIconWrapper : Component
    {



        public NotifyIconWrapper()
        {

            // コンポーネントの初期化
            this.InitializeComponent();

            // コンテキストメニューのイベントを設定
            this.toolStripMenuItem_Open.Click += this.toolStripMenuItem_Open_Click;
            this.toolStripMenuItem_Exit.Click += this.toolStripMenuItem_Exit_Click;
            this.toolStripMenuItem_AdapterName1.Click += this.toolStripMenuItem_AdapterName1_Click;
            this.toolStripMenuItem_AdapterName2.Click += this.toolStripMenuItem_AdapterName2_Click;
            this.toolStripMenuItem_AdapterName3.Click += this.toolStripMenuItem_AdapterName3_Click;

        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);

            this.InitializeComponent();
        }

        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            // MainWindow を生成、表示
            var wnd = new MainWindow();
            
            wnd.Show();
        }

        private void toolStripMenuItem_AdapterName1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "netsh.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;

            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName1 + "\" enable";
            process.Start();
            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName2 + "\" disable";
            process.Start();
            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName3 + "\" disable";
            process.Start();
        }

        private void toolStripMenuItem_AdapterName2_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "netsh.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;

            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName1 + "\" disable";
            process.Start();
            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName2 + "\" enable";
            process.Start();
            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName3 + "\" disable";
            process.Start();
        }

        private void toolStripMenuItem_AdapterName3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "netsh.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;

            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName1 + "\" disable";
            process.Start();
            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName2 + "\" disable";
            process.Start();
            process.StartInfo.Arguments = "interface set interface \"" + Properties.Settings.Default.adapterName3 + "\" enable";
            process.Start();
        }


        /// <summary>
        /// コンテキストメニュー "終了" を選択したとき呼ばれます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            // 現在のアプリケーションを終了
            Application.Current.Shutdown();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.toolStripMenuItem_AdapterName1.Text = Properties.Settings.Default.adapterName1;
            this.toolStripMenuItem_AdapterName2.Text = Properties.Settings.Default.adapterName2;
            this.toolStripMenuItem_AdapterName3.Text = Properties.Settings.Default.adapterName3;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }
    }
}
