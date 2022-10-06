using System.Windows;

namespace CardPickerUI
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

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfCards.Items.Clear();
            var drawnCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            foreach (var item in drawnCards)
            {
                listOfCards.Items.Add(item);
            }
        }
    }
}
