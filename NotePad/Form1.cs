using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Note_Pad_Form : Form
    {
        DataTable table;
        public Note_Pad_Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            dataGridView.DataSource = table;

            dataGridView.Columns["Message"].Visible = false;
            dataGridView.Columns["Title"].Width = 236; 

        }

        private void New_button_Click(object sender, EventArgs e)
        {
            Title_textBox.Clear();
            Message_textBox.Clear();
            Title_textBox.Focus();

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView.DataSource;
            DataRow drToAdd = dataTable.NewRow();
            drToAdd["Title"] = Title_textBox.Text;
            drToAdd["Message"] = Message_textBox.Text;

            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();
            Title_textBox.Clear();
            Message_textBox.Clear();

        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            if (index > -1)
            {
                Title_textBox.Text = table.Rows[index].ItemArray[0].ToString();
                Message_textBox.Text = table.Rows[index].ItemArray[1].ToString();


            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
