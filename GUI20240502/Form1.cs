using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI20240502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_orszag_Click(object sender, EventArgs e)
        {
            string adat = dataGridView_adatmegjelenites.SelectedRows[0].Cells[1].Value.ToString();
            string sqlParancs = "SELECT city FROM buildings WHERE building_name ='" + adat + "';";
            MySqlCommand sqlCommand = new MySqlCommand(sqlParancs, dbConnection);
            string varos = sqlCommand.ExecuteScalar().ToString();
            label1.Text = "Orszag: " + varos;
        }

        private void button_osszemelet_Click(object sender, EventArgs e)
        {
            string adat = dataGridView_adatmegjelenites.SelectedRows[0].Cells[2].Value.ToString();
            string sqlParancs = "SELECT COUNT(building_name) FROM buildings WHERE height_m >400 ;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlParancs, dbConnection);
            string varos = sqlCommand.ExecuteScalar().ToString();
            label2.Text = "A 400 m-nél magasabb épületek száma: " + varos;
        }
    }
}
