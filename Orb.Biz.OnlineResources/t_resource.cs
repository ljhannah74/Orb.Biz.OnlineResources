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
		public bool ins { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "props")]
		public bool props { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "doc_retrieval")]
		public bool doc_retrieval { get; set; }

		[Column(DbType = "money", CanBeNull = true, Storage = "subscrFeeAmt")]
		public decimal subscrFeeAmt { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "subscr_term")]
		public string subscr_term { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "subscribed")]
		public bool subscribed { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "sub_need")]
		public bool sub_need { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "tap")]
		public bool tap { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "rv")]
		public bool rv { get; set; }

		[Column(DbType = "bit", CanBeNull = true, Storage = "dtree_desk")]
		public bool dtree_desk { get; set; }

		[Column(DbType = "date", CanBeNull = true, Storage = "img_date")]
		public DateTime img_date { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "copy_source")]
		public string copy_source { get; set; }

		[Column(DbType = "money", CanBeNull = true, Storage = "copyFeeAmt")]
		public decimal copyFeeAmt { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "copy_pmt_method")]
		public string copy_pmt_method { get; set; }

		[Column(DbType = "date", CanBeNull = true, Storage = "index_date")]
		public DateTime index_date { get; set; }

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
		public bool login_req { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "court_url")]
		public string court_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "court_user")]
		public string court_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "court_pwd")]
		public string court_pwd { get; set; }

		[Column(DbType = "date", CanBeNull = true, Storage = "courtIndexDate")]
		public DateTime courtIndexDate { get; set; }

		[Column(DbType = "date", CanBeNull = true, Storage = "courtImageDate")]
		public DateTime courtImageDate { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "muniCourt_url")]
		public string muniCourt_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "muniCourt_user")]
		public string muniCourt_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "muniCourt_pwd")]
		public string muniCourt_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "tax_url")]
		public string tax_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "tax_user")]
		public string tax_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "tax_pwd")]
		public string tax_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "tax2_url")]
		public string tax2_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "tax2_user")]
		public string tax2_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "tax2_pwd")]
		public string tax2_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "prothon_url")]
		public string prothon_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "pro_user")]
		public string pro_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "pro_pwd")]
		public string pro_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "assessor_url")]
		public string assessor_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "assessor_user")]
		public string assessor_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "assessor_pwd")]
		public string assessor_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "probate_url")]
		public string probate_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "probate_user")]
		public string probate_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "probate_pwd")]
		public string probate_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "other_url")]
		public string other_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "other_user")]
		public string other_user { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "other_pwd")]
		public string other_pwd { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "ucc_url")]
		public string ucc_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "map_url")]
		public string map_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "plat_url")]
		public string plat_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "foreclosure_url")]
		public string foreclosure_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "sheriff_url")]
		public string sheriff_url { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "county_homepage")]
		public string county_homepage { get; set; }

		[Column(DbType = "NVarChar(255)", CanBeNull = true, Storage = "comments")]
		public string comments { get; set; }
	}
}
