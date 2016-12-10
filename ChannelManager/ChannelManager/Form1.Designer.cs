namespace ChannelManager
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
            this.btnSet = new System.Windows.Forms.Button();
            this.boxToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.boxMsg = new System.Windows.Forms.TextBox();
            this.txtBotName = new System.Windows.Forms.Label();
            this.boxUser = new System.Windows.Forms.TextBox();
            this.txtChannelUser = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(516, 15);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(54, 49);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Conect";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // boxToken
            // 
            this.boxToken.Location = new System.Drawing.Point(77, 15);
            this.boxToken.Name = "boxToken";
            this.boxToken.Size = new System.Drawing.Size(433, 20);
            this.boxToken.TabIndex = 1;
            this.boxToken.TextChanged += new System.EventHandler(this.boxToken_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "bot Token:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(15, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 339);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSendMsg);
            this.tabPage1.Controls.Add(this.boxMsg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(419, 259);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(129, 49);
            this.btnSendMsg.TabIndex = 7;
            this.btnSendMsg.Text = "Send!";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // boxMsg
            // 
            this.boxMsg.Location = new System.Drawing.Point(6, 6);
            this.boxMsg.Multiline = true;
            this.boxMsg.Name = "boxMsg";
            this.boxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxMsg.Size = new System.Drawing.Size(538, 247);
            this.boxMsg.TabIndex = 1;
            // 
            // txtBotName
            // 
            this.txtBotName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBotName.AutoSize = true;
            this.txtBotName.Location = new System.Drawing.Point(576, 22);
            this.txtBotName.Name = "txtBotName";
            this.txtBotName.Size = new System.Drawing.Size(37, 13);
            this.txtBotName.TabIndex = 4;
            this.txtBotName.Text = "Status";
            this.txtBotName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxUser
            // 
            this.boxUser.Location = new System.Drawing.Point(118, 41);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(392, 20);
            this.boxUser.TabIndex = 5;
            this.boxUser.TextChanged += new System.EventHandler(this.boxUser_TextChanged);
            // 
            // txtChannelUser
            // 
            this.txtChannelUser.AutoSize = true;
            this.txtChannelUser.Location = new System.Drawing.Point(12, 44);
            this.txtChannelUser.Name = "txtChannelUser";
            this.txtChannelUser.Size = new System.Drawing.Size(100, 13);
            this.txtChannelUser.TabIndex = 6;
            this.txtChannelUser.Text = "Channel Username:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send Photo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 410);
            this.Controls.Add(this.txtChannelUser);
            this.Controls.Add(this.boxUser);
            this.Controls.Add(this.txtBotName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxToken);
            this.Controls.Add(this.btnSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox boxToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txtBotName;
        private System.Windows.Forms.TextBox boxUser;
        private System.Windows.Forms.Label txtChannelUser;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox boxMsg;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

