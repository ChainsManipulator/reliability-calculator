namespace NewDifferencials
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(681, 443);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Вычисленные характеристики";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(390, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Среднее время восстановления системы: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 437);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Момент времени";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Коэффициент функциональной готовности";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "N6";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Погрешность";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.zedGraphControl2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(681, 443);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Графики";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(675, 437);
            this.zedGraphControl2.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Входные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(515, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "Очистить графики";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 395);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Location = new System.Drawing.Point(10, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 185);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прочие параметры";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Тип модели";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Первая модель",
            "Вторая модель",
            "Третья модель"});
            this.comboBox1.Location = new System.Drawing.Point(10, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Первая модель";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Размер шага: 0.01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Число отсчётов";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 140);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 22);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "2500";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Рассчитываемый период";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 90);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 22);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "25";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(10, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 175);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Интенсивности переходов";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "μ 2";
            this.label11.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(10, 140);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(213, 22);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "1";
            this.textBox9.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "μ 4";
            this.label12.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(450, 140);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(194, 22);
            this.textBox10.TabIndex = 14;
            this.textBox10.Text = "1";
            this.textBox10.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "μ 3";
            this.label13.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(240, 140);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(194, 22);
            this.textBox11.TabIndex = 12;
            this.textBox11.Text = "1";
            this.textBox11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Число шагов восстановления";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(10, 90);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(213, 22);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "ν";
            this.label4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(450, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "1";
            this.textBox4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "ξ";
            this.label5.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(240, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(194, 22);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "1";
            this.textBox5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "μ i";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(450, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "λ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "μ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Произвести вычисления";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 472);
            this.tabControl1.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 472);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Рассчёт надёжности НКС";
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

