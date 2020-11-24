using System;
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
using LB_7_3.Classes;

namespace LB_7_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            f1();
        }
        Store store;
        public void f1()
        {
             List<Item> phones = new List<Item>()
            {
                new Item("Xiaomi", 2, 3000),
                new Item("Sumsung", 3, 5000)
            };
             List<Item> games = new List<Item>()
            {
                new Item("Minecraft", 12, 300),
                new Item("Roblox", 8, 100),
                new Item("Wrot of Tanks", 3, 1000)
            };
            List<Item> cars = new List<Item>()
            {
                new Item("ZAZ", 3, 30000),
                new Item("VAZ", 5, 5000),
                new Item("TAZ", 13, 10000)
            };
            List<Article> articles = new List<Article>()
            {
                new Article(phones, "Phone-Store"),
                new Article(games, "Games-Store"),
                new Article(cars, "Cars-Store")
            };
            store = new Store(articles, storesContainer);

            store.DisplayArticles();
        }
        private void nameButton_click(object sender, RoutedEventArgs e)
        {
            string shop = nameInput.Text;
            store.ShowArticleByName(shop, goodsContainer);
        }

        private void indexButton_click(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(indexInput.Text);
            store.ShowArticleByIndex(index, goodsContainer);
        }
    }
}
