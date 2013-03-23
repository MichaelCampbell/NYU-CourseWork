using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LearningCSharp {

	// The well-known planets of the solar system
	// You can refer to Mars (for example) as Planet.Mars
	enum Planet {
		Mercury, 
		Venus, 
		Earth, 
		Mars, 
		Jupiter, 
		Saturn, 
		Uranus, 
		Nepture, 
		Pluto
	}
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
			this.richTextBox.Size = new System.Drawing.Size(320, 248);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// run
			// 
			this.run.Location = new System.Drawing.Point(8, 264);
			this.run.Name = "run";
			this.run.TabIndex = 1;
			this.run.Text = "Run";
			this.run.Click += new System.EventHandler(this.run_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 294);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.run,
																		  this.richTextBox});
			this.Name = "Form1";
			this.Text = "Types";
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

		// Simple method to display items on the main form
		private void Output(object anyObject) {
			if ( anyObject == null )
				return;
			richTextBox.AppendText(anyObject + "\n");
		}

		/// <summary>
		/// Button click event handler: produce output
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		// Runs when the Run button is clicked on the main form
		private void run_Click(object sender, System.EventArgs e) {

			int x = 42;
			Output( x );  // Writes "42" on the main form

			// TODO: 1 Initialize the suzanName variable with the value "Suzan Fine"
			string suzanName = "Suzan Fine";
			Output( suzanName );

			// TODO: 2 Declare and initialize a variable to hold a currency amount (135.20)
			// A decimal is used to the M suffix defines the literal value 135.20 as a decimal
			decimal currencyAmount = 135.20M;
			Output( currencyAmount );

			// TODO: 3 Using the Planet enumeration, assign Planet.Earth to ourPlanet.
			// Display the contents of the variable
			Planet ourPlanet = Planet.Earth;
			Output( ourPlanet );
			


			// More examples - these are in addition to the ones listed in the practice 

			// Write a note saying that the ones below are not part of the practice
			Output("");
			Output("------");
			Output("Additional Samples; not part of the practice");

			// Declare and initialize a variable that represents someone's age
			// It's good to use an int as the defult intereger type 
			// unless there is a good reason not to
			int age = 38;
			Output( age );

			// Declare a string with the value C:\tmp\sample.txt
			// Verbatim strings make it easy to specify file paths
			string tmpFile = @"C:\tmp\sample.txt";
			Output( tmpFile );

			// Declare a string that has the following value:
			// 123 High Street
			// Sammamish
			// The \n puts a newline into the string
			// We can't use a verbatim because that would literally place \n in the string
			string someAddress = "123 High Street\nSammamish";
			Output( someAddress );

			// Declare and initialize a variable PI (3.14)
			// F suffix means the literal 3.14 is a float type
			const float Pi = 3.14F;
			Output( Pi );

			// Assign 65537 to an int, then assign the int to an unsigned short
			// What value is in the ushort?
			int myInt = 65537;
			ushort myShort = (ushort)myInt;
			Output( myShort );
			// myShort has the value 1.
			// This is because a ushort can hold a maximum of 2^16 (2 to the power 16)
			// numbers. 2^16 is 65536. One of the numbers is 0 so the maximum value 
			// a ushort can hold is 65535. 65537 is two more than this value: the 
			// "extra" information is lost in the assignment. 65536 would have
			// resulted in 0; 65537 results in 1 being left in the ushort.
			// You can think of this as being like numbers rolling over on a car gauge.
		}
	}
}
