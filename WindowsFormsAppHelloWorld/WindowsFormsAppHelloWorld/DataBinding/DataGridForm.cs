using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.DataBinding
{
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            List<Personne> personnes = new List<Personne>();
            personnes.Add(new Personne("TOTO", "toto", DateTime.Parse("05/08/1987"), 15));
            personnes.Add(new Personne("TATA", "tata", DateTime.Parse("08/05/1998"), 21));
            personnes.Add(new Personne("TUTU", "tutu", DateTime.Parse("05/08/1994"), 18));
            personnes.Add(new Personne("TITI", "titi", DateTime.Parse("15/01/2000"), 5));

            personneBindingSource.DataSource = personnes;
        }
    }
}
