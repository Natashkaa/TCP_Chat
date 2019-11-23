namespace TCPchat_dz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.myNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myMailLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.myMailPass = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.messageList = new System.Windows.Forms.TextBox();
            this.newMessageBox = new System.Windows.Forms.TextBox();
            this.ofdButton = new System.Windows.Forms.Button();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usersMailBox = new System.Windows.Forms.TextBox();
            this.sendHistoryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // myNameBox
            // 
            this.myNameBox.Location = new System.Drawing.Point(16, 30);
            this.myNameBox.Name = "myNameBox";
            this.myNameBox.Size = new System.Drawing.Size(100, 20);
            this.myNameBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MyMail";
            // 
            // myMailLog
            // 
            this.myMailLog.Location = new System.Drawing.Point(281, 30);
            this.myMailLog.Name = "myMailLog";
            this.myMailLog.Size = new System.Drawing.Size(154, 20);
            this.myMailLog.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // myMailPass
            // 
            this.myMailPass.Location = new System.Drawing.Point(281, 74);
            this.myMailPass.Name = "myMailPass";
            this.myMailPass.PasswordChar = '*';
            this.myMailPass.Size = new System.Drawing.Size(152, 20);
            this.myMailPass.TabIndex = 7;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Location = new System.Drawing.Point(19, 57);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(97, 25);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Maroon;
            this.logoutButton.Enabled = false;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(19, 90);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(97, 26);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // messageList
            // 
            this.messageList.Enabled = false;
            this.messageList.Location = new System.Drawing.Point(236, 122);
            this.messageList.Multiline = true;
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(552, 262);
            this.messageList.TabIndex = 10;
            // 
            // newMessageBox
            // 
            this.newMessageBox.Enabled = false;
            this.newMessageBox.Location = new System.Drawing.Point(236, 390);
            this.newMessageBox.Multiline = true;
            this.newMessageBox.Name = "newMessageBox";
            this.newMessageBox.Size = new System.Drawing.Size(418, 49);
            this.newMessageBox.TabIndex = 11;
            // 
            // ofdButton
            // 
            this.ofdButton.Enabled = false;
            this.ofdButton.Location = new System.Drawing.Point(660, 390);
            this.ofdButton.Name = "ofdButton";
            this.ofdButton.Size = new System.Drawing.Size(31, 48);
            this.ofdButton.TabIndex = 12;
            this.ofdButton.Text = "File";
            this.ofdButton.UseVisualStyleBackColor = true;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Enabled = false;
            this.sendMessageButton.Location = new System.Drawing.Point(697, 390);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(91, 48);
            this.sendMessageButton.TabIndex = 13;
            this.sendMessageButton.Text = "SEND";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "UsersMail";
            // 
            // usersMailBox
            // 
            this.usersMailBox.Location = new System.Drawing.Point(627, 30);
            this.usersMailBox.Name = "usersMailBox";
            this.usersMailBox.Size = new System.Drawing.Size(136, 20);
            this.usersMailBox.TabIndex = 17;
            // 
            // sendHistoryButton
            // 
            this.sendHistoryButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.sendHistoryButton.Enabled = false;
            this.sendHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendHistoryButton.Location = new System.Drawing.Point(627, 57);
            this.sendHistoryButton.Name = "sendHistoryButton";
            this.sendHistoryButton.Size = new System.Drawing.Size(136, 23);
            this.sendHistoryButton.TabIndex = 18;
            this.sendHistoryButton.Text = "send message history";
            this.sendHistoryButton.UseVisualStyleBackColor = false;
            this.sendHistoryButton.Click += new System.EventHandler(this.sendHistoryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.mailLogDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(213, 316);
            this.dataGridView1.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Column1";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // mailLogDataGridViewTextBoxColumn
            // 
            this.mailLogDataGridViewTextBoxColumn.DataPropertyName = "MailLog";
            this.mailLogDataGridViewTextBoxColumn.HeaderText = "MailLog";
            this.mailLogDataGridViewTextBoxColumn.Name = "mailLogDataGridViewTextBoxColumn";
            this.mailLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailLogDataGridViewTextBoxColumn.Width = 110;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ObjectCollection.User);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sendHistoryButton);
            this.Controls.Add(this.usersMailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.ofdButton);
            this.Controls.Add(this.newMessageBox);
            this.Controls.Add(this.messageList);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.myMailPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myMailLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox myMailLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox myMailPass;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox messageList;
        private System.Windows.Forms.TextBox newMessageBox;
        private System.Windows.Forms.Button ofdButton;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usersMailBox;
        private System.Windows.Forms.Button sendHistoryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailLogDataGridViewTextBoxColumn;
    }
}

