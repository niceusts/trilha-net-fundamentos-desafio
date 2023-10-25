using System.Security;
using DesafioFundamentos.Interfaces;
using DesafioFundamentos.Models;
using Newtonsoft.Json;



ICalculadora calc = new Calculadora(); //usa interface que implememta em calculadora
Console.WriteLine(calc.Dividir(10, 5));


































// Computador c = new Computador();
// Console.WriteLine(c.ToString());


















// Corrente c1 = new Corrente();

// c1.Creditar(10);
// c1.ExibirSaldo();
// c1.Creditar(10);
// c1.ExibirSaldo();


// Aluno p1 = new Aluno("Niceu");
// p1.Apresentar();








// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material", 65.00M);
// Venda v2 = new Venda(2, "Casa", 505.00M);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivo/vendas.json", serializado);

// Console.WriteLine(serializado);






















// int numero = 10;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é " + (ehPar ? "Par" : "impar"));

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");
// if (sucesso)
// {
//     // Console.WriteLine("Leitura bem-sucedida. Quantidade de linhas: " + quantidadeLinhas); Descartes
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Falha na leitura do arquivo.");
// }

















// (int, string, string) tupla = (1, "Niceu", "Biriba");
// ValueTuple<int, string, string> outroExemplo = (1, "Niceu", "Biriba");
// var outraTupla = Tuple.Create(1, "Niceu", "Biriba");


// Console.WriteLine($"id? {tupla.Item1}");
// Console.WriteLine($"id? {tupla.Item2}");











































// // Coloca o encoding para UTF8 para exibir acentuação
// Console.OutputEncoding = System.Text.Encoding.UTF8;

// decimal precoInicial = 0;
// decimal precoPorHora = 0;

// Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
//                   "Digite o preço inicial:");
// precoInicial = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine("Agora digite o preço por hora:");
// precoPorHora = Convert.ToDecimal(Console.ReadLine());

// // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
// Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// string opcao = string.Empty;
// bool exibirMenu = true;

// // Realiza o loop do menu
// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar veículo");
//     Console.WriteLine("2 - Remover veículo");
//     Console.WriteLine("3 - Listar veículos");
//     Console.WriteLine("4 - Encerrar");

//     switch (Console.ReadLine())
//     {
//         case "1":
//             es.AdicionarVeiculo();
//             break;

//         case "2":
//             es.RemoverVeiculo();
//             break;

//         case "3":
//             es.ListarVeiculos();
//             break;

//         case "4":
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

//     Console.WriteLine("Pressione uma tecla para continuar");
//     Console.ReadLine();
// }

// Console.WriteLine("O programa se encerrou");
