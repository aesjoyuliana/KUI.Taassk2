using KUI.Taassk2.Core;
using KUI.Taassk2.View.Pages.TaskPages;
using System.Windows;
using System.Windows.Controls;

namespace KUI.Taassk2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
