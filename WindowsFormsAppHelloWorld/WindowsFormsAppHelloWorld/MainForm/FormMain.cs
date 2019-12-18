using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.DataBinding;
using WindowsFormsApp.Hexagone;
using WindowsFormsApp.TestPackages;

namespace WindowsFormsApp.MainForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Show calculator form
        private void button_calculator_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        // Show data binding personne form
        private void button_data_personne_Click(object sender, EventArgs e)
        {
            DataGridForm dataGridForm = new DataGridForm();
            dataGridForm.Show();
        }

        // Show hexagone form
        private void button_hexagone_Click(object sender, EventArgs e)
        {
            HexagoneForm hexagoneForm = new HexagoneForm();
            hexagoneForm.Show();
        }

        // Show QRCoder form
        private void button_qrcoder_Click(object sender, EventArgs e)
        {
            QRCoderForm qRCoderForm = new QRCoderForm();
            qRCoderForm.Show();
        }
    }
}
