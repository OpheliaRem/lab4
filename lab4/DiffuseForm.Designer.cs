namespace lab4
{
    partial class DiffuseForm
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
            components = new System.ComponentModel.Container();
            formsPlot = new ScottPlot.WinForms.FormsPlot();
            listBox = new ListBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            textBoxTimeStep = new TextBox();
            textBoxD = new TextBox();
            label7 = new Label();
            buttonCalculate = new Button();
            textBoxAlpha = new TextBox();
            label6 = new Label();
            textBoxWindPhi = new TextBox();
            textBoxWindAbs = new TextBox();
            label5 = new Label();
            label1 = new Label();
            buttonClear = new Button();
            buttonDelete = new Button();
            groupBox2 = new GroupBox();
            buttonAddQ = new Button();
            textBoxQ = new TextBox();
            label4 = new Label();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            label3 = new Label();
            label2 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot
            // 
            formsPlot.DisplayScale = 1F;
            formsPlot.Location = new Point(12, 12);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(521, 452);
            formsPlot.TabIndex = 0;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(287, 22);
            listBox.Name = "listBox";
            listBox.Size = new Size(133, 199);
            listBox.TabIndex = 1;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxTimeStep);
            groupBox1.Controls.Add(textBoxD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(buttonCalculate);
            groupBox1.Controls.Add(textBoxAlpha);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxWindPhi);
            groupBox1.Controls.Add(textBoxWindAbs);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(listBox);
            groupBox1.Location = new Point(539, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры системы";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 397);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 22;
            label8.Text = "Шаг по времени";
            // 
            // textBoxTimeStep
            // 
            textBoxTimeStep.Location = new Point(26, 415);
            textBoxTimeStep.Name = "textBoxTimeStep";
            textBoxTimeStep.Size = new Size(151, 23);
            textBoxTimeStep.TabIndex = 21;
            textBoxTimeStep.Text = "100";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(26, 367);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(151, 23);
            textBoxD.TabIndex = 20;
            textBoxD.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 346);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 19;
            label7.Text = "D";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(212, 407);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(216, 37);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Сделать расчёт";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxAlpha
            // 
            textBoxAlpha.Location = new Point(26, 311);
            textBoxAlpha.Name = "textBoxAlpha";
            textBoxAlpha.Size = new Size(151, 23);
            textBoxAlpha.TabIndex = 18;
            textBoxAlpha.Text = "0,000001";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 293);
            label6.Name = "label6";
            label6.Size = new Size(162, 15);
            label6.TabIndex = 17;
            label6.Text = "Параметр вымывания alpha";
            // 
            // textBoxWindPhi
            // 
            textBoxWindPhi.Location = new Point(26, 250);
            textBoxWindPhi.Name = "textBoxWindPhi";
            textBoxWindPhi.Size = new Size(151, 23);
            textBoxWindPhi.TabIndex = 16;
            textBoxWindPhi.Text = "45";
            // 
            // textBoxWindAbs
            // 
            textBoxWindAbs.Location = new Point(26, 192);
            textBoxWindAbs.Name = "textBoxWindAbs";
            textBoxWindAbs.Size = new Size(151, 23);
            textBoxWindAbs.TabIndex = 15;
            textBoxWindAbs.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 232);
            label5.Name = "label5";
            label5.Size = new Size(169, 15);
            label5.TabIndex = 14;
            label5.Text = "Угол наклона скорости ветра";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 174);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 13;
            label1.Text = "Модуль скорости ветра";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.DarkRed;
            buttonClear.ForeColor = SystemColors.Control;
            buttonClear.Location = new Point(287, 256);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(133, 23);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Очистить список";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(287, 227);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(133, 23);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Удалить элемент";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAddQ);
            groupBox2.Controls.Add(textBoxQ);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxY);
            groupBox2.Controls.Add(textBoxX);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(26, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 136);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задать точку Q";
            // 
            // buttonAddQ
            // 
            buttonAddQ.Location = new Point(7, 105);
            buttonAddQ.Name = "buttonAddQ";
            buttonAddQ.Size = new Size(104, 23);
            buttonAddQ.TabIndex = 9;
            buttonAddQ.Text = "Добавить точку";
            buttonAddQ.UseVisualStyleBackColor = true;
            buttonAddQ.Click += buttonAddQ_Click;
            // 
            // textBoxQ
            // 
            textBoxQ.Location = new Point(26, 76);
            textBoxQ.Name = "textBoxQ";
            textBoxQ.Size = new Size(142, 23);
            textBoxQ.TabIndex = 8;
            textBoxQ.Text = "100000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 79);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 7;
            label4.Text = "Q";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(26, 49);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(142, 23);
            textBoxY.TabIndex = 6;
            textBoxY.Text = "50";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(26, 22);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(142, 23);
            textBoxX.TabIndex = 5;
            textBoxX.Text = "50";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 49);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 4;
            label3.Text = "y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 25);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 3;
            label2.Text = "x";
            // 
            // timer
            // 
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // DiffuseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 476);
            Controls.Add(groupBox1);
            Controls.Add(formsPlot);
            Name = "DiffuseForm";
            Text = "Перенос примесей";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot;
        private ListBox listBox;
        private GroupBox groupBox1;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Label label3;
        private Label label2;
        private TextBox textBoxQ;
        private Label label4;
        private Button buttonAddQ;
        private GroupBox groupBox2;
        private Button buttonClear;
        private Button buttonDelete;
        private Label label1;
        private Label label5;
        private TextBox textBoxWindAbs;
        private TextBox textBoxWindPhi;
        private Label label6;
        private TextBox textBoxAlpha;
        private Button buttonCalculate;
        private TextBox textBoxD;
        private Label label7;
        private System.Windows.Forms.Timer timer;
        private TextBox textBoxTimeStep;
        private Label label8;
    }
}
