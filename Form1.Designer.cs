﻿namespace CG_Lab
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
            this.comboBox1.Location = new System.Drawing.Point(819, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Отобразить куб";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reflectionComboBox
            // 
            this.reflectionComboBox.FormattingEnabled = true;
            this.reflectionComboBox.Location = new System.Drawing.Point(814, 147);
            this.reflectionComboBox.Name = "reflectionComboBox";
            this.reflectionComboBox.Size = new System.Drawing.Size(209, 21);
            this.reflectionComboBox.TabIndex = 0;
            this.reflectionComboBox.SelectedIndexChanged += new System.EventHandler(this.reflectionComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 599);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(826, 340);
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
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(893, 340);
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
            this.numericUpDown2.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(958, 340);
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
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
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
            this.comboBox2.Location = new System.Drawing.Point(809, 277);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "Смещение";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Опорная точка";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(800, 409);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericUpDown4.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown4.TabIndex = 9;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(900, 409);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericUpDown5.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown5.TabIndex = 8;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Location = new System.Drawing.Point(996, 409);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericUpDown6.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown6.TabIndex = 7;
            // 
            // projectionListBox
            // 
            this.projectionListBox.FormattingEnabled = true;
            this.projectionListBox.Items.AddRange(new object[] {
            "Перспективная",
            "Ортографическая",
            "Аксонометрическая"});
            this.projectionListBox.Location = new System.Drawing.Point(786, 657);
            this.projectionListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectionListBox.Name = "projectionListBox";
            this.projectionListBox.Size = new System.Drawing.Size(188, 21);
            this.projectionListBox.TabIndex = 12;
            this.projectionListBox.Text = "Перспективная";
            this.projectionListBox.SelectedIndexChanged += new System.EventHandler(this.projectionListBox_SelectedIndexChanged);
            // 
            // axisXNumeric
            // 
            this.axisXNumeric.DecimalPlaces = 2;
            this.axisXNumeric.Location = new System.Drawing.Point(786, 725);
            this.axisXNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.axisXNumeric.Size = new System.Drawing.Size(60, 20);
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
            this.axisYNumeric.Location = new System.Drawing.Point(887, 725);
            this.axisYNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.axisYNumeric.Size = new System.Drawing.Size(59, 20);
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
            this.axisZNumeric.Location = new System.Drawing.Point(984, 725);
            this.axisZNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.axisZNumeric.Size = new System.Drawing.Size(57, 20);
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
            this.label2.Location = new System.Drawing.Point(798, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ось X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ось Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(991, 700);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ось Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(883, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Проекция";
            // 
            // affineOpButton
            // 
            this.affineOpButton.Location = new System.Drawing.Point(871, 302);
            this.affineOpButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.affineOpButton.Name = "affineOpButton";
            this.affineOpButton.Size = new System.Drawing.Size(98, 22);
            this.affineOpButton.TabIndex = 20;
            this.affineOpButton.Text = "Применить";
            this.affineOpButton.UseVisualStyleBackColor = true;
            this.affineOpButton.Click += new System.EventHandler(this.affineOpButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 411);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "2";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.DecimalPlaces = 2;
            this.numericUpDown10.Location = new System.Drawing.Point(996, 458);
            this.numericUpDown10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericUpDown10.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown10.TabIndex = 24;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.DecimalPlaces = 2;
            this.numericUpDown11.Location = new System.Drawing.Point(900, 458);
            this.numericUpDown11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericUpDown11.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown11.TabIndex = 23;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.DecimalPlaces = 2;
            this.numericUpDown12.Location = new System.Drawing.Point(800, 458);
            this.numericUpDown12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericUpDown12.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown12.TabIndex = 22;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(811, 169);
            this.labelScale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(212, 13);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Масштабирования относительно центра";
            this.labelScale.Click += new System.EventHandler(this.labelScale_Click);
            // 
            // numericScale
            // 
            this.numericScale.DecimalPlaces = 1;
            this.numericScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericScale.Location = new System.Drawing.Point(895, 193);
            this.numericScale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericScale.Name = "numericScale";
            this.numericScale.Size = new System.Drawing.Size(71, 20);
            this.numericScale.TabIndex = 3;
            this.numericScale.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numericScale.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(887, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Центр фигуры:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(826, 250);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(894, 250);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(59, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(955, 250);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(59, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numericUpDownDivisions
            // 
            this.numericUpDownDivisions.Location = new System.Drawing.Point(794, 603);
            this.numericUpDownDivisions.Name = "numericUpDownDivisions";
            this.numericUpDownDivisions.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDivisions.TabIndex = 31;
            this.numericUpDownDivisions.ValueChanged += new System.EventHandler(this.numericUpDownDivisions_ValueChanged);
            // 
            // DrawRevolveFigure
            // 
            this.DrawRevolveFigure.Location = new System.Drawing.Point(955, 515);
            this.DrawRevolveFigure.Name = "DrawRevolveFigure";
            this.DrawRevolveFigure.Size = new System.Drawing.Size(111, 107);
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
            this.comboBoxAxis.Location = new System.Drawing.Point(800, 548);
            this.comboBoxAxis.Name = "comboBoxAxis";
            this.comboBoxAxis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAxis.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(796, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 34;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(799, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 28);
            this.label12.TabIndex = 35;
            this.label12.Text = "Задать ось";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(798, 579);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Разбиения";
            // 
            // numericX0
            // 
            this.numericX0.DecimalPlaces = 2;
            this.numericX0.Location = new System.Drawing.Point(829, 55);
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
            this.numericX0.Size = new System.Drawing.Size(49, 20);
            this.numericX0.TabIndex = 30;
            this.numericX0.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericX0.ValueChanged += new System.EventHandler(this.numericX0_ValueChanged);
            // 
            // numericX1
            // 
            this.numericX1.DecimalPlaces = 2;
            this.numericX1.Location = new System.Drawing.Point(884, 55);
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
            this.numericX1.Size = new System.Drawing.Size(51, 20);
            this.numericX1.TabIndex = 31;
            this.numericX1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericX1.ValueChanged += new System.EventHandler(this.numericX1_ValueChanged);
            // 
            // numericY1
            // 
            this.numericY1.DecimalPlaces = 2;
            this.numericY1.Location = new System.Drawing.Point(884, 104);
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
            this.numericY1.Size = new System.Drawing.Size(51, 20);
            this.numericY1.TabIndex = 33;
            this.numericY1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericY1.ValueChanged += new System.EventHandler(this.numericY1_ValueChanged);
            // 
            // numericY0
            // 
            this.numericY0.DecimalPlaces = 2;
            this.numericY0.Location = new System.Drawing.Point(829, 104);
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
            this.numericY0.Size = new System.Drawing.Size(49, 20);
            this.numericY0.TabIndex = 32;
            this.numericY0.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericY0.ValueChanged += new System.EventHandler(this.numericY0_ValueChanged);
            // 
            // stepNumeric
            // 
            this.stepNumeric.DecimalPlaces = 2;
            this.stepNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.stepNumeric.Location = new System.Drawing.Point(965, 81);
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
            this.stepNumeric.Size = new System.Drawing.Size(47, 20);
            this.stepNumeric.TabIndex = 34;
            this.stepNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.stepNumeric.ValueChanged += new System.EventHandler(this.stepNumeric_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(944, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Шаг разбиения";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(811, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(811, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Y";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 52);
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
            this.button2.Location = new System.Drawing.Point(322, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 52);
            this.button2.TabIndex = 39;
            this.button2.Text = "Загрузить модель из файла";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 925);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

