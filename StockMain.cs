using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class StockMain : Form
    {

        public StockMain()
        {
            InitializeComponent();
        }
        public bool closing = true;
        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit?",
                                    "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    closing = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                } 
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.StartPosition = FormStartPosition.CenterScreen;
            pro.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock sto = new Stock();
            sto.MdiParent = this;
            sto.StartPosition = FormStartPosition.CenterScreen;
            sto.Show();
        }
    }
}
