using System;

namespace Aula_08_Abstração
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }
        
        public void Pagar(float valor){
            Console.WriteLine("Pagamento efetuado");
        }
        public string Cancelar(){
            return "Pagamento cancelado";
        }

    }
}