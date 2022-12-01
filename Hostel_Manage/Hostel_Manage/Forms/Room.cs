using Hostel_Manage.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Manage.Forms
{
	public partial class Room : Form
	{
		SqlData sqlData= new SqlData();
		public Room()
		{
			InitializeComponent();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			String Query = "INSERT INTO tbl_Room VALUES ('" + txt_Number.Text + "','" + txt_Floor.Text + "','" + cmb_Type.Text + "','" + cmb_washroom.Text + "','" + txt_seatsRent.Text + "')";
			sqlData.Opencon();
			sqlData.NonQueryExecter(Query);
			sqlData.Closecon();
			MyMessage.Success("Room");
		}
	}
}
