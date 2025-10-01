using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;


namespace psc_lista_04.Models
{
    public class Atividades
    {
        /// <summary>
        /// Faça um programa que peça uma nota, entre zero e dez. Mostre uma
        /// mensagem caso o valor seja inválido e continue pedindo até que o usuário
        /// informe um valor válido.
        /// </summary>
        public static void Exercicio01()
        {
            Console.WriteLine("Exercício 01:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o " +
                              "valor seja inválido e continue pedindo até que o usuário informe um valor válido.");
            Console.WriteLine("====================================");
            bool exit = false;
            int nota;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.WriteLine("Digite uma nota entre zero e dez:");
                    nota = Convert.ToInt32(Console.ReadLine());
                    if (nota >= 0 && nota <= 10)
                    {
                        Console.WriteLine("A nota " + nota + " está correta!");
                        exit = true;
                    }
                    else
                    {
                        throw new Exception("Nota inválida. Tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Faça um programa que leia um nome de usuário e a sua senha e não aceite a
        /// senha igual ao nome do usuário, mostrando uma mensagem de erro e
        /// voltando a pedir as informações.
        /// </summary>
        public static void Exercicio02()
        {
            Console.WriteLine("Exercício 02:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que leia um nome de usuário e a sua senha e não aceite a " +
                              "senha igual ao nome do usuário, mostrando uma mensagem de erro e " +
                              "voltando a pedir as informações.");
            Console.WriteLine("====================================");
            bool exit = false;
            string user;
            string pass;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.WriteLine("Digine seu nome de usuário:");
                    user = Console.ReadLine();
                    Console.WriteLine("Digine sua senha:");
                    pass = Console.ReadLine();
                    if (user == pass)
                    {
                        throw new Exception("A senha não pode ser igual ao nome de usuário. Tente novamente.");
                    }
                    else
                    if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                    {
                        throw new Exception("Usuário e senha não podem ser vazios. Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine("Usuário e senha cadastrados com sucesso!");
                        exit = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Faça um programa que leia e valide as seguintes informações:
        /// Nome: maior que 3 caracteres;
        /// Idade: entre 0 e 150;
        /// Salário: maior que zero;
        /// Sexo: 'f' ou 'm';
        /// Estado Civil: 's', 'c', 'v', 'd';
        /// </summary>
        public static void Exercicio03()
        {
            Console.WriteLine("Exercício 03:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que leia e valide as seguintes informações:");
            Console.WriteLine("Nome: maior que 3 caracteres;");
            Console.WriteLine("Idade: entre 0 e 150;");
            Console.WriteLine("Salário: maior que zero;");
            Console.WriteLine("Sexo: 'f' ou 'm';");
            Console.WriteLine("Estado Civil: 's', 'c', 'v', 'd';");
            Console.WriteLine("====================================");
            bool exit = false;
            string nome;
            int idade;
            double salario;
            string verify;
            char sexo;
            char estadoCivil;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.WriteLine("Digite seu nome:");
                    nome = Console.ReadLine();
                    if (nome.Length < 3)
                    {
                        throw new Exception("Nome requer pelo menos 3 caracteres, tente novamente");
                    }
                    Console.WriteLine("Digite sua idade:");
                    idade = Convert.ToInt32(Console.ReadLine());
                    if (idade > 150 || idade < 0)
                    {
                        throw new Exception("Idade deve estar entre 0 e 150, tente novamente");
                    }
                    else if (idade < 14)
                    {
                        Console.WriteLine(idade + " anos? Peça para seu responsável preencher."); //nem parece kkkkkkkkk
                    }
                    Console.WriteLine("Digite seu salário:");
                    salario = Convert.ToDouble(Console.ReadLine());
                    if (salario <= 0)
                    {
                        throw new Exception("Salário deve ser maior do que zero, tente novamente");
                    }
                    Console.WriteLine("Digite seu sexo ('f' ou 'm'):");
                    verify = Console.ReadLine();
                    if (verify.Length != 1)
                    {
                        throw new Exception("Número de caracteres inserido deve ser 1, tente novamente");
                    }
                    sexo = Convert.ToChar(verify.ToUpper());
                    switch (sexo)
                    {
                        case 'X':
                            throw new Exception("Não aceitamos X-Men aqui, tente novamente");
                        case 'T':
                            throw new Exception("Não aceitamos Transformers aqui, tente novamente"); // esse nem fui eu, foi a IA
                        case 'F':
                        case 'M':
                            break;
                        default:
                            throw new Exception("Sexo deve ser 'f' ou 'm', tente novamente");
                    }
                    Console.WriteLine("Digite seu estado civil ('s', 'c', 'v', 'd'):");
                    verify = Console.ReadLine();
                    if (verify.Length != 1)
                    {
                        throw new Exception("Número de caracteres inserido deve ser 1, tente novamente");
                    }
                    estadoCivil = Convert.ToChar(verify.ToUpper());
                    switch (estadoCivil)
                    {
                        case 'S':
                        case 'C':
                        case 'V':
                        case 'D':
                            break;
                        default:
                            throw new Exception("Estado civil deve ser 's', 'c', 'v' ou 'd', tente novamente");
                    }
                    Console.WriteLine("Cadastro realizado com sucesso!");
                    Console.WriteLine("====================================");
                    Console.WriteLine("Informações cadastradas:");
                    Console.WriteLine($"Nome: {nome}");
                    Console.WriteLine($"Idade: {idade}");
                    Console.WriteLine($"Salário: {salario:C}");
                    Console.WriteLine($"Sexo: {(sexo == 'F' ? "Feminino" : "Masculino")}");
                    string estadoCivilStr = estadoCivil switch
                    {
                        'S' => "Solteiro(a)",
                        'C' => "Casado(a)",
                        'V' => "Viúvo(a)",
                        'D' => "Divorciado(a)",
                        _ => "Desconhecido"
                    };
                    Console.WriteLine($"Estado Civil: {estadoCivilStr}");
                    Console.WriteLine("====================================");
                    exit = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Supondo que a população de um país A seja da ordem de 80000 habitantes
        /// com uma taxa anual de crescimento de 3% e que a população de B seja 200000
        /// habitantes com uma taxa de crescimento de 1.5%.
        /// Faça um programa que calcule e escreva o número de anos necessários para
        /// que a população do país A ultrapasse ou iguale a população do país B,
        /// mantidas as taxas de crescimento.
        /// </summary>
        public static void Exercicio04()
        {
            Console.WriteLine("Exercício 04:");
            Console.WriteLine("====================================");
            Console.WriteLine("Supondo que a população de um país A seja da ordem de 80000 habitantes " +
                              "com uma taxa anual de crescimento de 3% e que a população de B seja 200000 " +
                              "habitantes com uma taxa de crescimento de 1.5%. " +
                              "Faça um programa que calcule e escreva o número de anos necessários para " +
                              "que a população do país A ultrapasse ou iguale a população do país B, " +
                              "mantidas as taxas de crescimento.");
            Console.WriteLine("====================================");
            int ano = 0;
            int popA = 80000;
            int popB = 200000;
            double crescimentoA = 0.03;
            double crescimentoB = 0.015;
            for (int i = 0; popA < popB; i++)
            {
                popA += (int)(popA * crescimentoA);
                popB += (int)(popB * crescimentoB);
                Console.WriteLine($"Ano {i}, Pop A: {popA} // Pop B: {popB}");
                ano = i;
            }
            Console.WriteLine("====================================");
            Console.WriteLine("População do país A ultrapassou ou igualou a população do país B!");
            Console.WriteLine($"Ano em que isso ocorreu: {ano}");
            Console.WriteLine("====================================");
        }
        /// <summary>
        /// Altere o programa anterior permitindo ao usuário informar as populações e as
        /// taxas de crescimento iniciais. Valide a entrada e permita repetir a operação.
        /// </summary>
        public static void Exercicio05()
        {
            Console.WriteLine("Exercício 05:");
            Console.WriteLine("====================================");
            Console.WriteLine("Altere o programa anterior permitindo ao usuário informar as populações e as " +
                              "taxas de crescimento iniciais. Valide a entrada e permita repetir a operação.");
            Console.WriteLine("====================================");
            bool repetir = true;
            int ano;
            int popA;
            int popB;
            double crescimentoA;
            double crescimentoB;
            while (repetir)
            {
                try
                {
                    ano = 0;
                    Console.WriteLine("Digite a população do país A:");
                    popA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a população do país B:");
                    popB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a taxa de crescimento do país A (ex: 0,03 para 3%):");
                    crescimentoA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a taxa de crescimento do país B (ex: 0,015 para 1,5%):");
                    crescimentoB = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; popA < popB; i++)
                    {
                        popA += (int)(popA * crescimentoA);
                        popB += (int)(popB * crescimentoB);
                        Console.WriteLine($"Ano {i}, Pop A: {popA} // Pop B: {popB}");
                        ano = i;
                    }
                    Console.WriteLine("====================================");
                    Console.WriteLine("População do país A ultrapassou ou igualou a população do país B!");
                    Console.WriteLine($"Ano em que isso ocorreu: {ano}");
                    Console.WriteLine("Caso queira repetir a operação, digite A, caso queira sair, digite qualquer tecla.");
                    Console.WriteLine("====================================");
                    string resposta = Console.ReadLine();
                    if (!string.IsNullOrEmpty(resposta) && resposta.Trim().ToUpper() == "A")
                    {
                        repetir = true;
                    }
                    else
                    {
                        repetir = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, digite um formato válido.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("O número digitado é muito grande ou muito pequeno.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Faça um programa que imprima na tela os números de 1 a 20, um abaixo do
        /// outro. Depois modifique o programa para que ele mostre os números um ao
        /// lado do outro.
        /// </summary>
        public static void Exercicio06()
        {
            Console.WriteLine("Exercício 06:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que imprima na tela os números de 1 a 20, um abaixo do " +
                              "outro. Depois modifique o programa para que ele mostre os números um ao " +
                              "lado do outro.");
            Console.WriteLine("====================================");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
        }
        /// <summary>
        /// Faça um programa que leia 5 números e informe o maior número.
        /// </summary>
        public static void Exercicio07()
        {
            Console.WriteLine("Exercício 07:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que leia 5 números e informe o maior número.");
            Console.WriteLine("====================================");
            int maior = int.MinValue;
            for (int i = 1; i <= 5; i++)
            {
                try
                {
                    Console.WriteLine($"Digite o {i}º número:");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    i--;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("O número digitado é muito grande ou muito pequeno.");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    i--;
                }
            }
            Console.WriteLine($"O maior número digitado foi: {maior}");
        }
        /// <summary>
        /// Faça um programa que leia 5 números e informe a soma e a média dos
        /// números.
        /// </summary>
        public static void Exercicio08()
        {
            Console.WriteLine("Exercício 08:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que leia 5 números e informe a soma e a média dos números.");
            Console.WriteLine("====================================");
            int soma = 0;
            for (int i = 1; i <= 5; i++)
            {
                try
                {
                    Console.WriteLine($"Digite o {i}º número:");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    soma += numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    i--;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("O número digitado é muito grande ou muito pequeno.");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    i--;
                }
            }
            double media = soma / 5.0;
            Console.WriteLine($"A soma dos números digitados é: {soma}");
            Console.WriteLine($"A média dos números digitados é: {media}");
        }
        /// <summary>
        /// Faça um programa que imprima na tela apenas os números ímpares entre 1 e
        /// 50.
        /// </summary>
        public static void Exercicio09()
        {
            Console.WriteLine("Exercício 09:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.");
            Console.WriteLine("====================================");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Faça um programa que receba dois números inteiros e gere os números
        /// inteiros que estão no intervalo compreendido por eles.
        /// </summary>
        public static void Exercicio10()
        {
            Console.WriteLine("Exercício 10:");
            Console.WriteLine("====================================");
            Console.WriteLine("Faça um programa que receba dois números inteiros e gere os números " +
                              "inteiros que estão no intervalo compreendido por eles.");
            Console.WriteLine("====================================");
            int num1, num2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Digite o primeiro número inteiro:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número inteiro:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == num2)
                    {
                        throw new Exception("Os números não podem ser iguais. Tente novamente.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("O número digitado é muito grande ou muito pequeno.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
            int inicio = Math.Min(num1, num2);
            int fim = Math.Max(num1, num2);
            Console.WriteLine($"Números inteiros entre {inicio} e {fim}:");
            for (int i = inicio + 1; i < fim; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}