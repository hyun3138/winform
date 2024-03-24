namespace WinFormsApp1
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            In = new Button();
            takeout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // In
            // 
            In.Location = new Point(190, 317);
            In.Name = "In";
            In.Size = new Size(495, 90);
            In.TabIndex = 1;
            In.Text = "매장식사";
            In.UseVisualStyleBackColor = true;
            In.Click += In_Click;
            // 
            // takeout
            // 
            takeout.Location = new Point(190, 464);
            takeout.Name = "takeout";
            takeout.Size = new Size(495, 90);
            takeout.TabIndex = 2;
            takeout.Text = "포장주문";
            takeout.UseVisualStyleBackColor = true;
            takeout.Click += takeout_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 761);
            Controls.Add(takeout);
            Controls.Add(In);
            Controls.Add(pictureBox1);
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button In;
        private Button takeout;
    }
}