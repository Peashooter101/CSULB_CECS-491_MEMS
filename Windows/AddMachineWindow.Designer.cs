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
            this.lblName.Location = new System.Drawing.Point(14, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Machine Name";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(14, 72);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(40, 12);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblManu
            // 
            this.lblManu.Location = new System.Drawing.Point(12, 124);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(72, 17);
            this.lblManu.TabIndex = 2;
            this.lblManu.Text = "Manufacturer";
            // 
            // lblZone
            // 
            this.lblZone.Location = new System.Drawing.Point(14, 176);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(34, 16);
            this.lblZone.TabIndex = 3;
            this.lblZone.Text = "Zone";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameBox.Location = new System.Drawing.Point(101, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(222, 20);
            this.nameBox.TabIndex = 4;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(101, 72);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(222, 20);
            this.modelBox.TabIndex = 5;
            // 
            // manuBox
            // 
            this.manuBox.Location = new System.Drawing.Point(101, 124);
            this.manuBox.Name = "manuBox";
            this.manuBox.Size = new System.Drawing.Size(222, 20);
            this.manuBox.TabIndex = 6;
            // 
            // zoneBox
            // 
            this.zoneBox.Location = new System.Drawing.Point(101, 176);
            this.zoneBox.Name = "zoneBox";
            this.zoneBox.Size = new System.Drawing.Size(222, 20);
            this.zoneBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Building";
            // 
            // buildingBox
            // 
            this.buildingBox.Location = new System.Drawing.Point(101, 150);
            this.buildingBox.Name = "buildingBox";
            this.buildingBox.Size = new System.Drawing.Size(222, 20);
            this.buildingBox.TabIndex = 7;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(101, 18);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(221, 17);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "Please enter machine details below.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveDetailBtn
            // 
            this.saveDetailBtn.Location = new System.Drawing.Point(232, 209);
            this.saveDetailBtn.Name = "saveDetailBtn";
            this.saveDetailBtn.Size = new System.Drawing.Size(91, 23);
            this.saveDetailBtn.TabIndex = 11;
            this.saveDetailBtn.Text = "Save Details";
            this.saveDetailBtn.UseVisualStyleBackColor = true;
            this.saveDetailBtn.Click += new System.EventHandler(this.saveDetailBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(101, 209);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Location = new System.Drawing.Point(353, 7);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(215, 33);
            this.lblConfirm.TabIndex = 14;
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // detailBox
            // 
            this.detailBox.FormattingEnabled = true;
            this.detailBox.Location = new System.Drawing.Point(353, 49);
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(216, 121);
            this.detailBox.TabIndex = 15;
            // 
            // serialNumBox
            // 
            this.serialNumBox.Location = new System.Drawing.Point(100, 98);
            this.serialNumBox.Name = "serialNumBox";
            this.serialNumBox.Size = new System.Drawing.Size(222, 20);
            this.serialNumBox.TabIndex = 16;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(12, 98);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(75, 12);
            this.lblSerial.TabIndex = 17;
            this.lblSerial.Text = "Serial Number";
            // 
            // AddMachineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(590, 285);
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
            this.Name = "AddMachineWindow";
            this.Text = "[MEMS] DetailedMachineWindow";
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