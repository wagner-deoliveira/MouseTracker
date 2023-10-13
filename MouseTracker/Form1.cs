using System;
using System.Threading;
using System.Windows.Forms;

namespace MouseTracker
{
    public partial class MousePointer : Form
    {
        public MousePointer()
        {
            InitializeComponent();
            MousePointer_Load();
        }

        private void MousePointer_Load()
        {
            Thread trackerThread = new Thread(Tracker);
            trackerThread.Start();
        }

        private void Tracker()
        {
            while(true)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;
                Console.Write(y);

                mousePointerValueX.Text = x.ToString();
                mousePointerValueY.Text = y.ToString();

            }
        }
    }
}
