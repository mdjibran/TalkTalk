namespace TalkTalk
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
            this._BtnStartCam = new System.Windows.Forms.Button();
            this._BtnStopCam = new System.Windows.Forms.Button();
            this._pbUser1 = new System.Windows.Forms.PictureBox();
            this._cmbCamList = new System.Windows.Forms.ComboBox();
            this._pbUser2 = new System.Windows.Forms.PictureBox();
            this._btnSend = new System.Windows.Forms.Button();
            this._txtServer = new System.Windows.Forms.TextBox();
            this._txtClient = new System.Windows.Forms.TextBox();
            this._btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pbUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbUser2)).BeginInit();
            this.SuspendLayout();
            // 
            // _BtnStartCam
            // 
            this._BtnStartCam.Location = new System.Drawing.Point(13, 10);
            this._BtnStartCam.Name = "_BtnStartCam";
            this._BtnStartCam.Size = new System.Drawing.Size(110, 23);
            this._BtnStartCam.TabIndex = 0;
            this._BtnStartCam.Text = "Start Web Cam";
            this._BtnStartCam.UseVisualStyleBackColor = true;
            this._BtnStartCam.Click += new System.EventHandler(this._BtnStartCam_Click);
            // 
            // _BtnStopCam
            // 
            this._BtnStopCam.Location = new System.Drawing.Point(129, 10);
            this._BtnStopCam.Name = "_BtnStopCam";
            this._BtnStopCam.Size = new System.Drawing.Size(110, 23);
            this._BtnStopCam.TabIndex = 1;
            this._BtnStopCam.Text = "End Web Cam";
            this._BtnStopCam.UseVisualStyleBackColor = true;
            this._BtnStopCam.Click += new System.EventHandler(this._BtnStopCam_Click);
            // 
            // _pbUser1
            // 
            this._pbUser1.Location = new System.Drawing.Point(30, 119);
            this._pbUser1.Name = "_pbUser1";
            this._pbUser1.Size = new System.Drawing.Size(327, 319);
            this._pbUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._pbUser1.TabIndex = 2;
            this._pbUser1.TabStop = false;
            // 
            // _cmbCamList
            // 
            this._cmbCamList.FormattingEnabled = true;
            this._cmbCamList.Location = new System.Drawing.Point(30, 64);
            this._cmbCamList.Name = "_cmbCamList";
            this._cmbCamList.Size = new System.Drawing.Size(271, 24);
            this._cmbCamList.TabIndex = 3;
            // 
            // _pbUser2
            // 
            this._pbUser2.Location = new System.Drawing.Point(425, 119);
            this._pbUser2.Name = "_pbUser2";
            this._pbUser2.Size = new System.Drawing.Size(327, 319);
            this._pbUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._pbUser2.TabIndex = 4;
            this._pbUser2.TabStop = false;
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(259, 13);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(75, 23);
            this._btnSend.TabIndex = 5;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this._btnSend_Click);
            // 
            // _txtServer
            // 
            this._txtServer.AcceptsReturn = true;
            this._txtServer.Location = new System.Drawing.Point(786, 10);
            this._txtServer.Multiline = true;
            this._txtServer.Name = "_txtServer";
            this._txtServer.Size = new System.Drawing.Size(204, 186);
            this._txtServer.TabIndex = 6;
            // 
            // _txtClient
            // 
            this._txtClient.AcceptsReturn = true;
            this._txtClient.Location = new System.Drawing.Point(786, 329);
            this._txtClient.Multiline = true;
            this._txtClient.Name = "_txtClient";
            this._txtClient.Size = new System.Drawing.Size(204, 186);
            this._txtClient.TabIndex = 7;
            // 
            // _btnConnect
            // 
            this._btnConnect.Location = new System.Drawing.Point(358, 12);
            this._btnConnect.Name = "_btnConnect";
            this._btnConnect.Size = new System.Drawing.Size(75, 23);
            this._btnConnect.TabIndex = 8;
            this._btnConnect.Text = "Connect";
            this._btnConnect.UseVisualStyleBackColor = true;
            this._btnConnect.Click += new System.EventHandler(this._btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 527);
            this.Controls.Add(this._btnConnect);
            this.Controls.Add(this._txtClient);
            this.Controls.Add(this._txtServer);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._pbUser2);
            this.Controls.Add(this._cmbCamList);
            this.Controls.Add(this._pbUser1);
            this.Controls.Add(this._BtnStopCam);
            this.Controls.Add(this._BtnStartCam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pbUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbUser2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _BtnStartCam;
        private System.Windows.Forms.Button _BtnStopCam;
        private System.Windows.Forms.PictureBox _pbUser1;
        private System.Windows.Forms.ComboBox _cmbCamList;
        private System.Windows.Forms.PictureBox _pbUser2;
        private System.Windows.Forms.Button _btnSend;
        private System.Windows.Forms.TextBox _txtServer;
        private System.Windows.Forms.TextBox _txtClient;
        private System.Windows.Forms.Button _btnConnect;
    }
}

