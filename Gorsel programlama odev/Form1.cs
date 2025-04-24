using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel_programlama_odev
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir = txtIlAdi.Text.Trim();
            if (!string.IsNullOrEmpty(sehir))
            {
                lstSehirler.Items.Add(sehir);
                txtIlAdi.Clear();
            }
        }

        private void btnSaga_Click(object sender, EventArgs e)
        {
            if (lstSehirler.SelectedItem != null)
            {
                var secilen = lstSehirler.SelectedItem;
                lstSecilenler.Items.Add(secilen);
                lstSehirler.Items.Remove(secilen);
            }
        }

        private void btnSola_Click(object sender, EventArgs e)
        {
            if (lstSecilenler.SelectedItem != null)
            {
                var secilen = lstSecilenler.SelectedItem;
                lstSehirler.Items.Add(secilen);
                lstSecilenler.Items.Remove(secilen);
            }

        }
    }
}
