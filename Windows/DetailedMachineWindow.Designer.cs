using System.ComponentModel;

namespace MEMS.Windows
{
    partial class DetailedMachineWindow
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
            this.lblTop = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblManu = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.serialBox = new System.Windows.Forms.TextBox();
            this.manuBox = new System.Windows.Forms.TextBox();
            this.zoneBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.Location = new System.Drawing.Point(11, 11);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(408, 28);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Machine Information";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(11, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(11, 92);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(95, 28);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(11, 124);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(95, 28);
            this.lblSerial.TabIndex = 3;
            this.lblSerial.Text = "Serial #";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManu
            // 
            this.lblManu.Location = new System.Drawing.Point(11, 154);
            this.lblManu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(95, 28);
            this.lblManu.TabIndex = 4;
            this.lblManu.Text = "Manufacturer";
            this.lblManu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZone
            // 
            this.lblZone.Location = new System.Drawing.Point(11, 188);
            this.lblZone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(95, 28);
            this.lblZone.TabIndex = 5;
            this.lblZone.Text = "Zone";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(113, 60);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(304, 22);
            this.nameBox.TabIndex = 6;
            // 
            // modelBox
            // 
            this.modelBox.Enabled = false;
            this.modelBox.Location = new System.Drawing.Point(113, 92);
            this.modelBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(304, 22);
            this.modelBox.TabIndex = 7;
            // 
            // serialBox
            // 
            this.serialBox.Enabled = false;
            this.serialBox.Location = new System.Drawing.Point(113, 124);
            this.serialBox.Margin = new System.Windows.Forms.Padding(4);
            this.serialBox.Name = "serialBox";
            this.serialBox.Size = new System.Drawing.Size(304, 22);
            this.serialBox.TabIndex = 8;
            // 
            // manuBox
            // 
            this.manuBox.Enabled = false;
            this.manuBox.Location = new System.Drawing.Point(113, 158);
            this.manuBox.Margin = new System.Windows.Forms.Padding(4);
            this.manuBox.Name = "manuBox";
            this.manuBox.Size = new System.Drawing.Size(304, 22);
            this.manuBox.TabIndex = 9;
            // 
            // zoneBox
            // 
            this.zoneBox.Enabled = false;
            this.zoneBox.Location = new System.Drawing.Point(113, 188);
            this.zoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.zoneBox.Name = "zoneBox";
            this.zoneBox.Size = new System.Drawing.Size(304, 22);
            this.zoneBox.TabIndex = 10;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(11, 245);
            this.moveButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(117, 28);
            this.moveButton.TabIndex = 11;
            this.moveButton.Text = "Move Machine";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(316, 245);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(137, 245);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(117, 28);
            this.saveChangesButton.TabIndex = 13;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // DetailedMachineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(427, 288);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.zoneBox);
            this.Controls.Add(this.manuBox);
            this.Controls.Add(this.serialBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.lblManu);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailedMachineWindow";
            this.Text = "[MEMS] DetailedMachineWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button saveChangesButton;

        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button closeButton;

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblManu;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox serialBox;
        private System.Windows.Forms.TextBox manuBox;
        private System.Windows.Forms.TextBox zoneBox;

        private System.Windows.Forms.Label lblTop;

        #endregion
    }
}