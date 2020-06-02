namespace Aula8Abstração
{
    public class Cartao : Pagamento
    {
        protected string token ="6afb98f6GB7FIU";

        public string titular { get; set;}
        public string numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }

        public bool ValidarToken(){
            if (token != null){
                return true;
            }
            return false;
        }

    }
}