﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szotanulo_alkalmazas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Kiválasztott nehézségi szint
            string difficulty = (DifficultyComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Nyissuk meg az új ablakot, átadva a nehézségi szintet
            var quizWindow = new QuizWindow(difficulty);
            quizWindow.ShowDialog();
        }
    }
}