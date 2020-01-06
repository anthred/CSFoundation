// File: WinForm1.cs
using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
	public MyForm()
	{
		// Change the caption of the application.
		Text = "Hello World";

		// Change the background color of the window
		BackColor = Color.Blue;
	}

	static void Main()
	{
		MyForm myForm = new MyForm();

		// Remove the minimize and maximize box from the window
		myForm.MaximizeBox = false;
		myForm.MinimizeBox = false;

		// Make the window almost invisible
		////myForm.Visible = false;
		////myForm.SetVisibleCore(false);
		//myForm.TransparencyKey = myForm.BackColor;

		// Make the window display as maximized
		//myForm.WindowState = FormWindowState.Maximized;

		// Set the position and size of the window
		myForm.StartPosition = FormStartPosition.CenterScreen;
		myForm.Width = 1000;
		myForm.Height = 300;

		// Display the form.
		Application.Run(myForm);
	}
}