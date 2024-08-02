using MaterialSkin;
using MaterialSkin.Controls;

namespace SimpleMCAutoclicker
{
    internal class MaterialSettings
    {
        public MaterialSkinManager materialSkinManager { get; private set; }
        public MaterialSettings(MaterialForm form)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
