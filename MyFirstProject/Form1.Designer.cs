﻿namespace MyFirstProject
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			button1.BackColor = SystemColors.HighlightText;
			button1.Location = new Point(12, 365);
			button1.Name = "button1";
			button1.Size = new Size(494, 73);
			button1.TabIndex = 0;
			button1.Text = "Open Link";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 64);
			label1.Name = "label1";
			label1.Size = new Size(90, 15);
			label1.TabIndex = 1;
			label1.Text = "Enter Some text";
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(12, 93);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(494, 23);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged_1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Highlight;
			ClientSize = new Size(518, 446);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "My App";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox textBox1;
	}
}
