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
using System.IO;

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePW6.xaml
    /// </summary>
    public partial class PagePW6 : Page
    {
        public PagePW6()
        {
            InitializeComponent();
        }

        private void btnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lstInput.SelectedIndex;
                string str = (string)lstInput.Items[index];
                int len = str.Length;
                char[] rusalf = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                int i = 0;
                int count = 0;
                while (i < len - 1)
                {
                    foreach(char c in str)
                        if (c == rusalf[i])
                        count++;
                    i++;
                }
                txbRezult.Text = "Количество строчных русских букв = " + count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}