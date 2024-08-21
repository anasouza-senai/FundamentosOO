using Fundamentos;

internal class Program
{
    public static object Magnus { get; private set; }

    private static void Main(string[] args)
    {
        /*
        // Instanciar um Objeto do Tipo Aluno
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();

        // Preencher os atributos do objeto
        aluno1.Nome = "Cristiano de Paula";
        aluno1.RM = "1234TI";
        aluno1.Email = "cristiano.paula@sp.senai.br";
        aluno1.Nascimento = new DateOnly(1981, 07, 16);

        aluno2.Nome = "José da Silva";
        aluno2.RM = "2244TI";
        aluno2.Email = "jose.silva@sp.senai.br";
        aluno2.Nascimento = new DateOnly(2000, 07, 16);

        // Imprimir na Tela
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("E-mail: " + aluno1.Email);
        Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        Console.WriteLine("================================================");

        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("E-mail: " + aluno2.Email);
        Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        Console.WriteLine("================================================");
        Console.WriteLine();

        // Instanciar um Objeto do Tipo Produto
        Produto p1 = new Produto();
        p1.Codigo = 123456;
        p1.Nome = "Coca-Cola 3 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();
        p1.Estoque = 85;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();

        Console.WriteLine("================================================");
        Console.WriteLine();

        // Instanciar um objeto do tipo Carro
        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "José";
        pessoa1.Idade = 18;

        pessoa1.Envelhecer(5);
        pessoa1.Envelhecer(2);

        Console.WriteLine("================================================");
        Console.WriteLine();

        Funcionario func1 = new Funcionario();
        func1.Nome = "Luis Santos";
        func1.Idade = 20;
        func1.Cargo = "Aprendiz";
        func1.Salario = 1400.00;
        func1.ApresentarSe();

        Console.WriteLine("================================================");
        Console.WriteLine();
        */

        /*
        //Instanciar um Objeto 
        Animal animal1 = new Animal();

        //Inserindo dados no atributo;
        animal1.Especie = "Cachorro";

        //Chamando o Metodo do Objeto
        animal1.emitirSom();

        //Imprimindo a informação na tela
        Console.WriteLine("O animal " + animal1.Especie + " emitiu um som.");
        */

        /*
        Gato gato = new Gato();
        gato.Nome = "Lilith";
        Console.WriteLine(gato.Nome + " faz:");
        gato.emitirSom();

        Console.WriteLine("=======================================");

        Porco porco = new Porco();
        porco.Nome = "Alface";
        Console.WriteLine(porco.Nome + " faz:");
        porco.emitirSom();

        Console.WriteLine("=======================================");

        Galinha galinha = new Galinha();
        galinha.Nome = "Lolita";
        Console.WriteLine(galinha.Nome + " faz:");
        galinha.emitirSom();
        */

        Mago magnus = new Mago();
        magnus.Nome = "Mago Magnus";
        magnus.Vida = 100;
        magnus.Inteligencia = 87;
        magnus.Forca = 55;
        magnus.Agilidade = 55;
        magnus.Nivel = 1;

        Elfo Thranduil = new Elfo();
        Thranduil.Nome = "Thranduil";
        Thranduil.Vida = 100;
        Thranduil.Inteligencia = 83;
        Thranduil.Forca = 56;
        Thranduil.Agilidade = 90;
        Thranduil.Nivel = 1;


        magnus.apresentarSe();
        Thranduil.apresentarSe();

        magnus.batalhar(Thranduil);


    }
}
