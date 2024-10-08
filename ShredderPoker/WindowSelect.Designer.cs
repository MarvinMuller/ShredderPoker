using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShredderPoker
{
    partial class WindowSelect
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
            this.tcSelect = new System.Windows.Forms.Button();
            this.tcWindowList = new System.Windows.Forms.ListBox();
            this.tcLabel = new System.Windows.Forms.Label();
            this.tcCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcSelect
            // 
            this.tcSelect.BackgroundImage = global::ShredderPoker.Properties.Resources.verified;
            this.tcSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcSelect.Location = new System.Drawing.Point(141, 175);
            this.tcSelect.Name = "tcSelect";
            this.tcSelect.Size = new System.Drawing.Size(25, 25);
            this.tcSelect.TabIndex = 0;
            this.tcSelect.UseVisualStyleBackColor = true;
            this.tcSelect.Click += new System.EventHandler(this.tcSelect_Click);
            // 
            // tcWindowList
            // 
            this.tcWindowList.FormattingEnabled = true;
            this.tcWindowList.ItemHeight = 15;
            this.tcWindowList.Location = new System.Drawing.Point(12, 30);
            this.tcWindowList.Name = "tcWindowList";
            this.tcWindowList.Size = new System.Drawing.Size(182, 139);
            this.tcWindowList.TabIndex = 1;
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.Location = new System.Drawing.Point(12, 6);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(77, 15);
            this.tcLabel.TabIndex = 2;
            this.tcLabel.Text = "Select a Table";
            // 
            // tcCancel
            // 
            this.tcCancel.BackgroundImage = global::ShredderPoker.Properties.Resources.tcCancel;
            this.tcCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcCancel.Location = new System.Drawing.Point(169, 175);
            this.tcCancel.Name = "tcCancel";
            this.tcCancel.Size = new System.Drawing.Size(25, 25);
            this.tcCancel.TabIndex = 3;
            this.tcCancel.UseVisualStyleBackColor = true;
            this.tcCancel.Click += new System.EventHandler(this.tcCancel_Click);
            // 
            // WindowSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 208);
            this.Controls.Add(this.tcCancel);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.tcWindowList);
            this.Controls.Add(this.tcSelect);
            this.Name = "WindowSelect";
            this.Text = "tcWindowSelect";
            this.Load += new System.EventHandler(this.tcWindowSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tcSelect;
        private ListBox tcWindowList;
        private Label tcLabel;
        private Button tcCancel;
    }
}
