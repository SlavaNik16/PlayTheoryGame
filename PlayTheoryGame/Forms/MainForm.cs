using PlayTheoryGame.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PlayTheoryGame
{
    public partial class MainForm : IMaterialForm
    {
        public List<int> listPriceOne = new List<int>();
        public List<int> listPriceTwo = new List<int>();
        public MainForm()
        {
            InitializeComponent();

        }



        private void butName_Click(object sender, System.EventArgs e)
        {
            labelPlayer1.Text = nameOneBox.Text;
            labelPlayer2.Text = nameTwoBox.Text;
        }

        private void butPriceAddList_Click(object sender, System.EventArgs e)
        {

            if (int.TryParse(priceBox.Text, out int price))
            {
                if (listBox.Count < 2)
                {
                    listPriceOne.Add(price);
                    listBox.AddItem(price.ToString());
                    dataGridView1.Columns.Add($"{nameof(price)}{listBox.Count}", $"{price:C2}");
                }
            }
            listPriceTwo = listPriceOne;
            var listRows = new List<string>();
            if (listPriceOne.Count >= 2)
            {
                for (int i = 0; i < listPriceOne.Count; i++)
                {
                    var one = listPriceOne[i];
                    var two = listPriceTwo[i];
                    for (int j = 0; j < listPriceOne.Count; j++)
                    {
                        var plan = Math.Abs(12 - 2 * one+ listPriceTwo[j]) * one;
                        var plan2 = Math.Abs(12 - 2 * two + listPriceOne[j]) * two;
                        listRows.Add($"{plan}:{plan2}");
                    }
                    dataGridView1.Rows.Add();
                } 
                for(int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for(int j = i; j < listPriceOne.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = listRows[i+j];
                    }
                }
               
            }

        }

        private void butClear_Click(object sender, System.EventArgs e)
        {
            listBox.Clear();
        }

    }
}
//     4 6
//4
//6