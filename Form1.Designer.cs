namespace ClientIP
{
    partial class FormClientIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSend = new System.Windows.Forms.Button();
            btnSetConn = new System.Windows.Forms.Button();
            tbReceive = new System.Windows.Forms.RichTextBox();
            tbMessage = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            gbReceive = new System.Windows.Forms.GroupBox();
            labDelta = new System.Windows.Forms.Label();
            tbPR = new System.Windows.Forms.TextBox();
            tbDELTA = new System.Windows.Forms.TextBox();
            tbPP = new System.Windows.Forms.TextBox();
            tbV34 = new System.Windows.Forms.TextBox();
            tbV12 = new System.Windows.Forms.TextBox();
            tbV24 = new System.Windows.Forms.TextBox();
            tbV13 = new System.Windows.Forms.TextBox();
            tbBrutto = new System.Windows.Forms.TextBox();
            labPR = new System.Windows.Forms.Label();
            labPP = new System.Windows.Forms.Label();
            labV34 = new System.Windows.Forms.Label();
            labV12 = new System.Windows.Forms.Label();
            labV24 = new System.Windows.Forms.Label();
            labV13 = new System.Windows.Forms.Label();
            labBrutto = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            gbMode = new System.Windows.Forms.GroupBox();
            rbText = new System.Windows.Forms.RadioButton();
            rbHex = new System.Windows.Forms.RadioButton();
            chbLF = new System.Windows.Forms.CheckBox();
            chbCR = new System.Windows.Forms.CheckBox();
            chbSentQueue = new System.Windows.Forms.CheckBox();
            tbWaitSentMillisec = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbIp = new System.Windows.Forms.TextBox();
            tbPort = new System.Windows.Forms.TextBox();
            gbNetworkConnection = new System.Windows.Forms.GroupBox();
            btnGetData = new System.Windows.Forms.Button();
            btnCloseConn = new System.Windows.Forms.Button();
            timerSend = new System.Windows.Forms.Timer(components);
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnSendUdp = new System.Windows.Forms.Button();
            tbSendUDP = new System.Windows.Forms.TextBox();
            startGetDataUDP = new System.Windows.Forms.Button();
            closeConnectionUDP = new System.Windows.Forms.Button();
            tbPortUDP = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tbIpUDP = new System.Windows.Forms.TextBox();
            setConnectionUDP = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            gbReceive.SuspendLayout();
            groupBox1.SuspendLayout();
            gbMode.SuspendLayout();
            gbNetworkConnection.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(265, 18);
            btnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(120, 27);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += BtnSend_Click;
            // 
            // btnSetConn
            // 
            btnSetConn.Location = new System.Drawing.Point(265, 23);
            btnSetConn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSetConn.Name = "btnSetConn";
            btnSetConn.Size = new System.Drawing.Size(122, 27);
            btnSetConn.TabIndex = 1;
            btnSetConn.Text = "Set connection";
            btnSetConn.UseVisualStyleBackColor = true;
            btnSetConn.Click += btnSetConn_Click;
            // 
            // tbReceive
            // 
            tbReceive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbReceive.Font = new System.Drawing.Font("DejaVu Sans Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbReceive.Location = new System.Drawing.Point(7, 22);
            tbReceive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbReceive.Name = "tbReceive";
            tbReceive.Size = new System.Drawing.Size(510, 390);
            tbReceive.TabIndex = 2;
            tbReceive.Text = "";
            // 
            // tbMessage
            // 
            tbMessage.Location = new System.Drawing.Point(7, 22);
            tbMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new System.Drawing.Size(244, 23);
            tbMessage.TabIndex = 3;
            tbMessage.Text = "<Request method='get_static'/>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 33);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "IP";
            // 
            // gbReceive
            // 
            gbReceive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbReceive.BackColor = System.Drawing.Color.MistyRose;
            gbReceive.Controls.Add(labDelta);
            gbReceive.Controls.Add(tbPR);
            gbReceive.Controls.Add(tbDELTA);
            gbReceive.Controls.Add(tbPP);
            gbReceive.Controls.Add(tbV34);
            gbReceive.Controls.Add(tbV12);
            gbReceive.Controls.Add(tbV24);
            gbReceive.Controls.Add(tbV13);
            gbReceive.Controls.Add(tbBrutto);
            gbReceive.Controls.Add(labPR);
            gbReceive.Controls.Add(labPP);
            gbReceive.Controls.Add(labV34);
            gbReceive.Controls.Add(labV12);
            gbReceive.Controls.Add(labV24);
            gbReceive.Controls.Add(labV13);
            gbReceive.Controls.Add(labBrutto);
            gbReceive.Controls.Add(btnClear);
            gbReceive.Controls.Add(tbReceive);
            gbReceive.Location = new System.Drawing.Point(5, 6);
            gbReceive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbReceive.Name = "gbReceive";
            gbReceive.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbReceive.Size = new System.Drawing.Size(525, 476);
            gbReceive.TabIndex = 5;
            gbReceive.TabStop = false;
            gbReceive.Text = "Receiver";
            // 
            // labDelta
            // 
            labDelta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labDelta.AutoSize = true;
            labDelta.Location = new System.Drawing.Point(392, 432);
            labDelta.Name = "labDelta";
            labDelta.Size = new System.Drawing.Size(39, 15);
            labDelta.TabIndex = 19;
            labDelta.Text = "DELTA";
            // 
            // tbPR
            // 
            tbPR.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbPR.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbPR.Location = new System.Drawing.Point(330, 449);
            tbPR.Name = "tbPR";
            tbPR.Size = new System.Drawing.Size(52, 22);
            tbPR.TabIndex = 18;
            // 
            // tbDELTA
            // 
            tbDELTA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbDELTA.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbDELTA.Location = new System.Drawing.Point(385, 449);
            tbDELTA.Name = "tbDELTA";
            tbDELTA.Size = new System.Drawing.Size(52, 22);
            tbDELTA.TabIndex = 17;
            // 
            // tbPP
            // 
            tbPP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbPP.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbPP.Location = new System.Drawing.Point(276, 449);
            tbPP.Name = "tbPP";
            tbPP.Size = new System.Drawing.Size(52, 22);
            tbPP.TabIndex = 16;
            // 
            // tbV34
            // 
            tbV34.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV34.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV34.Location = new System.Drawing.Point(222, 449);
            tbV34.Name = "tbV34";
            tbV34.Size = new System.Drawing.Size(52, 22);
            tbV34.TabIndex = 15;
            // 
            // tbV12
            // 
            tbV12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV12.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV12.Location = new System.Drawing.Point(168, 449);
            tbV12.Name = "tbV12";
            tbV12.Size = new System.Drawing.Size(52, 22);
            tbV12.TabIndex = 14;
            // 
            // tbV24
            // 
            tbV24.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV24.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV24.Location = new System.Drawing.Point(114, 449);
            tbV24.Name = "tbV24";
            tbV24.Size = new System.Drawing.Size(52, 22);
            tbV24.TabIndex = 13;
            // 
            // tbV13
            // 
            tbV13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV13.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV13.Location = new System.Drawing.Point(60, 449);
            tbV13.Name = "tbV13";
            tbV13.Size = new System.Drawing.Size(52, 22);
            tbV13.TabIndex = 12;
            // 
            // tbBrutto
            // 
            tbBrutto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbBrutto.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbBrutto.Location = new System.Drawing.Point(6, 449);
            tbBrutto.Name = "tbBrutto";
            tbBrutto.Size = new System.Drawing.Size(52, 22);
            tbBrutto.TabIndex = 11;
            // 
            // labPR
            // 
            labPR.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labPR.AutoSize = true;
            labPR.Location = new System.Drawing.Point(344, 432);
            labPR.Name = "labPR";
            labPR.Size = new System.Drawing.Size(21, 15);
            labPR.TabIndex = 10;
            labPR.Text = "PR";
            // 
            // labPP
            // 
            labPP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labPP.AutoSize = true;
            labPP.Location = new System.Drawing.Point(291, 432);
            labPP.Name = "labPP";
            labPP.Size = new System.Drawing.Size(21, 15);
            labPP.TabIndex = 9;
            labPP.Text = "PP";
            // 
            // labV34
            // 
            labV34.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV34.AutoSize = true;
            labV34.Location = new System.Drawing.Point(235, 432);
            labV34.Name = "labV34";
            labV34.Size = new System.Drawing.Size(26, 15);
            labV34.TabIndex = 8;
            labV34.Text = "V34";
            // 
            // labV12
            // 
            labV12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV12.AutoSize = true;
            labV12.Location = new System.Drawing.Point(181, 432);
            labV12.Name = "labV12";
            labV12.Size = new System.Drawing.Size(26, 15);
            labV12.TabIndex = 7;
            labV12.Text = "V12";
            // 
            // labV24
            // 
            labV24.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV24.AutoSize = true;
            labV24.Location = new System.Drawing.Point(127, 432);
            labV24.Name = "labV24";
            labV24.Size = new System.Drawing.Size(26, 15);
            labV24.TabIndex = 6;
            labV24.Text = "V24";
            // 
            // labV13
            // 
            labV13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV13.AutoSize = true;
            labV13.Location = new System.Drawing.Point(74, 432);
            labV13.Name = "labV13";
            labV13.Size = new System.Drawing.Size(26, 15);
            labV13.TabIndex = 5;
            labV13.Text = "V13";
            // 
            // labBrutto
            // 
            labBrutto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labBrutto.AutoSize = true;
            labBrutto.Location = new System.Drawing.Point(8, 430);
            labBrutto.Name = "labBrutto";
            labBrutto.Size = new System.Drawing.Size(49, 15);
            labBrutto.TabIndex = 4;
            labBrutto.Text = "BRUTTO";
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(461, 451);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(56, 20);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.BackColor = System.Drawing.Color.Lavender;
            groupBox1.Controls.Add(gbMode);
            groupBox1.Controls.Add(chbLF);
            groupBox1.Controls.Add(chbCR);
            groupBox1.Controls.Add(chbSentQueue);
            groupBox1.Controls.Add(tbWaitSentMillisec);
            groupBox1.Controls.Add(tbMessage);
            groupBox1.Controls.Add(btnSend);
            groupBox1.Location = new System.Drawing.Point(537, 133);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(407, 182);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send to COM";
            // 
            // gbMode
            // 
            gbMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            gbMode.BackColor = System.Drawing.Color.Azure;
            gbMode.Controls.Add(rbText);
            gbMode.Controls.Add(rbHex);
            gbMode.Location = new System.Drawing.Point(10, 89);
            gbMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbMode.Name = "gbMode";
            gbMode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbMode.Size = new System.Drawing.Size(104, 74);
            gbMode.TabIndex = 8;
            gbMode.TabStop = false;
            gbMode.Text = "Data &Mode";
            // 
            // rbText
            // 
            rbText.AutoSize = true;
            rbText.Location = new System.Drawing.Point(14, 22);
            rbText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbText.Name = "rbText";
            rbText.Size = new System.Drawing.Size(46, 19);
            rbText.TabIndex = 0;
            rbText.Text = "Text";
            // 
            // rbHex
            // 
            rbHex.AutoSize = true;
            rbHex.Location = new System.Drawing.Point(14, 45);
            rbHex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbHex.Name = "rbHex";
            rbHex.Size = new System.Drawing.Size(46, 19);
            rbHex.TabIndex = 1;
            rbHex.Text = "Hex";
            // 
            // chbLF
            // 
            chbLF.AutoSize = true;
            chbLF.Location = new System.Drawing.Point(131, 134);
            chbLF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chbLF.Name = "chbLF";
            chbLF.Size = new System.Drawing.Size(129, 19);
            chbLF.TabIndex = 7;
            chbLF.Text = "add LF to messsage";
            chbLF.UseVisualStyleBackColor = true;
            // 
            // chbCR
            // 
            chbCR.AutoSize = true;
            chbCR.Location = new System.Drawing.Point(131, 108);
            chbCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chbCR.Name = "chbCR";
            chbCR.Size = new System.Drawing.Size(127, 19);
            chbCR.TabIndex = 6;
            chbCR.Text = "add CR to message";
            chbCR.UseVisualStyleBackColor = true;
            // 
            // chbSentQueue
            // 
            chbSentQueue.AutoSize = true;
            chbSentQueue.Location = new System.Drawing.Point(131, 55);
            chbSentQueue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chbSentQueue.Name = "chbSentQueue";
            chbSentQueue.Size = new System.Drawing.Size(85, 19);
            chbSentQueue.TabIndex = 5;
            chbSentQueue.Text = "Sent queue";
            chbSentQueue.UseVisualStyleBackColor = true;
            chbSentQueue.CheckedChanged += chbSentQueue_CheckedChanged;
            // 
            // tbWaitSentMillisec
            // 
            tbWaitSentMillisec.Location = new System.Drawing.Point(7, 52);
            tbWaitSentMillisec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbWaitSentMillisec.Name = "tbWaitSentMillisec";
            tbWaitSentMillisec.Size = new System.Drawing.Size(116, 23);
            tbWaitSentMillisec.TabIndex = 4;
            tbWaitSentMillisec.Text = "1000";
            tbWaitSentMillisec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 53);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "PORT";
            // 
            // tbIp
            // 
            tbIp.Location = new System.Drawing.Point(57, 25);
            tbIp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbIp.Name = "tbIp";
            tbIp.Size = new System.Drawing.Size(145, 23);
            tbIp.TabIndex = 8;
            // 
            // tbPort
            // 
            tbPort.Location = new System.Drawing.Point(57, 50);
            tbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbPort.Name = "tbPort";
            tbPort.Size = new System.Drawing.Size(145, 23);
            tbPort.TabIndex = 9;
            // 
            // gbNetworkConnection
            // 
            gbNetworkConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbNetworkConnection.BackColor = System.Drawing.Color.AliceBlue;
            gbNetworkConnection.Controls.Add(btnGetData);
            gbNetworkConnection.Controls.Add(btnCloseConn);
            gbNetworkConnection.Controls.Add(tbPort);
            gbNetworkConnection.Controls.Add(label2);
            gbNetworkConnection.Controls.Add(tbIp);
            gbNetworkConnection.Controls.Add(btnSetConn);
            gbNetworkConnection.Controls.Add(label1);
            gbNetworkConnection.Location = new System.Drawing.Point(537, 6);
            gbNetworkConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbNetworkConnection.Name = "gbNetworkConnection";
            gbNetworkConnection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbNetworkConnection.Size = new System.Drawing.Size(410, 126);
            gbNetworkConnection.TabIndex = 10;
            gbNetworkConnection.TabStop = false;
            gbNetworkConnection.Text = "TCP preferences (получаю xml)";
            // 
            // btnGetData
            // 
            btnGetData.Location = new System.Drawing.Point(265, 57);
            btnGetData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(120, 27);
            btnGetData.TabIndex = 11;
            btnGetData.Text = "Start getting data";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += BtnGetData_Click;
            // 
            // btnCloseConn
            // 
            btnCloseConn.Location = new System.Drawing.Point(265, 90);
            btnCloseConn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCloseConn.Name = "btnCloseConn";
            btnCloseConn.Size = new System.Drawing.Size(122, 27);
            btnCloseConn.TabIndex = 10;
            btnCloseConn.Text = "Close connection";
            btnCloseConn.UseVisualStyleBackColor = true;
            btnCloseConn.Click += btnCloseConn_Click;
            // 
            // timerSend
            // 
            timerSend.Interval = 1000;
            timerSend.Tick += timerSend_Tick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            groupBox2.Controls.Add(btnSendUdp);
            groupBox2.Controls.Add(tbSendUDP);
            groupBox2.Controls.Add(startGetDataUDP);
            groupBox2.Controls.Add(closeConnectionUDP);
            groupBox2.Controls.Add(tbPortUDP);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbIpUDP);
            groupBox2.Controls.Add(setConnectionUDP);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new System.Drawing.Point(537, 317);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(410, 164);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "UDP preferences (получаю словарь)";
            // 
            // btnSendUdp
            // 
            btnSendUdp.Location = new System.Drawing.Point(324, 132);
            btnSendUdp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSendUdp.Name = "btnSendUdp";
            btnSendUdp.Size = new System.Drawing.Size(61, 27);
            btnSendUdp.TabIndex = 13;
            btnSendUdp.Text = "Send";
            btnSendUdp.UseVisualStyleBackColor = true;
            btnSendUdp.Click += btnSendUDP_Click;
            // 
            // tbSendUDP
            // 
            tbSendUDP.Location = new System.Drawing.Point(10, 132);
            tbSendUDP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbSendUDP.Name = "tbSendUDP";
            tbSendUDP.Size = new System.Drawing.Size(213, 23);
            tbSendUDP.TabIndex = 12;
            tbSendUDP.Text = "<Request method='get_static'/>";
            // 
            // startGetDataUDP
            // 
            startGetDataUDP.Location = new System.Drawing.Point(265, 57);
            startGetDataUDP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            startGetDataUDP.Name = "startGetDataUDP";
            startGetDataUDP.Size = new System.Drawing.Size(120, 27);
            startGetDataUDP.TabIndex = 11;
            startGetDataUDP.Text = "Start getting data";
            startGetDataUDP.UseVisualStyleBackColor = true;
            startGetDataUDP.Click += startGetDataUDP_Click;
            // 
            // closeConnectionUDP
            // 
            closeConnectionUDP.Location = new System.Drawing.Point(265, 90);
            closeConnectionUDP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeConnectionUDP.Name = "closeConnectionUDP";
            closeConnectionUDP.Size = new System.Drawing.Size(122, 27);
            closeConnectionUDP.TabIndex = 10;
            closeConnectionUDP.Text = "Close connection";
            closeConnectionUDP.UseVisualStyleBackColor = true;
            closeConnectionUDP.Click += closeConnectionUDP_Click;
            // 
            // tbPortUDP
            // 
            tbPortUDP.Location = new System.Drawing.Point(57, 50);
            tbPortUDP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbPortUDP.Name = "tbPortUDP";
            tbPortUDP.Size = new System.Drawing.Size(145, 23);
            tbPortUDP.TabIndex = 9;
            tbPortUDP.Text = "10002";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 53);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "PORT";
            // 
            // tbIpUDP
            // 
            tbIpUDP.Location = new System.Drawing.Point(57, 25);
            tbIpUDP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbIpUDP.Name = "tbIpUDP";
            tbIpUDP.Size = new System.Drawing.Size(145, 23);
            tbIpUDP.TabIndex = 8;
            tbIpUDP.Text = "192.168.0.103";
            // 
            // setConnectionUDP
            // 
            setConnectionUDP.Location = new System.Drawing.Point(265, 23);
            setConnectionUDP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            setConnectionUDP.Name = "setConnectionUDP";
            setConnectionUDP.Size = new System.Drawing.Size(122, 27);
            setConnectionUDP.TabIndex = 1;
            setConnectionUDP.Text = "Set connection";
            setConnectionUDP.UseVisualStyleBackColor = true;
            setConnectionUDP.Click += setConnectionUDP_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(30, 33);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 15);
            label4.TabIndex = 4;
            label4.Text = "IP";
            // 
            // FormClientIP
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(946, 483);
            Controls.Add(groupBox2);
            Controls.Add(gbNetworkConnection);
            Controls.Add(groupBox1);
            Controls.Add(gbReceive);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormClientIP";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Client ip to Serial";
            Load += formClientIP_Load;
            gbReceive.ResumeLayout(false);
            gbReceive.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbMode.ResumeLayout(false);
            gbMode.PerformLayout();
            gbNetworkConnection.ResumeLayout(false);
            gbNetworkConnection.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startGetDataUDP;
        private System.Windows.Forms.Button closeConnectionUDP;
        private System.Windows.Forms.TextBox tbPortUDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIpUDP;
        private System.Windows.Forms.Button setConnectionUDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendUdp;
        private System.Windows.Forms.TextBox tbSendUDP;
        private System.Windows.Forms.Label labV12;
        private System.Windows.Forms.Label labV24;
        private System.Windows.Forms.Label labV13;
        private System.Windows.Forms.Label labBrutto;
        private System.Windows.Forms.Label labV34;
        private System.Windows.Forms.Label labPR;
        private System.Windows.Forms.Label labPP;
        private System.Windows.Forms.TextBox tbV12;
        private System.Windows.Forms.TextBox tbV24;
        private System.Windows.Forms.TextBox tbV13;
        private System.Windows.Forms.TextBox tbBrutto;
        private System.Windows.Forms.Label labDelta;
        private System.Windows.Forms.TextBox tbPR;
        private System.Windows.Forms.TextBox tbDELTA;
        private System.Windows.Forms.TextBox tbPP;
        private System.Windows.Forms.TextBox tbV34;
    }
}

