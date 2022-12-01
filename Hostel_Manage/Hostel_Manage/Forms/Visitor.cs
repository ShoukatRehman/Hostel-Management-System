using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Manage.Forms
{
	public partial class Visitor : Form
	{
		public Visitor()
		{
			InitializeComponent();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string Query="INSERT INTO tbl_Visitor VALUES('"+txt_CNIC.Text+"','"+txt_Name.Text+"','"+txt_VistorRelation.Text+"','"+txt_CNIC.Text+"','"+txt_Name.Text+')"
		}
	}
}
