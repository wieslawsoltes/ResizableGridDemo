using Avalonia.Controls;
using Avalonia.Media;

namespace ResizableGridDemo.ViewModels
{
    public abstract class ColumnViewModel
    {
        public string? Header { get; set; }
        public ColumnDefinition? Definition { get; set; }
        public int ColumnIndex { get; set; }
        public IBrush? Background { get; set; }
    }
}
