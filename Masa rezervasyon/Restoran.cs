namespace Masa_rezervasyon
{
    public partial class Restoran : Form
    {
        public Restoran()
        {
            InitializeComponent();
        }

        private void res1_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
