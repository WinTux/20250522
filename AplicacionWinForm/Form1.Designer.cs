﻿namespace AplicacionWinForm
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            lblResultado = new Label();
            button4 = new Button();
            txtNumB = new TextBox();
            txtNumA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button5 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            txtContenidoCargado = new TextBox();
            button7 = new Button();
            groupBox2 = new GroupBox();
            lblMensajes = new Label();
            button6 = new Button();
            txtContenido = new TextBox();
            button8 = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Hola mundo Bv";
            // 
            // button1
            // 
            button1.Location = new Point(47, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Saludar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clicBtnSaludar;
            // 
            // button2
            // 
            button2.Location = new Point(150, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Despedirse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clicBtnDespedirse;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 120);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(49, 160);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Agregar A";
            button3.UseVisualStyleBackColor = true;
            button3.Click += clicBtnAgregar;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtNumB);
            groupBox1.Controls.Add(txtNumA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(30, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 350);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(38, 132);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // button4
            // 
            button4.Location = new Point(275, 44);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "SUMAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtNumB
            // 
            txtNumB.Location = new Point(120, 86);
            txtNumB.Name = "txtNumB";
            txtNumB.Size = new Size(100, 23);
            txtNumB.TabIndex = 1;
            // 
            // txtNumA
            // 
            txtNumA.Location = new Point(120, 44);
            txtNumA.Name = "txtNumA";
            txtNumA.Size = new Size(100, 23);
            txtNumA.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 89);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Número B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 47);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Número A";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(459, 18);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(471, 625);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(463, 597);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PepeMatic";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 272);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 5;
            label7.Text = "LISTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 308);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 4;
            label6.Text = "Salida:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 23);
            textBox2.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(365, 272);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Ejecutar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 200);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 21);
            label5.Name = "label5";
            label5.Size = new Size(163, 15);
            label5.TabIndex = 0;
            label5.Text = "Ingrese su programa (código)";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(463, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gráficos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(46, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 196);
            panel1.TabIndex = 0;
            panel1.Paint += dibujando_panel1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(463, 597);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Archivos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtContenidoCargado);
            groupBox3.Controls.Add(button7);
            groupBox3.Location = new Point(35, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 249);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lectura de archivos";
            // 
            // txtContenidoCargado
            // 
            txtContenidoCargado.Location = new Point(24, 79);
            txtContenidoCargado.Multiline = true;
            txtContenidoCargado.Name = "txtContenidoCargado";
            txtContenidoCargado.Size = new Size(354, 154);
            txtContenidoCargado.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(24, 39);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 0;
            button7.Text = "Cargar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(lblMensajes);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(txtContenido);
            groupBox2.Location = new Point(25, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 241);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Escritura de archivos";
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Location = new Point(21, 95);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(48, 15);
            lblMensajes.TabIndex = 2;
            lblMensajes.Text = "Estado: ";
            // 
            // button6
            // 
            button6.Location = new Point(313, 64);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 1;
            button6.Text = "Crear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(21, 35);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(367, 23);
            txtContenido.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(23, 139);
            button8.Name = "button8";
            button8.Size = new Size(177, 23);
            button8.TabIndex = 3;
            button8.Text = "Crear archivo objeto";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(959, 675);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Super Aplicación 3000XD & Nukkles";
            KeyDown += teclaAbajo;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private GroupBox groupBox1;
        private Label lblResultado;
        private Button button4;
        private TextBox txtNumB;
        private TextBox txtNumA;
        private Label label4;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button5;
        private TextBox textBox1;
        private Label label5;
        private TabPage tabPage3;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button button6;
        private TextBox txtContenido;
        private Label lblMensajes;
        private GroupBox groupBox3;
        private TextBox txtContenidoCargado;
        private Button button7;
        private Button button8;
    }
}
