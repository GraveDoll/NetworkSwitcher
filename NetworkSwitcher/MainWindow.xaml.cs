using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NetworkSwitcher
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

            this.textBox_networkAdapter1.Text = Properties.Settings.Default.adapterName1;
            this.textBox_networkAdapter2.Text = Properties.Settings.Default.adapterName2;
            this.textBox_networkAdapter3.Text = Properties.Settings.Default.adapterName3;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.adapterName1 = this.textBox_networkAdapter1.Text;
            Properties.Settings.Default.adapterName2 = this.textBox_networkAdapter2.Text;
            Properties.Settings.Default.adapterName3 = this.textBox_networkAdapter3.Text;

            Properties.Settings.Default.Save();
            MessageBox.Show("設定を保存しました。");
        }

    }
}
