using System.ComponentModel;

namespace MEMS.Windows
{
    partial class AddMachineWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMachineWindow));
            this.lblName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManu = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.manuBox = new System.Windows.Forms.TextBox();
            this.zoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingBox = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.saveDetailBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.detailBox = new System.Windows.Forms.ListBox();
            this.serialNumBox = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(16, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Machine Name";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(16, 83);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(47, 14);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblManu
            // 
            this.lblManu.Location = new System.Drawing.Point(14, 143);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(84, 20);
            this.lblManu.TabIndex = 2;
            this.lblManu.Text = "Manufacturer";
            // 
            // lblZone
            // 
            this.lblZone.Location = new System.Drawing.Point(16, 203);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(40, 18);
            this.lblZone.TabIndex = 3;
            this.lblZone.Text = "Zone";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.GhostWhite;
            this.nameBox.Location = new System.Drawing.Point(118, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(258, 23);
            this.nameBox.TabIndex = 4;
            // 
            // modelBox
            // 
            this.modelBox.BackColor = System.Drawing.Color.GhostWhite;
            this.modelBox.Location = new System.Drawing.Point(118, 83);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(258, 23);
            this.modelBox.TabIndex = 5;
            // 
            // manuBox
            // 
            this.manuBox.BackColor = System.Drawing.Color.GhostWhite;
            this.manuBox.Location = new System.Drawing.Point(118, 143);
            this.manuBox.Name = "manuBox";
            this.manuBox.Size = new System.Drawing.Size(258, 23);
            this.manuBox.TabIndex = 6;
            // 
            // zoneBox
            // 
            this.zoneBox.BackColor = System.Drawing.Color.GhostWhite;
            this.zoneBox.Location = new System.Drawing.Point(118, 203);
            this.zoneBox.Name = "zoneBox";
            this.zoneBox.Size = new System.Drawing.Size(258, 23);
            this.zoneBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Building";
            // 
            // buildingBox
            // 
            this.buildingBox.BackColor = System.Drawing.Color.GhostWhite;
            this.buildingBox.Location = new System.Drawing.Point(118, 173);
            this.buildingBox.Name = "buildingBox";
            this.buildingBox.Size = new System.Drawing.Size(258, 23);
            this.buildingBox.TabIndex = 7;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(118, 21);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(258, 20);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "Please enter machine details below.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveDetailBtn
            // 
            this.saveDetailBtn.Location = new System.Drawing.Point(557, 203);
            this.saveDetailBtn.Name = "saveDetailBtn";
            this.saveDetailBtn.Size = new System.Drawing.Size(106, 27);
            this.saveDetailBtn.TabIndex = 11;
            this.saveDetailBtn.Text = "Save Details";
            this.saveDetailBtn.UseVisualStyleBackColor = true;
            this.saveDetailBtn.Click += new System.EventHandler(this.saveDetailBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(412, 203);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(87, 27);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Location = new System.Drawing.Point(412, 8);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(251, 38);
            this.lblConfirm.TabIndex = 14;
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // detailBox
            // 
            this.detailBox.BackColor = System.Drawing.Color.GhostWhite;
            this.detailBox.FormattingEnabled = true;
            this.detailBox.ItemHeight = 15;
            this.detailBox.Location = new System.Drawing.Point(412, 57);
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(251, 139);
            this.detailBox.TabIndex = 15;
            // 
            // serialNumBox
            // 
            this.serialNumBox.BackColor = System.Drawing.Color.GhostWhite;
            this.serialNumBox.Location = new System.Drawing.Point(117, 113);
            this.serialNumBox.Name = "serialNumBox";
            this.serialNumBox.Size = new System.Drawing.Size(258, 23);
            this.serialNumBox.TabIndex = 16;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(14, 113);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(87, 14);
            this.lblSerial.TabIndex = 17;
            this.lblSerial.Text = "Serial Number";
            // 
            // AddMachineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(695, 254);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.serialNumBox);
            this.Controls.Add(this.detailBox);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveDetailBtn);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.buildingBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoneBox);
            this.Controls.Add(this.manuBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.lblManu);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMachineWindow";
            this.Text = "[MEMS] Add Machine Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMachineWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSerial;

        private System.Windows.Forms.TextBox serialNumBox;

        private System.Windows.Forms.ListBox detailBox;

        private System.Windows.Forms.Label lblConfirm;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buildingBox;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button saveDetailBtn;
        private System.Windows.Forms.Button clearBtn;

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox manuBox;
        private System.Windows.Forms.TextBox zoneBox;

        private System.Windows.Forms.Label lblZone;

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManu;

        private System.Windows.Forms.Label lblName;

        #endregion
    }
}