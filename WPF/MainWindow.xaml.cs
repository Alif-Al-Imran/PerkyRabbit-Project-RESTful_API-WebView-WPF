using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;
using WPF.Models;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri baseAddress = new Uri("https://localhost:44333/api/");
        private readonly HttpClient client;
        public MainWindow()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = baseAddress;
            LoadGrid();
        }
        public void LoadGrid()
        {
            List<Customer> Customer = new List<Customer>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "customers").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Customer = JsonConvert.DeserializeObject<List<Customer>>(data);
            }
            datagrid.ItemsSource = Customer;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void SaveCustomer(Customer cus)
        {
            await client.PostAsJsonAsync("customer/create", cus);
        }
        private async void UpdateCustomer(Customer cus)
        {
            await client.PostAsJsonAsync("customer/update", cus);
        }
        private async void DeleteCustomer(int id)
        {
            await client.GetAsync("customer/delete/" + id);
        }
        private void create_Click(object sender, RoutedEventArgs e)
        {
            Customer cus = new Customer();
            cus.Id = Convert.ToInt32(id.Text);
            cus.Name = name.Text;
            cus.Address = address.Text;
            this.SaveCustomer(cus);
            MessageBox.Show("Customer created");
            LoadGrid();

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            Customer cus = new Customer();
            cus.Id = Convert.ToInt32(id.Text);
            cus.Name = name.Text;
            cus.Address = address.Text;
            this.UpdateCustomer(cus);
            MessageBox.Show("Customer updated");
            LoadGrid();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int cid = Convert.ToInt32(id.Text);
            this.DeleteCustomer(cid);
            MessageBox.Show("Customer deleted");
            LoadGrid();
        }
    }
}
