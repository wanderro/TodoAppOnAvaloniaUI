using System;
using System.Globalization;
using Avalonia.Media;

namespace TodoApp.ValueConverters; 

public class BoolToStrikethrougTextConverter : BaseValueConverter
{
    public override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is true
        ? TextDecorations.Strikethrough
        : null;
    }
}