using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoMouse
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;      // The left button is down.
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;        // The left button is up.

        bool bMousePointSearch = false;
        bool bRepeat = false;
        int nRptCount = 0;
        int nRndStart = 1;
        int nRndEnd = 5;

        Random rndNum = new Random();

        public Form1()
        {
            InitializeComponent();


        }

        private void butStart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            nRptCount = Convert.ToInt32(txtRepeat.Text);
            nRndStart = Convert.ToInt32(txtStartCycle.Text);
            nRndEnd = Convert.ToInt32(txtEndCycle.Text);

            int nNextTime = rndNum.Next(nRndStart, nRndEnd);
            txtCycle.Text = Convert.ToString(nNextTime);
            timer2.Interval = nNextTime * 1000;
            timer2.Start();
        }
                
        private void butGetMouse_Click(object sender, EventArgs e)
        {
            if (bMousePointSearch)
            {
                bMousePointSearch = false;
                timer1.Stop();
            }
            else
            {
                bMousePointSearch = true;
                timer1.Interval = 500;  // 1초 간격으로 마우스 위치 확인
                timer1.Start();
            }
        }

        private void butExit_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txtXPoint.Text = Cursor.Position.X.ToString();
            txtYPoint.Text = Cursor.Position.Y.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if( bMousePointSearch && e.KeyCode == Keys.Space )
            {
                timer1.Stop();
                bMousePointSearch = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (nRptCount > 0)
            {
                int x = Convert.ToInt32(txtXPoint.Text);
                int y = Convert.ToInt32(txtYPoint.Text);

                Cursor.Position = new Point(x, y);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                nRptCount--;

                int nNextTime = rndNum.Next(nRndStart, nRndEnd);
                txtCycle.Text = Convert.ToString(nNextTime);
                timer2.Stop();
                timer2.Interval = nNextTime * 1000;
                timer2.Start();

                int nCount = Convert.ToInt32(txtRepeat.Text);
                nCount = nCount - nRptCount;        // 진행 횟수 
                labCount.Text = Convert.ToString(nCount);
            }
            else
            {
                timer2.Stop();
            }
        }

        private void butStop_Click_1(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
