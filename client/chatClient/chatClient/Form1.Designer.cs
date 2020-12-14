namespace chatClient
{
    partial class chatForm
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
            this.enterChat = new System.Windows.Forms.Button();
            this.gui_userName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chat_msg = new System.Windows.Forms.TextBox();
            this.chat_send = new System.Windows.Forms.Button();
            this.gui_chat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsList = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.visiting = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterChat
            // 
            this.enterChat.Location = new System.Drawing.Point(549, 11);
            this.enterChat.Margin = new System.Windows.Forms.Padding(4);
            this.enterChat.Name = "enterChat";
            this.enterChat.Size = new System.Drawing.Size(164, 28);
            this.enterChat.TabIndex = 0;
            this.enterChat.Text = "Войти в чат";
            this.enterChat.UseVisualStyleBackColor = true;
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // gui_userName
            // 
            this.gui_userName.AutoSize = true;
            this.gui_userName.Location = new System.Drawing.Point(13, 11);
            this.gui_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gui_userName.Name = "gui_userName";
            this.gui_userName.Size = new System.Drawing.Size(226, 17);
            this.gui_userName.TabIndex = 1;
            this.gui_userName.Text = "Введите название дисциплины:  ";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(233, 11);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(132, 22);
            this.userName.TabIndex = 2;
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(16, 323);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(697, 235);
            this.chatBox.TabIndex = 3;
            this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // chat_msg
            // 
            this.chat_msg.Enabled = false;
            this.chat_msg.Location = new System.Drawing.Point(19, 568);
            this.chat_msg.Margin = new System.Windows.Forms.Padding(4);
            this.chat_msg.Name = "chat_msg";
            this.chat_msg.Size = new System.Drawing.Size(525, 22);
            this.chat_msg.TabIndex = 4;
            this.chat_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_msg_KeyDown);
            // 
            // chat_send
            // 
            this.chat_send.Enabled = false;
            this.chat_send.Location = new System.Drawing.Point(554, 566);
            this.chat_send.Margin = new System.Windows.Forms.Padding(4);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(164, 28);
            this.chat_send.TabIndex = 5;
            this.chat_send.Text = "Отправить";
            this.chat_send.UseVisualStyleBackColor = true;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // gui_chat
            // 
            this.gui_chat.AutoSize = true;
            this.gui_chat.Location = new System.Drawing.Point(19, 303);
            this.gui_chat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gui_chat.Name = "gui_chat";
            this.gui_chat.Size = new System.Drawing.Size(37, 17);
            this.gui_chat.TabIndex = 6;
            this.gui_chat.Text = "Чат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список студентов";
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Items.AddRange(new object[] {
            "Бердников Л.",
            "Вакаев О.",
            "Васильев Г.",
            "Жданкина А.",
            "Зайцев А.",
            "Клюско С.",
            "Кузьменко Р.",
            "Куликов А. А. ",
            "Куликов А. В. ",
            "Лазарев Р.",
            "Левичев А.",
            "Минченко В.",
            "Морозов М.",
            "Нарушевич О.",
            "Рыжков А.",
            "Серёжникова Н.",
            "Шубин В."});
            this.studentsList.Location = new System.Drawing.Point(16, 97);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(151, 24);
            this.studentsList.TabIndex = 8;
            this.studentsList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(219, 97);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(146, 22);
            this.date.TabIndex = 9;
            // 
            // visiting
            // 
            this.visiting.FormattingEnabled = true;
            this.visiting.Items.AddRange(new object[] {
            "Присутствовал",
            "Отсутствовал"});
            this.visiting.Location = new System.Drawing.Point(105, 180);
            this.visiting.Name = "visiting";
            this.visiting.Size = new System.Drawing.Size(145, 24);
            this.visiting.TabIndex = 10;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(84, 146);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(210, 17);
            this.lblTest.TabIndex = 11;
            this.lblTest.Text = "Отсутствовал / Присутствовал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата пары";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.visiting);
            this.Controls.Add(this.date);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gui_chat);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chat_msg);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.gui_userName);
            this.Controls.Add(this.enterChat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "chatForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterChat;
        private System.Windows.Forms.Label gui_userName;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox chat_msg;
        private System.Windows.Forms.Button chat_send;
        private System.Windows.Forms.Label gui_chat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentsList;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox visiting;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label3;
    }
}

