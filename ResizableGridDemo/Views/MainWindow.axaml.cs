using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace ResizableGridDemo.Views
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Column> Columns { get; set; }

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            Columns = new ObservableCollection<Column>();

            Columns.Add(new DataColumn()
            {
                Header = "Column1",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 0,
                Background = Brushes.Red
            });
            Columns.Add(new SplitterColumn()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 1,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumn()
            {
                Header = "Column2",
                Definition = new ColumnDefinition(new GridLength(1, GridUnitType.Star)),
                ColumnIndex = 2,
                Background = Brushes.Green
            });
            Columns.Add(new SplitterColumn()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 3,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumn()
            {
                Header = "Column3",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 4,
                Background = Brushes.Blue
            });
            Columns.Add(new SplitterColumn()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 5,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumn()
            {
                Header = "Column4",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 6,
                Background = Brushes.Cyan
            });
            Columns.Add(new SplitterColumn()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 7,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumn()
            {
                Header = "Column5",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 8,
                Background = Brushes.Magenta
            });
            Columns.Add(new SplitterColumn()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 9,
                Background = Brushes.Yellow
            });

            DataContext = this;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}