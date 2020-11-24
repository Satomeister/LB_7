using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LB_7_3.Classes
{
    class Store
    {
        public List<Article> Articles { get; set; }
        public WrapPanel StoresContainer { get; set; }

        public Store(List<Article> articles, WrapPanel storesContainet)
        {
            Articles = articles;
            StoresContainer = storesContainet;
        }
        public void DisplayArticles()
        {
            foreach (Article artcl in Articles)
            {
                StoresContainer.Children.Add(new TextBlock
                {
                    Text = artcl.StoreName,
                    TextAlignment = TextAlignment.Center,
                    FontSize = 20,
                    Padding = new Thickness(20, 20, 20, 7)
                });
            }
        }
        public void ClearArticlesContainer()
        {
            StoresContainer.Children.Clear();
        }
        public void ShowArticleByIndex(int index, WrapPanel goodsContainer)
        {
            goodsContainer.Children.Clear();
            if (index < Articles.Count)
            {
                Article candidate = Articles[index];
                DisplayGoods(candidate, goodsContainer);
            }
            else
                goodsContainer.Children.Add(new TextBlock { Text = "shop is not found", Foreground = new SolidColorBrush(Colors.Red) });
        }
        public void ShowArticleByName(string name, WrapPanel goodsContainer)
        {
            goodsContainer.Children.Clear();
            Article candidate = null;
            foreach (Article artcl in Articles)
            {
                if (artcl.StoreName == name)
                {
                    candidate = artcl;
                    break;
                }
            }
            DisplayGoods(candidate, goodsContainer);
        }
        private void DisplayGoods(Article candidate, WrapPanel goodsContainer)
        {
            if (candidate != null)
            {
                foreach (Item i in candidate.Goods)
                {
                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Margin = new Thickness(10, 0, 10, 0);
                    stackPanel.Children.Add(new TextBlock { Text = i.Name, FontSize = 14 });
                    stackPanel.Children.Add(new TextBlock { Text = $"price - {i.Price}", FontSize = 14 });
                    stackPanel.Children.Add(new TextBlock { Text = $"count - {i.Count}", FontSize = 14 });
                    goodsContainer.Children.Add(stackPanel);
                }
            }
            else
                goodsContainer.Children.Add(new TextBlock { Text = "shop is not found", Foreground = new SolidColorBrush(Colors.Red) });
        }
    }
}
