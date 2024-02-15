namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            lbCurrentDate = new Label();
            addAppPanel = new Panel();
            label2 = new Label();
            cbEndDate = new ComboBox();
            cbStartDate = new ComboBox();
            btDiscard = new Button();
            btConfirmApp = new Button();
            tbLocation = new TextBox();
            tbTitle = new TextBox();
            cbIsOnline = new CheckBox();
            tbAllDayEdit = new CheckBox();
            lbDate = new Label();
            tbDescription = new RichTextBox();
            statusLabel = new Label();
            appInfoPanel = new Panel();
            tbAllDayInfo = new CheckBox();
            btDelete = new Button();
            btEdit = new Button();
            appLocation = new Label();
            appDate = new Label();
            appDescriptionBox = new RichTextBox();
            appTitle = new Label();
            app4 = new Button();
            app3 = new Button();
            app2 = new Button();
            app1 = new Button();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            btImport = new Button();
            btExport = new Button();
            lbContactStatus = new Label();
            tbSearchBox = new TextBox();
            btAddContact = new Button();
            contactInfoPanel = new Panel();
            lbEmail = new LinkLabel();
            lbPhone = new Label();
            lbName = new Label();
            btDeleteContact = new Button();
            btEditContact = new Button();
            editContactPanel = new Panel();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            btDiscardContact = new Button();
            btConfirmContact = new Button();
            tbName = new TextBox();
            lvContacts = new ListView();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            addAppPanel.SuspendLayout();
            appInfoPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            contactInfoPanel.SuspendLayout();
            editContactPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(696, 467);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbCurrentDate);
            tabPage1.Controls.Add(addAppPanel);
            tabPage1.Controls.Add(statusLabel);
            tabPage1.Controls.Add(appInfoPanel);
            tabPage1.Controls.Add(app4);
            tabPage1.Controls.Add(app3);
            tabPage1.Controls.Add(app2);
            tabPage1.Controls.Add(app1);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(688, 439);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calendar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbCurrentDate
            // 
            lbCurrentDate.AutoSize = true;
            lbCurrentDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbCurrentDate.Location = new Point(233, 10);
            lbCurrentDate.Name = "lbCurrentDate";
            lbCurrentDate.Size = new Size(79, 19);
            lbCurrentDate.TabIndex = 14;
            lbCurrentDate.Text = "01.01.2023";
            // 
            // addAppPanel
            // 
            addAppPanel.Controls.Add(label2);
            addAppPanel.Controls.Add(cbEndDate);
            addAppPanel.Controls.Add(cbStartDate);
            addAppPanel.Controls.Add(btDiscard);
            addAppPanel.Controls.Add(btConfirmApp);
            addAppPanel.Controls.Add(tbLocation);
            addAppPanel.Controls.Add(tbTitle);
            addAppPanel.Controls.Add(cbIsOnline);
            addAppPanel.Controls.Add(tbAllDayEdit);
            addAppPanel.Controls.Add(lbDate);
            addAppPanel.Controls.Add(tbDescription);
            addAppPanel.Location = new Point(340, 8);
            addAppPanel.Margin = new Padding(3, 2, 3, 2);
            addAppPanel.Name = "addAppPanel";
            addAppPanel.Size = new Size(340, 197);
            addAppPanel.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 107);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 13;
            label2.Text = "-";
            // 
            // cbEndDate
            // 
            cbEndDate.FormattingEnabled = true;
            cbEndDate.Location = new Point(140, 105);
            cbEndDate.Margin = new Padding(3, 2, 3, 2);
            cbEndDate.Name = "cbEndDate";
            cbEndDate.Size = new Size(65, 23);
            cbEndDate.TabIndex = 12;
            // 
            // cbStartDate
            // 
            cbStartDate.FormattingEnabled = true;
            cbStartDate.Location = new Point(15, 105);
            cbStartDate.Margin = new Padding(3, 2, 3, 2);
            cbStartDate.Name = "cbStartDate";
            cbStartDate.Size = new Size(65, 23);
            cbStartDate.TabIndex = 11;
            // 
            // btDiscard
            // 
            btDiscard.Location = new Point(242, 158);
            btDiscard.Margin = new Padding(3, 2, 3, 2);
            btDiscard.Name = "btDiscard";
            btDiscard.Size = new Size(82, 22);
            btDiscard.TabIndex = 9;
            btDiscard.Text = "Discard";
            btDiscard.UseVisualStyleBackColor = true;
            btDiscard.Click += discardAppointment_Click;
            // 
            // btConfirmApp
            // 
            btConfirmApp.Location = new Point(154, 158);
            btConfirmApp.Margin = new Padding(3, 2, 3, 2);
            btConfirmApp.Name = "btConfirmApp";
            btConfirmApp.Size = new Size(82, 22);
            btConfirmApp.TabIndex = 8;
            btConfirmApp.Text = "Confirm";
            btConfirmApp.UseVisualStyleBackColor = true;
            btConfirmApp.Click += confirm_Click;
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(15, 129);
            tbLocation.Margin = new Padding(3, 2, 3, 2);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(205, 23);
            tbLocation.TabIndex = 7;
            tbLocation.Text = "Location";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(15, 7);
            tbTitle.Margin = new Padding(3, 2, 3, 2);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(308, 23);
            tbTitle.TabIndex = 6;
            tbTitle.Text = "Title";
            // 
            // cbIsOnline
            // 
            cbIsOnline.AutoSize = true;
            cbIsOnline.Location = new Point(225, 129);
            cbIsOnline.Margin = new Padding(3, 2, 3, 2);
            cbIsOnline.Name = "cbIsOnline";
            cbIsOnline.Size = new Size(61, 19);
            cbIsOnline.TabIndex = 5;
            cbIsOnline.Text = "Online";
            cbIsOnline.UseVisualStyleBackColor = true;
            cbIsOnline.CheckedChanged += cbIsOnline_CheckedChanged;
            // 
            // tbAllDayEdit
            // 
            tbAllDayEdit.AutoSize = true;
            tbAllDayEdit.Location = new Point(225, 100);
            tbAllDayEdit.Margin = new Padding(3, 2, 3, 2);
            tbAllDayEdit.Name = "tbAllDayEdit";
            tbAllDayEdit.Size = new Size(89, 19);
            tbAllDayEdit.TabIndex = 3;
            tbAllDayEdit.Text = "Lasts all day";
            tbAllDayEdit.UseVisualStyleBackColor = true;
            tbAllDayEdit.CheckedChanged += tbAllDayEdit_CheckedChanged;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(15, 88);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(31, 15);
            lbDate.TabIndex = 2;
            lbDate.Text = "Date";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(15, 32);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(308, 45);
            tbDescription.TabIndex = 1;
            tbDescription.Text = "";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(18, 417);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 15);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "label2";
            // 
            // appInfoPanel
            // 
            appInfoPanel.Controls.Add(tbAllDayInfo);
            appInfoPanel.Controls.Add(btDelete);
            appInfoPanel.Controls.Add(btEdit);
            appInfoPanel.Controls.Add(appLocation);
            appInfoPanel.Controls.Add(appDate);
            appInfoPanel.Controls.Add(appDescriptionBox);
            appInfoPanel.Controls.Add(appTitle);
            appInfoPanel.Location = new Point(342, 10);
            appInfoPanel.Margin = new Padding(3, 2, 3, 2);
            appInfoPanel.Name = "appInfoPanel";
            appInfoPanel.Size = new Size(340, 197);
            appInfoPanel.TabIndex = 8;
            // 
            // tbAllDayInfo
            // 
            tbAllDayInfo.AutoSize = true;
            tbAllDayInfo.Enabled = false;
            tbAllDayInfo.Location = new Point(229, 99);
            tbAllDayInfo.Margin = new Padding(3, 2, 3, 2);
            tbAllDayInfo.Name = "tbAllDayInfo";
            tbAllDayInfo.Size = new Size(89, 19);
            tbAllDayInfo.TabIndex = 13;
            tbAllDayInfo.Text = "Lasts all day";
            tbAllDayInfo.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(244, 122);
            btDelete.Margin = new Padding(3, 2, 3, 2);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(82, 22);
            btDelete.TabIndex = 12;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += deleteAppointment_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(157, 122);
            btEdit.Margin = new Padding(3, 2, 3, 2);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(82, 22);
            btEdit.TabIndex = 11;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += editAppointment_Click;
            // 
            // appLocation
            // 
            appLocation.AutoSize = true;
            appLocation.Location = new Point(15, 104);
            appLocation.Name = "appLocation";
            appLocation.Size = new Size(53, 15);
            appLocation.TabIndex = 4;
            appLocation.Text = "Location";
            // 
            // appDate
            // 
            appDate.AutoSize = true;
            appDate.Location = new Point(15, 80);
            appDate.Name = "appDate";
            appDate.Size = new Size(31, 15);
            appDate.TabIndex = 2;
            appDate.Text = "Date";
            // 
            // appDescriptionBox
            // 
            appDescriptionBox.Enabled = false;
            appDescriptionBox.Location = new Point(15, 32);
            appDescriptionBox.Margin = new Padding(3, 2, 3, 2);
            appDescriptionBox.Name = "appDescriptionBox";
            appDescriptionBox.Size = new Size(308, 48);
            appDescriptionBox.TabIndex = 1;
            appDescriptionBox.Text = "";
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            appTitle.Location = new Point(15, 10);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(38, 20);
            appTitle.TabIndex = 0;
            appTitle.Text = "Title";
            // 
            // app4
            // 
            app4.Location = new Point(18, 268);
            app4.Margin = new Padding(3, 2, 3, 2);
            app4.Name = "app4";
            app4.Size = new Size(294, 57);
            app4.TabIndex = 7;
            app4.Text = "appointment 4";
            app4.TextAlign = ContentAlignment.MiddleLeft;
            app4.UseVisualStyleBackColor = true;
            app4.Visible = false;
            app4.Click += appointment_Click;
            // 
            // app3
            // 
            app3.Location = new Point(18, 190);
            app3.Margin = new Padding(3, 2, 3, 2);
            app3.Name = "app3";
            app3.Size = new Size(294, 57);
            app3.TabIndex = 6;
            app3.Text = "appointment 3";
            app3.TextAlign = ContentAlignment.MiddleLeft;
            app3.UseVisualStyleBackColor = true;
            app3.Visible = false;
            app3.Click += appointment_Click;
            // 
            // app2
            // 
            app2.Location = new Point(18, 114);
            app2.Margin = new Padding(3, 2, 3, 2);
            app2.Name = "app2";
            app2.Size = new Size(294, 57);
            app2.TabIndex = 5;
            app2.Text = "appointment 2";
            app2.TextAlign = ContentAlignment.MiddleLeft;
            app2.UseVisualStyleBackColor = true;
            app2.Visible = false;
            app2.Click += appointment_Click;
            // 
            // app1
            // 
            app1.Location = new Point(18, 40);
            app1.Margin = new Padding(3, 2, 3, 2);
            app1.Name = "app1";
            app1.Size = new Size(294, 57);
            app1.TabIndex = 4;
            app1.Text = "appointment 1";
            app1.TextAlign = ContentAlignment.MiddleLeft;
            app1.UseVisualStyleBackColor = true;
            app1.Visible = false;
            app1.Click += appointment_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(397, 217);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "SCHEDULE";
            // 
            // button1
            // 
            button1.Location = new Point(553, 381);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 22);
            button1.TabIndex = 0;
            button1.Text = "Add appointment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addAppointment_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btImport);
            tabPage2.Controls.Add(btExport);
            tabPage2.Controls.Add(lbContactStatus);
            tabPage2.Controls.Add(tbSearchBox);
            tabPage2.Controls.Add(btAddContact);
            tabPage2.Controls.Add(contactInfoPanel);
            tabPage2.Controls.Add(editContactPanel);
            tabPage2.Controls.Add(lvContacts);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(688, 439);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contacts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btImport
            // 
            btImport.Location = new Point(512, 415);
            btImport.Margin = new Padding(3, 2, 3, 2);
            btImport.Name = "btImport";
            btImport.Size = new Size(82, 22);
            btImport.TabIndex = 17;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = true;
            btImport.Click += btImport_Click;
            // 
            // btExport
            // 
            btExport.Location = new Point(599, 415);
            btExport.Margin = new Padding(3, 2, 3, 2);
            btExport.Name = "btExport";
            btExport.Size = new Size(82, 22);
            btExport.TabIndex = 16;
            btExport.Text = "Export contacts";
            btExport.UseVisualStyleBackColor = true;
            btExport.Click += btExport_Click;
            // 
            // lbContactStatus
            // 
            lbContactStatus.AutoSize = true;
            lbContactStatus.Location = new Point(7, 243);
            lbContactStatus.Name = "lbContactStatus";
            lbContactStatus.Size = new Size(32, 15);
            lbContactStatus.TabIndex = 15;
            lbContactStatus.Text = "label";
            // 
            // tbSearchBox
            // 
            tbSearchBox.Location = new Point(7, 4);
            tbSearchBox.Margin = new Padding(3, 2, 3, 2);
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.Size = new Size(207, 23);
            tbSearchBox.TabIndex = 13;
            tbSearchBox.TextChanged += tbSearchBox_TextChanged;
            // 
            // btAddContact
            // 
            btAddContact.Location = new Point(584, 216);
            btAddContact.Margin = new Padding(3, 2, 3, 2);
            btAddContact.Name = "btAddContact";
            btAddContact.Size = new Size(82, 22);
            btAddContact.TabIndex = 12;
            btAddContact.Text = "Add";
            btAddContact.UseVisualStyleBackColor = true;
            btAddContact.Click += btAddContact_Click;
            // 
            // contactInfoPanel
            // 
            contactInfoPanel.Controls.Add(lbEmail);
            contactInfoPanel.Controls.Add(lbPhone);
            contactInfoPanel.Controls.Add(lbName);
            contactInfoPanel.Controls.Add(btDeleteContact);
            contactInfoPanel.Controls.Add(btEditContact);
            contactInfoPanel.Location = new Point(342, 8);
            contactInfoPanel.Margin = new Padding(3, 2, 3, 2);
            contactInfoPanel.Name = "contactInfoPanel";
            contactInfoPanel.Size = new Size(340, 155);
            contactInfoPanel.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(8, 62);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 12;
            lbEmail.TabStop = true;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(8, 37);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(41, 15);
            lbPhone.TabIndex = 11;
            lbPhone.Text = "Phone";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(8, 10);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 10;
            lbName.Text = "Name";
            // 
            // btDeleteContact
            // 
            btDeleteContact.Location = new Point(240, 118);
            btDeleteContact.Margin = new Padding(3, 2, 3, 2);
            btDeleteContact.Name = "btDeleteContact";
            btDeleteContact.Size = new Size(82, 22);
            btDeleteContact.TabIndex = 9;
            btDeleteContact.Text = "Delete";
            btDeleteContact.UseVisualStyleBackColor = true;
            btDeleteContact.Click += btDeleteContact_Click;
            // 
            // btEditContact
            // 
            btEditContact.Location = new Point(141, 118);
            btEditContact.Margin = new Padding(3, 2, 3, 2);
            btEditContact.Name = "btEditContact";
            btEditContact.Size = new Size(82, 22);
            btEditContact.TabIndex = 8;
            btEditContact.Text = "Edit";
            btEditContact.UseVisualStyleBackColor = true;
            btEditContact.Click += btEditContact_Click;
            // 
            // editContactPanel
            // 
            editContactPanel.Controls.Add(tbEmail);
            editContactPanel.Controls.Add(tbPhone);
            editContactPanel.Controls.Add(btDiscardContact);
            editContactPanel.Controls.Add(btConfirmContact);
            editContactPanel.Controls.Add(tbName);
            editContactPanel.Location = new Point(345, 8);
            editContactPanel.Margin = new Padding(3, 2, 3, 2);
            editContactPanel.Name = "editContactPanel";
            editContactPanel.Size = new Size(340, 155);
            editContactPanel.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(15, 86);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(308, 23);
            tbEmail.TabIndex = 11;
            tbEmail.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(15, 43);
            tbPhone.Margin = new Padding(3, 2, 3, 2);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(308, 23);
            tbPhone.TabIndex = 10;
            tbPhone.Text = "Phone";
            // 
            // btDiscardContact
            // 
            btDiscardContact.Location = new Point(240, 118);
            btDiscardContact.Margin = new Padding(3, 2, 3, 2);
            btDiscardContact.Name = "btDiscardContact";
            btDiscardContact.Size = new Size(82, 22);
            btDiscardContact.TabIndex = 9;
            btDiscardContact.Text = "Discard";
            btDiscardContact.UseVisualStyleBackColor = true;
            btDiscardContact.Click += btDiscardContact_Click;
            // 
            // btConfirmContact
            // 
            btConfirmContact.Location = new Point(141, 118);
            btConfirmContact.Margin = new Padding(3, 2, 3, 2);
            btConfirmContact.Name = "btConfirmContact";
            btConfirmContact.Size = new Size(82, 22);
            btConfirmContact.TabIndex = 8;
            btConfirmContact.Text = "Confirm";
            btConfirmContact.UseVisualStyleBackColor = true;
            btConfirmContact.Click += btConfirmContact_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(15, 7);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(308, 23);
            tbName.TabIndex = 6;
            tbName.Text = "Name";
            // 
            // lvContacts
            // 
            lvContacts.Location = new Point(7, 29);
            lvContacts.Margin = new Padding(3, 2, 3, 2);
            lvContacts.Name = "lvContacts";
            lvContacts.Size = new Size(207, 201);
            lvContacts.TabIndex = 0;
            lvContacts.UseCompatibleStateImageBehavior = false;
            lvContacts.SelectedIndexChanged += lvContacts_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 467);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calendar";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            addAppPanel.ResumeLayout(false);
            addAppPanel.PerformLayout();
            appInfoPanel.ResumeLayout(false);
            appInfoPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            contactInfoPanel.ResumeLayout(false);
            contactInfoPanel.PerformLayout();
            editContactPanel.ResumeLayout(false);
            editContactPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Button button1;
        private TabPage tabPage2;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button app4;
        private Button app3;
        private Button app2;
        private Button app1;
        private Label statusLabel;
        private Panel appInfoPanel;
        private Label appDate;
        private RichTextBox appDescriptionBox;
        private Label appTitle;
        private Label appLocation;
        private Panel addAppPanel;
        private TextBox tbTitle;
        private CheckBox cbIsOnline;
        private CheckBox tbAllDayEdit;
        private RichTextBox tbDescription;
        private TextBox tbLocation;
        private Label lbDate;
        private Button btConfirmApp;
        private Button btDiscard;
        private Button btDelete;
        private Button btEdit;
        private Label label2;
        private ComboBox cbEndDate;
        private ComboBox cbStartDate;
        private CheckBox tbAllDayInfo;
        private Panel editContactPanel;
        private Button btDiscardContact;
        private Button btConfirmContact;
        private TextBox tbName;
        private ListView lvContacts;
        private Panel contactInfoPanel;
        private Button btDeleteContact;
        private Button btEditContact;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private Label lbPhone;
        private Label lbName;
        private Button btAddContact;
        private LinkLabel lbEmail;
        private TextBox tbSearchBox;
        private Label lbContactStatus;
        private Label lbCurrentDate;
        private Button btExport;
        private Button btImport;
    }
}