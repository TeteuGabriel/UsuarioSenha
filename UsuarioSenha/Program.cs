namespace Usuario_Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string UsuarioSistema = "matheusgabriel";
            string SenhaSistema = "123";

            string UsuarioInserido;
            string SenhaInserida;

            int tentativas = 0;

            do
            {
                Console.Clear();    
                Console.Write("Digite o nome do usuario: ");
                UsuarioInserido = Console.ReadLine();
                Console.Write("Digite a senha do usuario: ");
                SenhaInserida = Console.ReadLine();

                tentativas++;

            } while (UsuarioInserido != UsuarioSistema && SenhaInserida != SenhaSistema && tentativas < 3);
            

            if (UsuarioInserido == UsuarioSistema && SenhaInserida == SenhaSistema)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo ao sistema, Matheus CR7");
            }
            else

            {   Console.Clear();
                Console.WriteLine($"Nome de usuário ou senha incorreta seu burro, você usou {tentativas} /3 tentativas");
            }

            Console.ReadKey();

        }
    }
}