namespace formCajero
{
    partial class Form1
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
            System.Windows.Forms.Button ButtonSalir;
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.radioButtonConsulta = new System.Windows.Forms.RadioButton();
            this.radioButtonRetiro = new System.Windows.Forms.RadioButton();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBoxRetiro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonDosMil = new System.Windows.Forms.RadioButton();
            this.radioButtonDiezMil = new System.Windows.Forms.RadioButton();
            this.radioButtonCincoMil = new System.Windows.Forms.RadioButton();
            this.radioButtonOtro = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ButtonSalir = new System.Windows.Forms.Button();
            this.groupBoxOpciones.SuspendLayout();
            this.groupBoxConsulta.SuspendLayout();
            this.groupBoxRetiro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.radioButtonRetiro);
            this.groupBoxOpciones.Controls.Add(this.radioButtonConsulta);
            this.groupBoxOpciones.Location = new System.Drawing.Point(12, 37);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(310, 60);
            this.groupBoxOpciones.TabIndex = 0;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opciones";
            // 
            // ButtonSalir
            // 
            ButtonSalir.Location = new System.Drawing.Point(362, 57);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new System.Drawing.Size(75, 23);
            ButtonSalir.TabIndex = 1;
            ButtonSalir.Text = "Salir";
            ButtonSalir.UseVisualStyleBackColor = true;
            // 
            // radioButtonConsulta
            // 
            this.radioButtonConsulta.AutoSize = true;
            this.radioButtonConsulta.Location = new System.Drawing.Point(27, 25);
            this.radioButtonConsulta.Name = "radioButtonConsulta";
            this.radioButtonConsulta.Size = new System.Drawing.Size(66, 17);
            this.radioButtonConsulta.TabIndex = 0;
            this.radioButtonConsulta.TabStop = true;
            this.radioButtonConsulta.Text = "Consulta";
            this.radioButtonConsulta.UseVisualStyleBackColor = true;
            // 
            // radioButtonRetiro
            // 
            this.radioButtonRetiro.AutoSize = true;
            this.radioButtonRetiro.Location = new System.Drawing.Point(189, 25);
            this.radioButtonRetiro.Name = "radioButtonRetiro";
            this.radioButtonRetiro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonRetiro.Size = new System.Drawing.Size(53, 17);
            this.radioButtonRetiro.TabIndex = 1;
            this.radioButtonRetiro.TabStop = true;
            this.radioButtonRetiro.Text = "Retiro";
            this.radioButtonRetiro.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.buttonConsultar);
            this.groupBoxConsulta.Controls.Add(this.textBox1);
            this.groupBoxConsulta.Controls.Add(this.label3);
            this.groupBoxConsulta.Controls.Add(this.textBox2);
            this.groupBoxConsulta.Controls.Add(this.textBoxCliente);
            this.groupBoxConsulta.Controls.Add(this.label2);
            this.groupBoxConsulta.Controls.Add(this.label1);
            this.groupBoxConsulta.Location = new System.Drawing.Point(12, 136);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(449, 100);
            this.groupBoxConsulta.TabIndex = 2;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(72, 30);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(274, 20);
            this.textBoxCliente.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(352, 29);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // groupBoxRetiro
            // 
            this.groupBoxRetiro.Controls.Add(this.textBox4);
            this.groupBoxRetiro.Controls.Add(this.radioButtonOtro);
            this.groupBoxRetiro.Controls.Add(this.radioButtonCincoMil);
            this.groupBoxRetiro.Controls.Add(this.radioButtonDiezMil);
            this.groupBoxRetiro.Controls.Add(this.radioButtonDosMil);
            this.groupBoxRetiro.Controls.Add(this.button1);
            this.groupBoxRetiro.Controls.Add(this.textBox3);
            this.groupBoxRetiro.Controls.Add(this.label4);
            this.groupBoxRetiro.Location = new System.Drawing.Point(13, 291);
            this.groupBoxRetiro.Name = "groupBoxRetiro";
            this.groupBoxRetiro.Size = new System.Drawing.Size(448, 169);
            this.groupBoxRetiro.TabIndex = 3;
            this.groupBoxRetiro.TabStop = false;
            this.groupBoxRetiro.Text = "Retiro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuenta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 20);
            this.textBox3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Retirar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonDosMil
            // 
            this.radioButtonDosMil.AutoSize = true;
            this.radioButtonDosMil.Location = new System.Drawing.Point(109, 72);
            this.radioButtonDosMil.Name = "radioButtonDosMil";
            this.radioButtonDosMil.Size = new System.Drawing.Size(49, 17);
            this.radioButtonDosMil.TabIndex = 3;
            this.radioButtonDosMil.TabStop = true;
            this.radioButtonDosMil.Text = "2000";
            this.radioButtonDosMil.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiezMil
            // 
            this.radioButtonDiezMil.AutoSize = true;
            this.radioButtonDiezMil.Location = new System.Drawing.Point(109, 137);
            this.radioButtonDiezMil.Name = "radioButtonDiezMil";
            this.radioButtonDiezMil.Size = new System.Drawing.Size(55, 17);
            this.radioButtonDiezMil.TabIndex = 4;
            this.radioButtonDiezMil.TabStop = true;
            this.radioButtonDiezMil.Text = "10000";
            this.radioButtonDiezMil.UseVisualStyleBackColor = true;
            // 
            // radioButtonCincoMil
            // 
            this.radioButtonCincoMil.AutoSize = true;
            this.radioButtonCincoMil.Location = new System.Drawing.Point(109, 104);
            this.radioButtonCincoMil.Name = "radioButtonCincoMil";
            this.radioButtonCincoMil.Size = new System.Drawing.Size(49, 17);
            this.radioButtonCincoMil.TabIndex = 5;
            this.radioButtonCincoMil.TabStop = true;
            this.radioButtonCincoMil.Text = "5000";
            this.radioButtonCincoMil.UseVisualStyleBackColor = true;
            // 
            // radioButtonOtro
            // 
            this.radioButtonOtro.AutoSize = true;
            this.radioButtonOtro.Location = new System.Drawing.Point(245, 72);
            this.radioButtonOtro.Name = "radioButtonOtro";
            this.radioButtonOtro.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOtro.TabIndex = 6;
            this.radioButtonOtro.TabStop = true;
            this.radioButtonOtro.Text = "Otro monto";
            this.radioButtonOtro.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(245, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(13, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirar Dinero";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 29);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(435, 104);
            this.textBox5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRetiro);
            this.Controls.Add(this.groupBoxConsulta);
            this.Controls.Add(ButtonSalir);
            this.Controls.Add(this.groupBoxOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.groupBoxRetiro.ResumeLayout(false);
            this.groupBoxRetiro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.RadioButton radioButtonRetiro;
        private System.Windows.Forms.RadioButton radioButtonConsulta;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRetiro;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButtonOtro;
        private System.Windows.Forms.RadioButton radioButtonCincoMil;
        private System.Windows.Forms.RadioButton radioButtonDiezMil;
        private System.Windows.Forms.RadioButton radioButtonDosMil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
    }
}

