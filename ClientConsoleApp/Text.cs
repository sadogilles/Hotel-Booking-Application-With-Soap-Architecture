using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientConsoleApp
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Text_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("First Name", typeof(String));
            table.Columns.Add("Last Name", typeof(String));
            table.Columns.Add("Age", typeof(int));

            table.Rows.Add(1,"First A","First B",10);
            table.Rows.Add(1, "First A", "First B", 10);
            table.Rows.Add(1, "First A", "First B", 10);
            table.Rows.Add(1, "First A", "First B", 10);
            table.Rows.Add(1, "First A", "First B", 10);
            table.Rows.Add(1, "First A", "First B", 10);

            dataGridView1.DataSource = table;
        }
    }
}
