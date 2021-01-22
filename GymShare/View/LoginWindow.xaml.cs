using GymShare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace GymShare.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    /// Nog via mvvm doen
    
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=Sportschool");
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                String query = "SELECT COUNT(1) FROM [dbo].[User] WHERE Email=@email AND Password=@password";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txtUsername.Text;
                sqlCommand.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = txtPassword.Text;

                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                string str = Convert.ToString(sqlCommand.ExecuteScalar());
                if (count == 1)
                {
                    GymWindow gymWindow = new GymWindow();
                    gymWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("email or password incorrect.");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
