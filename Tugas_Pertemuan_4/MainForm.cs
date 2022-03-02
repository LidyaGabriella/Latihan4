using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_Pertemuan_4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello, Selamat Datang di Mata Kuliah "+this.tbMK.Text
			                +Environment.NewLine
			                + Environment.NewLine
			                +"Nama : "+this.tbNama.Text
			                +Environment.NewLine
			                +"NIM    : "+this.tbNim.Text
			                +Environment.NewLine
			                +"Kelas  : "+this.tbKelas.Text);			                
		}
	}
}
