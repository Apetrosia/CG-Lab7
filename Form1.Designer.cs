namespace CG_Lab
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reflectionComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.projectionListBox = new System.Windows.Forms.ComboBox();
            this.axisXNumeric = new System.Windows.Forms.NumericUpDown();
            this.axisYNumeric = new System.Windows.Forms.NumericUpDown();
            this.axisZNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.affineOpButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.labelScale = new System.Windows.Forms.Label();
            this.numericScale = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDownDivisions = new System.Windows.Forms.NumericUpDown();
            this.DrawRevolveFigure = new System.Windows.Forms.Button();
            this.comboBoxAxis = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericX0 = new System.Windows.Forms.NumericUpDown();
            this.numericX1 = new System.Windows.Forms.NumericUpDown();
            this.numericY1 = new System.Windows.Forms.NumericUpDown();
            this.numericY0 = new System.Windows.Forms.NumericUpDown();
            this.stepNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisXNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisZNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Отобразить куб",
            "Отобразить тетраэдр",
            "Отобразить октаэдр",
            "Отобразить икосаэдр",
            "Отобразить додекаэдр",
            "Отобразить x*x+y*y",
            "Отобразить sin(x) + cos(y)",
            "Отобразить sin(x) * cos(y)",
            "Отобразить 5*(cos(r)/r+0.1)"});
            this.comboBox1.Location = new System.Drawing.Point(1092, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Отобразить куб";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reflectionComboBox
            // 
            this.reflectionComboBox.FormattingEnabled = true;
            this.reflectionComboBox.Location = new System.Drawing.Point(1085, 181);
            this.reflectionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.reflectionComboBox.Name = "reflectionComboBox";
            this.reflectionComboBox.Size = new System.Drawing.Size(277, 24);
            this.reflectionComboBox.TabIndex = 0;
            this.reflectionComboBox.SelectedIndexChanged += new System.EventHandler(this.reflectionComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 737);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(1101, 418);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(1191, 418);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(1277, 418);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown3.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Смещение",
            "Масштабирование",
            "Поворот",
            "Поворот вокруг прямой",
            "Вращение параллельно OX",
            "Вращение параллельно OY",
            "Вращение параллельно OZ"});
            this.comboBox2.Location = new System.Drawing.Point(1079, 341);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "Смещение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1175, 473);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Опорная точка";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(1067, 503);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown4.TabIndex = 9;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(1200, 503);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown5.TabIndex = 8;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Location = new System.Drawing.Point(1328, 503);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(76, 22);
            this.numericUpDown6.TabIndex = 7;
            // 
            // projectionListBox
            // 
            this.projectionListBox.FormattingEnabled = true;
            this.projectionListBox.Items.AddRange(new object[] {
            "Перспективная",
            "Ортографическая",
            "Аксонометрическая"});
            this.projectionListBox.Location = new System.Drawing.Point(1020, 727);
            this.projectionListBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.projectionListBox.Name = "projectionListBox";
            this.projectionListBox.Size = new System.Drawing.Size(249, 24);
            this.projectionListBox.TabIndex = 12;
            this.projectionListBox.Text = "Перспективная";
            this.projectionListBox.SelectedIndexChanged += new System.EventHandler(this.projectionListBox_SelectedIndexChanged);
            // 
            // axisXNumeric
            // 
            this.axisXNumeric.DecimalPlaces = 2;
            this.axisXNumeric.Location = new System.Drawing.Point(1030, 787);
            this.axisXNumeric.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.axisXNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.axisXNumeric.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.axisXNumeric.Name = "axisXNumeric";
            this.axisXNumeric.Size = new System.Drawing.Size(80, 22);
            this.axisXNumeric.TabIndex = 15;
            this.axisXNumeric.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.axisXNumeric.ValueChanged += new System.EventHandler(this.axisXNumeric_ValueChanged);
            // 
            // axisYNumeric
            // 
            this.axisYNumeric.DecimalPlaces = 2;
            this.axisYNumeric.Location = new System.Drawing.Point(1165, 787);
            this.axisYNumeric.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.axisYNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.axisYNumeric.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.axisYNumeric.Name = "axisYNumeric";
            this.axisYNumeric.Size = new System.Drawing.Size(79, 22);
            this.axisYNumeric.TabIndex = 14;
            this.axisYNumeric.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.axisYNumeric.ValueChanged += new System.EventHandler(this.axisYNumeric_ValueChanged);
            // 
            // axisZNumeric
            // 
            this.axisZNumeric.DecimalPlaces = 2;
            this.axisZNumeric.Location = new System.Drawing.Point(1294, 787);
            this.axisZNumeric.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.axisZNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.axisZNumeric.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.axisZNumeric.Name = "axisZNumeric";
            this.axisZNumeric.ReadOnly = true;
            this.axisZNumeric.Size = new System.Drawing.Size(76, 22);
            this.axisZNumeric.TabIndex = 13;
            this.axisZNumeric.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1046, 757);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ось X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1177, 757);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ось Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1303, 757);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ось Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1202, 705);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Проекция";
            // 
            // affineOpButton
            // 
            this.affineOpButton.Location = new System.Drawing.Point(1161, 372);
            this.affineOpButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.affineOpButton.Name = "affineOpButton";
            this.affineOpButton.Size = new System.Drawing.Size(131, 27);
            this.affineOpButton.TabIndex = 20;
            this.affineOpButton.Text = "Применить";
            this.affineOpButton.UseVisualStyleBackColor = true;
            this.affineOpButton.Click += new System.EventHandler(this.affineOpButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1025, 506);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1025, 566);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "2";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.DecimalPlaces = 2;
            this.numericUpDown10.Location = new System.Drawing.Point(1328, 564);
            this.numericUpDown10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown10.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown10.TabIndex = 24;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.DecimalPlaces = 2;
            this.numericUpDown11.Location = new System.Drawing.Point(1200, 564);
            this.numericUpDown11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown11.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown11.TabIndex = 23;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.DecimalPlaces = 2;
            this.numericUpDown12.Location = new System.Drawing.Point(1067, 564);
            this.numericUpDown12.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown12.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(76, 22);
            this.numericUpDown12.TabIndex = 22;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(1081, 208);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(273, 16);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Масштабирования относительно центра";
            // 
            // numericScale
            // 
            this.numericScale.DecimalPlaces = 1;
            this.numericScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericScale.Location = new System.Drawing.Point(1193, 238);
            this.numericScale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericScale.Name = "numericScale";
            this.numericScale.Size = new System.Drawing.Size(95, 22);
            this.numericScale.TabIndex = 3;
            this.numericScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericScale.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1183, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Центр фигуры:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1101, 308);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1192, 308);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(77, 22);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1273, 308);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(77, 22);
            this.textBox3.TabIndex = 29;
            // 
            // numericUpDownDivisions
            // 
            this.numericUpDownDivisions.Location = new System.Drawing.Point(1179, 665);
            this.numericUpDownDivisions.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDivisions.Name = "numericUpDownDivisions";
            this.numericUpDownDivisions.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownDivisions.TabIndex = 31;
            this.numericUpDownDivisions.ValueChanged += new System.EventHandler(this.numericUpDownDivisions_ValueChanged);
            // 
            // DrawRevolveFigure
            // 
            this.DrawRevolveFigure.Location = new System.Drawing.Point(1349, 635);
            this.DrawRevolveFigure.Margin = new System.Windows.Forms.Padding(4);
            this.DrawRevolveFigure.Name = "DrawRevolveFigure";
            this.DrawRevolveFigure.Size = new System.Drawing.Size(89, 132);
            this.DrawRevolveFigure.TabIndex = 32;
            this.DrawRevolveFigure.Text = "Создать фигуру вращения";
            this.DrawRevolveFigure.UseVisualStyleBackColor = true;
            this.DrawRevolveFigure.Click += new System.EventHandler(this.DrawRevolveFigure_Click);
            // 
            // comboBoxAxis
            // 
            this.comboBoxAxis.FormattingEnabled = true;
            this.comboBoxAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.comboBoxAxis.Location = new System.Drawing.Point(1005, 665);
            this.comboBoxAxis.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAxis.Name = "comboBoxAxis";
            this.comboBoxAxis.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAxis.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1048, 596);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(1003, 642);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 19);
            this.label12.TabIndex = 35;
            this.label12.Text = "Задать ось";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(1176, 642);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 36;
            this.label13.Text = "Разбиения";
            // 
            // numericX0
            // 
            this.numericX0.DecimalPlaces = 2;
            this.numericX0.Location = new System.Drawing.Point(1105, 68);
            this.numericX0.Margin = new System.Windows.Forms.Padding(4);
            this.numericX0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericX0.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericX0.Name = "numericX0";
            this.numericX0.Size = new System.Drawing.Size(65, 22);
            this.numericX0.TabIndex = 30;
            this.numericX0.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numericX1
            // 
            this.numericX1.DecimalPlaces = 2;
            this.numericX1.Location = new System.Drawing.Point(1179, 68);
            this.numericX1.Margin = new System.Windows.Forms.Padding(4);
            this.numericX1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericX1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericX1.Name = "numericX1";
            this.numericX1.Size = new System.Drawing.Size(68, 22);
            this.numericX1.TabIndex = 31;
            this.numericX1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericY1
            // 
            this.numericY1.DecimalPlaces = 2;
            this.numericY1.Location = new System.Drawing.Point(1179, 128);
            this.numericY1.Margin = new System.Windows.Forms.Padding(4);
            this.numericY1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericY1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericY1.Name = "numericY1";
            this.numericY1.Size = new System.Drawing.Size(68, 22);
            this.numericY1.TabIndex = 33;
            this.numericY1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericY0
            // 
            this.numericY0.DecimalPlaces = 2;
            this.numericY0.Location = new System.Drawing.Point(1105, 128);
            this.numericY0.Margin = new System.Windows.Forms.Padding(4);
            this.numericY0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericY0.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericY0.Name = "numericY0";
            this.numericY0.Size = new System.Drawing.Size(65, 22);
            this.numericY0.TabIndex = 32;
            this.numericY0.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // stepNumeric
            // 
            this.stepNumeric.DecimalPlaces = 2;
            this.stepNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.stepNumeric.Location = new System.Drawing.Point(1287, 100);
            this.stepNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.stepNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.stepNumeric.Name = "stepNumeric";
            this.stepNumeric.Size = new System.Drawing.Size(63, 22);
            this.stepNumeric.TabIndex = 34;
            this.stepNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1259, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Шаг разбиения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1081, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1081, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 766);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 64);
            this.button1.TabIndex = 38;
            this.button1.Text = "Сохранить модель в файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "obj";
            this.saveFileDialog1.Filter = "OBJ Files (*.obj)|*.obj";
            this.saveFileDialog1.Title = "Сохранить модель как .obj";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "obj";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "OBJ Files (*.obj)|*.obj";
            this.openFileDialog1.Title = "Открыть модель .obj";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 766);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 64);
            this.button2.TabIndex = 39;
            this.button2.Text = "Загрузить модель из файла";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxAxis);
            this.Controls.Add(this.DrawRevolveFigure);
            this.Controls.Add(this.numericUpDownDivisions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stepNumeric);
            this.Controls.Add(this.numericY1);
            this.Controls.Add(this.numericY0);
            this.Controls.Add(this.numericX1);
            this.Controls.Add(this.numericX0);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown10);
            this.Controls.Add(this.numericUpDown11);
            this.Controls.Add(this.numericUpDown12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.affineOpButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.axisXNumeric);
            this.Controls.Add(this.axisYNumeric);
            this.Controls.Add(this.axisZNumeric);
            this.Controls.Add(this.projectionListBox);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericScale);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.reflectionComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisXNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisZNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox reflectionComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.ComboBox projectionListBox;
        private System.Windows.Forms.NumericUpDown axisXNumeric;
        private System.Windows.Forms.NumericUpDown axisYNumeric;
        private System.Windows.Forms.NumericUpDown axisZNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button affineOpButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.NumericUpDown numericScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownDivisions;
        private System.Windows.Forms.Button DrawRevolveFigure;
        private System.Windows.Forms.ComboBox comboBoxAxis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericX0;
        private System.Windows.Forms.NumericUpDown numericX1;
        private System.Windows.Forms.NumericUpDown numericY1;
        private System.Windows.Forms.NumericUpDown numericY0;
        private System.Windows.Forms.NumericUpDown stepNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

