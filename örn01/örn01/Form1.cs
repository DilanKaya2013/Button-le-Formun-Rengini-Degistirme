using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örn01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKırmızı_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MessageBox.Show("Formun Rengi Kırmızı Olarak Ayarlandı");
        }

        private void btnMor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkViolet;
            MessageBox.Show("Formun Rengi Mor Olarak Ayarlandı");

        }
    }
}
