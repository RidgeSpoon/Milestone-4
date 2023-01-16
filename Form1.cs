namespace Mile_Stone_Inventory_Moving_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButt_Click_1(object sender, EventArgs e)
        {
            if (userNm.Text == "BruceTWayne" && passWd.Text == "JokersJoke343434")
            {
                new Inventory().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password you have entered is incorrect, try again");
                userNm.Clear();
                passWd.Clear();
                userNm.Focus();
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            userNm.Clear();
            passWd.Clear();
            userNm.Focus();
        }
    }
}