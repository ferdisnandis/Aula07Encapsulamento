using System;
namespace Aula07Encapsulamento
{
    public class Mastercard : Cartao
    {
        
        public int parcelas { get; set; }
        
        /// <summary>
        /// Desconto no total de parcelas
        /// </summary>
        /// <param name="desconto"></param>

        public void ComprarComDescontoMastercard(float desconto){
            Console.WriteLine($"Aplicado desconto de {desconto} reais, no total de {parcelas} parcelas");
        }
    }
}