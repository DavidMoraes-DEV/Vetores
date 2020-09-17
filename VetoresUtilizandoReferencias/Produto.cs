using System;
using System.Globalization;

namespace VetoresUtilizandoReferencias
{
    class Produto
    {
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        public Produto(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double Total
        {
            get { return Quantidade * Preco; }
        }

        public override string ToString()
        {
            return "Produto: "
                + Nome
                + ", Quantidade: "
                + Quantidade
                + ", Preço Unitário: R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Valor Total: R$ "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
