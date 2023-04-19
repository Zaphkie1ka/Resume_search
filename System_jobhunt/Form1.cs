using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_jobhunt
{
    public partial class Form1 : Form
    {
        private AppDatabase _database;
        public Form1()
        {
            InitializeComponent();

            _database = new AppDatabase();
            _database.Initialize();
            dataGridView1.DataSource = _database.Resumes.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _database.Resumes.Where(k => k.HumanName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = _database.Resumes.Where(k => k.Job == Job.Engineer).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = _database.Resumes.Where(k => k.Job == Job.Teacher).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = _database.Resumes.Where(k => k.Job == Job.Lawyer).ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = _database.Resumes.Where(k => k.Job == Job.Driver).ToList();
                    break;
                case 4:
                    dataGridView1.DataSource = _database.Resumes.Where(k => k.Job == Job.Doctor).ToList();
                    break;
                case 5:
                    dataGridView1.DataSource = _database.Resumes.Where(k => k.Job == Job.Architect).ToList();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = _database.Resumes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _database.Resumes.Where(k => k.Mark > 5).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _database.Resumes.Where(k => k.Mark < 5).ToList();
        }
    }
}
