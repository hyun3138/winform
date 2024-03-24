using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class payment : Form
    {
        private int receivedValue;
        private int price;
        
        public payment(int receivedValue)
        {
            InitializeComponent();
            this.receivedValue = receivedValue;
            label1.Text = receivedValue.ToString();
            price = receivedValue;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price = receivedValue / (int)numericUpDown1.Value;
            Console.WriteLine(price.ToString());
            label1.Text = price.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(price.ToString() + " 결제하시겠습니까?",
            "삼성페이",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                StartForm startForm = new StartForm();
                startForm.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(price.ToString() + " 결제하시겠습니까?",
            "카카오페이",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                StartForm startForm = new StartForm();
                startForm.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(price.ToString() + " 결제하시겠습니까?",
            "신용카드",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                StartForm startForm = new StartForm();
                startForm.ShowDialog();
                this.Close();
            }
        }
    }
}
