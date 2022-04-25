using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Orb.Biz.OnlineResources.Properties;

namespace Orb.Biz.OnlineResources
{
	[Database(Name = "orb")]
	public class OrbDataContext : DataContext
	{
		public OrbDataContext() : base("Data Source=DESKTOP-8E6IIU3;Initial Catalog=orb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") 
		{
		}
		public Table<t_resource> t_resources => this.GetTable<t_resource>();
	}
}