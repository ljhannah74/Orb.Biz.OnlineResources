using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orb.Biz.OnlineResources.Properties
{
	internal sealed class Settings
	{
		public string ORB_DB
		{
			get
			{
				return "Data Source=DESKTOP-8E6IIU3;Initial Catalog = orb; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			}
		}
	}
}
