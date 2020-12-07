using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =0;
            int y = 0;
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Sistema de Verificação de Validade de CPF ou CNPJ");
            Console.WriteLine("------------------------------------------------------------");
            // Instaciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();
            Validacoes valida = new Validacoes();

            int Menu;
            do
            {
                Console.WriteLine("Escolha uma opção válida");
                Console.WriteLine("[1] Cadastrar Pessoa Física");
                Console.WriteLine("[2] Cadastrar Pessoa Jurídica");
                Console.WriteLine("[3] Verificar o cadastro de Pessoa Física");
                Console.WriteLine("[4] Verificar o cadastro de Pessoa Jurídica");
                Console.WriteLine("[0] Sair");
                Menu = int.Parse(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                    Console.WriteLine("Digite o seu nome:");
                    pf.nome = Console.ReadLine();
                    Console.WriteLine("Digite seu CPF");
                    pf.cpf = Console.ReadLine();
                     // Mostramos no console o método de saudação da superclasse
                    Console.WriteLine(pf.DarBoasVindas(pf.nome));
                    // Mostramos no console o método de validação da subclasse
                    //validar cpf
                    if (Validacoes.ValidaCPF( pf.cpf))
                        {
                             Console.WriteLine($" {pf.nome} o seu CPF é Válido!");
                             x = 1;
                        }
                    else
                        {
                            Console.WriteLine("CPF Inválido! \n Digite um número válido para cadastrar no sistema");
                        }
                    break;
                    case 2:
                    Console.WriteLine("Digite o seu nome:");
                    pj.nome = Console.ReadLine();
                    Console.WriteLine("Digite seu CNPJ");
                    pj.cnpj = Console.ReadLine();
                    // Mostramos no console o método de saudação da superclasse
                    Console.WriteLine(pj.DarBoasVindas(pj.nome));
                    // Mostramos no console o método de validação da subclasse
                    // validar cnpj
                    if (Validacoes.ValidaCNPJ( pj.cnpj))
                        {
                              y = 1;
                            Console.WriteLine($" {pj.nome} o seu CNPJ é Válido! ");
                        }
                    else
                        {
                            Console.WriteLine("CNPJ Inválido! \n Digite um número válido para cadastrar no sistema");
                        }
                    break;
                    case 3:
                    if (x==1)
                    {Console.WriteLine($"Pessoa física {pf.nome} CPF: {pf.cpf}");}
                    else
                    {Console.WriteLine("Pessoa Física ainda não cadastrada");}
                    break;
                    case 4:
                    if (y==1)
                    {Console.WriteLine($"Pessoa jurídica {pj.nome} CNPJ: {pj.cnpj}");}
                    else
                    {Console.WriteLine("Pessoa jurídica ainda não cadastrada");}
                    break;
                    case 0:
                    break;
                    default:
                    break;
                }
            } while (Menu != 0);
           
        }
    }
}
