using System;
    class Program
{
    static void Main()
    {
        // ADICIONADO: Array para controlar quais vagas estão ocupadas (false = livre, true = ocupada)
        bool[] vagasOcupadas = {false, false, false, false};
        string resposta; // ADICIONADO: Variável para controlar se quer continuar
        
        do // ADICIONADO: Início do loop - vai repetir tudo até o usuário não querer mais
        {
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("Bem-vindo ao sistema de estacionamento!");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("Para prosseguir aperte qualquer tecla...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite a cor do veículo:");
            string cor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o ano do veículo:");
            string ano = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o tipo de combustível do veículo:");
            string combustivel = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Veículo cadastrado com sucesso!");
            Console.WriteLine("======================================");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Combustível: {combustivel}");

            Console.WriteLine("Aperte enter para verificar vagas disponíveis...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("Vagas disponíveis:");
            
            // MODIFICADO: Agora só mostra vagas que estão livres (false no array)
            if (!vagasOcupadas[0]) Console.WriteLine("1. Vaga 1 - Disponível");
            if (!vagasOcupadas[1]) Console.WriteLine("2. Vaga 2 - Disponível");
            if (!vagasOcupadas[2]) Console.WriteLine("3. Vaga 3 - Disponível");
            if (!vagasOcupadas[3]) Console.WriteLine("4. Vaga 4 - Disponível");
            
            Console.WriteLine();
            Console.WriteLine("Selecione uma vaga (1-4):");
            string vagaSelecionada = Console.ReadLine();
            Console.Clear();
            
            // MODIFICADO: Agora verifica se a vaga está livre antes de ocupar
            if ((vagaSelecionada == "1" && !vagasOcupadas[0]) || 
                (vagaSelecionada == "2" && !vagasOcupadas[1]) || 
                (vagaSelecionada == "3" && !vagasOcupadas[2]) || 
                (vagaSelecionada == "4" && !vagasOcupadas[3]))
            {
                // ADICIONADO: Marca a vaga como ocupada no array
                vagasOcupadas[int.Parse(vagaSelecionada) - 1] = true;
                
                Console.WriteLine("======================================");
                Console.WriteLine($"Vaga {vagaSelecionada} selecionada com sucesso!");
                Console.WriteLine("======================================");
            }
            else
            {
                Console.WriteLine("Opção inválida ou vaga já ocupada!");
            }

            Console.WriteLine("Aperte enter para ver status das vagas...");
            Console.ReadLine();
            Console.Clear();
            
            // MODIFICADO: Agora usa o array para mostrar o status real das vagas
            Console.WriteLine("Status atual das vagas:");
            Console.WriteLine(vagasOcupadas[0] ? "Vaga 1 - Ocupada" : "Vaga 1 - Disponível");
            Console.WriteLine(vagasOcupadas[1] ? "Vaga 2 - Ocupada" : "Vaga 2 - Disponível");
            Console.WriteLine(vagasOcupadas[2] ? "Vaga 3 - Ocupada" : "Vaga 3 - Disponível");
            Console.WriteLine(vagasOcupadas[3] ? "Vaga 4 - Ocupada" : "Vaga 4 - Disponível");
            
            Console.WriteLine("Obrigado por utilizar nosso sistema de estacionamento!");
            Console.WriteLine();

            // MODIFICADO: Agora pergunta se quer cadastrar outro veículo
            Console.Clear();
            Console.WriteLine("Deseja cadastrar outro veículo? (s/n):");
            resposta = Console.ReadLine().ToLower(); // ToLower() aceita S ou s
            Console.Clear();
            
            if (resposta != "s" && resposta != "sim")
            {
                Console.Clear();
                Console.WriteLine("Saindo do sistema...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
            
        } while (resposta == "s" || resposta == "sim"); // ADICIONADO: Fim do loop - repete se resposta for 's' ou 'sim'
        
        // ADICIONADO: Mensagem final quando sair do loop
        Console.WriteLine("Sistema finalizado!");
    }
}
