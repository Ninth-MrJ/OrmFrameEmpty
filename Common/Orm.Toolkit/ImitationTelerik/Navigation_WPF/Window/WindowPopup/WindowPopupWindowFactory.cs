﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Toolkit.Telerik.Windows.Controls.RadWindowPopup
{
	internal partial class WindowPopupWindowFactory : WindowPopupFactory
	{
		protected override WindowPopup CreatePopup(System.Windows.UIElement content)
		{
			return new WindowPopupWindowImpl();
		}
	}
}
