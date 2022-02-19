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

namespace web
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "09-121")
            {
                foreach (var line in File.ReadLines(@"c:\users\kseni\source\repos\web\TextFile1.txt", Encoding.Default))
                {
                    var array = line.Split();
                    dataGridView1.Rows.Add(array);
                }
            }

            if (e.Node.Text == "09-122")
            {
                foreach (var line in File.ReadLines(@"c:\users\kseni\source\repos\web\TextFile2.txt", Encoding.Default))
                {
                    var array = line.Split();
                    dataGridView1.Rows.Add(array);
                }
            }
        }
            

        private void pictureBox1_SizeModeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.textBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f3.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f3.textBox3.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f3.ShowDialog();
        }
    }
}
