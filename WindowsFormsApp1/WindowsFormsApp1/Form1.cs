using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        void Listele()
        {
            List_Sehirler.Items.Clear();
            for (int i = 0; i < sehirler.Count; i++)
            {
                List_Sehirler.Items.Add(i + " - " + sehirler[i]);
            }
        }


        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            sehirler.Add(Txt_SehirEkle.Text);
            Lbl_Eklendi.Text = "Şehir Eklendi";
            Listele();
        }

        private void Btn_ArayaEkle_Click(object sender, EventArgs e)
        {
            sehirler.Insert(List_Sehirler.SelectedIndex, Txt_SehirEkle.Text);
            Listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            sehirler[List_Sehirler.SelectedIndex] = Txt_SehirEkle.Text;
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            sehirler.Remove(Txt_SehirEkle.Text);
            Listele();
        }

        private void Btn_İndexSil_Click(object sender, EventArgs e)
        {
            sehirler.RemoveAt(List_Sehirler.SelectedIndex);
            Listele();
        }

        private void Btn_Arama_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(Txt_SehirEkle.Text))
            {
                Lbl_Eklendi.Text = "aranan şehir " + Txt_SehirEkle.Text + " var";
            }
            else
            {
                Lbl_Eklendi.Text = "aranan şehir " + Txt_SehirEkle.Text + " yok";
            }
        }
    }
}
