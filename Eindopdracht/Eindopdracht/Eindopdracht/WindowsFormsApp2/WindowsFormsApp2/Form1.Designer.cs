﻿namespace WindowsFormsApp2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button sortName;
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sortAge = new System.Windows.Forms.Button();
            sortName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // sortName
            // 
            sortName.Location = new System.Drawing.Point(165, 184);
            sortName.Name = "sortName";
            sortName.Size = new System.Drawing.Size(75, 23);
            sortName.TabIndex = 1;
            sortName.Text = "sortName";
            sortName.UseVisualStyleBackColor = true;
            sortName.Click += new System.EventHandler(this.sortName_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sortAge
            // 
            this.sortAge.Location = new System.Drawing.Point(503, 193);
            this.sortAge.Name = "sortAge";
            this.sortAge.Size = new System.Drawing.Size(75, 23);
            this.sortAge.TabIndex = 3;
            this.sortAge.Text = "sortAge";
            this.sortAge.UseVisualStyleBackColor = true;
            this.sortAge.Click += new System.EventHandler(this.sortAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortAge);
            this.Controls.Add(this.button2);
            this.Controls.Add(sortName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sortAge;
    }
}

