namespace TalkTalk
{
    partial class Server
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
            this._txtMsgHistoryServer = new System.Windows.Forms.TextBox();
            this._txtNewMsgServer = new System.Windows.Forms.TextBox();
            this._btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtMsgHistoryServer
            // 
            this._txtMsgHistoryServer.AcceptsReturn = true;
            this._txtMsgHistoryServer.AcceptsTab = true;
            this._txtMsgHistoryServer.Location = new System.Drawing.Point(9, 6);
            this._txtMsgHistoryServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtMsgHistoryServer.Multiline = true;
            this._txtMsgHistoryServer.Name = "_txtMsgHistoryServer";
            this._txtMsgHistoryServer.Size = new System.Drawing.Size(583, 314);
            this._txtMsgHistoryServer.TabIndex = 0;
            // 
            // _txtNewMsgServer
            // 
            this._txtNewMsgServer.Location = new System.Drawing.Point(9, 335);
            this._txtNewMsgServer.Name = "_txtNewMsgServer";
            this._txtNewMsgServer.Size = new System.Drawing.Size(485, 20);
            this._txtNewMsgServer.TabIndex = 1;
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(500, 335);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(75, 23);
            this._btnSend.TabIndex = 2;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this._btnSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._txtNewMsgServer);
            this.Controls.Add(this._txtMsgHistoryServer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtMsgHistoryServer;
        private System.Windows.Forms.TextBox _txtNewMsgServer;
        private System.Windows.Forms.Button _btnSend;
    }
}