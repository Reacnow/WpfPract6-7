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

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePW7.xaml
    /// </summary>
    public partial class PagePW7 : Page
    {
        int[] Y = new int[25];
        public PagePW7()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создание массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateArray_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            for(int i = 0; i < Y.Length; i++) 
            {
                Y[i] = rand.Next(-1000,1000);
                LstArray.Items.Add($"#{i}  {Y[i]}");
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSolveArray_Click(object sender, RoutedEventArgs e)
        {

            double[] r = new double[25];
            for (int i = 0; i < Y.Length; i++)
            {
                r[i] = (5 * Y[i] + Math.Pow(Math.Cos(Y[i]), 2)) / 2.35;
                LstArrayNew.Items.Add($"#{i}  {r[i]}");
            }
        }
    }
}
