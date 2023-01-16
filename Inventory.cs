using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mile_Stone_Inventory_Moving_List
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void addInv_Click(object sender, EventArgs e)
        {
            new AddDet().Show();
            this.Hide();
        }

        private void remInv_Click(object sender, EventArgs e)
        {
            new Remove().Show();
            this.Hide();
        }

        private void roomAvail_Click(object sender, EventArgs e)
        {
            new RoomAvai().Show();
            this.Hide();
        }

        private void detList_Click(object sender, EventArgs e)
        {
            new TheList().Show();
            this.Hide();
        }

        private void roomSea_Click(object sender, EventArgs e)
        {
            new Search().Show();
            this.Hide();
        }

        private void cancBut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
