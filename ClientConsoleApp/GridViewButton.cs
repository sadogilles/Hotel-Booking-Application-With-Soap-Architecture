using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClientConsoleApp
{
    public partial class GridViewButton : Form
    {
        public GridViewButton()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
                MessageBox.Show((e.RowIndex + 1).ToString() + "Row Clicked");
               
            }
        }

        private void GridViewButton_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "First column";
            dataGridView1.Columns[1].Name = "Second Column";
            dataGridView1.Columns[2].Name = "Third colunn";

            ArrayList row= new ArrayList();
            row.Add("1");
            row.Add("2");
            row.Add("3");

            dataGridView1.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("2");
            row.Add("3");

            dataGridView1.Rows.Add(row.ToArray());

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //    btn.HeaderText("Buttons");
            btn.Name = "Fourth Column";
            btn.Text = "click me";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


        }
    }
}
