using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.titular = "Fernanda";
            card.AprovarCompra();

            Mastercard master = new Mastercard();
            master.titular = "Fernanda";
            master.parcelas = 7;
            master.ComprarComDescontoMastercard(45f);
        }
    }
}
