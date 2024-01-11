using System.Windows;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyChiTieuSV
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Xac thuc dang nhap
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            
            //Gia tri khong rong thi se dang nhap thanh cong
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                
                MessageBox.Show("Đăng nhập thành công."); //Hien thi Dang nhap thanh cong
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Sau khi dang nhap thanh cong, dong cua so login
                Close();
            }
            else
            {
                MessageBox.Show("Không có thông tin. Hãy thử lại!");
            }

        }
    }
}
