using Hostel_Manage.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Manage
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Student_Registration student= new Student_Registration();
			student.IsMdiContainer=true;
			student.Show();
		}

		private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Staff staff=new Staff();
			staff.IsMdiContainer=true;
			staff.Show();
		}

		private void registerRoomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Room room = new Room();
			room.IsMdiContainer=true;
			room.Show();
		}

		private void assignRoomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AssignRoom assignRoom = new AssignRoom();
			assignRoom.IsMdiContainer=true;
			assignRoom.Show();
		}

		private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Visitor visitor = new Visitor();
			visitor.IsMdiContainer=true;
			visitor.Show();
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			Visitor visitor = new Visitor();
			visitor.IsMdiContainer = true;
			visitor.Show();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			AssignRoom assignRoom = new AssignRoom();
			assignRoom.IsMdiContainer = true;
			assignRoom.Show();
		}
	}
}
