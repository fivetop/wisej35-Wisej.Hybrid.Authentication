﻿namespace HybridLocal
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "Authenticate";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1814, 928);
			this.Text = "Page1";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button button1;
	}
}

