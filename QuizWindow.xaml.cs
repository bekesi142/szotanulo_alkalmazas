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
using System.Windows.Shapes;

namespace szotanulo_alkalmazas
{
    /// <summary>
    /// Interaction logic for QuizWindow.xaml
    /// </summary>
    public partial class QuizWindow : Window
    {
        public QuizWindow(string difficulty)
        {
            InitializeComponent();

            // A kiválasztott nehézségi szint alapján döntsük el, hány StackPanel-t kell hozzáadni
            int numberOfPanels = 0;

            if (difficulty == "Könnyű")
            {
                numberOfPanels = 10;
            }
            else if (difficulty == "Közepes")
            {
                numberOfPanels = 15;
            }
            else if (difficulty == "Nehéz")
            {
                numberOfPanels = 20;
            }

            // StackPanel-ek dinamikus létrehozása
            for (int i = 0; i < numberOfPanels; i++)
            {
                var stackPanel = new StackPanel { Orientation = Orientation.Vertical, Margin = new Thickness(10) };

                // Label
                var label = new Label { Content = "Hello", HorizontalAlignment = HorizontalAlignment.Center };
                stackPanel.Children.Add(label);

                // Gombok (1, 2, 3, 4)
                var buttonPanel = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };
                for (int j = 1; j <= 4; j++)
                {
                    var button = new Button { Content = j.ToString(), Width = 50, Margin = new Thickness(5) };
                    buttonPanel.Children.Add(button);
                }

                // Gombok paneljének hozzáadása a StackPanelhez
                stackPanel.Children.Add(buttonPanel);

                // StackPanel hozzáadása a fő panelhez
                MainStackPanel.Children.Add(stackPanel);
            }
        }
    }
}
