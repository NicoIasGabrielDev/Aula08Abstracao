namespace Aula08Abstracao
{
    public class Boleto:Pagamento
  {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codigoBarras { get; set; }
        public string registrarNoSistema(){
            return "Boleto Registrado";
        }

    }
}