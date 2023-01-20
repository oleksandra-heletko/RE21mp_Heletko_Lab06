namespace Heletko_Lab06
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sFileLabel = new System.Windows.Forms.Label();
            this.oFileLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xorImageList = new System.Windows.Forms.ImageList(this.components);
            this.keyGenImageList = new System.Windows.Forms.ImageList(this.components);
            this.eLabel = new System.Windows.Forms.Label();
            this.aLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kExtendRadioButton = new System.Windows.Forms.RadioButton();
            this.kRNGRadioButton = new System.Windows.Forms.RadioButton();
            this.kLengthComboBox = new System.Windows.Forms.ComboBox();
            this.kLengthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.keyFilePage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oKeyFileBtn = new System.Windows.Forms.Button();
            this.oKeyPathBox = new System.Windows.Forms.TextBox();
            this.keyHEXPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eHEXCheckBox = new System.Windows.Forms.CheckBox();
            this.kHEXTextBox = new System.Windows.Forms.TextBox();
            this.passPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.vPassCheckBox = new System.Windows.Forms.CheckBox();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.keyXORPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.oFileButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.sFileButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.keyFilePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.keyHEXPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.passPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.keyXORPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // sFileLabel
            // 
            this.sFileLabel.AutoSize = true;
            this.sFileLabel.ForeColor = System.Drawing.Color.Red;
            this.sFileLabel.Location = new System.Drawing.Point(325, 48);
            this.sFileLabel.Name = "sFileLabel";
            this.sFileLabel.Size = new System.Drawing.Size(39, 13);
            this.sFileLabel.TabIndex = 15;
            this.sFileLabel.Text = "(нема)";
            // 
            // oFileLabel
            // 
            this.oFileLabel.AutoSize = true;
            this.oFileLabel.ForeColor = System.Drawing.Color.Red;
            this.oFileLabel.Location = new System.Drawing.Point(11, 48);
            this.oFileLabel.Name = "oFileLabel";
            this.oFileLabel.Size = new System.Drawing.Size(39, 13);
            this.oFileLabel.TabIndex = 13;
            this.oFileLabel.Text = "(нема)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Зберегти:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Довжина ключа (байти):";
            // 
            // xorImageList
            // 
            this.xorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("xorImageList.ImageStream")));
            this.xorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.xorImageList.Images.SetKeyName(0, "xor_1.png");
            this.xorImageList.Images.SetKeyName(1, "xor_2.png");
            // 
            // keyGenImageList
            // 
            this.keyGenImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("keyGenImageList.ImageStream")));
            this.keyGenImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.keyGenImageList.Images.SetKeyName(0, "key_s1.png");
            this.keyGenImageList.Images.SetKeyName(1, "key_s2.png");
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.ForeColor = System.Drawing.Color.Red;
            this.eLabel.Location = new System.Drawing.Point(132, 48);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(39, 13);
            this.eLabel.TabIndex = 14;
            this.eLabel.Text = "(нема)";
            // 
            // aLinkLabel
            // 
            this.aLinkLabel.AutoSize = true;
            this.aLinkLabel.Location = new System.Drawing.Point(419, 9);
            this.aLinkLabel.Name = "aLinkLabel";
            this.aLinkLabel.Size = new System.Drawing.Size(37, 13);
            this.aLinkLabel.TabIndex = 11;
            this.aLinkLabel.TabStop = true;
            this.aLinkLabel.Text = "Автор";
            this.aLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aLinkLabel_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kExtendRadioButton);
            this.groupBox2.Controls.Add(this.kRNGRadioButton);
            this.groupBox2.Controls.Add(this.kLengthComboBox);
            this.groupBox2.Controls.Add(this.kLengthLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // kExtendRadioButton
            // 
            this.kExtendRadioButton.AutoSize = true;
            this.kExtendRadioButton.Location = new System.Drawing.Point(215, 48);
            this.kExtendRadioButton.Name = "kExtendRadioButton";
            this.kExtendRadioButton.Size = new System.Drawing.Size(229, 17);
            this.kExtendRadioButton.TabIndex = 8;
            this.kExtendRadioButton.TabStop = true;
            this.kExtendRadioButton.Text = "Ключ генерується розширенням пароля";
            this.kExtendRadioButton.UseVisualStyleBackColor = true;
            this.kExtendRadioButton.CheckedChanged += new System.EventHandler(this.kExtendRadioButton_CheckedChanged);
            // 
            // kRNGRadioButton
            // 
            this.kRNGRadioButton.AutoSize = true;
            this.kRNGRadioButton.Location = new System.Drawing.Point(215, 14);
            this.kRNGRadioButton.Name = "kRNGRadioButton";
            this.kRNGRadioButton.Size = new System.Drawing.Size(140, 17);
            this.kRNGRadioButton.TabIndex = 7;
            this.kRNGRadioButton.TabStop = true;
            this.kRNGRadioButton.Text = "Ключ з генератора ПП";
            this.kRNGRadioButton.UseVisualStyleBackColor = true;
            this.kRNGRadioButton.CheckedChanged += new System.EventHandler(this.kRNGRadioButton_CheckedChanged);
            // 
            // kLengthComboBox
            // 
            this.kLengthComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.kLengthComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kLengthComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kLengthComboBox.FormattingEnabled = true;
            this.kLengthComboBox.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.kLengthComboBox.Location = new System.Drawing.Point(134, 13);
            this.kLengthComboBox.Name = "kLengthComboBox";
            this.kLengthComboBox.Size = new System.Drawing.Size(65, 21);
            this.kLengthComboBox.TabIndex = 6;
            this.kLengthComboBox.TextChanged += new System.EventHandler(this.kLengthComboBox_TextChanged);
            this.kLengthComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kLengthComboBox_KeyPress);
            // 
            // kLengthLabel
            // 
            this.kLengthLabel.AutoSize = true;
            this.kLengthLabel.Location = new System.Drawing.Point(133, 50);
            this.kLengthLabel.Name = "kLengthLabel";
            this.kLengthLabel.Size = new System.Drawing.Size(13, 13);
            this.kLengthLabel.TabIndex = 5;
            this.kLengthLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Довжина ключа (бітіи):";
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateKeyButton.ImageIndex = 0;
            this.generateKeyButton.ImageList = this.keyGenImageList;
            this.generateKeyButton.Location = new System.Drawing.Point(23, 211);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(143, 33);
            this.generateKeyButton.TabIndex = 7;
            this.generateKeyButton.Text = "Згенерувати ключ";
            this.generateKeyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(399, 221);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.totalTimeLabel.TabIndex = 9;
            this.totalTimeLabel.Text = "00:00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тривалість (хв. : с.):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Кодування:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.keyFilePage);
            this.tabControl1.Controls.Add(this.keyHEXPage);
            this.tabControl1.Controls.Add(this.passPage);
            this.tabControl1.Controls.Add(this.keyXORPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 113);
            this.tabControl1.TabIndex = 6;
            // 
            // keyFilePage
            // 
            this.keyFilePage.BackColor = System.Drawing.SystemColors.Control;
            this.keyFilePage.Controls.Add(this.groupBox1);
            this.keyFilePage.Location = new System.Drawing.Point(4, 22);
            this.keyFilePage.Name = "keyFilePage";
            this.keyFilePage.Padding = new System.Windows.Forms.Padding(3);
            this.keyFilePage.Size = new System.Drawing.Size(464, 87);
            this.keyFilePage.TabIndex = 0;
            this.keyFilePage.Text = "Файл з ключем";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oKeyFileBtn);
            this.groupBox1.Controls.Add(this.oKeyPathBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шлях до файлу";
            // 
            // oKeyFileBtn
            // 
            this.oKeyFileBtn.Location = new System.Drawing.Point(404, 29);
            this.oKeyFileBtn.Name = "oKeyFileBtn";
            this.oKeyFileBtn.Size = new System.Drawing.Size(44, 23);
            this.oKeyFileBtn.TabIndex = 1;
            this.oKeyFileBtn.Text = "...";
            this.oKeyFileBtn.UseVisualStyleBackColor = true;
            this.oKeyFileBtn.Click += new System.EventHandler(this.oKeyFileBtn_Click);
            // 
            // oKeyPathBox
            // 
            this.oKeyPathBox.Location = new System.Drawing.Point(6, 31);
            this.oKeyPathBox.Name = "oKeyPathBox";
            this.oKeyPathBox.Size = new System.Drawing.Size(392, 20);
            this.oKeyPathBox.TabIndex = 0;
            // 
            // keyHEXPage
            // 
            this.keyHEXPage.BackColor = System.Drawing.SystemColors.Control;
            this.keyHEXPage.Controls.Add(this.groupBox3);
            this.keyHEXPage.Location = new System.Drawing.Point(4, 22);
            this.keyHEXPage.Name = "keyHEXPage";
            this.keyHEXPage.Padding = new System.Windows.Forms.Padding(3);
            this.keyHEXPage.Size = new System.Drawing.Size(464, 87);
            this.keyHEXPage.TabIndex = 1;
            this.keyHEXPage.Text = "Ключ у HEX форматі";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.eHEXCheckBox);
            this.groupBox3.Controls.Add(this.kHEXTextBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 72);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключ (HEX)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Heletko_Lab06.Properties.Resources.hand;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(384, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 47);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // eHEXCheckBox
            // 
            this.eHEXCheckBox.AutoSize = true;
            this.eHEXCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eHEXCheckBox.Location = new System.Drawing.Point(368, 34);
            this.eHEXCheckBox.Name = "eHEXCheckBox";
            this.eHEXCheckBox.Size = new System.Drawing.Size(15, 14);
            this.eHEXCheckBox.TabIndex = 2;
            this.eHEXCheckBox.UseVisualStyleBackColor = true;
            this.eHEXCheckBox.CheckedChanged += new System.EventHandler(this.eHEXCheckBox_CheckedChanged);
            // 
            // kHEXTextBox
            // 
            this.kHEXTextBox.Location = new System.Drawing.Point(6, 31);
            this.kHEXTextBox.Name = "kHEXTextBox";
            this.kHEXTextBox.ReadOnly = true;
            this.kHEXTextBox.Size = new System.Drawing.Size(356, 20);
            this.kHEXTextBox.TabIndex = 0;
            this.kHEXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kHEXTextBox_KeyPress);
            // 
            // passPage
            // 
            this.passPage.BackColor = System.Drawing.SystemColors.Control;
            this.passPage.Controls.Add(this.label2);
            this.passPage.Controls.Add(this.vPassCheckBox);
            this.passPage.Controls.Add(this.pTextBox);
            this.passPage.Controls.Add(this.pictureBox2);
            this.passPage.Location = new System.Drawing.Point(4, 22);
            this.passPage.Name = "passPage";
            this.passPage.Size = new System.Drawing.Size(464, 87);
            this.passPage.TabIndex = 2;
            this.passPage.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш пароль:";
            // 
            // vPassCheckBox
            // 
            this.vPassCheckBox.AutoSize = true;
            this.vPassCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vPassCheckBox.Location = new System.Drawing.Point(374, 35);
            this.vPassCheckBox.Name = "vPassCheckBox";
            this.vPassCheckBox.Size = new System.Drawing.Size(15, 14);
            this.vPassCheckBox.TabIndex = 4;
            this.vPassCheckBox.UseVisualStyleBackColor = true;
            this.vPassCheckBox.CheckedChanged += new System.EventHandler(this.vPassCheckBox_CheckedChanged);
            // 
            // pTextBox
            // 
            this.pTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.pTextBox.Location = new System.Drawing.Point(81, 32);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.PasswordChar = '*';
            this.pTextBox.Size = new System.Drawing.Size(287, 20);
            this.pTextBox.TabIndex = 1;
            this.pTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Heletko_Lab06.Properties.Resources.eyes;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(391, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 47);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // keyXORPage
            // 
            this.keyXORPage.BackColor = System.Drawing.SystemColors.Control;
            this.keyXORPage.Controls.Add(this.sFileLabel);
            this.keyXORPage.Controls.Add(this.eLabel);
            this.keyXORPage.Controls.Add(this.oFileLabel);
            this.keyXORPage.Controls.Add(this.label11);
            this.keyXORPage.Controls.Add(this.label10);
            this.keyXORPage.Controls.Add(this.label9);
            this.keyXORPage.Controls.Add(this.label8);
            this.keyXORPage.Controls.Add(this.label7);
            this.keyXORPage.Controls.Add(this.label6);
            this.keyXORPage.Controls.Add(this.oFileButton);
            this.keyXORPage.Controls.Add(this.eButton);
            this.keyXORPage.Controls.Add(this.sFileButton);
            this.keyXORPage.Location = new System.Drawing.Point(4, 22);
            this.keyXORPage.Name = "keyXORPage";
            this.keyXORPage.Size = new System.Drawing.Size(464, 87);
            this.keyXORPage.TabIndex = 3;
            this.keyXORPage.Text = "Кодування XOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Відкрити:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(320, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "3.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(124, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "2.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "1.";
            // 
            // oFileButton
            // 
            this.oFileButton.BackgroundImage = global::Heletko_Lab06.Properties.Resources.Folder_Heart_icon;
            this.oFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oFileButton.Location = new System.Drawing.Point(64, 11);
            this.oFileButton.Name = "oFileButton";
            this.oFileButton.Size = new System.Drawing.Size(52, 55);
            this.oFileButton.TabIndex = 6;
            this.oFileButton.UseVisualStyleBackColor = true;
            this.oFileButton.Click += new System.EventHandler(this.oFileButton_Click);
            // 
            // eButton
            // 
            this.eButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eButton.ImageIndex = 0;
            this.eButton.ImageList = this.xorImageList;
            this.eButton.Location = new System.Drawing.Point(193, 16);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(121, 45);
            this.eButton.TabIndex = 5;
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // sFileButton
            // 
            this.sFileButton.BackgroundImage = global::Heletko_Lab06.Properties.Resources.Download_Folder_icon;
            this.sFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sFileButton.Location = new System.Drawing.Point(379, 11);
            this.sFileButton.Name = "sFileButton";
            this.sFileButton.Size = new System.Drawing.Size(52, 55);
            this.sFileButton.TabIndex = 4;
            this.sFileButton.UseVisualStyleBackColor = true;
            this.sFileButton.Click += new System.EventHandler(this.sFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 255);
            this.Controls.Add(this.aLinkLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generateKeyButton);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Генератор ключів";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.keyFilePage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.keyHEXPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.passPage.ResumeLayout(false);
            this.passPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.keyXORPage.ResumeLayout(false);
            this.keyXORPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sFileLabel;
        private System.Windows.Forms.Label oFileLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList xorImageList;
        private System.Windows.Forms.ImageList keyGenImageList;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.LinkLabel aLinkLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton kExtendRadioButton;
        private System.Windows.Forms.RadioButton kRNGRadioButton;
        private System.Windows.Forms.ComboBox kLengthComboBox;
        private System.Windows.Forms.Label kLengthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage keyFilePage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button oKeyFileBtn;
        private System.Windows.Forms.TextBox oKeyPathBox;
        private System.Windows.Forms.TabPage keyHEXPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox eHEXCheckBox;
        private System.Windows.Forms.TextBox kHEXTextBox;
        private System.Windows.Forms.TabPage passPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox vPassCheckBox;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage keyXORPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button oFileButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button sFileButton;
    }
}

