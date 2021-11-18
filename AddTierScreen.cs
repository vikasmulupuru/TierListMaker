using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TierListMaker
{
    public partial class AddTierScreen : Form
    {

        public AddTierScreen()
        {
            InitializeComponent();
        }

        private void AddTierScreen_Load(object sender, EventArgs e)
        {

        }

        private void OKAddTierButton_Click(object sender, EventArgs e)
        {
            TierListScreen parent = (TierListScreen)this.Owner;
            parent.comboBoxAddTier(addTierTextbox.Text);
            Close();
        }

        private void CancelAddTierButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTierTextbox_TextChanged(object sender, EventArgs e)
        {

        }

   /*     public Tier[] ComboboxItems()
        {
            Tier[] Tiers = new Tier[newTierList.ListLength()];
            Tier current;
            int i = 0;
            
            for(current = newTierList.head; current != null; current = current.getnextTier())
            {
                Tiers[i] = current;
                    i++;
            }

            return Tiers;
        } */
    }
}
