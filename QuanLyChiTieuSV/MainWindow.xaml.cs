using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System;


namespace QuanLyChiTieuSV
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Transaction> Expenses { get; set; }
        public ObservableCollection<Transaction> Incomes { get; set; }

        public MainWindow()
        {
            //Frame mainFrame = new Frame();
            //mainFrame.Navigate(new HomePage());
            //mainFrame.Navigate(new LoginPage());

            InitializeComponent();
            //ConnectToDatabase();
            Expenses = new ObservableCollection<Transaction>();
            Incomes = new ObservableCollection<Transaction>();
            lstExpenses.ItemsSource = Expenses;
            lstIncomes.ItemsSource = Incomes;
        }

        private void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExpenseDescription.Text) && decimal.TryParse(txtExpenseAmount.Text, out decimal amount))
            {
                Expenses.Add(new Transaction { Description = txtExpenseDescription.Text, Amount = amount });
                txtExpenseDescription.Clear();
                txtExpenseAmount.Clear();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin. Hãy thử lại!");
            }
        }

        private void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIncomeSource.Text) && decimal.TryParse(txtIncomeAmount.Text, out decimal amount))
            {
                Incomes.Add(new Transaction { Source = txtIncomeSource.Text, Amount = amount });
                txtIncomeSource.Clear();
                txtIncomeAmount.Clear();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin. Hãy thử lại!");
            }
        }

        private void btnDeleteExpense_Click(object sender, RoutedEventArgs e)
        {
            if (lstExpenses.SelectedItem != null)
            {
                Expenses.Remove((Transaction)lstExpenses.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }
        }

        private void btnDeleteIncome_Click(object sender, RoutedEventArgs e)
        {
            if (lstIncomes.SelectedItem != null)
            {
                Incomes.Remove((Transaction)lstIncomes.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        //private void ConnectToDatabase()
        //{
        //    try
        //    {
        //        // Chuỗi kết nối đến cơ sở dữ liệu (điều chỉnh theo thông tin của bạn)
        //        string connectionString = "Data Source=GLHF;Initial Catalog=UserProfile;User ID=abc;Password=123;";

        //        // Tạo đối tượng SqlConnection
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            // Mở kết nối
        //            connection.Open();

        //            // Thực hiện truy vấn SQL
        //            string query = "SELECT * FROM YourTable";
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    // Xử lý dữ liệu đọc được từ cơ sở dữ liệu
        //                    while (reader.Read())
        //                    {
        //                        // Ví dụ: In ra Console
        //                        Console.WriteLine($"Column1: {reader["Column1"]}, Column2: {reader["Column2"]}");
        //                    }
        //                }
        //            }

        //            // Đóng kết nối
        //            connection.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý nếu có lỗi
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}
    }


    public class Transaction
    {
        public string Description { get; set; }
        public string Source { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{(string.IsNullOrEmpty(Source) ? "Expense" : "Income")} - {Description ?? Source} - ${Amount}";
        }
    }
}
