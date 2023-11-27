using System.ComponentModel;

namespace MEMS.Windows
{
    partial class MoveMachineWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveMachineWindow));
            this.lblMove = new System.Windows.Forms.Label();
            this.relocateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.zoneChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMove
            // 
            this.lblMove.Location = new System.Drawing.Point(14, 10);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(275, 31);
            this.lblMove.TabIndex = 0;
            this.lblMove.Text = "Please enter/choose the zone the Machine will move to:";
            this.lblMove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // relocateButton
            // 
            this.relocateButton.Location = new System.Drawing.Point(14, 87);
            this.relocateButton.Name = "relocateButton";
            this.relocateButton.Size = new System.Drawing.Size(87, 27);
            this.relocateButton.TabIndex = 2;
            this.relocateButton.Text = "Relocate";
            this.relocateButton.UseVisualStyleBackColor = true;
            this.relocateButton.Click += new System.EventHandler(this.relocateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(201, 87);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // zoneChoice
            // 
            this.zoneChoice.BackColor = System.Drawing.Color.GhostWhite;
            this.zoneChoice.FormattingEnabled = true;
            this.zoneChoice.Location = new System.Drawing.Point(78, 45);
            this.zoneChoice.Name = "zoneChoice";
            this.zoneChoice.Size = new System.Drawing.Size(140, 23);
            this.zoneChoice.TabIndex = 4;
            // 
            // MoveMachineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 133);
            this.Controls.Add(this.zoneChoice);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.relocateButton);
            this.Controls.Add(this.lblMove);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoveMachineWindow";
            this.Text = "[MEMS] MoveWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox zoneChoice;

        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Button relocateButton;
        private System.Windows.Forms.Button cancelButton;

        #endregion
    }
}