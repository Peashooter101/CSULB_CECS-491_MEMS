using System.ComponentModel;

namespace MEMS.Windows
{
    partial class MainMenuMaintenanceReminderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuMaintenanceReminderWindow));
            this.maintenanceEntriesList = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.severity = new System.Windows.Forms.ColumnHeader();
            this.maintenanceTime = new System.Windows.Forms.ColumnHeader();
            this.userId = new System.Windows.Forms.ColumnHeader();
            this.machineId = new System.Windows.Forms.ColumnHeader();
            this.type = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.flashTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.flashTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // maintenanceEntriesList
            // 
            this.maintenanceEntriesList.BackColor = System.Drawing.Color.GhostWhite;
            this.maintenanceEntriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.id, this.severity, this.maintenanceTime, this.userId, this.machineId, this.type, this.description });
            this.maintenanceEntriesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.maintenanceEntriesList.FullRowSelect = true;
            this.maintenanceEntriesList.GridLines = true;
            this.maintenanceEntriesList.HideSelection = false;
            this.maintenanceEntriesList.Location = new System.Drawing.Point(14, 14);
            this.maintenanceEntriesList.Name = "maintenanceEntriesList";
            this.maintenanceEntriesList.Size = new System.Drawing.Size(671, 491);
            this.maintenanceEntriesList.TabIndex = 12;
            this.maintenanceEntriesList.UseCompatibleStateImageBehavior = false;
            this.maintenanceEntriesList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // severity
            // 
            this.severity.Text = "Severity";
            this.severity.Width = 72;
            // 
            // maintenanceTime
            // 
            this.maintenanceTime.Text = "Maintenance Time";
            this.maintenanceTime.Width = 100;
            // 
            // userId
            // 
            this.userId.Text = "User";
            // 
            // machineId
            // 
            this.machineId.Text = "Machine ID";
            this.machineId.Width = 71;
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 477;
            // 
            // flashTimer
            // 
            this.flashTimer.SynchronizingObject = this;
            // 
            // MainMenuMaintenanceReminderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 549);
            this.Controls.Add(this.maintenanceEntriesList);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuMaintenanceReminderWindow";
            this.Text = "[MEMS] Maintenance Reminder";
            this.Load += new System.EventHandler(this.MainMenuMaintenanceReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flashTimer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer flashTimer;

        private System.Windows.Forms.ListView maintenanceEntriesList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader severity;
        private System.Windows.Forms.ColumnHeader maintenanceTime;
        private System.Windows.Forms.ColumnHeader userId;
        private System.Windows.Forms.ColumnHeader machineId;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader description;

        #endregion
    }
}