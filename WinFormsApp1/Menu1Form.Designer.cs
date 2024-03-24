namespace WinFormsApp1
{
    partial class Menu1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            set = new Button();
            single = new Button();
            dessert = new Button();
            drink = new Button();
            set1 = new PictureBox();
            set3 = new PictureBox();
            set4 = new PictureBox();
            set2 = new PictureBox();
            menu1 = new Label();
            price1 = new Label();
            menu2 = new Label();
            price2 = new Label();
            menu3 = new Label();
            price3 = new Label();
            menu4 = new Label();
            price4 = new Label();
            richTextBox1 = new RichTextBox();
            totalprice = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)set1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)set3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)set4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)set2).BeginInit();
            SuspendLayout();
            // 
            // set
            // 
            set.Location = new Point(-1, -1);
            set.Name = "set";
            set.Size = new Size(225, 66);
            set.TabIndex = 0;
            set.Text = "세트메뉴";
            set.UseVisualStyleBackColor = true;
            set.Click += set_Click;
            // 
            // single
            // 
            single.Location = new Point(218, -1);
            single.Name = "single";
            single.Size = new Size(225, 66);
            single.TabIndex = 1;
            single.Text = "햄버거";
            single.UseVisualStyleBackColor = true;
            single.Click += single_Click;
            // 
            // dessert
            // 
            dessert.Location = new Point(441, -1);
            dessert.Name = "dessert";
            dessert.Size = new Size(237, 66);
            dessert.TabIndex = 2;
            dessert.Text = "디저트";
            dessert.UseVisualStyleBackColor = true;
            dessert.Click += dessert_Click;
            // 
            // drink
            // 
            drink.Location = new Point(669, -1);
            drink.Name = "drink";
            drink.Size = new Size(215, 66);
            drink.TabIndex = 3;
            drink.Text = "음료";
            drink.UseVisualStyleBackColor = true;
            drink.Click += drink_Click;
            // 
            // set1
            // 
            set1.Location = new Point(42, 97);
            set1.Name = "set1";
            set1.Size = new Size(323, 189);
            set1.SizeMode = PictureBoxSizeMode.StretchImage;
            set1.TabIndex = 4;
            set1.TabStop = false;
            set1.Click += set1_Click;
            // 
            // set3
            // 
            set3.Location = new Point(42, 344);
            set3.Name = "set3";
            set3.Size = new Size(323, 189);
            set3.SizeMode = PictureBoxSizeMode.StretchImage;
            set3.TabIndex = 5;
            set3.TabStop = false;
            set3.Click += set3_Click;
            // 
            // set4
            // 
            set4.Location = new Point(494, 342);
            set4.Name = "set4";
            set4.Size = new Size(323, 189);
            set4.SizeMode = PictureBoxSizeMode.StretchImage;
            set4.TabIndex = 6;
            set4.TabStop = false;
            set4.Click += set4_Click;
            // 
            // set2
            // 
            set2.Location = new Point(494, 97);
            set2.Name = "set2";
            set2.Size = new Size(323, 189);
            set2.SizeMode = PictureBoxSizeMode.StretchImage;
            set2.TabIndex = 7;
            set2.TabStop = false;
            set2.Click += set2_Click;
            // 
            // menu1
            // 
            menu1.AutoSize = true;
            menu1.Location = new Point(151, 79);
            menu1.Name = "menu1";
            menu1.Size = new Size(99, 15);
            menu1.TabIndex = 8;
            menu1.Text = "불고기 버거 세트";
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Location = new Point(175, 289);
            price1.Name = "price1";
            price1.Size = new Size(35, 15);
            price1.TabIndex = 9;
            price1.Text = "5300";
            // 
            // menu2
            // 
            menu2.AutoSize = true;
            menu2.Location = new Point(613, 79);
            menu2.Name = "menu2";
            menu2.Size = new Size(87, 15);
            menu2.TabIndex = 10;
            menu2.Text = "치즈 버거 세트";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(639, 289);
            price2.Name = "price2";
            price2.Size = new Size(35, 15);
            price2.TabIndex = 11;
            price2.Text = "7000";
            // 
            // menu3
            // 
            menu3.AutoSize = true;
            menu3.Location = new Point(151, 326);
            menu3.Name = "menu3";
            menu3.Size = new Size(87, 15);
            menu3.TabIndex = 12;
            menu3.Text = "새우 버거 세트";
            // 
            // price3
            // 
            price3.AutoSize = true;
            price3.Location = new Point(175, 536);
            price3.Name = "price3";
            price3.Size = new Size(35, 15);
            price3.TabIndex = 13;
            price3.Text = "9700";
            // 
            // menu4
            // 
            menu4.AutoSize = true;
            menu4.Location = new Point(613, 324);
            menu4.Name = "menu4";
            menu4.Size = new Size(87, 15);
            menu4.TabIndex = 14;
            menu4.Text = "치킨 버거 세트";
            // 
            // price4
            // 
            price4.AutoSize = true;
            price4.Location = new Point(639, 536);
            price4.Name = "price4";
            price4.Size = new Size(35, 15);
            price4.TabIndex = 15;
            price4.Text = "5200";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ActiveCaption;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(42, 587);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(775, 138);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // totalprice
            // 
            totalprice.BackColor = SystemColors.ActiveCaption;
            totalprice.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalprice.Location = new Point(564, 587);
            totalprice.Name = "totalprice";
            totalprice.Size = new Size(235, 57);
            totalprice.TabIndex = 18;
            totalprice.Text = "원";
            totalprice.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(386, 654);
            button1.Name = "button1";
            button1.Size = new Size(172, 63);
            button1.TabIndex = 20;
            button1.Text = "장바구니";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(613, 654);
            button2.Name = "button2";
            button2.Size = new Size(172, 63);
            button2.TabIndex = 21;
            button2.Text = "결제하기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(367, 590);
            label1.Name = "label1";
            label1.Size = new Size(191, 50);
            label1.TabIndex = 22;
            label1.Text = "주문금액 :";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ActiveCaption;
            listView1.Location = new Point(51, 590);
            listView1.Name = "listView1";
            listView1.Size = new Size(253, 127);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Menu1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(884, 761);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(totalprice);
            Controls.Add(richTextBox1);
            Controls.Add(price4);
            Controls.Add(menu4);
            Controls.Add(price3);
            Controls.Add(menu3);
            Controls.Add(price2);
            Controls.Add(menu2);
            Controls.Add(price1);
            Controls.Add(menu1);
            Controls.Add(set2);
            Controls.Add(set4);
            Controls.Add(set3);
            Controls.Add(set1);
            Controls.Add(drink);
            Controls.Add(dessert);
            Controls.Add(single);
            Controls.Add(set);
            Name = "Menu1Form";
            Text = "Menu1Form";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)set1).EndInit();
            ((System.ComponentModel.ISupportInitialize)set3).EndInit();
            ((System.ComponentModel.ISupportInitialize)set4).EndInit();
            ((System.ComponentModel.ISupportInitialize)set2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button set;
        private Button single;
        private Button dessert;
        private Button drink;
        private PictureBox set1;
        private PictureBox set3;
        private PictureBox set4;
        private PictureBox set2;
        private Label menu1;
        private Label price1;
        private Label menu2;
        private Label price2;
        private Label menu3;
        private Label price3;
        private Label menu4;
        private Label price4;
        private RichTextBox richTextBox1;
        private TextBox totalprice;
        private Button button1;
        private Button button2;
        private Label label1;
        private ListView listView1;
    }
}