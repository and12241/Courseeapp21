namespace Courseeapp21
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonAdmin = new Button();
            pnlNav = new FlowLayoutPanel();
            buttonExit = new Button();
            buttonGraf = new Button();
            buttonMain = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            labelHead = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            label14 = new Label();
            textBoxCabinet = new TextBox();
            labelCabinet = new Label();
            labelFlur = new Label();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            labelDay = new Label();
            labelTime = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            button1 = new Button();
            buttonPrepareInfo = new Button();
            panel3 = new Panel();
            label1 = new Label();
            button3 = new Button();
            textFindTime = new Label();
            textBoxTime = new TextBox();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(buttonAdmin);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonGraf);
            panel1.Controls.Add(buttonMain);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 934);
            panel1.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(24, 30, 54);
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdmin.ForeColor = Color.FromArgb(0, 126, 249);
            buttonAdmin.Image = Properties.Resources.icons8_буклет_со_спиралью_32;
            buttonAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdmin.Location = new Point(3, 240);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(186, 42);
            buttonAdmin.TabIndex = 5;
            buttonAdmin.Text = "Для лікарів";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(24, 30, 54);
            buttonExit.Dock = DockStyle.Bottom;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.FromArgb(0, 126, 249);
            buttonExit.Image = Properties.Resources.icons8_выход_30;
            buttonExit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExit.Location = new Point(0, 892);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(186, 42);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonGraf
            // 
            buttonGraf.BackColor = Color.FromArgb(24, 30, 54);
            buttonGraf.FlatAppearance.BorderSize = 0;
            buttonGraf.FlatStyle = FlatStyle.Flat;
            buttonGraf.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGraf.ForeColor = Color.FromArgb(0, 126, 249);
            buttonGraf.Image = Properties.Resources.icons8_буклет_со_спиралью_32;
            buttonGraf.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGraf.Location = new Point(0, 192);
            buttonGraf.Name = "buttonGraf";
            buttonGraf.Size = new Size(186, 42);
            buttonGraf.TabIndex = 2;
            buttonGraf.Text = "Графік";
            buttonGraf.UseVisualStyleBackColor = false;
            buttonGraf.Click += buttonGraf_Click;
            // 
            // buttonMain
            // 
            buttonMain.BackColor = Color.FromArgb(24, 30, 54);
            buttonMain.Dock = DockStyle.Top;
            buttonMain.FlatAppearance.BorderSize = 0;
            buttonMain.FlatStyle = FlatStyle.Flat;
            buttonMain.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMain.ForeColor = Color.FromArgb(0, 126, 249);
            buttonMain.Image = Properties.Resources.icons8_главная_30;
            buttonMain.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMain.Location = new Point(0, 144);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(186, 42);
            buttonMain.TabIndex = 1;
            buttonMain.Text = "Головна";
            buttonMain.UseVisualStyleBackColor = false;
            buttonMain.Click += buttonMain_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelHead
            // 
            labelHead.Font = new Font("Nirmala UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelHead.ForeColor = Color.DimGray;
            labelHead.Location = new Point(203, 18);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(218, 57);
            labelHead.TabIndex = 1;
            labelHead.Text = "Головна";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1030, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 36);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Лікарі";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(226, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(756, 681);
            dataGridView1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1087, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(266, 36);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "День тиждня";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Image = Properties.Resources.icons8_буклет_со_спиралью_32;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(627, 634);
            button2.Name = "button2";
            button2.Size = new Size(323, 90);
            button2.TabIndex = 6;
            button2.Text = "Вхід";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(627, 576);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 31);
            textBox1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 126, 249);
            label10.Location = new Point(627, 536);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 8;
            label10.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(627, 497);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 31);
            textBox2.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 126, 249);
            label12.Location = new Point(627, 457);
            label12.Name = "label12";
            label12.Size = new Size(64, 28);
            label12.TabIndex = 10;
            label12.Text = "Login";
            // 
            // label13
            // 
            label13.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 126, 249);
            label13.Location = new Point(627, 349);
            label13.Name = "label13";
            label13.Size = new Size(323, 79);
            label13.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(24, 30, 54);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.FromArgb(0, 126, 249);
            buttonAdd.Image = Properties.Resources.icons8_буклет_со_спиралью_32;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(1030, 634);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(323, 90);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(1030, 497);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(323, 31);
            textBoxName.TabIndex = 13;
            // 
            // label14
            // 
            label14.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 126, 249);
            label14.Location = new Point(1030, 456);
            label14.Name = "label14";
            label14.Size = new Size(145, 38);
            label14.TabIndex = 14;
            label14.Text = "Ім`я лікаря";
            // 
            // textBoxCabinet
            // 
            textBoxCabinet.Location = new Point(1030, 397);
            textBoxCabinet.Name = "textBoxCabinet";
            textBoxCabinet.Size = new Size(323, 31);
            textBoxCabinet.TabIndex = 15;
            // 
            // labelCabinet
            // 
            labelCabinet.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCabinet.ForeColor = Color.FromArgb(0, 126, 249);
            labelCabinet.Location = new Point(1030, 349);
            labelCabinet.Name = "labelCabinet";
            labelCabinet.Size = new Size(145, 38);
            labelCabinet.TabIndex = 16;
            labelCabinet.Text = "Кабінет №";
            // 
            // labelFlur
            // 
            labelFlur.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFlur.ForeColor = Color.FromArgb(0, 126, 249);
            labelFlur.Location = new Point(627, 349);
            labelFlur.Name = "labelFlur";
            labelFlur.Size = new Size(265, 38);
            labelFlur.TabIndex = 17;
            labelFlur.Text = "Кабінет Флюраграфіії";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(627, 397);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 31);
            textBox3.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(626, 497);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(324, 36);
            comboBox3.TabIndex = 19;
            comboBox3.Text = "День тиждня";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDay.ForeColor = Color.FromArgb(0, 126, 249);
            labelDay.Location = new Point(627, 457);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(151, 28);
            labelDay.TabIndex = 20;
            labelDay.Text = "День тиждня";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = Color.FromArgb(0, 126, 249);
            labelTime.Location = new Point(626, 545);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(137, 28);
            labelTime.TabIndex = 21;
            labelTime.Text = "Час работы";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(626, 576);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(191, 36);
            comboBox4.TabIndex = 22;
            comboBox4.Text = "Початок работы";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(814, 576);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(191, 36);
            comboBox5.TabIndex = 23;
            comboBox5.Text = "Кінець работи";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1087, 144);
            button1.Name = "button1";
            button1.Size = new Size(266, 42);
            button1.TabIndex = 6;
            button1.Text = "Остані на цьому тиждні";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonPrepareInfo
            // 
            buttonPrepareInfo.BackColor = Color.FromArgb(24, 30, 54);
            buttonPrepareInfo.FlatAppearance.BorderSize = 0;
            buttonPrepareInfo.FlatStyle = FlatStyle.Flat;
            buttonPrepareInfo.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrepareInfo.ForeColor = Color.FromArgb(0, 126, 249);
            buttonPrepareInfo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrepareInfo.Location = new Point(1087, 212);
            buttonPrepareInfo.Name = "buttonPrepareInfo";
            buttonPrepareInfo.Size = new Size(266, 42);
            buttonPrepareInfo.TabIndex = 25;
            buttonPrepareInfo.Text = "Зберегти графік";
            buttonPrepareInfo.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textFindTime);
            panel3.Controls.Add(textBoxTime);
            panel3.Location = new Point(1030, 295);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 190);
            panel3.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 28;
            label1.Text = "Флюраграфія";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(46, 51, 73);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(14, 121);
            button3.Name = "button3";
            button3.Size = new Size(203, 49);
            button3.TabIndex = 27;
            button3.Text = "Пошук";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // textFindTime
            // 
            textFindTime.AutoSize = true;
            textFindTime.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textFindTime.ForeColor = Color.FromArgb(0, 126, 249);
            textFindTime.Location = new Point(14, 50);
            textFindTime.Name = "textFindTime";
            textFindTime.Size = new Size(115, 28);
            textFindTime.TabIndex = 1;
            textFindTime.Text = "Ведіть час";
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.White;
            textBoxTime.Location = new Point(14, 84);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(227, 31);
            textBoxTime.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(24, 30, 54);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(0, 126, 249);
            buttonDelete.Image = Properties.Resources.icons8_буклет_со_спиралью_32;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(701, 634);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(323, 90);
            buttonDelete.TabIndex = 27;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1522, 934);
            Controls.Add(buttonDelete);
            Controls.Add(panel3);
            Controls.Add(buttonPrepareInfo);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(labelTime);
            Controls.Add(labelDay);
            Controls.Add(comboBox3);
            Controls.Add(textBox3);
            Controls.Add(labelFlur);
            Controls.Add(labelCabinet);
            Controls.Add(textBoxCabinet);
            Controls.Add(label14);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(labelHead);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonMain;
        private Button buttonGraf;
        private Button buttonExit;
        private FlowLayoutPanel pnlNav;
        private Label labelHead;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button buttonAdmin;
        private Button button2;
        private Label label10;
        private Label label12;
        private Label label13;
        private Button buttonAdd;
        private TextBox textBoxName;
        private Label label14;
        private TextBox textBoxCabinet;
        private Label labelCabinet;
        private Label labelFlur;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private Label labelDay;
        private Label labelTime;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button buttonPrepareInfo;
        private Panel panel3;
        private TextBox textBoxTime;
        private Label textFindTime;
        private Button button3;
        private Label label1;
        private Button buttonDelete;
    }
}