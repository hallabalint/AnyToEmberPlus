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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDataProviders.SelectedIndex != -1)
            {
                btRemove.Enabled = true;
                btEdit.Enabled = true;
                btStart.Enabled = true;
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
    }
}
