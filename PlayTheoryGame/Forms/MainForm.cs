using PlayTheoryGame.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace PlayTheoryGame
{
    public partial class MainForm : IMaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void butName_Click(object sender, System.EventArgs e)
        {
            Label1.Text = nameOne.Text; 
            Label2.Text = nameTwo.Text;
        }

        private void butPriceAddList_Click(object sender, System.EventArgs e)
        {
            if(int.TryParse(priceBox.Text, out int price))
            {
                if (listBox.Count < 2)
                {
                    listBox.AddItem(price.ToString());
                }
            }
            for(int i = 0; i< listBox.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        price1_1.Text = listBox.Items[i].Text;
                        price2_1.Text = listBox.Items[i].Text;
                        break;
                    case 1:
                        price1_2.Text = listBox.Items[i].Text;
                        price2_2.Text = listBox.Items[i].Text;
                        break;

                }
                
            }
                
            
        }

        private void butClear_Click(object sender, System.EventArgs e)
        {
            listBox.Clear();
        }
    }
}
