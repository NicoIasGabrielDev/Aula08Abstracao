namespace Aula08Abstracao
{
    public class CartaoDebito:Cartao
    { 
         public float saldoo { get; set; }

        public string Transfere (float valor){
            return "transferido"+valor;
        }

        public string PagaroTitulo(){
            return "pagar titulo";
        }
    }
}