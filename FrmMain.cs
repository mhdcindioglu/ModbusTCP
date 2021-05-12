using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        ModbusIpMaster Master;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (BtnConnect.Text == "Connect")
            {
                Master = ModbusIpMaster.CreateIp(new System.Net.Sockets.TcpClient(TxtIP.Text, Convert.ToInt32(TxtPort.Text)));
                GrpConnect.Enabled = false;
                GrpReadWrite.Visible = true;
                BtnConnect.Text = "DisConnect";
            }
            else
            {
                Master = null;
                GrpConnect.Enabled = true;
                GrpReadWrite.Visible = false;
                BtnConnect.Text = "Connect";
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (BtnRead.Text == "Read")
            {
                BtnRead.Text = "Stop";
                TmrRead.Interval = Convert.ToInt32(TxtRefresh.Text);
                TmrRead.Enabled = true;
            }
            else
            {
                BtnRead.Text = "Read";
                TmrRead.Enabled = false;
            }
        }

        private ushort[] ReadHoldingRegisters(ushort registerAddress, ushort length)
        {
            try
            {
                return Master.ReadHoldingRegisters(Convert.ToByte(TxtSlaveAddress.Text), registerAddress, length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TmrRead_Tick(object sender, EventArgs e)
        {
            try
            {
                var values = ReadHoldingRegisters(Convert.ToUInt16(TxtRegisterAddress.Text, 16), Convert.ToUInt16(TxtRegisterCount.Text));

                LblTemp1.Text = ToDecimal(values[0]);
                LblTemp2.Text = ToDecimal(values[1]);
                LblTemp3.Text = ToDecimal(values[2]);
                LblTemp4.Text = ToDecimal(values[3]);
                LblTemp5.Text = ToDecimal(values[4]);
                LblTemp6.Text = ToDecimal(values[5]);
                LblTemp.Text = ToDecimal(values[6]);
            }
            catch (Exception ex)
            {
                TmrRead.Enabled = false;
                BtnConnect_Click(this, new EventArgs());
                BtnRead_Click(this, new EventArgs());
                MessageBox.Show(ex.Message);
            }
        }

        private string ToDecimal(ushort value)
        {
            decimal val = Convert.ToDecimal(value.ToString());
            return (val / 10).ToString("0.0");
        }
    }
}
