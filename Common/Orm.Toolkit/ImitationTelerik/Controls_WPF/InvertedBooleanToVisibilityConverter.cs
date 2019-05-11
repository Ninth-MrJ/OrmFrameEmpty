﻿using System;
using System.Windows;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents the converter that converts Boolean values to and from Visibility enumeration values.
	/// InvertedBooleanToVisibilityConverter converts "true" to Visibility.Collapsed and "false" to Visibility.Visible.
	/// </summary>
	public class InvertedBooleanToVisibilityConverter : IValueConverter
	{
		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value produced by the binding source.</param>
		/// <param name="targetType">The type of the binding target property.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			bool flag = false;
			if (value is bool)
			{
				flag = (bool) value;
			}
			else if (value is bool?)
			{
				bool? nullable = (bool?) value;
				flag = nullable.Value;
			}
			return flag ? Visibility.Collapsed : Visibility.Visible;
		}

		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value that is produced by the binding target.</param>
		/// <param name="targetType">The type to convert to.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value is Visibility && (Visibility) value == Visibility.Collapsed;
		}
	}
}
