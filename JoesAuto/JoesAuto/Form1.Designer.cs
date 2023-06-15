namespace JoesAuto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label15 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(79, 28);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Flushes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 79);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 187);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Misc";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 271);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Labor $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Location = new Point(308, 28);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Oil And Lube";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 45);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 10;
            label6.Text = "Summary:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(598, 195);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(583, 115);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 9;
            label10.Click += label10_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(284, 213);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 12;
            label13.Text = "Parts ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(284, 187);
            label15.Name = "label15";
            label15.Size = new Size(91, 15);
            label15.TabIndex = 14;
            label15.Text = "Parts And Labor";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Silver;
            checkBox1.Location = new Point(284, 73);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Oil Change($26.00)";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Silver;
            checkBox2.Location = new Point(284, 122);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(114, 19);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Lube Job($18.00)";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Silver;
            checkBox3.ForeColor = SystemColors.ActiveCaptionText;
            checkBox3.Location = new Point(48, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(151, 19);
            checkBox3.TabIndex = 19;
            checkBox3.Text = " Radiator's flush($30.00)";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Silver;
            checkBox4.Location = new Point(48, 121);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(157, 19);
            checkBox4.TabIndex = 20;
            checkBox4.Text = "Transmissio flush($80.00)";
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Silver;
            checkBox5.Location = new Point(52, 297);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(125, 19);
            checkBox5.TabIndex = 22;
            checkBox5.Text = " Inspection($15.00)";
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Silver;
            checkBox6.Location = new Point(51, 219);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(159, 19);
            checkBox6.TabIndex = 23;
            checkBox6.Text = "Replace Muffler ($100.00)";
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = Color.Silver;
            checkBox7.Location = new Point(51, 255);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(137, 19);
            checkBox7.TabIndex = 24;
            checkBox7.Text = " Tire Rotation($20.00)";
            checkBox7.UseVisualStyleBackColor = false;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(48, 362);
            button1.Name = "button1";
            button1.Size = new Size(114, 24);
            button1.TabIndex = 25;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 362);
            button2.Name = "button2";
            button2.Size = new Size(91, 24);
            button2.TabIndex = 26;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(561, 361);
            button3.Name = "button3";
            button3.Size = new Size(104, 25);
            button3.TabIndex = 27;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(547, 295);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 31;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(549, 277);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 30;
            label8.Text = "Total Fees";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(548, 239);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 23);
            textBox4.TabIndex = 33;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 213);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 32;
            label7.Text = "Tax On Parts ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(544, 160);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 23);
            textBox5.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(544, 142);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 34;
            label11.Text = "Parts :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(544, 95);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(134, 23);
            textBox6.TabIndex = 37;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(539, 77);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 36;
            label12.Text = "Service And Labor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label12);
            Controls.Add(textBox5);
            Controls.Add(label11);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label15;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
    }
}