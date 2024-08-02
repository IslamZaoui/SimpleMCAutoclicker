using Microsoft.Win32;

namespace SimpleMCAutoclicker
{
    internal class SettingsManager
    {
        private const string SettingsKey = @"SOFTWARE\SimpleMCAutoclicker";

        public void SaveSettings(MainForm form)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(SettingsKey))
            {
                key.SetValue("AttackButton", form.AttackButtonText);
                key.SetValue("CPS", form.CPS);
                key.SetValue("Randomize", form.Randomize);
                key.SetValue("ActivationKey", form.ActivationKey.ToString());
            }
        }

        public void LoadSettings(MainForm form)
        {
            using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(SettingsKey))
            {
                if (key != null)
                {
                    form.AttackButtonText = key.GetValue("AttackButton")?.ToString() ?? "left";
                    form.CPS = Convert.ToInt32(key.GetValue("CPS") ?? 10);
                    form.Randomize = Convert.ToInt32(key.GetValue("Randomize") ?? 0);

                    string activationKeyString = key.GetValue("ActivationKey")?.ToString() ?? "None";
                    if (Enum.TryParse(activationKeyString, out Keys keyCode))
                        form.ActivationKey = keyCode;
                    else
                        form.ActivationKey = Keys.None;
                }
            }
        }
    }
}
