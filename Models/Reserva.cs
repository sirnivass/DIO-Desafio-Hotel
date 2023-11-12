namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count) //Caso a capacidade da Suite seja maior ou igual ao n de hospedes...
            {
                Hospedes = hospedes; //o valor do parâmetro vai para Lista Pessoa criada acima.
            }
            else
            {
                //Caso não, essa Exception irá tratar dos demais casos.
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            //Instanciando uma suite da classe Suite
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Para obter o número de hóspedes, vou simplesmente "contar" quantos estão guardados na variável Hospedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;// Cálculo: DiasReservados X Suite.ValorDiaria

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados > 10)
            {
                valor = valor * 0.9M; //0.9 seria achar 90% do valor (E esse M no final que me deixou perdido por 30 min....)
            }

            return valor;// Retorna o valor da diária
        }
    }
}