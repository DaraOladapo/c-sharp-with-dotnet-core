using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinExtra.Services;
using XamarinExtra.Models;

namespace XamarinExtra
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetEmployeesFromAPI();
        }
        async void GetEmployeesFromAPI()
        {
            EmployeesListView.ItemsSource = await EmployeeService.GetEmployees();
        }
        private void OnEmployeeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Employee = (Employee)e.SelectedItem;
            EmployeeService.RemoveEmployee(Employee);
            StatusLabel.Text = $"{Employee.FullName} has been removed.";
        }

        private void OnEmployeeAdd(object sender, EventArgs e)
        {
            var Employee = new Employee()
            {
                FirstName = FirstNameEntry.Text,
                LastName = LastNameEntry.Text,
                EmailAddress = EmailEntry.Text
            };
            var EmployeeAdded = EmployeeService.AddEmployee(Employee);
            StatusLabel.Text = $"{EmployeeAdded.FullName} has been added.";
        }
    }
}
