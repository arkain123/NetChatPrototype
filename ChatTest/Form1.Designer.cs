namespace ChatTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sendButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.onlineUsersView = new System.Windows.Forms.TreeView();
            this.hostBox = new System.Windows.Forms.CheckBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onlineLight = new System.Windows.Forms.ProgressBar();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(697, 356);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(109, 35);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(697, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 35);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Enabled = false;
            this.userTextBox.Location = new System.Drawing.Point(177, 356);
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(514, 76);
            this.userTextBox.TabIndex = 3;
            // 
            // onlineUsersView
            // 
            this.onlineUsersView.Location = new System.Drawing.Point(12, 61);
            this.onlineUsersView.Name = "onlineUsersView";
            this.onlineUsersView.Size = new System.Drawing.Size(152, 289);
            this.onlineUsersView.TabIndex = 4;
            // 
            // hostBox
            // 
            this.hostBox.AutoSize = true;
            this.hostBox.Location = new System.Drawing.Point(12, 356);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(59, 20);
            this.hostBox.TabIndex = 5;
            this.hostBox.Text = "Хост";
            this.hostBox.UseVisualStyleBackColor = true;
            this.hostBox.CheckedChanged += new System.EventHandler(this.hostBox_CheckedChanged);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(12, 378);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(97, 22);
            this.ipBox.TabIndex = 6;
            this.ipBox.Text = "127.0.0.1";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 406);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(152, 26);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(115, 378);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(49, 22);
            this.portBox.TabIndex = 8;
            this.portBox.Text = "11200";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 16);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(152, 22);
            this.usernameBox.TabIndex = 9;
            this.usernameBox.Text = "anon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Оффлайн";
            // 
            // onlineLight
            // 
            this.onlineLight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.onlineLight.ForeColor = System.Drawing.Color.HotPink;
            this.onlineLight.Location = new System.Drawing.Point(86, 43);
            this.onlineLight.Maximum = 1;
            this.onlineLight.Name = "onlineLight";
            this.onlineLight.Size = new System.Drawing.Size(15, 15);
            this.onlineLight.Step = 1;
            this.onlineLight.TabIndex = 11;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Enabled = false;
            this.chatTextBox.Location = new System.Drawing.Point(177, 12);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.Size = new System.Drawing.Size(629, 338);
            this.chatTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(818, 440);
            this.Controls.Add(this.onlineLight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.onlineUsersView);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TreeView onlineUsersView;
        private System.Windows.Forms.CheckBox hostBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar onlineLight;
        private System.Windows.Forms.TextBox chatTextBox;
    }
}

