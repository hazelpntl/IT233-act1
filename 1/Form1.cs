using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if (lastname.Text == "" || firstname.Text == "" || middlename.Text == "" )
            {
                MessageBox.Show("Please Fill-Out all needed Student Information");
            }
            else 
            {
                if (listBox1.Items.Contains(lastname.Text + ", " + firstname.Text + "  " + middlename.Text))
                {
                    MessageBox.Show("Student is already in the list", "Student Record Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    listBox1.Items.Add(lastname.Text + ", " + firstname.Text + "  " + middlename.Text);
                }
            }

        }
    }
        
}
