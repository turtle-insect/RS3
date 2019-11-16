using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RS3
{
	class CharacterIDConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			uint id = (uint)(int)(value);
			var items = Info.Instance().Character;
			for (int i = 0; i < items.Count; i++)
			{
				if (id == items[i].Value) return i;
			}
			return -1;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return Info.Instance().Character[(int)value].Value;
		}
	}
}
