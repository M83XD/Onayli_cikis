using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Selam!", "Warning!", MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                label2.Text = "EVET butonuna bastınız.";
            } else if (sonuc == DialogResult.No)
            {
                label2.Text = "HAYIR butonuna bastınız.";
            } else
            {
                label2.Text = "İPTAL butonuna bastınız.";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Program Kapatılsın mı?", "Uyarı!", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                label2.Text = "Program çalışıyo aga";
            }
        }
    }
}
