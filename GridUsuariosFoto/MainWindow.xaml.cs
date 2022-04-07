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

namespace GridUsuariosFoto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> user = new List<User>();
            user.Add(new User() { Id = 1, Name = "Jhon Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl= "C:\\muñeco.png" });
            user.Add(new User() { Id = 2, Name = "Jahne Dos", Birthday = new DateTime(1974, 1, 17) });
            user.Add(new User() { Id = 3, Name = "Samy Doe", Birthday = new DateTime(1991, 9, 2) });
            dgUsers.ItemsSource = user;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageUrl { get; set; }
    }
}
