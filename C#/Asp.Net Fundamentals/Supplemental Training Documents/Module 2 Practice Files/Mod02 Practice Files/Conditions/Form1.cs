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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown visitorsUpDown;
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
			this.visitorsUpDown = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.visitorsUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox
			// 
			this.richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.richTextBox.Location = new System.Drawing.Point(8, 8);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(304, 216);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// run
			// 
			this.run.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.run.Location = new System.Drawing.Point(8, 232);
			this.run.Name = "run";
			this.run.TabIndex = 1;
			this.run.Text = "Run";
			this.run.Click += new System.EventHandler(this.run_Click);
			// 
			// visitorsUpDown
			// 
			this.visitorsUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.visitorsUpDown.Location = new System.Drawing.Point(240, 232);
			this.visitorsUpDown.Maximum = new System.Decimal(new int[] {
																		   100000,
																		   0,
																		   0,
																		   0});
			this.visitorsUpDown.Minimum = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   -2147483648});
			this.visitorsUpDown.Name = "visitorsUpDown";
			this.visitorsUpDown.Size = new System.Drawing.Size(72, 20);
			this.visitorsUpDown.TabIndex = 2;
			this.visitorsUpDown.Value = new System.Decimal(new int[] {
																		 3000,
																		 0,
																		 0,
																		 0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Visitors:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.visitorsUpDown,
																		  this.run,
																		  this.richTextBox});
			this.Name = "Form1";
			this.Text = "Conditions";
			((System.ComponentModel.ISupportInitialize)(this.visitorsUpDown)).EndInit();
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

		private void Output( object anyObject ) {
			richTextBox.AppendText( anyObject.ToString() + "\n" );
		}


		private void run_Click(object sender, System.EventArgs e) {
			int visitors = (int) visitorsUpDown.Value;

			// Code placed here will run when the button on the form is clicked

			// TODO 1: using if statements
			// If the number of visitors (in the "visitors" variable) is
			// 5000 or more, then output a message saying that the target
			// was achieved. Otherwise output a message saying that the target
			// was not achieved.



		}
	}
}
