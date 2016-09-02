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
            this.gbTwitch.SuspendLayout();
            this.tlpTwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
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
            // AutoTwitchSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTwitch);
            this.Name = "AutoTwitchSettings";
            this.Size = new System.Drawing.Size(476, 453);
            this.gbTwitch.ResumeLayout(false);
            this.tlpTwitch.ResumeLayout(false);
            this.tlpTwitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
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
    }
}
