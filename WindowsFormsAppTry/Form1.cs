using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int vize = int.Parse(txt_vize.Text);
            int final = int.Parse(txt_final.Text);

            int sonuc = (vize + final) / 2;

            MessageBox.Show($"not ortalamanız {sonuc}");
        }
    }
}
