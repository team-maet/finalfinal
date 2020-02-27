/*
 * Created by SharpDevelop.
 * User: Rea
 * Date: 3/21/2019
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace finalfinal
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
	
		}
		private int imageNumber = 1;
		
		private void LoadNextImage()
		{
			if (imageNumber == 10)
			{
				imageNumber = 1;
			}
			pictureBox2.ImageLocation = string.Format(@"Images/{0}.jpg",imageNumber);
			imageNumber++;
		}
			
		void Timer1Tick(object sender, EventArgs e) 
		{
			LoadNextImage();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 sistema = new Form1();
			sistema.ShowDialog();
			this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 sistema = new Form2();
			sistema.ShowDialog();
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 sistema = new Form3();
			sistema.ShowDialog();
			this.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			Form4 sistema = new Form4();
			sistema.ShowDialog();
			this.Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 sistema = new Form5();
			sistema.ShowDialog();
			this.Close();
		}
		void Button6Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button7Click(object sender, EventArgs e)
		{
			this.Hide();
			Form6 sistema = new Form6();
			sistema.ShowDialog();
			this.Close();
		}
	}
}
