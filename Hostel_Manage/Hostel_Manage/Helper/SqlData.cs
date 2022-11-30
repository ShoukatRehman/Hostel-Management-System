using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manage.Helper
{
	public class SqlData
	{
		SqlConnection con;
		public static String ConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
		public void Opencon()
		{
			con = new SqlConnection(ConString);
			con.Open();
		}
		public void Closecon()
		{
			con=new SqlConnection(ConString);
			con.Close();
		}
		public void NonQueryExecter(string Query)
		{
			SqlCommand cmd=new SqlCommand(Query,con);
			cmd.ExecuteNonQuery();
		}
	}
}
