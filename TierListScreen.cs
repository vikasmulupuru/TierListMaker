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
    public partial class TierListScreen : Form 
    {

        public List<Tier> newTierList = new List<Tier>();
        public int newTierListLength = 0;
        DataTable tierList = new DataTable();
       


        
        public string strAddTier;
        public Tier addTier;

        public TierListScreen()
        {
            InitializeComponent();
            this.tiersDropdownComboBox.Text = "Tiers shown below";
            tierList.Columns.Add("rank", typeof(int));
            tierList.Columns.Add("tierName", typeof(string));
        }

        public void comboBoxAddTier(string newTier)
        {
            InitializeComponent();
            Tier addTier = new Tier(newTier);
            newTierList.Add(addTier);
            DataRow newRow = tierList.NewRow();
            newRow["rank"] = newTierListLength;
            newRow["tierName"] = newTier;
            newTierListLength++;
            refreshCombobox();
            Console.Out.WriteLine(newTierList.Count);
            Console.Out.WriteLine(tierList.Rows.Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void newTierButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddTierScreen();
            newForm.Show(this);
        }

        private void newItembutton_Click(object sender, EventArgs e)
        {
            var newForm = new AddItemScreen();
            newForm.Show();
        }

        private void newTraitButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddTraitScreen();
            newForm.Show();

        }

        private void showItemsButton_Click(object sender, EventArgs e)
        {

        }

        private void tiersDropdownComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tiersDropdownComboBox_DropDown(object sender, EventArgs e)
        {
            Console.Out.WriteLine("Pass");
        }





            /*       tiersDropdownComboBox.Items.Clear();
                   while (newTierList.head != null)
                   {
                       tiersDropdownComboBox.Items.Add(newTierList.head.name);
                   } */


        public void setAddTier(Tier setter)
        {
            addTier = setter;
        }

        public Tier getAddTier()
        {
            return addTier;
        }

        public void refreshCombobox()
        {
            
            this.tiersDropdownComboBox.DataSource = tierList;
            this.tiersDropdownComboBox.DisplayMember = "tierName";
        }
    }
}
