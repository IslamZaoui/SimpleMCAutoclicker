using MaterialSkin.Controls;

public class NotifyIconManager
{
    private readonly NotifyIcon trayIcon;
    private readonly ContextMenuStrip trayMenu;
    private readonly MaterialForm form;

    public NotifyIconManager(MaterialForm form)
    {
        this.form = form;

        trayMenu = new ContextMenuStrip();
        trayMenu.Items.Add("Restore", null, Restore_Click);
        trayMenu.Items.Add("Exit", null, Exit_Click);

        trayIcon = new NotifyIcon
        {
            Text = "SimpleMCAutoclicker",
            Icon = form.Icon,
            ContextMenuStrip = trayMenu,
            Visible = false
        };

        trayIcon.DoubleClick += Restore_Click;
    }

    public void HandleResize(object sender, EventArgs e)
    {
        if (form.WindowState == FormWindowState.Minimized)
        {
            form.Hide();
            trayIcon.Visible = true;
            ShowBalloonTip("Simple MC Autoclicker", "The application has been minimized to the system tray.");
        }
    }

    private void Restore_Click(object sender, EventArgs e)
    {
        form.Show();
        form.WindowState = FormWindowState.Normal;
        trayIcon.Visible = false;
    }

    private void Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void ShowBalloonTip(string title, string message)
    {
        trayIcon.BalloonTipTitle = title;
        trayIcon.BalloonTipText = message;
        trayIcon.BalloonTipIcon = ToolTipIcon.Info;
        trayIcon.ShowBalloonTip(3000);
    }
}
