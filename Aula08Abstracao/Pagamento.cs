namespace Aula08Abstracao
{
    public class Pagamento
    {
        public float saldo { get; set; }
        public string pagar(float valor){
            return $"Valor R$ {valor} transferido";
        }
         public string PagarTitulo(){
            return "Título pago com cartão de débito";
        }
    }
}