using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Este trecho de código realiza a simulação de um processo de reserva em um sistema de hospedagem.
// A seguir, serão detalhados os passos e operações realizadas:

// 1. Criação de uma lista de modelos de hóspedes e cadastro de dois hóspedes nessa lista.
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
hospedes.Add(p1);
hospedes.Add(p2);

// 2. Solicitação ao usuário para inserir o valor da diária e validação da entrada.
Console.Write("Digite o valor da diária: ");
if (decimal.TryParse(Console.ReadLine(), out decimal valorDiaria) && valorDiaria > 0)
{
    // 3. Criação de uma suíte premium com capacidade para 2 pessoas e o valor da diária informado.
    Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: valorDiaria);

    // 4. Solicitação ao usuário para inserir o número de diárias e validação da entrada.
    Console.Write("Digite o número de diárias: ");
    if (int.TryParse(Console.ReadLine(), out int numeroDiarias) && numeroDiarias > 0)
    {
        // 5. Criação de uma nova reserva, passando a suíte e os hóspedes.
        Reserva reserva = new Reserva(numeroDiarias);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // 6. Exibição da quantidade de hóspedes e do valor total da reserva.
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria():C}");
    }
    else
    {
        // 7. Exibição de mensagem de erro em caso de número inválido de diárias.
        Console.WriteLine("Número inválido de diárias.");
    }
}
else
{
    // 8. Exibição de mensagem de erro em caso de valor inválido para a diária.
    Console.WriteLine("Valor inválido para a diária.");
}