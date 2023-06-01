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
using System.Windows.Shapes;

namespace praktika.pages
{
    /// <summary>
    /// Логика взаимодействия для PasRemind.xaml
    /// </summary>
    public partial class PasRemind : Window
    {
        Model1 context;
        public PasRemind(Model1 cont)
        {
            InitializeComponent();
            context = cont;
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            
            var a = Convert.ToString(Name.Text);
            var b = Convert.ToInt32(TabNum.Text);
            var c = Convert.ToInt32(Position.Text);
            var res = context.Author.Where(x => x.position == c && x.id == b && x.login == a).ToString();
            if(res.Count() > 0 )
            {
                Author author = context.Author.ToList().Find(x => x.id.Equals(b));
                string shw = author.password.ToString();
                MessageBox.Show(shw);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка! Пользователь не найден.");
                this.Close();
            }
            
        }
    }
}
