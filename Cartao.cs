namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string titular { get; set; }
        public string numero { get; set; }
        public string bandeira { get; set; }
        private string token { get; set; }
        protected int cvc { get; set; }

        /// <summary>
        /// Confirmação de compra
        /// </summary>
        /// <returns>Texto de aprovação</returns>
        public string AprovarCompra(){
            return "Compra aprovada";
        }
        
        /// <summary>
        /// Validação do token
        /// </summary>
        /// <param name="tokenValidacao"></param>
        /// <returns>Aprovou ou não, não pode ser vazio</returns>
        
        private bool ValidarToken(string tokenValidacao){
            if(tokenValidacao != null && tokenValidacao != ""){
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validação da compra
        /// </summary>
        /// <returns>Sempre verdadeiro</returns>
        protected bool ValidarCompra(){
            return true;
        }
    }
}