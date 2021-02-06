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

namespace TextAnalizer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<IMetric> metrics = new List<IMetric>();
        IContent content;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Analyse_Click(object sender, RoutedEventArgs e)
        {
            content = new StringText();
            content.Content = Text.Text;
            FullMetrics();
            Execute();
        }
        private async void Execute()
        {
            foreach (var e in metrics) await e.Analyse(content);
            string info = string.Join("",metrics.Select(x => x.Info).ToArray());
            Result.Text = info;
        }

        private void FullMetrics()
        {
            metrics = new List<IMetric>();
            if (GlasAnalyse.IsChecked == true) metrics.Add(new GlasMetric());
        }
    }
}
