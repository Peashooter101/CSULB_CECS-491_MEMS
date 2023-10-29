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
            this.lblMove = new System.Windows.Forms.Label();
            this.newZoneBox = new System.Windows.Forms.TextBox();
            this.relocateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMove
            // 
            this.lblMove.Location = new System.Drawing.Point(12, 9);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(236, 23);
            this.lblMove.TabIndex = 0;
            this.lblMove.Text = "Please enter the zone the Machine will move to:";
            // 
            // newZoneBox
            // 
            this.newZoneBox.Location = new System.Drawing.Point(81, 35);
            this.newZoneBox.Name = "newZoneBox";
            this.newZoneBox.Size = new System.Drawing.Size(100, 20);
            this.newZoneBox.TabIndex = 1;
            this.newZoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // relocateButton
            // 
            this.relocateButton.Location = new System.Drawing.Point(12, 72);
            this.relocateButton.Name = "relocateButton";
            this.relocateButton.Size = new System.Drawing.Size(75, 23);
            this.relocateButton.TabIndex = 2;
            this.relocateButton.Text = "Relocate";
            this.relocateButton.UseVisualStyleBackColor = true;
            this.relocateButton.Click += new System.EventHandler(this.relocateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(173, 72);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MoveMachineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 107);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.relocateButton);
            this.Controls.Add(this.newZoneBox);
            this.Controls.Add(this.lblMove);
            this.Name = "MoveMachineWindow";
            this.Text = "[MEMS] MoveWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.TextBox newZoneBox;
        private System.Windows.Forms.Button relocateButton;
        private System.Windows.Forms.Button closeButton;

        #endregion
    }
}