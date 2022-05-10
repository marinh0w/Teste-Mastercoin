using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string nome, data, nomeUsuario, email, senha;
        List<Usuario> usuarios = new List<Usuario>();
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            DateTime nascimento;
            nome = NameTextBox.Text;
            data = DataTextBox.Text;
            nomeUsuario = NomeUsuario.Text;
            email = Email.Text;
            senha = Senha.Text;

            if(nome == "" || data=="" || nomeUsuario =="" ||  email =="" || senha =="")
            {
                Log.Text = "Preencha todos os campos";
                return;
            }
            else if(nomeUsuario.ToLower() == "mastercoin" || nomeUsuario.ToLower() == "mc")
            {
                Log.Text = "Nome de usuário inválido";
                return;
            }

            bool dataValida = DateTime.TryParse(data, out nascimento);
            if(!dataValida)
            {
                Log.Text = "Insira uma data válida no formato\n(DD/MM/AAAA)";
                return;
            }
            else if(!IsValidEmail(email))
            {
                Log.Text = "Insira um email válido";
                return;
            }
            
            Usuario newUsuario = new Usuario(nome, data, nomeUsuario, email, senha);

            foreach(Usuario u in usuarios)
            {
                if(u.NomeUsuario == newUsuario.NomeUsuario)
                {
                    Log.Text = "Este nome de usuário já está em uso";
                    return;
                }
                else if(u.Email == newUsuario.Email)
                {
                    Log.Text = "Este email já está cadastrado";
                    return;
                }
            }

            usuarios.Add(newUsuario);

            Log.Text = "Usuário adicionado com sucesso!";
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void ListarUsuarios_Click(object sender, EventArgs e)
        {
            if(usuarios.Count == 0)
            {
                ListaTexto.Text = "Não há usuários cadastrados";
                return;
            }

            string lista = "------------------------------";
            foreach(Usuario u in usuarios)
            {
                lista += "\nNome: " + u.Nome + "\nData: " + u.DataDeNascimento + "\nUsuário: " + u.NomeUsuario
                    + "\nE-mail: " + u.Email + "\nSenha: " + u.Senha + "\n------------------------------";
            }

            ListaTexto.Text = lista;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Nascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void InverterPalavra_Click(object sender, EventArgs e)
        {
            string palavra = PalavraBox.Text;

            if(palavra.Length < 3)
            {
                Invertida.Text = "Insira uma palavra com no mínimo 3 caracteres";
                return;
            }

            char[] charArray = palavra.ToCharArray();
            Array.Reverse(charArray);
            string palavraInvertida = new string(charArray);
            Invertida.Text = palavra == palavraInvertida? palavraInvertida + "\nÉ um Palíndromo" : palavraInvertida;
        }

        private void CalcularIdadeButton_Click(object sender, EventArgs e)
        {
            string data = Nascimento.Text;
            DateTime nascimento;

            bool dataValida = DateTime.TryParse(data, out nascimento);
            if (dataValida)
            {
                Idade.Text = CalcularIdade(nascimento);
            }
            else
            {
                Idade.Text = "Insira uma data válida no formato\n(DD/MM/AAAA)";
            }
        }

        private string CalcularIdade(DateTime dt)
        {
            DateTime nascimento = dt;
            DateTime hoje = DateTime.Today;
            int valorIdade = hoje.Year - nascimento.Year;
            string idade = valorIdade.ToString();
            
            if(hoje.Month > nascimento.Month) 
            {
                return idade;
            }
            else if (hoje.Month == nascimento.Month)
            {
                if (hoje.Day == nascimento.Day)
                {
                    return idade + "\nFeliz Aniversário!";
                }
                else if (hoje.Day > nascimento.Day)
                {
                    return idade;
                }
                else
                {
                    valorIdade = valorIdade - 1;
                    idade = valorIdade.ToString();
                    return idade;
                }
            }
            else
            {
                valorIdade = valorIdade - 1;
                idade = valorIdade.ToString();
                return idade;
            }
        }

        private void ConverterParaDolar_Click(object sender, EventArgs e)
        {
            float cotacaoDolar = 5.16f;
            bool valorValido = float.TryParse(ValorParaConverter.Text, out float valorReais);
            if (!valorValido)
            {
                ValorDolar.Text = "Insira um valor válido.";
                return;
            }

            float valorDolar = valorReais * cotacaoDolar;
            ValorDolar.Text = valorDolar.ToString("F2");
        }
    }
}
