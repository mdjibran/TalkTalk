namespace TalkTalk
{
    partial class Client
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
            this._txtMsgHistory = new System.Windows.Forms.TextBox();
            this._txtBoxNewMsg = new System.Windows.Forms.TextBox();
            this._btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtMsgHistory
            // 
            this._txtMsgHistory.AcceptsReturn = true;
            this._txtMsgHistory.AcceptsTab = true;
            this._txtMsgHistory.Location = new System.Drawing.Point(9, 11);
            this._txtMsgHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtMsgHistory.Multiline = true;
            this._txtMsgHistory.Name = "_txtMsgHistory";
            this._txtMsgHistory.Size = new System.Drawing.Size(583, 314);
            this._txtMsgHistory.TabIndex = 0;
            // 
            // _txtBoxNewMsg
            // 
            this._txtBoxNewMsg.Location = new System.Drawing.Point(10, 338);
            this._txtBoxNewMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtBoxNewMsg.Name = "_txtBoxNewMsg";
            this._txtBoxNewMsg.Size = new System.Drawing.Size(437, 20);
            this._txtBoxNewMsg.TabIndex = 1;
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(487, 337);
            this._btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(81, 19);
            this._btnSend.TabIndex = 2;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this._btnSend_Click_1);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._txtBoxNewMsg);
            this.Controls.Add(this._txtMsgHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtMsgHistory;
        private System.Windows.Forms.TextBox _txtBoxNewMsg;
        private System.Windows.Forms.Button _btnSend;
    }
}