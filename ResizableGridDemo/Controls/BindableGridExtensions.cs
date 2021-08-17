using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using ResizableGridDemo.ViewModels;

namespace ResizableGridDemo.Controls
{
    public class BindableGridExtensions : AvaloniaObject
    {
        public static readonly AttachedProperty<IEnumerable<ColumnDefinition?>?> ColumnDefinitionsBindingProperty = 
            AvaloniaProperty.RegisterAttached<BindableGridExtensions, IEnumerable<ColumnDefinition?>?>("ColumnDefinitionsBinding", typeof(Grid));

        public static readonly AttachedProperty<IEnumerable<RowDefinition?>?> RowDefinitionsBindingProperty = 
            AvaloniaProperty.RegisterAttached<BindableGridExtensions, IEnumerable<RowDefinition?>?>("RowDefinitionsBinding", typeof(Grid));

        public static IEnumerable<ColumnDefinition?>? GetColumnDefinitionsBinding(Grid grid)
        {
            return grid.GetValue(ColumnDefinitionsBindingProperty);
        }

        public static void SetColumnDefinitionsBinding(Grid grid, IEnumerable<ColumnDefinition?>? value)
        {
            grid.SetValue(ColumnDefinitionsBindingProperty, value);
        }

        public static IEnumerable<RowDefinition?>? GetRowDefinitionsBinding(Grid grid)
        {
            return grid.GetValue(RowDefinitionsBindingProperty);
        }

        public static void SetRowDefinitionsBinding(Grid grid, IEnumerable<RowDefinition?>? value)
        {
            grid.SetValue(RowDefinitionsBindingProperty, value);
        }

        static BindableGridExtensions()
        {
            ColumnDefinitionsBindingProperty.Changed.Subscribe(e =>
            {
                var oldColumns = e.OldValue.GetValueOrDefault();
                var newColumns = e.NewValue.GetValueOrDefault();

                // if (Equals(oldColumns, newColumns))
                // {
                //     return;
                // }

                if (e.Sender is not Grid grid)
                {
                    return;
                }
  
                if (oldColumns is { })
                {
                    grid.ColumnDefinitions.Clear();
                }

                if (newColumns is null)
                {
                    return;
                }

                grid.ColumnDefinitions.Clear();

                foreach (var columnDefinition in newColumns)
                {
                    if (columnDefinition is { })
                    {
                        grid.ColumnDefinitions.Add(columnDefinition);
                    }
                }
            });

            RowDefinitionsBindingProperty.Changed.Subscribe(e =>
            {
                var oldRows = e.OldValue.GetValueOrDefault();
                var newRows = e.NewValue.GetValueOrDefault();

                // if (Equals(oldRows, newRows))
                // {
                //     return;
                // }

                if (e.Sender is not Grid grid)
                {
                    return;
                }

                if (oldRows is { })
                {
                    grid.RowDefinitions.Clear();
                }

                if (newRows is null)
                {
                    return;
                }

                grid.RowDefinitions.Clear();

                foreach (var rowDefinition in newRows)
                {
                    if (rowDefinition is { })
                    {
                        grid.RowDefinitions.Add(rowDefinition);
                    }
                }
            });
        }
    }
}
