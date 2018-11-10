using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTech
{
    public partial class MetinGiris : Form
    {
        public MetinGiris()
        {
            InitializeComponent();
        }

        private void MetinGiris_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void gecBTN_Click(object sender, EventArgs e)
        {
            if ((dakikaTB.Value != 0 || saniyeTB.Value != 0) && metinTB.Text != string.Empty)
            {
                MessageBox.Show("Tamam'a basıp 3 saniyelik geri sayımdan sonra testiniz başlayacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Degisken.yazi = Degisken.boslukTemizle(metinTB.Text.Trim());
                Degisken.dk = int.Parse(dakikaTB.Value.ToString());
                Degisken.sn = int.Parse(saniyeTB.Value.ToString());
                MetinTest metinTest = new MetinTest();
                metinTest.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Veriler Boş Bırakılamaz.");
            }
        }

        private void MetinGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}

