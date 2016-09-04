namespace LiveSplit.AutoTwitch
{
    partial class MessageSettings
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
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.cbAccuracy = new System.Windows.Forms.ComboBox();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblTimeFormat = new System.Windows.Forms.Label();
            this.cbTimeFormat = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbSendOnNewSplit = new System.Windows.Forms.CheckBox();
            this.lblTimingMethod = new System.Windows.Forms.Label();
            this.cbTimingMethod = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.gbMessage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMessage
            // 
            this.gbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMessage.Controls.Add(this.tableLayoutPanel1);
            this.gbMessage.Location = new System.Drawing.Point(0, 0);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(427, 135);
            this.gbMessage.TabIndex = 0;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.tbMessage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAccuracy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAccuracy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTimeFormat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTimeFormat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbSendOnNewSplit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTimingMethod, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbTimingMethod, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEvent, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbEvents, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbMessage, 3);
            this.tbMessage.Location = new System.Drawing.Point(97, 4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(321, 20);
            this.tbMessage.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(88, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Message Text:";
            // 
            // cbAccuracy
            // 
            this.cbAccuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccuracy.FormattingEnabled = true;
            this.cbAccuracy.Location = new System.Drawing.Point(311, 32);
            this.cbAccuracy.Name = "cbAccuracy";
            this.cbAccuracy.Size = new System.Drawing.Size(107, 21);
            this.cbAccuracy.TabIndex = 5;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(204, 37);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(101, 13);
            this.lblAccuracy.TabIndex = 6;
            this.lblAccuracy.Text = "Time Accuracy:";
            // 
            // lblTimeFormat
            // 
            this.lblTimeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeFormat.AutoSize = true;
            this.lblTimeFormat.Location = new System.Drawing.Point(3, 37);
            this.lblTimeFormat.Name = "lblTimeFormat";
            this.lblTimeFormat.Size = new System.Drawing.Size(88, 13);
            this.lblTimeFormat.TabIndex = 7;
            this.lblTimeFormat.Text = "Time Format:";
            // 
            // cbTimeFormat
            // 
            this.cbTimeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeFormat.FormattingEnabled = true;
            this.cbTimeFormat.Location = new System.Drawing.Point(97, 33);
            this.cbTimeFormat.Name = "cbTimeFormat";
            this.cbTimeFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTimeFormat.Size = new System.Drawing.Size(101, 21);
            this.cbTimeFormat.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.Location = new System.Drawing.Point(317, 90);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Message";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cbSendOnNewSplit
            // 
            this.cbSendOnNewSplit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSendOnNewSplit.AutoSize = true;
            this.cbSendOnNewSplit.Location = new System.Drawing.Point(311, 64);
            this.cbSendOnNewSplit.Name = "cbSendOnNewSplit";
            this.cbSendOnNewSplit.Size = new System.Drawing.Size(107, 17);
            this.cbSendOnNewSplit.TabIndex = 9;
            this.cbSendOnNewSplit.Text = "Send if New Split";
            this.cbSendOnNewSplit.UseVisualStyleBackColor = true;
            // 
            // lblTimingMethod
            // 
            this.lblTimingMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimingMethod.AutoSize = true;
            this.lblTimingMethod.Location = new System.Drawing.Point(3, 66);
            this.lblTimingMethod.Name = "lblTimingMethod";
            this.lblTimingMethod.Size = new System.Drawing.Size(80, 13);
            this.lblTimingMethod.TabIndex = 10;
            this.lblTimingMethod.Text = "Timing Method:";
            // 
            // cbTimingMethod
            // 
            this.cbTimingMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbTimingMethod, 2);
            this.cbTimingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimingMethod.FormattingEnabled = true;
            this.cbTimingMethod.Location = new System.Drawing.Point(97, 62);
            this.cbTimingMethod.Name = "cbTimingMethod";
            this.cbTimingMethod.Size = new System.Drawing.Size(208, 21);
            this.cbTimingMethod.TabIndex = 11;
            // 
            // lblEvent
            // 
            this.lblEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(3, 95);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(88, 13);
            this.lblEvent.TabIndex = 2;
            this.lblEvent.Text = "Event:";
            // 
            // cbEvents
            // 
            this.cbEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(97, 91);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(101, 21);
            this.cbEvents.TabIndex = 3;
            // 
            // MessageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMessage);
            this.Name = "MessageSettings";
            this.Size = new System.Drawing.Size(427, 135);
            this.gbMessage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cbAccuracy;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblTimeFormat;
        private System.Windows.Forms.ComboBox cbTimeFormat;
        private System.Windows.Forms.CheckBox cbSendOnNewSplit;
        private System.Windows.Forms.Label lblTimingMethod;
        private System.Windows.Forms.ComboBox cbTimingMethod;
    }
}
