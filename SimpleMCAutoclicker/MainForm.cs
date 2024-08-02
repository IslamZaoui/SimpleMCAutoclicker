using MaterialSkin.Controls;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace SimpleMCAutoclicker
{
    public partial class MainForm : MaterialForm
    {
        private bool isEnabled = false;
        private bool isActivated = false;
        private int cps = 10;
        private int randomize = 0;
        private Keys activationKey = Keys.None;

        private readonly Random random = new Random();
        private SettingsManager settingsManager;

        private NotifyIconManager notifyIconManager;

        public string AttackButtonText
        {
            get => attackbtnbox.Text;
            set => attackbtnbox.Text = value;
        }

        public int CPS
        {
            get => cps;
            set
            {
                cps = value;
                CPSTrackBar.Value = cps;
            }
        }

        public int Randomize
        {
            get => randomize;
            set
            {
                randomize = value;
                randomizeTrackBar.Value = randomize;
            }
        }

        public Keys ActivationKey
        {
            get => activationKey;
            set
            {
                activationKey = value;
                activationBindButton.Text = activationKey == Keys.None ? "Bind Activation Key" : $"Activation Key: {activationKey}";
            }
        }

        public MainForm()
        {
            InitializeComponent();
            new MaterialSettings(this);
            attackbtnbox.SelectedIndex = 1;

            settingsManager = new SettingsManager();
            notifyIconManager = new NotifyIconManager(this);

            this.Resize += notifyIconManager.HandleResize;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            settingsManager.LoadSettings(this);
            StartInfiniteLoop();
        }

        private void StartInfiniteLoop()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    if (activationKey == Keys.None || !isEnabled)
                    {
                        Thread.Sleep(100);
                        continue;
                    }

                    isActivated = (NativeMethods.GetAsyncKeyState((int)activationKey) & 0x8000) != 0;

                    if (isActivated)
                    {
                        Invoke(new Action(PerformMouseClick));
                        int interval = GetAdjustedInterval();
                        Thread.Sleep(interval);
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            });
        }

        private void PerformMouseClick()
        {
            if (attackbtnbox.InvokeRequired)
            {
                attackbtnbox.Invoke(new Action(PerformMouseClick));
                return;
            }

            IntPtr hWnd = FindMinecraftWindow();
            if (hWnd != IntPtr.Zero)
            {
                NativeMethods.SetForegroundWindow(hWnd);

                uint downMsg = attackbtnbox.Text.Equals("left") ? NativeMethods.WM_LBUTTONDOWN : NativeMethods.WM_RBUTTONDOWN;
                uint upMsg = attackbtnbox.Text.Equals("left") ? NativeMethods.WM_LBUTTONUP : NativeMethods.WM_RBUTTONUP;

                NativeMethods.PostMessage(hWnd, downMsg, IntPtr.Zero, IntPtr.Zero);
                NativeMethods.PostMessage(hWnd, upMsg, IntPtr.Zero, IntPtr.Zero);
            }
        }

        private IntPtr FindMinecraftWindow()
        {
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                IntPtr hWnd = process.MainWindowHandle;
                if (hWnd != IntPtr.Zero)
                {
                    StringBuilder sb = new StringBuilder(256);
                    if (NativeMethods.GetWindowText(hWnd, sb, sb.Capacity) > 0 && sb.ToString().Contains("Minecraft"))
                    {
                        return hWnd;
                    }
                }
            }
            return IntPtr.Zero;
        }

        private int GetAdjustedInterval()
        {
            int baseInterval = CPSToInterval(cps);
            int randomOffset = random.Next(0, randomize + 1);
            return baseInterval + randomOffset;
        }

        private int CPSToInterval(int clicksPerSecond)
        {
            if (clicksPerSecond <= 0)
                throw new ArgumentException("Clicks per second must be greater than zero.");

            return (int)(1000.0 / clicksPerSecond);
        }

        private void CPSTrackBar_onValueChanged(object sender, int newValue)
        {
            cps = newValue;
            settingsManager.SaveSettings(this);
        }

        private void randomizeTrackBar_onValueChanged(object sender, int newValue)
        {
            randomize = newValue;
            settingsManager.SaveSettings(this);
        }

        private void ActivationBindButton_Click(object sender, EventArgs e)
        {
            using (var bindForm = new BindKeyForm())
            {
                if (bindForm.ShowDialog() == DialogResult.OK)
                {
                    activationKey = bindForm.BoundKey;
                    activationBindButton.Text = $"Activation Key: {activationKey}";
                    settingsManager.SaveSettings(this);
                }
            }
        }

        private void EnableSwitch_CheckedChanged(object sender, EventArgs e)
        {
            isEnabled = EnableSwitch.Checked;
        }
    }
}
