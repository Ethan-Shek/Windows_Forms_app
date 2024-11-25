using System.Xml.Linq;

namespace Windows_Forms_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !IstName.Items.Contains(txtName.Text))
                IstName.Items.Add(txtName.Text);
        }
    }
}
