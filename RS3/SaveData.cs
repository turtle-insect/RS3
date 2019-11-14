using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Collections.ObjectModel;

namespace RS3
{
	class SaveData
	{
		private SaveData() { }
		private static SaveData me = new SaveData();
		public ObservableCollection<PlayerWork> Players { get; set; } = new ObservableCollection<PlayerWork>();
		public PartyWork Party { get; set; } = new PartyWork();
		public static SaveData Instance()
		{
			return me;
		}

		public void Open(string filename)
		{
			string json = File.ReadAllText(filename, Encoding.Unicode);
			var master = new OriginalJson();
			using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
			{
				var dcjs = new DataContractJsonSerializer(typeof(OriginalJson));
				master = dcjs.ReadObject(ms) as OriginalJson;
			}
			
			foreach (var work in master.m_playerWork)
			{
				using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(work)))
				{
					var player = new PlayerWork();
					var dcjs = new DataContractJsonSerializer(typeof(PlayerWork));
					player = dcjs.ReadObject(ms) as PlayerWork;
					Players.Add(player);
				}
			}

			using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(master.m_partyWork)))
			{
				var dcjs = new DataContractJsonSerializer(typeof(PartyWork));
				Party = dcjs.ReadObject(ms) as PartyWork;
			}

			Filename = filename;
		}

		public void SaveAs(string filename)
		{
			var master = new OriginalJson();
			master.m_playerWork = new List<string>();
			var dcjs = new DataContractJsonSerializer(typeof(PartyWork));
			using (var ms = new MemoryStream())
			{
				dcjs.WriteObject(ms, Party);
				master.m_partyWork = Encoding.UTF8.GetString(ms.ToArray());
			}

			foreach (var player in Players)
			{
				dcjs = new DataContractJsonSerializer(typeof(PlayerWork));
				using (var ms = new MemoryStream())
				{
					dcjs.WriteObject(ms, player);
					master.m_playerWork.Add(Encoding.UTF8.GetString(ms.ToArray()));
				}
			}

			dcjs = new DataContractJsonSerializer(typeof(OriginalJson));
			string contents;
			using (var ms = new MemoryStream())
			{
				dcjs.WriteObject(ms, master);
				contents = Encoding.UTF8.GetString(ms.ToArray());
			}

			File.WriteAllText(filename, contents, new UnicodeEncoding(false, false));
			Filename = filename;
		}

		public void Save()
		{
			SaveAs(Filename);
		}

		private string Filename { get; set; }
	}
}
