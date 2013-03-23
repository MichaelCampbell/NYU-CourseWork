using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LearningCSharp {
	/// <summary>
	/// Main window.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Button run;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void Output(object anyObject) {
			if ( anyObject == null )
				return;
			richTextBox.AppendText(anyObject + "\n");
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.run = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox
			// 
			this.richTextBox.Location = new System.Drawing.Point(8, 8);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(272, 216);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// run
			// 
			this.run.Location = new System.Drawing.Point(16, 232);
			this.run.Name = "run";
			this.run.TabIndex = 1;
			this.run.Text = "Run";
			this.run.Click += new System.EventHandler(this.run_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.run,
																		  this.richTextBox});
			this.Name = "Form1";
			this.Text = "Operators";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		// The following code runs when the Run button on the form is clicked
		private void run_Click(object sender, System.EventArgs e) {

			int x = 10;

			// Task 1
			int y = x++;
			Output( y );
			// x is incremented after the assignment to y

			// Task 2
			x += 10;
			Output( x );
			// x was incremented.

			// Task 3
			int z = 30;
			int a = x + y * z;
			Output( a );
			// The * operator has higher precedence
			// You should always use parenthesis to make these statements
			// unambiguous:  int a = x + (y * z);

			// Task 4
			a = 10;
			int b = a++;
			bool myBool = ( a == b );
			Output ( myBool );
			// b was assigned a before a was incremented. The statement (a == b)
			// results in a boolean value
		}
	}
}
