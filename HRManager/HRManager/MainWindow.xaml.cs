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
using HRMenager.Controller;
using HRMenager.DTO;
namespace HRMenager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorkerController workerController;
        Worker worker;

        public MainWindow()
        {
            InitializeComponent();
            workerController = new WorkerController();
            worker = new Worker();

        }


        void WinWorker()
        {

            worker.WorkerId = int.Parse(TextBox1.Text);
            worker.Surname = TextBox2.Text;
            worker.Name = TextBox3.Text;
            worker.MiddleName = TextBox4.Text;
            worker.DataBirth = DateTime.Parse(TextBox5.Text);
            worker.PlaceBirth = TextBox6.Text;
        }




        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            WinWorker();

            workerController.Create(worker);

        }



        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {


            workerController.Delete(int.Parse(TextBox1.Text));

        }



        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {

            TextBox7.Text = workerController.Read();

        }


        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            WinWorker();
            workerController.Update(worker);

        }







    }
}
