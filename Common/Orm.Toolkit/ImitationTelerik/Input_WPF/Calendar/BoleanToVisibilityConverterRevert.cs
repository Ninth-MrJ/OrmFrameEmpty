﻿using System;
using System.Windows;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	internal class BoleanToVisibilityConverterRevert : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (bool)value ? Visibility.Collapsed : Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
