
namespace WindowsFormsApp1
{
    partial class FrmMain
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.GrpConnect = new System.Windows.Forms.GroupBox();
            this.TxtRefresh = new System.Windows.Forms.TextBox();
            this.TxtSlaveAddress = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.TmrRead = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRegisterAddress = new System.Windows.Forms.TextBox();
            this.GrpReadWrite = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTemp = new System.Windows.Forms.Label();
            this.LblTemp6 = new System.Windows.Forms.Label();
            this.LblTemp5 = new System.Windows.Forms.Label();
            this.LblTemp4 = new System.Windows.Forms.Label();
            this.LblTemp3 = new System.Windows.Forms.Label();
            this.LblTemp2 = new System.Windows.Forms.Label();
            this.LblTemp1 = new System.Windows.Forms.Label();
            this.TxtRegisterCount = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GrpConnect.SuspendLayout();
            this.GrpReadWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 0;
            label1.Text = "TCP IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(150, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 4;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(233, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 13);
            label3.TabIndex = 10;
            label3.Text = "Slave Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(352, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 13);
            label4.TabIndex = 32;
            label4.Text = "Refresh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.GrpConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(452, 14);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // GrpConnect
            // 
            this.GrpConnect.BackColor = System.Drawing.Color.Transparent;
            this.GrpConnect.Controls.Add(this.TxtRefresh);
            this.GrpConnect.Controls.Add(label4);
            this.GrpConnect.Controls.Add(this.TxtSlaveAddress);
            this.GrpConnect.Controls.Add(this.TxtPort);
            this.GrpConnect.Controls.Add(this.TxtIP);
            this.GrpConnect.Controls.Add(label3);
            this.GrpConnect.Controls.Add(label1);
            this.GrpConnect.Controls.Add(label2);
            this.GrpConnect.Location = new System.Drawing.Point(6, 9);
            this.GrpConnect.Name = "GrpConnect";
            this.GrpConnect.Size = new System.Drawing.Size(449, 33);
            this.GrpConnect.TabIndex = 2;
            // 
            // TxtRefresh
            // 
            this.TxtRefresh.Location = new System.Drawing.Point(407, 7);
            this.TxtRefresh.Name = "TxtRefresh";
            this.TxtRefresh.Size = new System.Drawing.Size(33, 20);
            this.TxtRefresh.TabIndex = 33;
            this.TxtRefresh.Text = "1000";
            this.TxtRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSlaveAddress
            // 
            this.TxtSlaveAddress.Location = new System.Drawing.Point(318, 7);
            this.TxtSlaveAddress.Name = "TxtSlaveAddress";
            this.TxtSlaveAddress.Size = new System.Drawing.Size(28, 20);
            this.TxtSlaveAddress.TabIndex = 31;
            this.TxtSlaveAddress.Text = "1";
            this.TxtSlaveAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(187, 7);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(40, 20);
            this.TxtPort.TabIndex = 30;
            this.TxtPort.Text = "502";
            this.TxtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(52, 7);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(92, 20);
            this.TxtIP.TabIndex = 29;
            this.TxtIP.Text = "192.168.1.198";
            // 
            // TmrRead
            // 
            this.TmrRead.Tick += new System.EventHandler(this.TmrRead_Tick);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(101, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "0x";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(230, 8);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 20);
            this.BtnRead.TabIndex = 7;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Register Address:";
            // 
            // TxtRegisterAddress
            // 
            this.TxtRegisterAddress.Location = new System.Drawing.Point(121, 8);
            this.TxtRegisterAddress.Name = "TxtRegisterAddress";
            this.TxtRegisterAddress.Size = new System.Drawing.Size(56, 20);
            this.TxtRegisterAddress.TabIndex = 32;
            this.TxtRegisterAddress.Text = "1000";
            this.TxtRegisterAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrpReadWrite
            // 
            this.GrpReadWrite.BackColor = System.Drawing.Color.Transparent;
            this.GrpReadWrite.Controls.Add(this.label13);
            this.GrpReadWrite.Controls.Add(this.label12);
            this.GrpReadWrite.Controls.Add(this.label10);
            this.GrpReadWrite.Controls.Add(this.label9);
            this.GrpReadWrite.Controls.Add(this.label8);
            this.GrpReadWrite.Controls.Add(this.label7);
            this.GrpReadWrite.Controls.Add(this.LblTemp);
            this.GrpReadWrite.Controls.Add(this.LblTemp6);
            this.GrpReadWrite.Controls.Add(this.LblTemp5);
            this.GrpReadWrite.Controls.Add(this.LblTemp4);
            this.GrpReadWrite.Controls.Add(this.LblTemp3);
            this.GrpReadWrite.Controls.Add(this.LblTemp2);
            this.GrpReadWrite.Controls.Add(this.LblTemp1);
            this.GrpReadWrite.Controls.Add(this.TxtRegisterCount);
            this.GrpReadWrite.Controls.Add(this.TxtRegisterAddress);
            this.GrpReadWrite.Controls.Add(this.label5);
            this.GrpReadWrite.Controls.Add(this.BtnRead);
            this.GrpReadWrite.Controls.Add(this.label11);
            this.GrpReadWrite.Location = new System.Drawing.Point(12, 63);
            this.GrpReadWrite.Name = "GrpReadWrite";
            this.GrpReadWrite.Size = new System.Drawing.Size(776, 375);
            this.GrpReadWrite.TabIndex = 1;
            this.GrpReadWrite.Visible = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(568, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 60);
            this.label13.TabIndex = 59;
            this.label13.Text = "Temp6";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(569, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 60);
            this.label12.TabIndex = 58;
            this.label12.Text = "Temp5";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(569, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 60);
            this.label10.TabIndex = 57;
            this.label10.Text = "Temp4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(568, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 60);
            this.label9.TabIndex = 56;
            this.label9.Text = "Temp3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(569, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 60);
            this.label8.TabIndex = 55;
            this.label8.Text = "Temp2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(568, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 56);
            this.label7.TabIndex = 54;
            this.label7.Text = "Temp1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTemp
            // 
            this.LblTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp.Font = new System.Drawing.Font("Digital-7", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp.ForeColor = System.Drawing.Color.Lime;
            this.LblTemp.Location = new System.Drawing.Point(308, 124);
            this.LblTemp.Name = "LblTemp";
            this.LblTemp.Size = new System.Drawing.Size(204, 116);
            this.LblTemp.TabIndex = 53;
            this.LblTemp.Text = "0.0";
            this.LblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTemp6
            // 
            this.LblTemp6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp6.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTemp6.Location = new System.Drawing.Point(566, 300);
            this.LblTemp6.Name = "LblTemp6";
            this.LblTemp6.Size = new System.Drawing.Size(196, 58);
            this.LblTemp6.TabIndex = 52;
            this.LblTemp6.Text = "0.0";
            this.LblTemp6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTemp5
            // 
            this.LblTemp5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp5.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTemp5.Location = new System.Drawing.Point(566, 242);
            this.LblTemp5.Name = "LblTemp5";
            this.LblTemp5.Size = new System.Drawing.Size(196, 58);
            this.LblTemp5.TabIndex = 51;
            this.LblTemp5.Text = "0.0";
            this.LblTemp5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTemp4
            // 
            this.LblTemp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp4.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTemp4.Location = new System.Drawing.Point(566, 184);
            this.LblTemp4.Name = "LblTemp4";
            this.LblTemp4.Size = new System.Drawing.Size(196, 58);
            this.LblTemp4.TabIndex = 50;
            this.LblTemp4.Text = "0.0";
            this.LblTemp4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTemp3
            // 
            this.LblTemp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp3.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTemp3.Location = new System.Drawing.Point(566, 126);
            this.LblTemp3.Name = "LblTemp3";
            this.LblTemp3.Size = new System.Drawing.Size(196, 58);
            this.LblTemp3.TabIndex = 49;
            this.LblTemp3.Text = "0.0";
            this.LblTemp3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTemp2
            // 
            this.LblTemp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp2.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTemp2.Location = new System.Drawing.Point(566, 68);
            this.LblTemp2.Name = "LblTemp2";
            this.LblTemp2.Size = new System.Drawing.Size(196, 58);
            this.LblTemp2.TabIndex = 48;
            this.LblTemp2.Text = "0.0";
            this.LblTemp2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTemp1
            // 
            this.LblTemp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTemp1.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTemp1.Location = new System.Drawing.Point(566, 10);
            this.LblTemp1.Name = "LblTemp1";
            this.LblTemp1.Size = new System.Drawing.Size(196, 58);
            this.LblTemp1.TabIndex = 47;
            this.LblTemp1.Text = "0.0";
            this.LblTemp1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtRegisterCount
            // 
            this.TxtRegisterCount.Location = new System.Drawing.Point(183, 8);
            this.TxtRegisterCount.Name = "TxtRegisterCount";
            this.TxtRegisterCount.Size = new System.Drawing.Size(41, 20);
            this.TxtRegisterCount.TabIndex = 46;
            this.TxtRegisterCount.Text = "7";
            this.TxtRegisterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpReadWrite);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "ModbusTCP";
            this.groupBox1.ResumeLayout(false);
            this.GrpConnect.ResumeLayout(false);
            this.GrpConnect.PerformLayout();
            this.GrpReadWrite.ResumeLayout(false);
            this.GrpReadWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.GroupBox GrpConnect;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.TextBox TxtSlaveAddress;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtRefresh;
        private System.Windows.Forms.Timer TmrRead;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRegisterAddress;
        private System.Windows.Forms.GroupBox GrpReadWrite;
        private System.Windows.Forms.TextBox TxtRegisterCount;
        private System.Windows.Forms.Label LblTemp4;
        private System.Windows.Forms.Label LblTemp3;
        private System.Windows.Forms.Label LblTemp2;
        private System.Windows.Forms.Label LblTemp1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblTemp;
        private System.Windows.Forms.Label LblTemp6;
        private System.Windows.Forms.Label LblTemp5;
    }
}

