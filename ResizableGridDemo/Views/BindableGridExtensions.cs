using System;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using ResizableGridDemo.ViewModels;

namespace ResizableGridDemo.Views
{
    public class BindableGridExtensions : AvaloniaObject
    {
        public static readonly AttachedProperty<ObservableCollection<ColumnViewModel>?> ColumnDefinitionsBindingProperty = 
            AvaloniaProperty.RegisterAttached<BindableGridExtensions, ObservableCollection<ColumnViewModel>?>("ColumnDefinitionsBinding", typeof(Grid));

        public static ObservableCollection<ColumnViewModel>? GetColumnDefinitionsBinding(Grid grid)
        {
            return grid.GetValue(ColumnDefinitionsBindingProperty);
        }

        public static void SetColumnDefinitionsBinding(Grid grid, ObservableCollection<ColumnViewModel>? value)
        {
            grid.SetValue(ColumnDefinitionsBindingProperty, value);
        }

        static BindableGridExtensions()
        {
            ColumnDefinitionsBindingProperty.Changed.Subscribe(e =>
            {
                var oldColumns = e.OldValue.GetValueOrDefault();
                var newColumns = e.NewValue.GetValueOrDefault();

                if (oldColumns == newColumns)
                {
                    return;
                }

                if (e.Sender is Grid grid)
                {
                    if (oldColumns is { })
                    {
                        grid.ColumnDefinitions.Clear();
                    }

                    if (newColumns is { })
                    {
                        grid.ColumnDefinitions.Clear();

                        foreach (var column in newColumns)
                        {
                            if (column.Definition is { })
                            {
                                grid.ColumnDefinitions.Add(column.Definition);
                            }
                        }
                    }
                }
            });
        }
    }
}
