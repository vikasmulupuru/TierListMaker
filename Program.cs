using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TierListMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
     /*       TierListScreen parentForm = new TierListScreen();
            AddTierScreen TierChildForm = new AddTierScreen();
            AddItemScreen ItemChildForm = new AddItemScreen();
            AddTraitScreen TraitChildForm = new AddTraitScreen();

            TierChildForm.MdiParent = parentForm;
            ItemChildForm.MdiParent = parentForm;
            TraitChildForm.MdiParent = parentForm; */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TierListScreen());
        }
    }
}
 