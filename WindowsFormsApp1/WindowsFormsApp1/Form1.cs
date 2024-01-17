using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'table_1DataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.table_1DataSet.Table_1);
            // TODO: This line of code loads data into the 'demo1DataSet.name1' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table1BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                table1BindingSource.EndEdit();
                table_1TableAdapter.Update(table_1DataSet.Table_1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveLast();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            table1BindingSource.MovePrevious();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveNext();

        }
    }
}
