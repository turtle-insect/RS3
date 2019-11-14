using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RS3
{
	class ViewModel
	{
		public Info Info { get; set; } = Info.Instance();
		public SaveData SaveData { get; set; } = SaveData.Instance();
	}
}
