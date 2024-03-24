using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu1Form : Form
    {
        public Menu1Form()
        {
            InitializeComponent();
        }
        int tprice = 0;
        int payprice;
        public void AddPrice(string price)
        {
            if (int.TryParse(price, out int convertedPrice))
            {
                tprice += convertedPrice;
                totalprice.Text = (tprice.ToString() + " 원");
                payprice = tprice;
            }
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            set1.Image = Properties.Resources.set1;
            set2.Image = Properties.Resources.set2;
            set3.Image = Properties.Resources.set3;
            set4.Image = Properties.Resources.set4;



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void set1_Click(object sender, EventArgs e)
        {
            AddPrice(price1.Text);

            ListViewItem item = new ListViewItem(menu1.ToString());
            listView1.Items.Add(menu1.Text);
        }

        private void set2_Click(object sender, EventArgs e)
        {
            AddPrice(price2.Text);
            ListViewItem item = new ListViewItem(menu2.ToString());
            listView1.Items.Add(menu2.Text);
        }

        private void set3_Click(object sender, EventArgs e)
        {
            AddPrice(price3.Text);
            ListViewItem item = new ListViewItem(menu3.ToString());
            listView1.Items.Add(menu3.Text);
        }

        private void set4_Click(object sender, EventArgs e)
        {
            AddPrice(price4.Text);
            ListViewItem item = new ListViewItem(menu4.ToString());
            listView1.Items.Add(menu4.Text);
        }

        private void set_Click(object sender, EventArgs e)
        {
            set1.Image = Properties.Resources.set1;
            set2.Image = Properties.Resources.set2;
            set3.Image = Properties.Resources.set3;
            set4.Image = Properties.Resources.set4;

            menu1.Text = "불고기버거 세트";
            menu2.Text = "치즈버거 세트";
            menu3.Text = "새우버거 세트";
            menu4.Text = "치킨버거 세트";

            price1.Text = "5300";
            price2.Text = "7000";
            price3.Text = "9700";
            price4.Text = "5200";
        }

        private void single_Click(object sender, EventArgs e)
        {
            set1.Image = Properties.Resources.single1;
            set2.Image = Properties.Resources.single2;
            set3.Image = Properties.Resources.single3;
            set4.Image = Properties.Resources.single4;

            menu1.Text = "불고기버거";
            menu2.Text = "치즈버거";
            menu3.Text = "새우버거";
            menu4.Text = "치킨버거";

            price1.Text = "3100";
            price2.Text = "4700";
            price3.Text = "3900";
            price4.Text = "4000";

        }

        private void dessert_Click(object sender, EventArgs e)
        {
            set1.Image = Properties.Resources.dessert1;
            set2.Image = Properties.Resources.dessert2;
            set3.Image = Properties.Resources.dessert3;
            set4.Image = Properties.Resources.dessert4;

            menu1.Text = "아이스크림콘";
            menu2.Text = "초코콘";
            menu3.Text = "애플파이";
            menu4.Text = "아포가토";

            price1.Text = "1100";
            price2.Text = "1000";
            price3.Text = "1300";
            price4.Text = "3500";

        }

        private void drink_Click(object sender, EventArgs e)
        {
            set1.Image = Properties.Resources.drink1;
            set2.Image = Properties.Resources.drink2;
            set3.Image = Properties.Resources.drink3;
            set4.Image = Properties.Resources.drink4;

            menu1.Text = "콜라";
            menu2.Text = "사이다";
            menu3.Text = "제로콜라";
            menu4.Text = "제로사이다";

            price1.Text = "2000";
            price2.Text = "2000";
            price3.Text = "2000";
            price4.Text = "2000";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment payment = new payment(payprice);
            payment.ShowDialog();
            this.Hide();
        }
    }

}
