namespace _01
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            deserializar = new Button();
            serializarJSON = new Button();
            deserializarJSON = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(184, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Serializar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(184, 102);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Deserializar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 197);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 226);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 7;
            label2.Text = "Ano lançamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 255);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Preço";
            // 
            // button3
            // 
            button3.Location = new Point(318, 194);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 9;
            button3.Text = "Serializar XML";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // deserializar
            // 
            deserializar.Location = new Point(318, 255);
            deserializar.Name = "deserializar";
            deserializar.Size = new Size(108, 23);
            deserializar.TabIndex = 10;
            deserializar.Text = "Deserializar XML";
            deserializar.UseVisualStyleBackColor = true;
            deserializar.Click += button4_Click;
            // 
            // serializarJSON
            // 
            serializarJSON.Location = new Point(475, 194);
            serializarJSON.Name = "serializarJSON";
            serializarJSON.Size = new Size(111, 23);
            serializarJSON.TabIndex = 11;
            serializarJSON.Text = "Serializar JSON";
            serializarJSON.UseVisualStyleBackColor = true;
            serializarJSON.Click += serializarJSON_Click;
            // 
            // deserializarJSON
            // 
            deserializarJSON.Location = new Point(475, 255);
            deserializarJSON.Name = "deserializarJSON";
            deserializarJSON.Size = new Size(111, 23);
            deserializarJSON.TabIndex = 12;
            deserializarJSON.Text = "Deserializar JSON";
            deserializarJSON.UseVisualStyleBackColor = true;
            deserializarJSON.Click += deserializarJSON_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 305);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 342);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 375);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(deserializarJSON);
            Controls.Add(serializarJSON);
            Controls.Add(deserializar);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button deserializar;
        private Button serializarJSON;
        private Button deserializarJSON;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}