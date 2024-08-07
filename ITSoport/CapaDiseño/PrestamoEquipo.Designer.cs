namespace ITSoport.CapaDiseño
{
    partial class PrestamoEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamoEquipo));
            label1 = new Label();
            btnCerrar = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 58);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 0;
            label1.Text = "Prestamo de Equipo";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(652, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 22);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 9;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 110);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese el codigo del equipo";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(383, 110);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escriba una breve descripcion del equipo";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 249);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle del Equipo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(345, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 249);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle prestamo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(306, 210);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 122, 204);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(553, 50);
            button2.Name = "button2";
            button2.Size = new Size(110, 36);
            button2.TabIndex = 14;
            button2.Text = "Imprimir";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 15;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 113);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 16;
            label3.Text = "Descripcion del Equipo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(144, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(168, 23);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(144, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(144, 155);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(168, 23);
            textBox7.TabIndex = 4;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(144, 184);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(168, 23);
            textBox8.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 42);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 17;
            label4.Text = "Docente/Empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 71);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 18;
            label5.Text = "Area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 100);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 19;
            label6.Text = "Codigo del Equipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 129);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 20;
            label7.Text = "Hora de entrega";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 158);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 21;
            label8.Text = "Fecha de entrega";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 187);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 22;
            label9.Text = "Prestado por";
            // 
            // PrestamoEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 439);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(222, 49);
            Name = "PrestamoEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrestamoEquipo";
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox btnCerrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label4;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}