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
    public partial class EditProvider : Form
    {
        Provider selected;
        public EditProvider(Provider selected)
        {
            this.selected = selected;
            InitializeComponent();
            var kvpList = new List<GridViewElemenet>();
            foreach (var config in selected.Properties)
            {
                kvpList.Add(new GridViewElemenet()
                {
                    Key = config.Key,
                    Value = config.Value
                });
            }
            dgvProperties.DataSource = kvpList;
            dgvProperties.Columns[0].ReadOnly = true;
            dgvProperties.Columns[1].ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var key = row.Cells[0].Value.ToString();
                    var value = row.Cells[1].Value.ToString();
                    selected.Properties[key] = value;
                }


                this.Close();
            }
        }
    }
}
