using System;

namespace DesafioIMC
{
    internal class Program
    {
        // Função para mostrar o menu
        static void MostrarMenu()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("          PROGRAMA DE EMAGRECIMENTO          ");
            Console.WriteLine(); // Quebra de linha
            Console.WriteLine("                     MENU                    ");
            Console.WriteLine(); // Quebra de linha
            Console.WriteLine("               1 - CALCULAR IMC               ");
            Console.WriteLine("                   0 - SAIR                   ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(); // Quebra de linha
        }

        //Função para pedir e receber os dados e calcular o IMC
        static void CalcularIMC()
        {
            // Declaração de Variáveis
            string nome, sexo, categoria, riscos, recomendacao;
            double peso, altura;
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sexo: (Masculino / Feminino");
            sexo = Console.ReadLine();

            // Validação de dados
            while (sexo != "Masculino" && sexo != "masculino" && sexo != "Feminino" && sexo != "feminino")
            {
                Console.WriteLine("Entrada Inválida!");
                Console.WriteLine("Digite seu sexo novamente: (Masculino / Feminino)");
                sexo = Console.ReadLine();
            }

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            // Validação de dados
            while (idade < 0 && idade < 200)
            {
                Console.WriteLine("Entrada Invalida!");
                Console.WriteLine("Digite novamente sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }

            // Estrutura condicional para atribuir a categoria de acordo com a idade
            if (idade < 12)
            {
                categoria = "Infantil";
            }
            else if (idade >= 12 && idade <= 20)
            {
                categoria = "Juvenil";
            }
            else if (idade >= 21 && idade <= 65)
            {
                categoria = "Adulto";
            }
            else
            {
                categoria = "idoso";
            }

            Console.WriteLine("Digite sua altura: (Ex: 1,55)");
            altura = double.Parse(Console.ReadLine());

            // Validação de dados
            while (altura < 0 && altura < 3)
            {
                Console.WriteLine("Entrada Inválida!");
                Console.WriteLine("Digite sua altura novamente: ");
                altura = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            // Validação de dados
            while (peso < 0 && peso < 650)
            {
                Console.WriteLine("Entrada Inválida!");
                Console.WriteLine("Digite seu peso novamente: ");
                peso = double.Parse(Console.ReadLine());
            }

            Console.Clear(); // Limpa tela

            string imcDesejavel = "entre 20 e 24"; // IMC Desejável

            double imc = peso / (altura * altura); // Fórmula para o calculo do IMC

            // Estrutura condicional para atribuir os riscos e a recomendação de acordo com o resultado do IMC
            if (imc < 20)
            {
                riscos = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares \r\npodem estar associadas ao baixo peso.";
                recomendacao = "Inclua carboidratos simples em sua dieta, \r\nalém de proteínas indispensáveis para ganho de massa magra. Procure um profissional.";
            }
            else if (imc >= 20 && imc <= 24)
            {
                riscos = "Seu peso está ideal para suas referências. ";
                recomendacao = "Mantenha uma dieta saudável e faça seus exames periódicos.";
            }
            else if (imc >= 25 && imc <= 29)
            {
                riscos = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                recomendacao = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. \r\nA ajuda de um profissional pode ser interessante.";
            }
            else if (imc >= 30 && imc <= 35)
            {
                riscos = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                recomendacao = "Adote uma dieta alimentar rigorosa, com o acompanhamento \r\nde um nutricionista um médico especialista(endócrino).";
            }
            else
            {
                riscos = "O obeso mórbido vive menos, tem alto risco \r\nde mortalidade geral por diversas causas. ";
                recomendacao = "Procure com urgência o acompanhamento de um nutricionista para realizar \r\nreeducação alimentar, um psicólogo e um médico especialista(endócrino).";
            }

            // Impressão do diagnótisco prévio
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("              DIAGNÓSTICO PRÉVIO             ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Categoria: " + categoria);

            Console.WriteLine(); // Quebra de linha
            Console.WriteLine(); // Quebra de linha

            Console.WriteLine("IMC Desejável: " + imcDesejavel);
            Console.WriteLine(); // Quebra de linha
            Console.WriteLine($"Resultado IMC: {Math.Round(imc, 1)}");
            Console.WriteLine(); // Quebra de linha
            Console.WriteLine("Riscos: " + riscos);
            Console.WriteLine(); // Quebra de linha
            Console.WriteLine("Recomendação Inicial: " + recomendacao);
            Console.WriteLine("---------------------------------------------");
        }
        static void Main(string[] args)
        {
            MostrarMenu(); //Chamando a função para mostrar o menu

            Console.WriteLine("Escolha uma das opções do menu!");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine(); // Quebra de linha

            // Estrutura de repetição para ser executada enquanto a opção Calcular IMC do menu for escolhida
            while (opcao == 1)
            {
                CalcularIMC(); // Chamando a função para calcular o IMC

                Console.WriteLine(); // Quebra de linha

                MostrarMenu(); // Chamando a função para mostrar o menu
                Console.WriteLine();

                Console.WriteLine("Escolha uma das opções do menu!");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine(); // Quebra de linha
            }

            Console.Clear(); // Limpa a tela do console
            Console.WriteLine("VOLTE MAIS TARDE!");
        }
    }
}
