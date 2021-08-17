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

        public static IEnumerable<ColumnDefinition?>? GetColumnDefinitionsBinding(Grid grid)
        {
            return grid.GetValue(ColumnDefinitionsBindingProperty);
        }

        public static void SetColumnDefinitionsBinding(Grid grid, IEnumerable<ColumnDefinition?>? value)
        {
            grid.SetValue(ColumnDefinitionsBindingProperty, value);
        }

        static BindableGridExtensions()
        {
            ColumnDefinitionsBindingProperty.Changed.Subscribe(e =>
            {
                var oldColumns = e.OldValue.GetValueOrDefault();
                var newColumns = e.NewValue.GetValueOrDefault();

                if (Equals(oldColumns, newColumns))
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

                        foreach (var columnDefinition in newColumns)
                        {
                            if (columnDefinition is { })
                            {
                                grid.ColumnDefinitions.Add(columnDefinition);
                            }
                        }
                    }
                }
            });
        }
    }
}
