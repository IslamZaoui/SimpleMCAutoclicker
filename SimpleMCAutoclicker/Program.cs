namespace SimpleMCAutoclicker
{
    internal static class Program
    {
        static Mutex? mutex = null;

        [STAThread]
        static void Main()
        {
            const string appName = "SimpleMCAutoclicker";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("An instance of SimpleMCAutoclicker is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}