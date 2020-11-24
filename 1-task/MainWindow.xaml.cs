using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LB_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void AddContent(string content)
        {
            container.Children.Add(new TextBlock { Text = content, Margin = new Thickness(20, 0, 0, 0), FontSize = 16 });
        }

        public string OddArray(int[] array)
        {
            ArrayList oddList = new ArrayList();
            
            foreach (int n in array)
            {
                if (n % 2 != 0)
                    oddList.Add(n);
            }
            return string.Join(",", oddList.ToArray());
        }
        public void CreateArray(int N)
        {
            input.IsReadOnly = true;
            int[] nums = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                nums[i] = rand.Next(0, 100);
            }
            string arrayString = string.Join(",", nums);
            array.Children.Add(new TextBlock { Text = $"array - {arrayString}", FontSize = 16 });
            AddContent($"max = {nums.Max()}");
            AddContent($"min = {nums.Min()}");
            AddContent($"sum = {nums.Sum()}");
            AddContent($"arithmetic mean = {nums.Sum()}");
            AddContent($"odd numbers = {OddArray(nums)}");
            input.IsReadOnly = false;
        }
        private void input_change(object sender, TextChangedEventArgs e)
        {
            try
            {
                array.Children.Clear();
                container.Children.Clear();
                error.Visibility = Visibility.Collapsed;
                int N = Convert.ToInt32(input.Text);
                CreateArray(N);
            } 
            catch
            {
                container.Children.Clear();
                error.Visibility = Visibility.Visible;
            }
        }
    }
}
