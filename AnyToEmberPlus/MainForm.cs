namespace AnyToEmberPlus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btRemove.Enabled = false;
            btEdit.Enabled = false;
            btStart.Enabled = false;
            btStart.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDataProviders.SelectedIndex != -1)
            {
                btRemove.Enabled = true;
                btEdit.Enabled = true;
                btStart.Enabled = true;
                if (((Provider)listBoxDataProviders.SelectedItem).state)
                {
                    btStart.Text = "Stop";
                }
                else
                {
                    btStart.Text = "Start";
                }
            }
            else
            {
                btRemove.Enabled = false;
                btEdit.Enabled = false;
                btStart.Enabled = false;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var window = new AddProvider();
            window.ShowDialog();
            refreshView();
        }

        public void refreshView()
        {
            listBoxDataProviders.Items.Clear();
            listBoxDataProviders.Items.AddRange(Program.Providers.ToArray());
            listBoxDataProviders.Refresh();
        }
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listBoxDataProviders.SelectedItem != null)
            {
                Provider selected = (Provider)listBoxDataProviders.SelectedItem;
                listBoxDataProviders.Items.Remove(selected);
                selected.Dispose();
                refreshView();

            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (listBoxDataProviders.SelectedItem != null)
            {
                Provider selected = (Provider)listBoxDataProviders.SelectedItem;
                listBoxDataProviders.Items.Remove(selected);
                if (selected.state)
                {
                    selected.Stop();
                }
                else
                {
                    selected.Run();
                }
                refreshView();

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (listBoxDataProviders.SelectedItem != null)
            {
                Provider selected = (Provider)listBoxDataProviders.SelectedItem;
                new EditProvider(selected).ShowDialog();
            }
        }

        private void refresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxDataProviders.Refresh();
        }
    }
}
