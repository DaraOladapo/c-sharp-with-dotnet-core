using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace lesson_21_extra_dotnetcore_gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ObservableCollection<User> Users;
        public MainWindow()
        {
            Users = new ObservableCollection<User>();
            InitializeComponent();
            UsersListView.ItemsSource = Users;
        }
        static string Register(User newUser)
        {
            Users.Add(newUser);
            return $"{newUser.FirstName} {newUser.LastName} has been registered.";
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstNameBox.Text)
                && !string.IsNullOrEmpty(LastNameBox.Text)
                && !string.IsNullOrEmpty(EmailAddressBox.Text))
            {
                var _User = new User()
                {
                    FirstName = FirstNameBox.Text,
                    LastName = LastNameBox.Text,
                    EmailAddress = EmailAddressBox.Text
                };
                var RegistrationResult = Register(_User);
                StatusLabel.Text = $"{RegistrationResult}";
            }
            else
            {
                StatusLabel.Text = "Some of your inputs are invalid, please check and try again";
            }

        }
    }
}
