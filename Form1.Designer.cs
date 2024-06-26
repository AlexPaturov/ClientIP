﻿namespace ClientIP
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSetConn = new System.Windows.Forms.Button();
            this.tbReceive = new System.Windows.Forms.RichTextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReceive = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.gbNetworkConnection = new System.Windows.Forms.GroupBox();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.gbReceive.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbNetworkConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(227, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSetConn
            // 
            this.btnSetConn.Location = new System.Drawing.Point(227, 20);
            this.btnSetConn.Name = "btnSetConn";
            this.btnSetConn.Size = new System.Drawing.Size(105, 23);
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
            this.tbReceive.Location = new System.Drawing.Point(6, 19);
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.Size = new System.Drawing.Size(450, 237);
            this.tbReceive.TabIndex = 2;
            this.tbReceive.Text = "";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(6, 19);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(210, 20);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.Text = "F#1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
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
            this.gbReceive.Location = new System.Drawing.Point(4, 5);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Size = new System.Drawing.Size(462, 284);
            this.gbReceive.TabIndex = 5;
            this.gbReceive.TabStop = false;
            this.gbReceive.Text = "Receiver";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(408, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 17);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(472, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send to COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(49, 22);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(125, 20);
            this.tbIp.TabIndex = 8;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(49, 43);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(125, 20);
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
            this.gbNetworkConnection.Location = new System.Drawing.Point(472, 5);
            this.gbNetworkConnection.Name = "gbNetworkConnection";
            this.gbNetworkConnection.Size = new System.Drawing.Size(351, 109);
            this.gbNetworkConnection.TabIndex = 10;
            this.gbNetworkConnection.TabStop = false;
            this.gbNetworkConnection.Text = "NET preferences";
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.Location = new System.Drawing.Point(227, 78);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(105, 23);
            this.btnCloseConn.TabIndex = 10;
            this.btnCloseConn.Text = "Close connection";
            this.btnCloseConn.UseVisualStyleBackColor = true;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(227, 49);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(103, 23);
            this.btnGetData.TabIndex = 11;
            this.btnGetData.Text = "Start getting data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // formClientIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 290);
            this.Controls.Add(this.gbNetworkConnection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbReceive);
            this.Name = "formClientIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client ip to Serial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClientIP_FormClosed);
            this.Load += new System.EventHandler(this.formClientIP_Load);
            this.gbReceive.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

