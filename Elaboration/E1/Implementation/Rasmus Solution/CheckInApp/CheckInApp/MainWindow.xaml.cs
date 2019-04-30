using System;
using System.Collections.Generic;
using System.Linq;
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
using Renci.SshNet;

namespace CheckInApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectToServerBTN_Click(object sender, RoutedEventArgs e)
        {
            RemoteServer funnhallViborgLinuxServer = new RemoteServer("10.152.120.24", "funhall", "ubuntu123");
            using (SshClient ssh = new SshClient(funnhallViborgLinuxServer.RemoteHost, funnhallViborgLinuxServer.Username, funnhallViborgLinuxServer.Password))
            {
                ssh.Connect();
                ssh.Disconnect();
            }
        }
    }
}
