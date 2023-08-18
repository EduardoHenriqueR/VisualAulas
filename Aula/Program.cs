using Aula;


Produto produto = new Produto();
produto.Nome = Console.ReadLine();
produto.Preco = Convert.ToInt32(Console.ReadLine());
produto.Descricao = Console.ReadLine();
Console.WriteLine(produto.Nome);
Console.WriteLine(produto);

Produto produto1 = new Produto{
    Nome = "Pão",
    Preco = 15,
    Validacao = DateTime.Now
};
Console.WriteLine(produto1);
