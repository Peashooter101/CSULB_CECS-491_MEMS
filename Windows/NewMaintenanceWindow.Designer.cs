using System.ComponentModel;

namespace MEMS
{
    partial class NewMaintenanceWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listview = new System.Windows.Forms.ListView();
            this.MachineName = new System.Windows.Forms.ColumnHeader();
            this.MachineUID = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Machine Selection";
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.MachineName, this.MachineUID });
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(86, 154);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(124, 482);
            this.listview.TabIndex = 1;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // MachineName
            // 
            this.MachineName.Text = "Name";
            // 
            // MachineUID
            // 
            this.MachineUID.Text = "UID";
            // 
            // NewMaintenanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 655);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.textBox1);
            this.Name = "NewMaintenanceWindow";
            this.Text = "NewMaintenanceWindow";
            this.Load += new System.EventHandler(this.NewMaintenanceWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ColumnHeader MachineName;
        private System.Windows.Forms.ColumnHeader MachineUID;

        private System.Windows.Forms.ListView listview;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}