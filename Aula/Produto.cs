namespace Aula;
public class Produto
{
        public string? Nome { get; set; }
        public double Preco { get; set; }

        public string? Descricao {get; set;}

        public DateTime Validacao {get; set;}

    public override string ToString()
    {
        return $"Nome: {Nome} \nPreço: {Preco}  \n Descricao: {Descricao} \nValidade: {Validacao}";
    }

}

