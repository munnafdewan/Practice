using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practiceday4
{
    public partial class New : Form
    {
        List<string> names = new List<string> {"Munnaf"};
        List<int> ages = new List<int> { 15 };
        public New()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            names.Add(nameTextBox.Text);
            ages.Add(Convert.ToInt32(ageTextBox.Text));
            ShowCustomer();
            MessageBox.Show("Add");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private void ShowCustomer()
        {

            string message = " ";

            for (int i = 0; i < names.Count(); i++)
            {
                message += "Name : " + names[i] + "Age :" + ages[i] + "\n";

            }
            showRichTextBox.Text = message;
            //string message = "";

            //foreach (string name in names)
            //{
            //    message += "Name : " + name + "\n";
            //}
            //showRichTextBox.Text = message;
        }

        private void New_Load(object sender, EventArgs e)
        {

        }
    }
}
