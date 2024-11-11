using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyToEmberPlus
{
    public partial class AddProvider : Form
    {
        public AddProvider()
        {
            InitializeComponent();
            comboBox1.DataSource = Program.LoadedTypes;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
           Program.AddModule((Type)comboBox1.SelectedValue, tbName.Text, tbNodeName.Text);
            this.Close();
        }
    }
}
