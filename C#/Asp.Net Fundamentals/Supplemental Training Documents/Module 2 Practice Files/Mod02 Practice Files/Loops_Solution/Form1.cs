using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Loops {
	/// <summary>
	/// Summary description for Form1.
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
			this.richTextBox.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.richTextBox.Location = new System.Drawing.Point(8, 8);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(272, 208);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// run
			// 
			this.run.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.run.Location = new System.Drawing.Point(8, 232);
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
			this.Text = "Loops";
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

		// Display strings on the main window form
		private void Output(object anyObject) {
			if ( anyObject != null ) {
				richTextBox.AppendText( anyObject.ToString() + "\n" );
			}
		}

		// This code runs when the Run button is clicked on the main form
		private void run_Click(object sender, System.EventArgs e) {
			// TODO 1: writing loops

			// For loop is a natural way to do solve this problem
			int total = 0;
			for ( int i = 0; i <= 1000; i++ ) {
				total += i;
			}
			Output("Result: " + total);


			// The while loop is basically the same, but it takes a little more work
			// because we have to remember to initialize and increment j
			int j = 0;
			total = 0;
			while ( j <= 1000 ) {
				total += j;
				j++;
			}
			Output("Result (while loop): " + total);  


			// The do loop is not the best solution for this problem
			// Solution illustrates the use of "break" to exit the loop
			int k = 0;
			total = 0;
			do {
				k ++;
				if ( k > 1000 ) {
					break;
				}
				total += k;
			} while ( true );
			Output("Result (do loop): " + total);  

		}
	}
}