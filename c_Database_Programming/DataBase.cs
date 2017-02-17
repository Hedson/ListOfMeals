using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_Database_Programming
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void ingredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cookbookDataSet);

        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookbookDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.cookbookDataSet.Ingredient);

        }

        private void bBackToMainForm_Click(object sender, EventArgs e)
        {
            FormMain m = new FormMain();
            m.Show();
            this.Hide();
        }
    }
}
