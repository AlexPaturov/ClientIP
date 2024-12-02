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
            btnSend.Location = new System.Drawing.Point(303, 24);
            btnSend.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(137, 36);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += BtnSend_Click;
            // 
            // btnSetConn
            // 
            btnSetConn.Location = new System.Drawing.Point(303, 31);
            btnSetConn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnSetConn.Name = "btnSetConn";
            btnSetConn.Size = new System.Drawing.Size(139, 36);
            btnSetConn.TabIndex = 1;
            btnSetConn.Text = "Set connection";
            btnSetConn.UseVisualStyleBackColor = true;
            btnSetConn.Click += btnSetConn_Click;
            // 
            // tbReceive
            // 
            tbReceive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbReceive.Font = new System.Drawing.Font("DejaVu Sans Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbReceive.Location = new System.Drawing.Point(8, 29);
            tbReceive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbReceive.Name = "tbReceive";
            tbReceive.Size = new System.Drawing.Size(582, 519);
            tbReceive.TabIndex = 2;
            tbReceive.Text = "";
            // 
            // tbMessage
            // 
            tbMessage.Location = new System.Drawing.Point(8, 29);
            tbMessage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new System.Drawing.Size(278, 27);
            tbMessage.TabIndex = 3;
            tbMessage.Text = "<Request method='get_static'/>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 44);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(21, 20);
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
            gbReceive.Location = new System.Drawing.Point(6, 8);
            gbReceive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gbReceive.Name = "gbReceive";
            gbReceive.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gbReceive.Size = new System.Drawing.Size(600, 635);
            gbReceive.TabIndex = 5;
            gbReceive.TabStop = false;
            gbReceive.Text = "Receiver";
            // 
            // labDelta
            // 
            labDelta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labDelta.AutoSize = true;
            labDelta.Location = new System.Drawing.Point(448, 576);
            labDelta.Name = "labDelta";
            labDelta.Size = new System.Drawing.Size(51, 20);
            labDelta.TabIndex = 19;
            labDelta.Text = "DELTA";
            // 
            // tbPR
            // 
            tbPR.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbPR.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbPR.Location = new System.Drawing.Point(377, 599);
            tbPR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPR.Name = "tbPR";
            tbPR.Size = new System.Drawing.Size(59, 25);
            tbPR.TabIndex = 18;
            // 
            // tbDELTA
            // 
            tbDELTA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbDELTA.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbDELTA.Location = new System.Drawing.Point(440, 599);
            tbDELTA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDELTA.Name = "tbDELTA";
            tbDELTA.Size = new System.Drawing.Size(59, 25);
            tbDELTA.TabIndex = 17;
            // 
            // tbPP
            // 
            tbPP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbPP.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbPP.Location = new System.Drawing.Point(315, 599);
            tbPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPP.Name = "tbPP";
            tbPP.Size = new System.Drawing.Size(59, 25);
            tbPP.TabIndex = 16;
            // 
            // tbV34
            // 
            tbV34.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV34.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV34.Location = new System.Drawing.Point(254, 599);
            tbV34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbV34.Name = "tbV34";
            tbV34.Size = new System.Drawing.Size(59, 25);
            tbV34.TabIndex = 15;
            // 
            // tbV12
            // 
            tbV12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV12.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV12.Location = new System.Drawing.Point(192, 599);
            tbV12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbV12.Name = "tbV12";
            tbV12.Size = new System.Drawing.Size(59, 25);
            tbV12.TabIndex = 14;
            // 
            // tbV24
            // 
            tbV24.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV24.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV24.Location = new System.Drawing.Point(130, 599);
            tbV24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbV24.Name = "tbV24";
            tbV24.Size = new System.Drawing.Size(59, 25);
            tbV24.TabIndex = 13;
            // 
            // tbV13
            // 
            tbV13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbV13.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbV13.Location = new System.Drawing.Point(69, 599);
            tbV13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbV13.Name = "tbV13";
            tbV13.Size = new System.Drawing.Size(59, 25);
            tbV13.TabIndex = 12;
            // 
            // tbBrutto
            // 
            tbBrutto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbBrutto.Font = new System.Drawing.Font("Segoe UI", 8F);
            tbBrutto.Location = new System.Drawing.Point(7, 599);
            tbBrutto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbBrutto.Name = "tbBrutto";
            tbBrutto.Size = new System.Drawing.Size(59, 25);
            tbBrutto.TabIndex = 11;
            // 
            // labPR
            // 
            labPR.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labPR.AutoSize = true;
            labPR.Location = new System.Drawing.Point(393, 576);
            labPR.Name = "labPR";
            labPR.Size = new System.Drawing.Size(26, 20);
            labPR.TabIndex = 10;
            labPR.Text = "PR";
            // 
            // labPP
            // 
            labPP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labPP.AutoSize = true;
            labPP.Location = new System.Drawing.Point(333, 576);
            labPP.Name = "labPP";
            labPP.Size = new System.Drawing.Size(25, 20);
            labPP.TabIndex = 9;
            labPP.Text = "PP";
            // 
            // labV34
            // 
            labV34.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV34.AutoSize = true;
            labV34.Location = new System.Drawing.Point(269, 576);
            labV34.Name = "labV34";
            labV34.Size = new System.Drawing.Size(34, 20);
            labV34.TabIndex = 8;
            labV34.Text = "V34";
            // 
            // labV12
            // 
            labV12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV12.AutoSize = true;
            labV12.Location = new System.Drawing.Point(207, 576);
            labV12.Name = "labV12";
            labV12.Size = new System.Drawing.Size(34, 20);
            labV12.TabIndex = 7;
            labV12.Text = "V12";
            // 
            // labV24
            // 
            labV24.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV24.AutoSize = true;
            labV24.Location = new System.Drawing.Point(145, 576);
            labV24.Name = "labV24";
            labV24.Size = new System.Drawing.Size(34, 20);
            labV24.TabIndex = 6;
            labV24.Text = "V24";
            // 
            // labV13
            // 
            labV13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labV13.AutoSize = true;
            labV13.Location = new System.Drawing.Point(85, 576);
            labV13.Name = "labV13";
            labV13.Size = new System.Drawing.Size(34, 20);
            labV13.TabIndex = 5;
            labV13.Text = "V13";
            // 
            // labBrutto
            // 
            labBrutto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labBrutto.AutoSize = true;
            labBrutto.Location = new System.Drawing.Point(9, 573);
            labBrutto.Name = "labBrutto";
            labBrutto.Size = new System.Drawing.Size(63, 20);
            labBrutto.TabIndex = 4;
            labBrutto.Text = "BRUTTO";
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(527, 601);
            btnClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(64, 27);
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
            groupBox1.Location = new System.Drawing.Point(614, 177);
            groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox1.Size = new System.Drawing.Size(465, 243);
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
            gbMode.Location = new System.Drawing.Point(11, 119);
            gbMode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gbMode.Name = "gbMode";
            gbMode.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gbMode.Size = new System.Drawing.Size(119, 99);
            gbMode.TabIndex = 8;
            gbMode.TabStop = false;
            gbMode.Text = "Data &Mode";
            // 
            // rbText
            // 
            rbText.AutoSize = true;
            rbText.Location = new System.Drawing.Point(16, 29);
            rbText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            rbText.Name = "rbText";
            rbText.Size = new System.Drawing.Size(57, 24);
            rbText.TabIndex = 0;
            rbText.Text = "Text";
            // 
            // rbHex
            // 
            rbHex.AutoSize = true;
            rbHex.Location = new System.Drawing.Point(16, 60);
            rbHex.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            rbHex.Name = "rbHex";
            rbHex.Size = new System.Drawing.Size(56, 24);
            rbHex.TabIndex = 1;
            rbHex.Text = "Hex";
            // 
            // chbLF
            // 
            chbLF.AutoSize = true;
            chbLF.Location = new System.Drawing.Point(150, 179);
            chbLF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            chbLF.Name = "chbLF";
            chbLF.Size = new System.Drawing.Size(161, 24);
            chbLF.TabIndex = 7;
            chbLF.Text = "add LF to messsage";
            chbLF.UseVisualStyleBackColor = true;
            // 
            // chbCR
            // 
            chbCR.AutoSize = true;
            chbCR.Location = new System.Drawing.Point(150, 144);
            chbCR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            chbCR.Name = "chbCR";
            chbCR.Size = new System.Drawing.Size(159, 24);
            chbCR.TabIndex = 6;
            chbCR.Text = "add CR to message";
            chbCR.UseVisualStyleBackColor = true;
            // 
            // chbSentQueue
            // 
            chbSentQueue.AutoSize = true;
            chbSentQueue.Location = new System.Drawing.Point(150, 73);
            chbSentQueue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            chbSentQueue.Name = "chbSentQueue";
            chbSentQueue.Size = new System.Drawing.Size(105, 24);
            chbSentQueue.TabIndex = 5;
            chbSentQueue.Text = "Sent queue";
            chbSentQueue.UseVisualStyleBackColor = true;
            chbSentQueue.CheckedChanged += chbSentQueue_CheckedChanged;
            // 
            // tbWaitSentMillisec
            // 
            tbWaitSentMillisec.Location = new System.Drawing.Point(8, 69);
            tbWaitSentMillisec.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbWaitSentMillisec.Name = "tbWaitSentMillisec";
            tbWaitSentMillisec.Size = new System.Drawing.Size(132, 27);
            tbWaitSentMillisec.TabIndex = 4;
            tbWaitSentMillisec.Text = "1000";
            tbWaitSentMillisec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 71);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 20);
            label2.TabIndex = 7;
            label2.Text = "PORT";
            // 
            // tbIp
            // 
            tbIp.Location = new System.Drawing.Point(65, 33);
            tbIp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbIp.Name = "tbIp";
            tbIp.Size = new System.Drawing.Size(165, 27);
            tbIp.TabIndex = 8;
            // 
            // tbPort
            // 
            tbPort.Location = new System.Drawing.Point(65, 67);
            tbPort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbPort.Name = "tbPort";
            tbPort.Size = new System.Drawing.Size(165, 27);
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
            gbNetworkConnection.Location = new System.Drawing.Point(614, 8);
            gbNetworkConnection.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gbNetworkConnection.Name = "gbNetworkConnection";
            gbNetworkConnection.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gbNetworkConnection.Size = new System.Drawing.Size(469, 168);
            gbNetworkConnection.TabIndex = 10;
            gbNetworkConnection.TabStop = false;
            gbNetworkConnection.Text = "TCP preferences";
            // 
            // btnGetData
            // 
            btnGetData.Location = new System.Drawing.Point(303, 76);
            btnGetData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(137, 36);
            btnGetData.TabIndex = 11;
            btnGetData.Text = "Start getting data";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += BtnGetData_Click;
            // 
            // btnCloseConn
            // 
            btnCloseConn.Location = new System.Drawing.Point(303, 120);
            btnCloseConn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnCloseConn.Name = "btnCloseConn";
            btnCloseConn.Size = new System.Drawing.Size(139, 36);
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
            groupBox2.Location = new System.Drawing.Point(614, 423);
            groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox2.Size = new System.Drawing.Size(469, 219);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "UDP preferences";
            // 
            // btnSendUdp
            // 
            btnSendUdp.Location = new System.Drawing.Point(370, 176);
            btnSendUdp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnSendUdp.Name = "btnSendUdp";
            btnSendUdp.Size = new System.Drawing.Size(70, 36);
            btnSendUdp.TabIndex = 13;
            btnSendUdp.Text = "Send";
            btnSendUdp.UseVisualStyleBackColor = true;
            btnSendUdp.Click += btnSendUDP_Click;
            // 
            // tbSendUDP
            // 
            tbSendUDP.Location = new System.Drawing.Point(11, 176);
            tbSendUDP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbSendUDP.Name = "tbSendUDP";
            tbSendUDP.Size = new System.Drawing.Size(243, 27);
            tbSendUDP.TabIndex = 12;
            tbSendUDP.Text = "<Request method='get_static'/>";
            // 
            // startGetDataUDP
            // 
            startGetDataUDP.Location = new System.Drawing.Point(303, 76);
            startGetDataUDP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            startGetDataUDP.Name = "startGetDataUDP";
            startGetDataUDP.Size = new System.Drawing.Size(137, 36);
            startGetDataUDP.TabIndex = 11;
            startGetDataUDP.Text = "Start getting data";
            startGetDataUDP.UseVisualStyleBackColor = true;
            startGetDataUDP.Click += startGetDataUDP_Click;
            // 
            // closeConnectionUDP
            // 
            closeConnectionUDP.Location = new System.Drawing.Point(303, 120);
            closeConnectionUDP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            closeConnectionUDP.Name = "closeConnectionUDP";
            closeConnectionUDP.Size = new System.Drawing.Size(139, 36);
            closeConnectionUDP.TabIndex = 10;
            closeConnectionUDP.Text = "Close connection";
            closeConnectionUDP.UseVisualStyleBackColor = true;
            closeConnectionUDP.Click += closeConnectionUDP_Click;
            // 
            // tbPortUDP
            // 
            tbPortUDP.Location = new System.Drawing.Point(65, 67);
            tbPortUDP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbPortUDP.Name = "tbPortUDP";
            tbPortUDP.Size = new System.Drawing.Size(165, 27);
            tbPortUDP.TabIndex = 9;
            tbPortUDP.Text = "10002";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 71);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "PORT";
            // 
            // tbIpUDP
            // 
            tbIpUDP.Location = new System.Drawing.Point(65, 33);
            tbIpUDP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tbIpUDP.Name = "tbIpUDP";
            tbIpUDP.Size = new System.Drawing.Size(165, 27);
            tbIpUDP.TabIndex = 8;
            tbIpUDP.Text = "192.168.0.103";
            // 
            // setConnectionUDP
            // 
            setConnectionUDP.Location = new System.Drawing.Point(303, 31);
            setConnectionUDP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            setConnectionUDP.Name = "setConnectionUDP";
            setConnectionUDP.Size = new System.Drawing.Size(139, 36);
            setConnectionUDP.TabIndex = 1;
            setConnectionUDP.Text = "Set connection";
            setConnectionUDP.UseVisualStyleBackColor = true;
            setConnectionUDP.Click += setConnectionUDP_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(34, 44);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(21, 20);
            label4.TabIndex = 4;
            label4.Text = "IP";
            // 
            // FormClientIP
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1081, 644);
            Controls.Add(groupBox2);
            Controls.Add(gbNetworkConnection);
            Controls.Add(groupBox1);
            Controls.Add(gbReceive);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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

