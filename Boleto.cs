using System;

namespace Aula8Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime data_vencimento {get; set;}

        public string banco_emissor {get; set;}

        public string codigo_de_barra {get; set;}

        public string Registrar(){
            return "Registrado com sucesso!";
        }
    }
}