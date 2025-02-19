﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WannaHome.Model.WanaHome
{
	public  class UpdateVoteInfo
	{
		//服务器ID
		public ushort server { get; set; }
		//房区
		public ushort territory { get; set; }
		public ushort ward { get; set; }
		public ushort housenumber { get; set; }
		public byte size { get; set; }
		public ushort type { get; set; }
		public string owner { get; set; } = "";
		public ushort sell { get; set; }
		public uint price { get; set; }
		public uint votecount { get; set; }
		public uint winner { get; set; }
		public string plugin_version { get; set; } = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "0.0.0.0";
	}
}
