namespace JurosDias
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            string? opt;
            
            while (flag)
            {
                Console.WriteLine("Calcular Multa: \n" +
                                  "1 - Calculo Juros Simples \n" +
                                  "2 - Calculo Juros Composto \n" +
                                  "2 - Sair\n");
                opt = Console.ReadLine();    
                switch (opt)
                {
                    case "1":
                        CalcularJurosSimples();
                        break;
                    case "2":
                        CalcularJurosCompostos();
                        break;
                    case "3":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
            }
            
        }
        static void CalcularJurosSimples()
        {
            Console.WriteLine("Insira a data de Vencimento:  (dd/MM/yyyy)\n");
            DateTime dataVencimento = DateTime.Parse(Console.ReadLine()!);
            DateTime hoje = DateTime.Today;
            
            Console.WriteLine("Insira o valor:");
            double valor = double.Parse(Console.ReadLine()!);
            double juros = 0.025;
            double multa = 0;
            double valorFinal = 0;

            int diasAtraso = (hoje - dataVencimento).Days;

            if (diasAtraso > 0)
            {
                multa = (valor * juros) * diasAtraso;
            }

            valorFinal = valor + multa;
            
            Console.WriteLine("Dias em atraso: " + diasAtraso);
            Console.WriteLine("Valor Final: " + valorFinal);
            Console.WriteLine($"Valor Final: {valorFinal} = Valor : {valor} + (Valor : {valor} * (Juros : {juros} " +
                              $"* Dias atrasados : {diasAtraso}))"); 

        }

        static void CalcularJurosCompostos()
        {
            Console.WriteLine("Insira a data de Vencimento:  (dd/MM/yyyy)\n");
            DateTime dataVencimento = DateTime.Parse(Console.ReadLine()!);
            DateTime hoje = DateTime.Today;
            
            Console.WriteLine("Insira o valor:");
            double valor = double.Parse(Console.ReadLine()!);
            double juros = 0.025;
            double valorFinal = 0;

            int diasAtraso = (hoje - dataVencimento).Days;

            if (diasAtraso > 0)
            {
                valorFinal = valor * Math.Pow((1 + juros), diasAtraso);
            }
            
            Console.WriteLine("Dias em atraso: " + diasAtraso);
            Console.WriteLine("Valor Final: " + valorFinal);
            Console.WriteLine($"Valor Final: {valorFinal} = Valor : {valor} * (1 + Juros : {juros} " +
                              $"^ Dias atrasados : {diasAtraso}))"); 
        }
    }    
}

