namespace CryptChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextLocalIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aboutBTN = new System.Windows.Forms.Button();
            this.sendBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.TextBox();
            this.decryptBTN = new System.Windows.Forms.Button();
            this.encryptBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.MainMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextLocalIP);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(41, 53);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(143, 22);
            this.textLocalPort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP";
            // 
            // TextLocalIP
            // 
            this.TextLocalIP.Location = new System.Drawing.Point(41, 21);
            this.TextLocalIP.Name = "TextLocalIP";
            this.TextLocalIP.Size = new System.Drawing.Size(143, 22);
            this.TextLocalIP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(234, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Port";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(41, 53);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(143, 22);
            this.textRemotePort.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "IP";
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Location = new System.Drawing.Point(41, 21);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(143, 22);
            this.textRemoteIP.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonConnect.Location = new System.Drawing.Point(161, 131);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(113, 52);
            this.buttonConnect.TabIndex = 11;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aboutBTN);
            this.groupBox3.Controls.Add(this.sendBTN);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.previewBox);
            this.groupBox3.Controls.Add(this.decryptBTN);
            this.groupBox3.Controls.Add(this.encryptBTN);
            this.groupBox3.Controls.Add(this.clearBTN);
            this.groupBox3.Controls.Add(this.MainMessage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 471);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // aboutBTN
            // 
            this.aboutBTN.Location = new System.Drawing.Point(14, 425);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(61, 27);
            this.aboutBTN.TabIndex = 17;
            this.aboutBTN.Text = "About";
            this.aboutBTN.UseVisualStyleBackColor = true;
            this.aboutBTN.Click += new System.EventHandler(this.aboutBTN_Click);
            // 
            // sendBTN
            // 
            this.sendBTN.Location = new System.Drawing.Point(335, 426);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(75, 26);
            this.sendBTN.TabIndex = 16;
            this.sendBTN.Text = "Send";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Preview";
            // 
            // previewBox
            // 
            this.previewBox.Enabled = false;
            this.previewBox.Location = new System.Drawing.Point(14, 285);
            this.previewBox.Multiline = true;
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(396, 111);
            this.previewBox.TabIndex = 14;
            // 
            // decryptBTN
            // 
            this.decryptBTN.Location = new System.Drawing.Point(335, 208);
            this.decryptBTN.Name = "decryptBTN";
            this.decryptBTN.Size = new System.Drawing.Size(75, 26);
            this.decryptBTN.TabIndex = 13;
            this.decryptBTN.Text = "Decrypt";
            this.decryptBTN.UseVisualStyleBackColor = true;
            this.decryptBTN.Click += new System.EventHandler(this.decryptBTN_Click_1);
            // 
            // encryptBTN
            // 
            this.encryptBTN.Location = new System.Drawing.Point(14, 208);
            this.encryptBTN.Name = "encryptBTN";
            this.encryptBTN.Size = new System.Drawing.Size(75, 26);
            this.encryptBTN.TabIndex = 12;
            this.encryptBTN.Text = "Encrypt";
            this.encryptBTN.UseVisualStyleBackColor = true;
            this.encryptBTN.Click += new System.EventHandler(this.encryptBTN_Click_1);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(353, 12);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(57, 34);
            this.clearBTN.TabIndex = 11;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // MainMessage
            // 
            this.MainMessage.Location = new System.Drawing.Point(14, 58);
            this.MainMessage.Multiline = true;
            this.MainMessage.Name = "MainMessage";
            this.MainMessage.Size = new System.Drawing.Size(396, 111);
            this.MainMessage.TabIndex = 10;
            this.MainMessage.TextChanged += new System.EventHandler(this.MainMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(446, 686);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CryptChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextLocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox previewBox;
        private System.Windows.Forms.Button decryptBTN;
        private System.Windows.Forms.Button encryptBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.TextBox MainMessage;
        private System.Windows.Forms.Label label1;
    }
}

