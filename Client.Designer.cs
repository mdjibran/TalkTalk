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
            this._txtMsgHistory.Location = new System.Drawing.Point(12, 13);
            this._txtMsgHistory.Multiline = true;
            this._txtMsgHistory.Name = "_txtMsgHistory";
            this._txtMsgHistory.Size = new System.Drawing.Size(776, 386);
            this._txtMsgHistory.TabIndex = 0;
            // 
            // _txtBoxNewMsg
            // 
            this._txtBoxNewMsg.Location = new System.Drawing.Point(13, 416);
            this._txtBoxNewMsg.Name = "_txtBoxNewMsg";
            this._txtBoxNewMsg.Size = new System.Drawing.Size(581, 22);
            this._txtBoxNewMsg.TabIndex = 1;
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(649, 415);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(108, 23);
            this._btnSend.TabIndex = 2;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._txtBoxNewMsg);
            this.Controls.Add(this._txtMsgHistory);
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