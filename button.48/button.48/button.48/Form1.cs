using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciList = new List<Ogrenci>();

            ogrenciList.Add(new Ogrenci(34, "Büsra Ekmen", "10A", "05872374940"));
            ogrenciList.Add(new Ogrenci(33, "Meryem Akbahar", "10A", "05877374840"));
            ogrenciList.Add(new Ogrenci(32, "Ayda Ersoy", "10E", "05872375640"));
            ogrenciList.Add(new Ogrenci(31, "Elmas BOM", "10E", "05872764090"));

            dataGridView1.DataSource = ogrenciList.ToList();

        }
    }
}
