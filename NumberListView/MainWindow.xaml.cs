using System.Windows;

namespace List_of_Numbers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int click = 0;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NumberList.Items.Add(click);
            click++;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            NumberList.Items.Remove(NumberList.SelectedItem);
        }
    }
}
