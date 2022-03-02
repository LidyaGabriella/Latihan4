/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 3/2/2022
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas_Pertemuan_4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbNama = new System.Windows.Forms.Label();
			this.lbNim = new System.Windows.Forms.Label();
			this.lbKelas = new System.Windows.Forms.Label();
			this.lbMK = new System.Windows.Forms.Label();
			this.tbNama = new System.Windows.Forms.TextBox();
			this.tbKelas = new System.Windows.Forms.TextBox();
			this.tbNim = new System.Windows.Forms.TextBox();
			this.tbMK = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbNama
			// 
			this.lbNama.Location = new System.Drawing.Point(13, 48);
			this.lbNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNama.Name = "lbNama";
			this.lbNama.Size = new System.Drawing.Size(91, 27);
			this.lbNama.TabIndex = 0;
			this.lbNama.Text = "Nama";
			this.lbNama.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbNim
			// 
			this.lbNim.Location = new System.Drawing.Point(13, 77);
			this.lbNim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNim.Name = "lbNim";
			this.lbNim.Size = new System.Drawing.Size(91, 27);
			this.lbNim.TabIndex = 1;
			this.lbNim.Text = "NIM";
			this.lbNim.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbKelas
			// 
			this.lbKelas.Location = new System.Drawing.Point(13, 106);
			this.lbKelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbKelas.Name = "lbKelas";
			this.lbKelas.Size = new System.Drawing.Size(91, 27);
			this.lbKelas.TabIndex = 2;
			this.lbKelas.Text = "Kelas";
			this.lbKelas.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbMK
			// 
			this.lbMK.Location = new System.Drawing.Point(13, 135);
			this.lbMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbMK.Name = "lbMK";
			this.lbMK.Size = new System.Drawing.Size(91, 27);
			this.lbMK.TabIndex = 3;
			this.lbMK.Text = "Mata Kuliah";
			this.lbMK.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbNama
			// 
			this.tbNama.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbNama.Location = new System.Drawing.Point(154, 45);
			this.tbNama.Name = "tbNama";
			this.tbNama.Size = new System.Drawing.Size(221, 23);
			this.tbNama.TabIndex = 4;
			// 
			// tbKelas
			// 
			this.tbKelas.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbKelas.Location = new System.Drawing.Point(154, 103);
			this.tbKelas.Name = "tbKelas";
			this.tbKelas.Size = new System.Drawing.Size(221, 23);
			this.tbKelas.TabIndex = 5;
			// 
			// tbNim
			// 
			this.tbNim.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbNim.Location = new System.Drawing.Point(154, 74);
			this.tbNim.Name = "tbNim";
			this.tbNim.Size = new System.Drawing.Size(221, 23);
			this.tbNim.TabIndex = 6;
			// 
			// tbMK
			// 
			this.tbMK.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbMK.Location = new System.Drawing.Point(154, 132);
			this.tbMK.Name = "tbMK";
			this.tbMK.Size = new System.Drawing.Size(221, 23);
			this.tbMK.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(114, 196);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 26);
			this.button1.TabIndex = 8;
			this.button1.Text = "Klik Saya";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(415, 256);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbMK);
			this.Controls.Add(this.tbNim);
			this.Controls.Add(this.tbKelas);
			this.Controls.Add(this.tbNama);
			this.Controls.Add(this.lbMK);
			this.Controls.Add(this.lbKelas);
			this.Controls.Add(this.lbNim);
			this.Controls.Add(this.lbNama);
			this.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.Text = "Tugas_Pertemuan_4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbMK;
		private System.Windows.Forms.TextBox tbNim;
		private System.Windows.Forms.TextBox tbKelas;
		private System.Windows.Forms.TextBox tbNama;
		private System.Windows.Forms.Label lbMK;
		private System.Windows.Forms.Label lbKelas;
		private System.Windows.Forms.Label lbNim;
		private System.Windows.Forms.Label lbNama;
	}
}
