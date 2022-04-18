using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataGridView
{
    public partial class Form1 : Form
    {
        string[] data = new string[] {
        "101",
        "102",
        "103",
        "104",
        "105",
        "106",
        "107",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(data);

            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows.Add(data[i]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (textBox1.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[1].Value = DateTime.Now.ToString("HH : mm : ss");
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (textBox1.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[2].Value = DateTime.Now.ToString("HH : mm : ss");
                    }
                }
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[2].Cells[1].Value = "Test";
            //MessageBox.Show(dataGridView1.Rows[2].Cells[2].Value.ToString());
        }
    }
}
