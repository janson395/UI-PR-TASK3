using MaterialDesignThemes.Wpf;
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
using UI_PR_TASK3.Core;

namespace UI_PR_TASK3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //47209b

            List<Core.MenuItem> menu = new List<Core.MenuItem>();
            menu.Add(new Core.MenuItem("Ресурсы", PackIconKind.Image, new ItemCount(Brushes.Orange, 1232)));
            menu.Add(new Core.MenuItem("Фильмы", PackIconKind.Cinema, new ItemCount(Brushes.DarkBlue, 95)));
            menu.Add(new Core.MenuItem("Заметки", PackIconKind.Notes, new ItemCount(Brushes.DarkGreen, 1117)));
            menu.Add(new Core.MenuItem("Документы", PackIconKind.Folder, new ItemCount(Brushes.DarkOrange, 191)));
            menu.Add(new Core.MenuItem("Статьи", PackIconKind.Artist, new ItemCount(Brushes.Orange, 123)));
            menu.Add(new Core.MenuItem("Новости", PackIconKind.Newspaper, new ItemCount(Brushes.DarkBlue, 95)));
            menu.Add(new Core.MenuItem("Блог", PackIconKind.Blog, new ItemCount(Brushes.DarkGreen, 12)));
            menu.Add(new Core.MenuItem("Рестораны", PackIconKind.Food, new ItemCount(Brushes.DarkOrange, 5)));
            menu.Add(new Core.MenuItem("Документы", PackIconKind.Folder, new ItemCount(Brushes.DarkOrange, 191)));
            menu.Add(new Core.MenuItem("Статьи", PackIconKind.Artist, new ItemCount(Brushes.Orange, 123)));
            menu.Add(new Core.MenuItem("Новости", PackIconKind.Newspaper, new ItemCount(Brushes.DarkBlue, 95)));
            menu.Add(new Core.MenuItem("Блог", PackIconKind.Blog, new ItemCount(Brushes.DarkGreen, 12)));
            menu.Add(new Core.MenuItem("Рестораны", PackIconKind.Food, new ItemCount(Brushes.DarkOrange, 5)));

            ListViewMenu.ItemsSource = menu;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
