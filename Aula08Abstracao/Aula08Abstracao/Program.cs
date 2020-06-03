using System;

namespace Aula_08_Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
	        visa.limite = 1200;
	        visa.AumentarLimite(visa.limite, 300);
	        visa.Pagar(900);
        }
    }
}
