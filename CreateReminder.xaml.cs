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
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для CreateReminder.xaml
    /// </summary>
    public partial class CreateReminder : Window
    {

        private readonly MainWindow _mainWindow;
        public CreateReminder(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ReminderName.Text == "Напишите название напоминания") ReminderName.Text = "";
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ReminderName.Text == "") ReminderName.Text = "Напишите название напоминания";
        }

        private void TextReminder_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextReminder.Text == "") TextReminder.Text = "Введите сюда текст напоминания.";
        }

        private void TextReminder_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextReminder.Text == "Введите сюда текст напоминания.") TextReminder.Text = "";
        }

        private void CreateReminderButton_Click(object sender, RoutedEventArgs e)
        {

            if (ReminderName.Text == "Напишите название напоминания") MessageBox.Show("Введите название");
            else if(Date.Text == "") MessageBox.Show("Выберите дату");
            else if (TextReminder.Text == "Введите сюда текст напоминания.") MessageBox.Show("Введите текст напоминание");
            else
            { 
                Style scrollViewerStyle = this.FindResource("ScrollViewerStyle") as Style;
                Style sangha = this.FindResource("sangha") as Style;

                Border border = new Border()
                {
                    Margin = new Thickness(5, 5, 0, 0),
                    CornerRadius = new CornerRadius(5),
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#53354a")),
                    BorderThickness = new Thickness(2),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e84545")),
                    MinHeight = 100,
                    MinWidth = 175,

                };

                ScrollViewer scrollViewer = new ScrollViewer()
                {
                    Foreground = null,
                    Margin = new Thickness(2),
                    Style = scrollViewerStyle,

                };

                GroupBox groupBox = new GroupBox()
                {
                    Header = ReminderName.Text,
                    Padding = new Thickness(2),
                    FontSize = 18,
                    Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e84545")),
                    BorderBrush = null,
                    Style = sangha,
                };

                StackPanel stackPanel = new StackPanel();

                TextBlock dateTextBlock = new TextBlock()
                {
                    Text = Date.Text,
                };

                TextBlock reminderTextBlock = new TextBlock()
                {
                    Text = TextReminder.Text,
                    TextWrapping = TextWrapping.Wrap,
                    FontSize = 25,
                    Foreground = Brushes.White,
                    Style = sangha,
                };

                stackPanel.Children.Add(dateTextBlock);
                stackPanel.Children.Add(reminderTextBlock);

                groupBox.Content = stackPanel;
                scrollViewer.Content = groupBox;
                border.Child = scrollViewer;

                _mainWindow.AddNewReminder(border);
                Debug.Write("lox");
            }


            

        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
