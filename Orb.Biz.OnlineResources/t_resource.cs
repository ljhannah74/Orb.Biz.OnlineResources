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
		[Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
		public int id { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? st { get; set; }
		
		[Column(DbType = "NVarChar(255) NULL")]
		public string? county { get; set; }
		
		[Column(DbType = "bit NULL")]
		public bool? ins { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? props { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? copy { get; set; }

		[Column(DbType = "money NULL")]
		public decimal? subFee { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? sub_term { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? we_subscribe { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? sub_need { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? tap { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? rv { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? dtree_desk { get; set; }

		[Column(DbType = "date NULL")]
		public DateTime? img_date { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? copy_source { get; set; }

		[Column(DbType = "money NULL")]
		public decimal? copyFeeAmt { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? copy_pmt_method { get; set; }

		[Column(DbType = "date NULL")]
		public DateTime? index_date { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? index_source { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? index_pmt_method { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? land_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? county_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? county_pwd { get; set; }

		[Column(DbType = "bit NULL")]
		public bool? login_req { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? court_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? court_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? court_pwd { get; set; }

		[Column(DbType = "date NULL")]
		public DateTime? courtIndexDt { get; set; }

		[Column(DbType = "date NULL")]
		public DateTime? courtImgDt { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? muniCourt_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? muni_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? muni_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? tax_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? tax_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? tax_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? tax2_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? tax2_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? tax2_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? prothon_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? pro_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? pro_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? assessor_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? assessor_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? assessor_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? probate_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? probate_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? probate_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? other_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? other_user { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? other_pwd { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? ucc_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? map_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? plat_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? foreclosure_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? sheriff_url { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? county_homepage { get; set; }

		[Column(DbType = "NVarChar(255) NULL")]
		public string? comments { get; set; }
	}
}
