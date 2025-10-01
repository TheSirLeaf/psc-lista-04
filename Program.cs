using psc_lista_04.Models;
bool exit = false;
while (!exit)
{
    Console.Clear();
    Console.WriteLine("Escolha uma atividade (1-10) ou 0 para sair:");
    Console.WriteLine("1. Atividade 01");
    Console.WriteLine("2. Atividade 02");
    Console.WriteLine("3. Atividade 03");
    Console.WriteLine("4. Atividade 04");
    Console.WriteLine("5. Atividade 05");
    Console.WriteLine("6. Atividade 06");
    Console.WriteLine("7. Atividade 07");
    Console.WriteLine("8. Atividade 08");
    Console.WriteLine("9. Atividade 09");
    Console.WriteLine("10. Atividade 10");
    Console.WriteLine("0. Sair");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Atividades.Exercicio01();
            break;
        case "2":
            Atividades.Exercicio02();
            break;
        case "3":
            Atividades.Exercicio03();
            break;
        case "4":
            Atividades.Exercicio04();
            break;
        case "5":
            Atividades.Exercicio05();
            break;
        case "6":
            Atividades.Exercicio06();
            break;
        case "7":
            Atividades.Exercicio07();
            break;
        case "8":
            Atividades.Exercicio08();
            break;
        case "9":
            Atividades.Exercicio09();
            break;
        case "10":
            Atividades.Exercicio10();
            break;
        case "0":
            exit = true;
            continue;
        default:
            Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            continue;
    }
    Console.WriteLine("");
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
}