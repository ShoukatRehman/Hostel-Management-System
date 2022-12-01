using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Manage.Helper
{
	public static class MyMessage
	{
		public static void Success(string Name)
		{
			MessageBox.Show(Name + "Saved Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}
