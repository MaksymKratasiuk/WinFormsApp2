﻿namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox_message = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(147, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "години :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 121);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "повідомлення :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox_message
            // 
            textBox_message.Location = new Point(129, 114);
            textBox_message.Name = "textBox_message";
            textBox_message.Size = new Size(125, 27);
            textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 43);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "хвилини :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 76);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "секунди :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(372, 268);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_message);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox_message;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}