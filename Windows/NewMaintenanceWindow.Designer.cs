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
            this.listview = new System.Windows.Forms.ListView();
            this.MachineName = new System.Windows.Forms.ColumnHeader();
            this.MachineUID = new System.Windows.Forms.ColumnHeader();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.printButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.phoneBoxText = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.issueDescriptionLabel = new System.Windows.Forms.Label();
            this.machineSelectionLabel = new System.Windows.Forms.Label();
            this.newMaintenanceRequestLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.updateRequestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.MachineName, this.MachineUID });
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(84, 154);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(234, 482);
            this.listview.TabIndex = 1;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // MachineName
            // 
            this.MachineName.Text = "Name";
            this.MachineName.Width = 172;
            // 
            // MachineUID
            // 
            this.MachineUID.Text = "UID";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.Width = -1;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(325, 601);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(73, 35);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(883, 601);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(73, 35);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(804, 601);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(73, 35);
            this.mainMenuButton.TabIndex = 8;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            // 
            // companyTextBox
            // 
            this.companyTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyTextBox.Location = new System.Drawing.Point(473, 158);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(482, 20);
            this.companyTextBox.TabIndex = 10;
            this.companyTextBox.Text = "Enter Company Name";
            this.companyTextBox.TextChanged += new System.EventHandler(this.companyTextBox_TextChanged);
            // 
            // phoneBoxText
            // 
            this.phoneBoxText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneBoxText.Location = new System.Drawing.Point(473, 184);
            this.phoneBoxText.Name = "phoneBoxText";
            this.phoneBoxText.Size = new System.Drawing.Size(482, 20);
            this.phoneBoxText.TabIndex = 11;
            this.phoneBoxText.Text = "Enter Phone Number";
            this.phoneBoxText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // contactTextBox
            // 
            this.contactTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.contactTextBox.Location = new System.Drawing.Point(474, 210);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(482, 20);
            this.contactTextBox.TabIndex = 12;
            this.contactTextBox.Text = "Enter Contact Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(473, 236);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(482, 20);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Text = "Enter Contact Email";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.descriptionTextBox.Location = new System.Drawing.Point(473, 262);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(482, 20);
            this.descriptionTextBox.TabIndex = 14;
            this.descriptionTextBox.Text = "Enter Issue Description";
            // 
            // companyLabel
            // 
            this.companyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyLabel.Location = new System.Drawing.Point(326, 157);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(145, 20);
            this.companyLabel.TabIndex = 15;
            this.companyLabel.Text = "Company:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phoneLabel.Location = new System.Drawing.Point(327, 184);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(145, 20);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone:";
            // 
            // contactLabel
            // 
            this.contactLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contactLabel.Location = new System.Drawing.Point(327, 210);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(145, 20);
            this.contactLabel.TabIndex = 17;
            this.contactLabel.Text = "Contact:";
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLabel.Location = new System.Drawing.Point(327, 236);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(145, 20);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email:";
            // 
            // issueDescriptionLabel
            // 
            this.issueDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.issueDescriptionLabel.Location = new System.Drawing.Point(327, 262);
            this.issueDescriptionLabel.Name = "issueDescriptionLabel";
            this.issueDescriptionLabel.Size = new System.Drawing.Size(145, 20);
            this.issueDescriptionLabel.TabIndex = 19;
            this.issueDescriptionLabel.Text = "Issue Description:";
            this.issueDescriptionLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // machineSelectionLabel
            // 
            this.machineSelectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.machineSelectionLabel.Location = new System.Drawing.Point(83, 124);
            this.machineSelectionLabel.Name = "machineSelectionLabel";
            this.machineSelectionLabel.Size = new System.Drawing.Size(236, 21);
            this.machineSelectionLabel.TabIndex = 20;
            this.machineSelectionLabel.Text = "Machine Selection";
            // 
            // newMaintenanceRequestLabel
            // 
            this.newMaintenanceRequestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newMaintenanceRequestLabel.Location = new System.Drawing.Point(327, 124);
            this.newMaintenanceRequestLabel.Name = "newMaintenanceRequestLabel";
            this.newMaintenanceRequestLabel.Size = new System.Drawing.Size(146, 21);
            this.newMaintenanceRequestLabel.TabIndex = 21;
            this.newMaintenanceRequestLabel.Text = "New Maintenance Request:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 311);
            this.dataGridView1.TabIndex = 22;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(404, 601);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 35);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Add Request";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // updateRequestButton
            // 
            this.updateRequestButton.Location = new System.Drawing.Point(483, 601);
            this.updateRequestButton.Name = "updateRequestButton";
            this.updateRequestButton.Size = new System.Drawing.Size(73, 35);
            this.updateRequestButton.TabIndex = 24;
            this.updateRequestButton.Text = "Update Request";
            this.updateRequestButton.UseVisualStyleBackColor = true;
            this.updateRequestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewMaintenanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 666);
            this.Controls.Add(this.updateRequestButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newMaintenanceRequestLabel);
            this.Controls.Add(this.machineSelectionLabel);
            this.Controls.Add(this.issueDescriptionLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.phoneBoxText);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.listview);
            this.Name = "NewMaintenanceWindow";
            this.Text = "NewMaintenanceWindow";
            this.Load += new System.EventHandler(this.NewMaintenanceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button updateRequestButton;

        private System.Windows.Forms.Button addButton;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label newMaintenanceRequestLabel;

        private System.Windows.Forms.Label machineSelectionLabel;

        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label issueDescriptionLabel;

        private System.Windows.Forms.Label companyLabel;

        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox phoneBoxText;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;

        private System.Windows.Forms.Button mainMenuButton;

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;

        private System.Windows.Forms.ColumnHeader MachineName;
        private System.Windows.Forms.ColumnHeader MachineUID;

        private System.Windows.Forms.ListView listview;

        #endregion
    }
}