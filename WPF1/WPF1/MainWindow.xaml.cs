//Soulinthone Hongchith
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

namespace WPF1
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


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Form a = new Form();
            bool isFormValid = true;
            a.Name = txtName.Text;
            a.Address = txtAddress.Text;
            a.ZipCode = Convert.ToInt32(txtZipCode.Text);

            //check if the user doesn't input the name
            if (a.Name == "" || a.Name == string.Empty)
            {
                MessageBox.Show("Please input your name");
                txtName.Focus();
                isFormValid = false;
            }

            if(a.Address == "")
            {
                MessageBox.Show("Please input your address");
                isFormValid = false;
            }

            if(isFormValid == false)
            {
                return;
            }

            MessageBox.Show(a.ToString());

            ListBox.Items.Add(a);

            txtName.Clear();
            txtAddress.Clear();
            txtZipCode.Clear();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
