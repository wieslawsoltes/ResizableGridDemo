using System;
using Avalonia.Controls;

namespace ResizableGridDemo.Controls
{
    public static class DefinitionBaseExtensions
    {
        public static GridLength GetUserSizeValueCache(this DefinitionBase definitionBase)
        {
            return definitionBase switch
            {
                ColumnDefinition columnDefinition => columnDefinition.Width,
                RowDefinition rowDefinition => rowDefinition.Height,
                _ => throw new Exception()
            };
        }
        
        public static double GetUserMinSizeValueCache(this DefinitionBase definitionBase)
        {
            return definitionBase switch
            {
                ColumnDefinition columnDefinition => columnDefinition.MinWidth,
                RowDefinition rowDefinition => rowDefinition.MinHeight,
                _ => throw new Exception()
            };
        }

        public static double GetUserMaxSizeValueCache(this DefinitionBase definitionBase)
        {
            return definitionBase switch
            {
                ColumnDefinition columnDefinition => columnDefinition.MaxWidth,
                RowDefinition rowDefinition => rowDefinition.MaxHeight,
                _ => throw new Exception()
            };
        }
    }
}
