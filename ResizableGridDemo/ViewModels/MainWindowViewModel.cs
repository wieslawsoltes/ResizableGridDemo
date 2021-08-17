using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Media;

namespace ResizableGridDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ColumnViewModel> Columns { get; set; }

        public MainWindowViewModel()
        {
            Columns = new ObservableCollection<ColumnViewModel>();

            Columns.Add(new DataColumnViewModel()
            {
                Header = "Column1",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 0,
                Background = Brushes.Red
            });
            Columns.Add(new SplitterColumnViewModel()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 1,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumnViewModel()
            {
                Header = "Column2",
                Definition = new ColumnDefinition(new GridLength(1, GridUnitType.Star)),
                ColumnIndex = 2,
                Background = Brushes.Green
            });
            Columns.Add(new SplitterColumnViewModel()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 3,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumnViewModel()
            {
                Header = "Column3",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 4,
                Background = Brushes.Blue
            });
            Columns.Add(new SplitterColumnViewModel()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 5,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumnViewModel()
            {
                Header = "Column4",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 6,
                Background = Brushes.Cyan
            });
            Columns.Add(new SplitterColumnViewModel()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 7,
                Background = Brushes.Yellow
            });
            Columns.Add(new DataColumnViewModel()
            {
                Header = "Column5",
                Definition = new ColumnDefinition(new GridLength(0, GridUnitType.Auto)),
                ColumnIndex = 8,
                Background = Brushes.Magenta
            });
            Columns.Add(new SplitterColumnViewModel()
            {
                Header = "",
                Definition = new ColumnDefinition(new GridLength(5, GridUnitType.Pixel)),
                ColumnIndex = 9,
                Background = Brushes.Yellow
            });
        }
    }
}
