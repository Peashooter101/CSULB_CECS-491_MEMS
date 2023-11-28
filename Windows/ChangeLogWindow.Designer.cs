using System.ComponentModel;

namespace MEMS
{
    partial class ChangeLogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLogWindow));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.MachineID = new System.Windows.Forms.ColumnHeader();
            this.UserID = new System.Windows.Forms.ColumnHeader();
            this.AuthorID = new System.Windows.Forms.ColumnHeader();
            this.Timestamp = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.GhostWhite;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ID, this.MachineID, this.UserID, this.AuthorID, this.Timestamp, this.Type, this.Description });
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 406);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 118;
            // 
            // MachineID
            // 
            this.MachineID.Text = "Machine ID";
            this.MachineID.Width = 77;
            // 
            // UserID
            // 
            this.UserID.Text = "User ID";
            // 
            // AuthorID
            // 
            this.AuthorID.Text = "Author ID";
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Time";
            this.Timestamp.Width = 108;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 101;
            // 
            // ChangeLogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(702, 462);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeLogWindow";
            this.Text = "[MEMS] Change Log Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeLogWindow_FormClosing);
            this.Load += new System.EventHandler(this.ChangelogWindow_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ColumnHeader MachineID;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader AuthorID;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ColumnHeader Type;

        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Description;

        private System.Windows.Forms.ListView listView1;

        #endregion
    }
}