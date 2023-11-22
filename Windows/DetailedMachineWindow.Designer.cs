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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedMachineWindow));
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
            this.lblTop.Location = new System.Drawing.Point(9, 11);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(357, 27);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Machine Information";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(9, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 27);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(9, 87);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(83, 27);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(9, 117);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(83, 27);
            this.lblSerial.TabIndex = 3;
            this.lblSerial.Text = "Serial #";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManu
            // 
            this.lblManu.Location = new System.Drawing.Point(9, 150);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(97, 27);
            this.lblManu.TabIndex = 4;
            this.lblManu.Text = "Manufacturer";
            this.lblManu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManu.Click += new System.EventHandler(this.lblManu_Click);
            // 
            // lblZone
            // 
            this.lblZone.Location = new System.Drawing.Point(9, 177);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(83, 27);
            this.lblZone.TabIndex = 5;
            this.lblZone.Text = "Zone";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.GhostWhite;
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(113, 58);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(266, 23);
            this.nameBox.TabIndex = 6;
            // 
            // modelBox
            // 
            this.modelBox.BackColor = System.Drawing.Color.GhostWhite;
            this.modelBox.Enabled = false;
            this.modelBox.Location = new System.Drawing.Point(113, 87);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(266, 23);
            this.modelBox.TabIndex = 7;
            // 
            // serialBox
            // 
            this.serialBox.BackColor = System.Drawing.Color.GhostWhite;
            this.serialBox.Enabled = false;
            this.serialBox.Location = new System.Drawing.Point(113, 117);
            this.serialBox.Name = "serialBox";
            this.serialBox.Size = new System.Drawing.Size(266, 23);
            this.serialBox.TabIndex = 8;
            // 
            // manuBox
            // 
            this.manuBox.BackColor = System.Drawing.Color.GhostWhite;
            this.manuBox.Enabled = false;
            this.manuBox.Location = new System.Drawing.Point(113, 147);
            this.manuBox.Name = "manuBox";
            this.manuBox.Size = new System.Drawing.Size(266, 23);
            this.manuBox.TabIndex = 9;
            // 
            // zoneBox
            // 
            this.zoneBox.BackColor = System.Drawing.Color.GhostWhite;
            this.zoneBox.Enabled = false;
            this.zoneBox.Location = new System.Drawing.Point(113, 179);
            this.zoneBox.Name = "zoneBox";
            this.zoneBox.Size = new System.Drawing.Size(266, 23);
            this.zoneBox.TabIndex = 10;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(9, 229);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(103, 27);
            this.moveButton.TabIndex = 11;
            this.moveButton.Text = "Move Machine";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(276, 229);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 27);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(120, 229);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(103, 27);
            this.saveChangesButton.TabIndex = 13;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // DetailedMachineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(394, 272);
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
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailedMachineWindow";
            this.Text = "[MEMS] Detailed Machine Window";
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