namespace ClientIP
{
    partial class formClientIP
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSetConn = new System.Windows.Forms.Button();
            this.tbReceive = new System.Windows.Forms.RichTextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReceive = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.chbLF = new System.Windows.Forms.CheckBox();
            this.chbCR = new System.Windows.Forms.CheckBox();
            this.chbSentQueue = new System.Windows.Forms.CheckBox();
            this.tbWaitSentMillisec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.gbNetworkConnection = new System.Windows.Forms.GroupBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.gbReceive.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.gbNetworkConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(303, 20);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSetConn
            // 
            this.btnSetConn.Location = new System.Drawing.Point(303, 25);
            this.btnSetConn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetConn.Name = "btnSetConn";
            this.btnSetConn.Size = new System.Drawing.Size(140, 28);
            this.btnSetConn.TabIndex = 1;
            this.btnSetConn.Text = "Set connection";
            this.btnSetConn.UseVisualStyleBackColor = true;
            this.btnSetConn.Click += new System.EventHandler(this.btnSetConn_Click);
            // 
            // tbReceive
            // 
            this.tbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReceive.Location = new System.Drawing.Point(8, 23);
            this.tbReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.Size = new System.Drawing.Size(599, 291);
            this.tbReceive.TabIndex = 2;
            this.tbReceive.Text = "";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(8, 23);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(279, 22);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.Text = "<Request method=\'get_static\'/>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // gbReceive
            // 
            this.gbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReceive.BackColor = System.Drawing.Color.MistyRose;
            this.gbReceive.Controls.Add(this.btnClear);
            this.gbReceive.Controls.Add(this.tbReceive);
            this.gbReceive.Location = new System.Drawing.Point(5, 6);
            this.gbReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReceive.Size = new System.Drawing.Size(616, 350);
            this.gbReceive.TabIndex = 5;
            this.gbReceive.TabStop = false;
            this.gbReceive.Text = "Receiver";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(544, 322);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 21);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.gbMode);
            this.groupBox1.Controls.Add(this.chbLF);
            this.groupBox1.Controls.Add(this.chbCR);
            this.groupBox1.Controls.Add(this.chbSentQueue);
            this.groupBox1.Controls.Add(this.tbWaitSentMillisec);
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(629, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(463, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send to COM";
            // 
            // gbMode
            // 
            this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMode.BackColor = System.Drawing.Color.Azure;
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Location = new System.Drawing.Point(12, 95);
            this.gbMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMode.Size = new System.Drawing.Size(119, 79);
            this.gbMode.TabIndex = 8;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(16, 23);
            this.rbText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(51, 20);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(16, 48);
            this.rbHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(49, 20);
            this.rbHex.TabIndex = 1;
            this.rbHex.Text = "Hex";
            // 
            // chbLF
            // 
            this.chbLF.AutoSize = true;
            this.chbLF.Location = new System.Drawing.Point(149, 143);
            this.chbLF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbLF.Name = "chbLF";
            this.chbLF.Size = new System.Drawing.Size(149, 20);
            this.chbLF.TabIndex = 7;
            this.chbLF.Text = "add LF to messsage";
            this.chbLF.UseVisualStyleBackColor = true;
            // 
            // chbCR
            // 
            this.chbCR.AutoSize = true;
            this.chbCR.Location = new System.Drawing.Point(149, 116);
            this.chbCR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbCR.Name = "chbCR";
            this.chbCR.Size = new System.Drawing.Size(146, 20);
            this.chbCR.TabIndex = 6;
            this.chbCR.Text = "add CR to message";
            this.chbCR.UseVisualStyleBackColor = true;
            // 
            // chbSentQueue
            // 
            this.chbSentQueue.AutoSize = true;
            this.chbSentQueue.Location = new System.Drawing.Point(149, 59);
            this.chbSentQueue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbSentQueue.Name = "chbSentQueue";
            this.chbSentQueue.Size = new System.Drawing.Size(94, 20);
            this.chbSentQueue.TabIndex = 5;
            this.chbSentQueue.Text = "Sent queue";
            this.chbSentQueue.UseVisualStyleBackColor = true;
            this.chbSentQueue.CheckedChanged += new System.EventHandler(this.chbSentQueue_CheckedChanged);
            // 
            // tbWaitSentMillisec
            // 
            this.tbWaitSentMillisec.Location = new System.Drawing.Point(8, 55);
            this.tbWaitSentMillisec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWaitSentMillisec.Name = "tbWaitSentMillisec";
            this.tbWaitSentMillisec.Size = new System.Drawing.Size(132, 22);
            this.tbWaitSentMillisec.TabIndex = 4;
            this.tbWaitSentMillisec.Text = "1000";
            this.tbWaitSentMillisec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(65, 27);
            this.tbIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(165, 22);
            this.tbIp.TabIndex = 8;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(65, 53);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(165, 22);
            this.tbPort.TabIndex = 9;
            // 
            // gbNetworkConnection
            // 
            this.gbNetworkConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNetworkConnection.BackColor = System.Drawing.Color.AliceBlue;
            this.gbNetworkConnection.Controls.Add(this.btnGetData);
            this.gbNetworkConnection.Controls.Add(this.btnCloseConn);
            this.gbNetworkConnection.Controls.Add(this.tbPort);
            this.gbNetworkConnection.Controls.Add(this.label2);
            this.gbNetworkConnection.Controls.Add(this.tbIp);
            this.gbNetworkConnection.Controls.Add(this.btnSetConn);
            this.gbNetworkConnection.Controls.Add(this.label1);
            this.gbNetworkConnection.Location = new System.Drawing.Point(629, 6);
            this.gbNetworkConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNetworkConnection.Name = "gbNetworkConnection";
            this.gbNetworkConnection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNetworkConnection.Size = new System.Drawing.Size(468, 134);
            this.gbNetworkConnection.TabIndex = 10;
            this.gbNetworkConnection.TabStop = false;
            this.gbNetworkConnection.Text = "NET preferences";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(303, 60);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(137, 28);
            this.btnGetData.TabIndex = 11;
            this.btnGetData.Text = "Start getting data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.Location = new System.Drawing.Point(303, 96);
            this.btnCloseConn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(140, 28);
            this.btnCloseConn.TabIndex = 10;
            this.btnCloseConn.Text = "Close connection";
            this.btnCloseConn.UseVisualStyleBackColor = true;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // timerSend
            // 
            this.timerSend.Interval = 1000;
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // formClientIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 357);
            this.Controls.Add(this.gbNetworkConnection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbReceive);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formClientIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client ip to Serial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClientIP_FormClosed);
            this.Load += new System.EventHandler(this.formClientIP_Load);
            this.Leave += new System.EventHandler(this.formClientIP_Leave);
            this.gbReceive.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbNetworkConnection.ResumeLayout(false);
            this.gbNetworkConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSetConn;
        private System.Windows.Forms.RichTextBox tbReceive;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbNetworkConnection;
        private System.Windows.Forms.Button btnCloseConn;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.CheckBox chbLF;
        private System.Windows.Forms.CheckBox chbCR;
        private System.Windows.Forms.CheckBox chbSentQueue;
        private System.Windows.Forms.TextBox tbWaitSentMillisec;
    }
}

