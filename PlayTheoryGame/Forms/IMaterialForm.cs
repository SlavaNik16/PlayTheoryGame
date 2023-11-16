using MaterialSkin;
using MaterialSkin.Controls;

namespace PlayTheoryGame.Forms
{
    public partial class IMaterialForm : MaterialForm
    {
       
        public IMaterialForm()
        {
            //InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey600, Primary.BlueGrey900, Primary.LightBlue700, Accent.Orange700, TextShade.WHITE
            );
        }
    }
}
