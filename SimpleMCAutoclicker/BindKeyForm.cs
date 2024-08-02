using MaterialSkin.Controls;

namespace SimpleMCAutoclicker
{
    public partial class BindKeyForm : MaterialForm
    {
        public Keys BoundKey { get; private set; }

        public BindKeyForm()
        {
            InitializeComponent();
            new MaterialSettings(this);
        }

        private void BindKeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            BoundKey = e.KeyCode;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BindKeyForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    BoundKey = Keys.LButton;
                    break;
                case MouseButtons.Right:
                    BoundKey = Keys.RButton;
                    break;
                case MouseButtons.Middle:
                    BoundKey = Keys.MButton;
                    break;
                case MouseButtons.XButton1:
                    BoundKey = Keys.XButton1;
                    break;
                case MouseButtons.XButton2:
                    BoundKey = Keys.XButton2;
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BindKeyForm_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void BindKeyForm_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}