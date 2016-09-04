namespace LiveSplit.AutoTwitch
{
    partial class AutoTwitchSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTwitchSettings));
            this.gbTwitch = new System.Windows.Forms.GroupBox();
            this.tlpTwitch = new System.Windows.Forms.TableLayoutPanel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbOAuth = new System.Windows.Forms.TextBox();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblOAuth = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.gbMessages = new System.Windows.Forms.GroupBox();
            this.tlpMessageList = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.gbTwitch.SuspendLayout();
            this.tlpTwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.gbMessages.SuspendLayout();
            this.tlpMessageList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTwitch
            // 
            this.gbTwitch.Controls.Add(this.tlpTwitch);
            this.gbTwitch.Location = new System.Drawing.Point(4, 4);
            this.gbTwitch.Name = "gbTwitch";
            this.gbTwitch.Size = new System.Drawing.Size(469, 106);
            this.gbTwitch.TabIndex = 0;
            this.gbTwitch.TabStop = false;
            this.gbTwitch.Text = "Twitch Info";
            // 
            // tlpTwitch
            // 
            this.tlpTwitch.ColumnCount = 3;
            this.tlpTwitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpTwitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTwitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTwitch.Controls.Add(this.tbUsername, 2, 0);
            this.tlpTwitch.Controls.Add(this.tbOAuth, 2, 1);
            this.tlpTwitch.Controls.Add(this.tbChannel, 2, 2);
            this.tlpTwitch.Controls.Add(this.lblUsername, 0, 0);
            this.tlpTwitch.Controls.Add(this.lblOAuth, 0, 1);
            this.tlpTwitch.Controls.Add(this.lblChannel, 0, 2);
            this.tlpTwitch.Controls.Add(this.pbHelp, 1, 1);
            this.tlpTwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTwitch.Location = new System.Drawing.Point(3, 16);
            this.tlpTwitch.Name = "tlpTwitch";
            this.tlpTwitch.RowCount = 3;
            this.tlpTwitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTwitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTwitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTwitch.Size = new System.Drawing.Size(463, 87);
            this.tlpTwitch.TabIndex = 0;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(117, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(343, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tbOAuth
            // 
            this.tbOAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOAuth.Location = new System.Drawing.Point(117, 33);
            this.tbOAuth.Name = "tbOAuth";
            this.tbOAuth.Size = new System.Drawing.Size(343, 20);
            this.tbOAuth.TabIndex = 1;
            this.tbOAuth.UseSystemPasswordChar = true;
            // 
            // tbChannel
            // 
            this.tbChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChannel.Location = new System.Drawing.Point(117, 62);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(343, 20);
            this.tbChannel.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblOAuth
            // 
            this.lblOAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOAuth.AutoSize = true;
            this.lblOAuth.Location = new System.Drawing.Point(3, 37);
            this.lblOAuth.Name = "lblOAuth";
            this.lblOAuth.Size = new System.Drawing.Size(79, 13);
            this.lblOAuth.TabIndex = 4;
            this.lblOAuth.Text = "OAuth Code:";
            // 
            // lblChannel
            // 
            this.lblChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(3, 66);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(79, 13);
            this.lblChannel.TabIndex = 5;
            this.lblChannel.Text = "Channel:";
            // 
            // pbHelp
            // 
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(88, 32);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(23, 23);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 6;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            this.pbHelp.MouseEnter += new System.EventHandler(this.pbHelp_MouseEnter);
            this.pbHelp.MouseLeave += new System.EventHandler(this.pbHelp_MouseLeave);
            // 
            // gbMessages
            // 
            this.gbMessages.Controls.Add(this.tlpMessageList);
            this.gbMessages.Location = new System.Drawing.Point(4, 116);
            this.gbMessages.Name = "gbMessages";
            this.gbMessages.Size = new System.Drawing.Size(469, 48);
            this.gbMessages.TabIndex = 1;
            this.gbMessages.TabStop = false;
            this.gbMessages.Text = "Messages";
            // 
            // tlpMessageList
            // 
            this.tlpMessageList.ColumnCount = 2;
            this.tlpMessageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.46652F));
            this.tlpMessageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.53348F));
            this.tlpMessageList.Controls.Add(this.btnAddMessage, 1, 0);
            this.tlpMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMessageList.Location = new System.Drawing.Point(3, 16);
            this.tlpMessageList.Name = "tlpMessageList";
            this.tlpMessageList.RowCount = 1;
            this.tlpMessageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpMessageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMessageList.Size = new System.Drawing.Size(463, 29);
            this.tlpMessageList.TabIndex = 0;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddMessage.Location = new System.Drawing.Point(385, 3);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(75, 23);
            this.btnAddMessage.TabIndex = 0;
            this.btnAddMessage.Text = "Add Message";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // AutoTwitchSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMessages);
            this.Controls.Add(this.gbTwitch);
            this.Name = "AutoTwitchSettings";
            this.Size = new System.Drawing.Size(476, 169);
            this.gbTwitch.ResumeLayout(false);
            this.tlpTwitch.ResumeLayout(false);
            this.tlpTwitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.gbMessages.ResumeLayout(false);
            this.tlpMessageList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTwitch;
        private System.Windows.Forms.TableLayoutPanel tlpTwitch;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbOAuth;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblOAuth;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.GroupBox gbMessages;
        private System.Windows.Forms.TableLayoutPanel tlpMessageList;
        private System.Windows.Forms.Button btnAddMessage;
    }
}
