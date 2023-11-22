using System.ComponentModel;

namespace MEMS.Windows
{
    partial class ListMachinesWindow
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
            this.activeMachines = new System.Windows.Forms.ListView();
            this.MachineName = new System.Windows.Forms.ColumnHeader();
            this.MachineUid = new System.Windows.Forms.ColumnHeader();
            this.MachineModel = new System.Windows.Forms.ColumnHeader();
            this.MachineManufacturer = new System.Windows.Forms.ColumnHeader();
            this.MachineZone = new System.Windows.Forms.ColumnHeader();
            this.printButton = new System.Windows.Forms.Button();
            this.addNewMachineButton = new System.Windows.Forms.Button();
            this.lblDoubleClick = new System.Windows.Forms.Label();
            this.FlagButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(26, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Active Machines";
            // 
            // activeMachines
            // 
            this.activeMachines.BackColor = System.Drawing.Color.GhostWhite;
            this.activeMachines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeMachines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.MachineName, this.MachineUid, this.MachineModel, this.MachineManufacturer, this.MachineZone });
            this.activeMachines.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeMachines.GridLines = true;
            this.activeMachines.HideSelection = false;
            this.activeMachines.Location = new System.Drawing.Point(27, 49);
            this.activeMachines.Name = "activeMachines";
            this.activeMachines.Size = new System.Drawing.Size(766, 394);
            this.activeMachines.TabIndex = 1;
            this.activeMachines.UseCompatibleStateImageBehavior = false;
            this.activeMachines.View = System.Windows.Forms.View.Details;
            this.activeMachines.SelectedIndexChanged += new System.EventHandler(this.activeMachines_SelectedIndexChanged);
            this.activeMachines.DoubleClick += new System.EventHandler(this.activeMachines_DoubleClick);
            // 
            // MachineName
            // 
            this.MachineName.Text = "Name";
            this.MachineName.Width = 286;
            // 
            // MachineUid
            // 
            this.MachineUid.Text = "UID";
            this.MachineUid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MachineUid.Width = 82;
            // 
            // MachineModel
            // 
            this.MachineModel.Text = "Model";
            this.MachineModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MachineModel.Width = 109;
            // 
            // MachineManufacturer
            // 
            this.MachineManufacturer.DisplayIndex = 4;
            this.MachineManufacturer.Text = "Manufacturer";
            this.MachineManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MachineManufacturer.Width = 226;
            // 
            // MachineZone
            // 
            this.MachineZone.DisplayIndex = 3;
            this.MachineZone.Text = "Zone";
            this.MachineZone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MachineZone.Width = 62;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.GhostWhite;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printButton.Location = new System.Drawing.Point(26, 449);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(85, 32);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // addNewMachineButton
            // 
            this.addNewMachineButton.BackColor = System.Drawing.Color.GhostWhite;
            this.addNewMachineButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewMachineButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addNewMachineButton.Location = new System.Drawing.Point(657, 11);
            this.addNewMachineButton.Name = "addNewMachineButton";
            this.addNewMachineButton.Size = new System.Drawing.Size(136, 32);
            this.addNewMachineButton.TabIndex = 4;
            this.addNewMachineButton.Text = "Add New Machine";
            this.addNewMachineButton.UseVisualStyleBackColor = false;
            this.addNewMachineButton.Click += new System.EventHandler(this.NewMachineButton_Click);
            // 
            // lblDoubleClick
            // 
            this.lblDoubleClick.BackColor = System.Drawing.SystemColors.Control;
            this.lblDoubleClick.Location = new System.Drawing.Point(316, 16);
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(335, 23);
            this.lblDoubleClick.TabIndex = 6;
            this.lblDoubleClick.Text = "Double-click machine for details.";
            this.lblDoubleClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlagButton
            // 
            this.FlagButton.Location = new System.Drawing.Point(117, 449);
            this.FlagButton.Name = "FlagButton";
            this.FlagButton.Size = new System.Drawing.Size(91, 32);
            this.FlagButton.TabIndex = 7;
            this.FlagButton.Text = "Flag Machine";
            this.FlagButton.UseVisualStyleBackColor = true;
            // 
            // ListMachinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.FlagButton);
            this.Controls.Add(this.lblDoubleClick);
            this.Controls.Add(this.addNewMachineButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.activeMachines);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListMachinesWindow";
            this.Text = "Active Machines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListMachinesWindow_FormClosing);
            this.Load += new System.EventHandler(this.ListMachinesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button FlagButton;

        private System.Windows.Forms.Label lblDoubleClick;

        private System.Windows.Forms.Button addNewMachineButton;
        private System.Windows.Forms.Button addMachineButton;


        private System.Windows.Forms.ColumnHeader MachineManufacturer;

        private System.Windows.Forms.ColumnHeader MachineZone;

        private System.Windows.Forms.ColumnHeader MachineModel;

        private System.Windows.Forms.ColumnHeader MachineUid;
        private System.Windows.Forms.ColumnHeader MachineName;

        private System.Windows.Forms.ListView activeMachines;
        private System.Windows.Forms.Button printButton;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}