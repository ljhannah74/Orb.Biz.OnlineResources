using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Orb.Biz.OnlineResources
{
	[Table(Name = "dbo.orb")]
	public class t_resource
	{
		[Column(DbType = "Int NOT NULL", IsPrimaryKey = true, Storage = "id")]
		public int Id { get; set; }


		public string st { get; set; }
		public string county { get; set; }
		public string ins { get; set; }

		public string props { get; set; }

		public string doc_retrieval { get; set; }

		public string subscrFeeAmt { get; set; }

		public string subscr_term { get; set; }

		public string subscribed { get; set; }

		public string sub_need { get; set; }

		public string tap { get; set; }

		public string rv { get; set; }

		public string dtree_desk { get; set; }

		public string img_date { get; set; }

		public string copy_source { get; set; }

		public string copyFeeAmt { get; set; }

		public string copy_pmt_method { get; set; }

		public string index_date { get; set; }

		public string index_source { get; set; }

		public string index_pmt_method { get; set; }

		public string land_url { get; set; }

		public string county_user { get; set; }

		public string county_pwd { get; set; }

		public string login_required { get; set; }

		public string court_url { get; set; }

		public string court_user { get; set; }

		public string court_pwd { get; set; }

		public string courtIndexDate { get; set; }

		public string courtImageDate { get; set; }

		public string muniCourt_url { get; set; }

		public string muniCourt_user { get; set; }

		public string muniCourt_pwd { get; set; }

		public string tax_url { get; set; }

		public string tax_user { get; set; }

		public string tax_pwd { get; set; }

		public string tax2_url { get; set; }

		public string tax2_user { get; set; }

		public string tax2_pwd { get; set; }

		public string prothon_url { get; set; }

		public string pro_user { get; set; }

		public string pro_pwd { get; set; }

		public string assessor_url { get; set; }

		public string assessor_user { get; set; }

		public string assessor_pwd { get; set; }

		public string probate_url { get; set; }

		public string probate_user { get; set; }

		public string probate_pwd { get; set; }

		public string other_url { get; set; }

		public string other_user { get; set; }

		public string other_pwd { get; set; }

		public string ucc_url { get; set; }

		public string map_url { get; set; }

		public string plat_url { get; set; }

		public string foreclosure_url { get; set; }

		public string sheriff_url { get; set; }

		public string county_homepage { get; set; }

		public string comments { get; set; }
	}
}
