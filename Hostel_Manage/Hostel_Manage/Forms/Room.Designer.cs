namespace Hostel_Manage.Forms
{
	partial class Room
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_Number = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Floor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmb_Type = new System.Windows.Forms.ComboBox();
			this.cmb_washroom = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.txt_seatsRent = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(78)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 435);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(398, 74);
			this.panel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(142, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 39);
			this.label2.TabIndex = 0;
			this.label2.Text = "Room";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(78)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(398, 90);
			this.panel1.TabIndex = 2;
			// 
			// txt_Number
			// 
			this.txt_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_Number.Location = new System.Drawing.Point(177, 128);
			this.txt_Number.Name = "txt_Number";
			this.txt_Number.Size = new System.Drawing.Size(167, 20);
			this.txt_Number.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Number";
			// 
			// txt_Floor
			// 
			this.txt_Floor.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_Floor.Location = new System.Drawing.Point(177, 174);
			this.txt_Floor.Name = "txt_Floor";
			this.txt_Floor.Size = new System.Drawing.Size(167, 20);
			this.txt_Floor.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Floor";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(44, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Type";
			// 
			// cmb_Type
			// 
			this.cmb_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmb_Type.FormattingEnabled = true;
			this.cmb_Type.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.cmb_Type.Location = new System.Drawing.Point(177, 223);
			this.cmb_Type.Name = "cmb_Type";
			this.cmb_Type.Size = new System.Drawing.Size(167, 21);
			this.cmb_Type.TabIndex = 13;
			// 
			// cmb_washroom
			// 
			this.cmb_washroom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmb_washroom.FormattingEnabled = true;
			this.cmb_washroom.Items.AddRange(new object[] {
            "True",
            "False"});
			this.cmb_washroom.Location = new System.Drawing.Point(177, 271);
			this.cmb_washroom.Name = "cmb_washroom";
			this.cmb_washroom.Size = new System.Drawing.Size(167, 21);
			this.cmb_washroom.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(44, 271);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Attach Washroom";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(44, 324);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Per Seats Rent";
			// 
			// btn_Clear
			// 
			this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
			this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Clear.Location = new System.Drawing.Point(189, 374);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(83, 39);
			this.btn_Clear.TabIndex = 33;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Clear.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
			this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Save.Location = new System.Drawing.Point(58, 374);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(83, 39);
			this.btn_Save.TabIndex = 32;
			this.btn_Save.Text = "Save";
			this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// txt_seatsRent
			// 
			this.txt_seatsRent.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_seatsRent.Location = new System.Drawing.Point(177, 320);
			this.txt_seatsRent.Name = "txt_seatsRent";
			this.txt_seatsRent.Size = new System.Drawing.Size(167, 20);
			this.txt_seatsRent.TabIndex = 34;
			// 
			// Room
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 509);
			this.Controls.Add(this.txt_seatsRent);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmb_washroom);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmb_Type);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Floor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_Number);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Room";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Room";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_Number;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Floor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb_Type;
		private System.Windows.Forms.ComboBox cmb_washroom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.TextBox txt_seatsRent;
	}
}