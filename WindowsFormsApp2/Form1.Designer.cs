namespace WindowsFormsApp2
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.NomeUsuario = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CadastrarUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.ListarUsuarios = new System.Windows.Forms.Button();
            this.ListaTexto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PalavraBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Invertida = new System.Windows.Forms.Label();
            this.InverterPalavra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Idade = new System.Windows.Forms.Label();
            this.CalcularIdadeButton = new System.Windows.Forms.Button();
            this.ValorParaConverter = new System.Windows.Forms.TextBox();
            this.ConverterParaDolar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ValorDolar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(56, 83);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(56, 109);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataTextBox.TabIndex = 1;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.Location = new System.Drawing.Point(56, 135);
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.NomeUsuario.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(56, 161);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 3;
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(56, 187);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(100, 20);
            this.Senha.TabIndex = 4;
            this.Senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CadastrarUsuario
            // 
            this.CadastrarUsuario.Location = new System.Drawing.Point(20, 228);
            this.CadastrarUsuario.Name = "CadastrarUsuario";
            this.CadastrarUsuario.Size = new System.Drawing.Size(136, 23);
            this.CadastrarUsuario.TabIndex = 10;
            this.CadastrarUsuario.Text = "Cadastrar Usuário";
            this.CadastrarUsuario.UseVisualStyleBackColor = true;
            this.CadastrarUsuario.Click += new System.EventHandler(this.CadastrarUsuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insira os dados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(17, 289);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(0, 13);
            this.Log.TabIndex = 12;
            // 
            // ListarUsuarios
            // 
            this.ListarUsuarios.Location = new System.Drawing.Point(20, 263);
            this.ListarUsuarios.Name = "ListarUsuarios";
            this.ListarUsuarios.Size = new System.Drawing.Size(136, 23);
            this.ListarUsuarios.TabIndex = 13;
            this.ListarUsuarios.Text = "Listar Usuários";
            this.ListarUsuarios.UseVisualStyleBackColor = true;
            this.ListarUsuarios.Click += new System.EventHandler(this.ListarUsuarios_Click);
            // 
            // ListaTexto
            // 
            this.ListaTexto.AutoSize = true;
            this.ListaTexto.Location = new System.Drawing.Point(180, 83);
            this.ListaTexto.Name = "ListaTexto";
            this.ListaTexto.Size = new System.Drawing.Size(0, 13);
            this.ListaTexto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Insira uma palavra:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PalavraBox
            // 
            this.PalavraBox.Location = new System.Drawing.Point(535, 52);
            this.PalavraBox.Name = "PalavraBox";
            this.PalavraBox.Size = new System.Drawing.Size(100, 20);
            this.PalavraBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Invertida:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Invertida
            // 
            this.Invertida.AutoSize = true;
            this.Invertida.Location = new System.Drawing.Point(538, 114);
            this.Invertida.Name = "Invertida";
            this.Invertida.Size = new System.Drawing.Size(85, 13);
            this.Invertida.TabIndex = 18;
            this.Invertida.Text = "palavra invertida";
            this.Invertida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InverterPalavra
            // 
            this.InverterPalavra.Location = new System.Drawing.Point(495, 78);
            this.InverterPalavra.Name = "InverterPalavra";
            this.InverterPalavra.Size = new System.Drawing.Size(75, 23);
            this.InverterPalavra.TabIndex = 19;
            this.InverterPalavra.Text = "Inverter";
            this.InverterPalavra.UseVisualStyleBackColor = true;
            this.InverterPalavra.Click += new System.EventHandler(this.InverterPalavra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Insira sua data de nascimento:";
            // 
            // Nascimento
            // 
            this.Nascimento.Location = new System.Drawing.Point(593, 210);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(100, 20);
            this.Nascimento.TabIndex = 21;
            this.Nascimento.TextChanged += new System.EventHandler(this.Nascimento_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Idade:";
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(594, 273);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(0, 13);
            this.Idade.TabIndex = 23;
            // 
            // CalcularIdadeButton
            // 
            this.CalcularIdadeButton.Location = new System.Drawing.Point(532, 236);
            this.CalcularIdadeButton.Name = "CalcularIdadeButton";
            this.CalcularIdadeButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularIdadeButton.TabIndex = 24;
            this.CalcularIdadeButton.Text = "Calcular";
            this.CalcularIdadeButton.UseVisualStyleBackColor = true;
            this.CalcularIdadeButton.Click += new System.EventHandler(this.CalcularIdadeButton_Click);
            // 
            // ValorParaConverter
            // 
            this.ValorParaConverter.Location = new System.Drawing.Point(484, 352);
            this.ValorParaConverter.Name = "ValorParaConverter";
            this.ValorParaConverter.Size = new System.Drawing.Size(100, 20);
            this.ValorParaConverter.TabIndex = 25;
            // 
            // ConverterParaDolar
            // 
            this.ConverterParaDolar.Location = new System.Drawing.Point(460, 386);
            this.ConverterParaDolar.Name = "ConverterParaDolar";
            this.ConverterParaDolar.Size = new System.Drawing.Size(75, 23);
            this.ConverterParaDolar.TabIndex = 26;
            this.ConverterParaDolar.Text = "Converter";
            this.ConverterParaDolar.UseVisualStyleBackColor = true;
            this.ConverterParaDolar.Click += new System.EventHandler(this.ConverterParaDolar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Dólar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Real:";
            // 
            // ValorDolar
            // 
            this.ValorDolar.AutoSize = true;
            this.ValorDolar.Location = new System.Drawing.Point(484, 427);
            this.ValorDolar.Name = "ValorDolar";
            this.ValorDolar.Size = new System.Drawing.Size(0, 13);
            this.ValorDolar.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(436, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Calcule Sua Idade";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cadastre um Usuário";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(436, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Inverta uma Palavra";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(436, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Converta Dólar para Real";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ValorDolar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ConverterParaDolar);
            this.Controls.Add(this.ValorParaConverter);
            this.Controls.Add(this.CalcularIdadeButton);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InverterPalavra);
            this.Controls.Add(this.Invertida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PalavraBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListaTexto);
            this.Controls.Add(this.ListarUsuarios);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CadastrarUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.NomeUsuario);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Teste Mastercoin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.TextBox NomeUsuario;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CadastrarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Button ListarUsuarios;
        private System.Windows.Forms.Label ListaTexto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PalavraBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Invertida;
        private System.Windows.Forms.Button InverterPalavra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Nascimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.Button CalcularIdadeButton;
        private System.Windows.Forms.TextBox ValorParaConverter;
        private System.Windows.Forms.Button ConverterParaDolar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ValorDolar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

