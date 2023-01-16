using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mile_Stone_Inventory_Moving_List
{
    public partial class TheList : Form
    {
        public TheList()
        {
            InitializeComponent();

            string content1 = File.ReadAllText("E:\\Room 1.txt");
            detLab1.Text = ("Room 1: " + content1);

            string content2 = File.ReadAllText("E:\\Room 2.txt");
            detLab2.Text = ("Room 2: " + content2);

            string content3 = File.ReadAllText("E:\\Room 3.txt");
            detLab3.Text = ("Room 3: " + content3);

            string content4 = File.ReadAllText("E:\\Room 4.txt");
            detLab4.Text = ("Room 4: " + content4);

            string content5 = File.ReadAllText("E:\\Room 5.txt");
            detLab5.Text = ("Room 5: " + content5);
        }

        private void retButt3_Click(object sender, EventArgs e)
        {
            new Inventory().Show();
            this.Hide();
        }
    }
}
