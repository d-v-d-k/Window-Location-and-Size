using System;
using System.Windows.Forms;

namespace GetWindowPosAndSize
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Window_Move(sender, e);
            Window_Resize(sender, e);
        }

        private void Window_Move(object sender, EventArgs e)
        {
            nudLocX.Value = this.Location.X;
            nudLocY.Value = this.Location.Y;
            OnWindowChange();
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            nudSizeW.Value = this.Size.Width;
            nudSizeH.Value = this.Size.Height;
            OnWindowChange();
        }

        private void nudLocX_ValueChanged(object sender, EventArgs e)
        {
            this.Left = (int)nudLocX.Value;
        }

        private void nudLocY_ValueChanged(object sender, EventArgs e)
        {
            this.Top = (int)nudLocY.Value;
        }

        private void nudSizeW_ValueChanged(object sender, EventArgs e)
        {
            this.Width = (int)nudSizeW.Value;
        }

        private void nudSizeH_ValueChanged(object sender, EventArgs e)
        {
            this.Height = (int)nudSizeH.Value;
        }

        void OnWindowChange()
        {
            tbChrome.Text = "--window-position=" + this.Left + "," + this.Top +" --window-size=" + this.Width + "," + this.Height;
        }
    }
}
