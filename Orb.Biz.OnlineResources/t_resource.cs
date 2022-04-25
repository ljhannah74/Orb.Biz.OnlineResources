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
		[Column(DbType = "Int NOT NULL", IsPrimaryKey = true, Storage = "id", CanBeNull = false)]
		public int Id { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "st")]
		public string st { get; set; }
		
		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "county")]
		
		public string county { get; set; }
		
		[Column(DbType = "bit", CanBeNull = true, Storage = "ins")]
		public string ins { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "props")]
		public string props { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "doc_retrieval")]
		public string doc_retrieval { get; set; }

		[Column(DbType = "money", CanBeNull = true, Storage = "subscrFeeAmt")]
		public string subscrFeeAmt { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "subscr_term")]
		public string subscr_term { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "subscribed")]
		public string subscribed { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "sub_need")]
		public string sub_need { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "tap")]
		public string tap { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "rv")]
		public string rv { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "dtree_desk")]
		public string dtree_desk { get; set; }

		[Column(DbType = "date", CanBeNull = true, Storage = "img_date")]
		public string img_date { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "copy_source")]
		public string copy_source { get; set; }

		[Column(DbType = "money", CanBeNull = true, Storage = "copyFeeAmt")]
		public string copyFeeAmt { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "copy_pmt_method")]
		public string copy_pmt_method { get; set; }

		[Column(DbType = "date", CanBeNull = true, Storage = "index_date")]
		public string index_date { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "index_source")]
		public string index_source { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "index_pmt_method")]
		public string index_pmt_method { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "land_url")]
		public string land_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "county_user")]
		public string county_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "county_pwd")]
		public string county_pwd { get; set; }

		[Column(DbType = "bit NOT NULL", Storage = "login_req", CanBeNull = false]
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
