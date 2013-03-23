using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LearningCSharp {

	// Planets in our solar system
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
		private void run_Click(object sender, System.EventArgs e) {

			int x = 42;
			Output( x );

			// TODO: 1 Initialize the suzanName variable with the value "Suzan Fine"
			string suzanName;
			Output( null );

			// TODO: 2 Declare and initialize a variable to hold a currency amount (135.20)
			Output( null );

			// TODO: 3 Using the Planet enumeration, assign Planet.Earth to ourPlanet
			// Display the contents of the variable
			Output( null );

		}
	}
}
