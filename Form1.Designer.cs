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
            textStatus = new TextBox();
            sendBtn = new Button();
            textMsg = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            connectBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textStatus
            // 
            textStatus.Location = new Point(90, 176);
            textStatus.Multiline = true;
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(329, 135);
            textStatus.TabIndex = 20;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(344, 147);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 19;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // textMsg
            // 
            textMsg.Location = new Point(87, 77);
            textMsg.Multiline = true;
            textMsg.Name = "textMsg";
            textMsg.Size = new Size(329, 64);
            textMsg.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 17;
            textBox2.Text = "8910";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 40);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 16;
            label2.Text = "Port: ";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(344, 37);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(75, 23);
            connectBtn.TabIndex = 15;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(90, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            textBox1.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "Host: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 356);
            Controls.Add(textStatus);
            Controls.Add(sendBtn);
            Controls.Add(textMsg);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textStatus;
        private Button sendBtn;
        private TextBox textMsg;
        private TextBox textBox2;
        private Label label2;
        private Button connectBtn;
        private TextBox textBox1;
        private Label label1;
    }
}
