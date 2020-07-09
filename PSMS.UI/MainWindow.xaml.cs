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
using PSMS.BLL;

namespace UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //验证用户是否登录
        public static bool logined = false;
        //登录后设置level,对应不同的用户身份
        public static int level = 0;
        //存放主窗口实例，方便调用
        public static MainWindow currentObj;
        public MainWindow()
        {
            InitializeComponent();
            MainWindow.currentObj = this;
            //初次进入需要进行登录操作
            login loginBox = new login();
            loginBox.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login loginBox = new login();
            loginBox.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
