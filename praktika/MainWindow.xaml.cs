using System;
using System.Collections.Generic;
using System.IO;
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

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 context;
        public MainWindow()
        {
            InitializeComponent();
            //DownloadPictures();
            context = new Model1();
            myFrame.Navigate(new pages.Authorisation(context, this));
        }
        //public void DownloadPictures()
        //{
        //    using (Model1 context = new Model1())
        //    {
        //        foreach (var item in context.Repair.ToList())
        //        {
        //            item.photo = File.ReadAllBytes($"C:/Devices/{item.id}.jpg");
        //        }
        //        context.SaveChanges();
        //    }
        //}
    }
}
