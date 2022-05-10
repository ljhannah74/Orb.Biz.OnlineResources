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
				return orbDataContext.t_resources.Where(rs => rs.st == st && rs.county == county)
									 .SingleOrDefault();
			}
		}

		public List<t_state> GetStates()
		{
			using (OrbDataContext orbDataContext = new OrbDataContext())
			{
				return orbDataContext.t_resources.Select(rs => new t_state { st_name = rs.st })
					.Distinct()
					.OrderBy(rs => rs.st_name)
					.ToList();
			}
		}

		public List<t_county> GetCountiesByState(string st)
		{
			using (OrbDataContext orbDataContext = new OrbDataContext())
			{
				return orbDataContext.t_resources.Select(rs => new t_county { st_name = rs.st, county_name = rs.county })
					.Where(rs => rs.st_name == st)
					.OrderBy(rs => rs.county_name)
					.ToList();
			}
		}

		public int SaveOnlineResource(t_resource res)
		{
			using (OrbDataContext orbDataContext = new OrbDataContext())
			{
				var exsiting_orb = orbDataContext.t_resources.Where(rs => rs.st == res.st && rs.county == res.county)
									 .SingleOrDefault();
				if (!existing_orb == null)
				{
				}

			}
		}
	}
	}
}
