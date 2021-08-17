using Avalonia.Controls;
using Avalonia.Media;

namespace ResizableGridDemo.Views
{
    public abstract class Column
    {
        public string? Header { get; set; }
        public ColumnDefinition? Definition { get; set; }
        public int ColumnIndex { get; set; }
        public IBrush? Background { get; set; }
    }
}