using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mile_Stone_Inventory_Moving_List
{
    public partial class AddDet : Form
    {
        public AddDet()
        {
            InitializeComponent();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("E:\\Room 1.txt");
            txt.Write(nameBox.Text);
            txt.Write("  -  ");
            txt.Write(ethBox.Text);
            txt.Write("  -  ");
            txt.Write(charBox.Text);
            txt.Close();

            new Inventory().Show();
            this.Hide();
        }

        private void addButt2_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("E:\\Room 2.txt");
            txt.Write(nameBox.Text);
            txt.Write("  -  ");
            txt.Write(ethBox.Text);
            txt.Write("  -  ");
            txt.Write(charBox.Text);
            txt.Close();

            new Inventory().Show();
            this.Hide();
        }

        private void addButt3_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("E:\\Room 3.txt");
            txt.Write(nameBox.Text);
            txt.Write("  -  ");
            txt.Write(ethBox.Text);
            txt.Write("  -  ");
            txt.Write(charBox.Text);
            txt.Close();

            new Inventory().Show();
            this.Hide();
        }

        private void addButt4_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("E:\\Room 4.txt");
            txt.Write(nameBox.Text);
            txt.Write("  -  ");
            txt.Write(ethBox.Text);
            txt.Write("  -  ");
            txt.Write(charBox.Text);
            txt.Close();

            new Inventory().Show();
            this.Hide();
        }

        private void addButt5_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("E:\\Room 5.txt");
            txt.Write(nameBox.Text);
            txt.Write("  -  ");
            txt.Write(ethBox.Text);
            txt.Write("  -  ");
            txt.Write(charBox.Text);
            txt.Close();

            new Inventory().Show();
            this.Hide();
        }
    }
}
