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
            Placa = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            dtEntrada = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Placa
            // 
            Placa.AutoSize = true;
            Placa.Location = new Point(12, 34);
            Placa.Name = "Placa";
            Placa.Size = new Size(81, 15);
            Placa.TabIndex = 1;
            Placa.Text = "Placa Entrada:";
            Placa.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, HoraEntrada, dtEntrada });
            dataGridView1.Location = new Point(487, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(467, 381);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Placa";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            HoraEntrada.HeaderText = "Hora Entrada";
            HoraEntrada.Name = "HoraEntrada";
            HoraEntrada.ReadOnly = true;
            // 
            // dtEntrada
            // 
            dtEntrada.HeaderText = "Data de Entrada";
            dtEntrada.Name = "dtEntrada";
            dtEntrada.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(264, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(623, 34);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(160, 29);
            label1.TabIndex = 5;
            label1.Text = "Hora e data";
            // 
            // button2
            // 
            button2.Location = new Point(264, 189);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Saída";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Placa Saída:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Carro", "Moto", "Outro" });
            listBox1.Location = new Point(99, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(143, 49);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 488);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Placa);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Estacionamento do LIPERETOOO";
            Load += onLoadForm;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Placa;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn dtEntrada;
        private ListBox listBox1;
    }
}