using Microsoft.VisualBasic.Logging;
using WinFormsApp1.SOLID;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string secilenOdemeTipi = "";
        IOdeme iOdeme;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOdeme_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);
            OdemeFactory factory = new OdemeFactory();
            iOdeme = factory.yeniNesneOlustur(secilenOdemeTipi);
            OdemeYap odemeYap = new OdemeYap(iOdeme);
            lblSonuc.Text = odemeYap.OdemeIslemiYap(tutar);
        }

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
