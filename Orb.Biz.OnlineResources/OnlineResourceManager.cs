using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orb.Biz.OnlineResources
{
	public class OnlineResourceManager
	{
		public t_resource GetByStateCounty(string st, string county)
		{
			using (OrbDataContext orbDataContext = new OrbDataContext())
			{
				return orbDataContext.t_resources.Where(rs => rs.st == st && rs.county == county).SingleOrDefault();
			}
		}
	}
}
