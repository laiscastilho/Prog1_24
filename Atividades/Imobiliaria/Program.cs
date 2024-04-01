using Exercicio.Models;
List <Imovel> imoveis = new List<Imovel>();

Imovel casa = new Imovel();
casa.ID = 1;
casa.Endereco = "Endereço 01";
casa.Negociacao = "Aluguel";
casa.Tipo = "Casa";
casa.Valor = 2500;
casa.Quartos = 3;
casa.Localizacao = "Urbana";
casa.Imagens.Add("diretório_do_arquivo\\imagem.jpg");

Imovel apartamento = new Imovel();
apartamento.ID = 2;
apartamento.Endereco = "Endereço 02";
apartamento.Negociacao = "Compra";
apartamento.Tipo = "Apartamento";
apartamento.Valor = 200000;
apartamento.Quartos = 2;
apartamento.Localizacao = "Urbana";
apartamento.Imagens.Add("diretório_do_arquivo\\imagem_apartamento.jpg");
apartamento.Imagens.Add("diretório_do_arquivo\\imagem_apartamento_02.jpg");

Imovel sitio = new Imovel();
sitio.ID = 3;
sitio.Endereco = "Área rural rua 03";
sitio.Negociacao = "Aluguel";
sitio.Tipo = "Sítio";
sitio.Valor = 5000;
sitio.Quartos = 4;
sitio.Localizacao = "Rural";
sitio.Imagens.Add("diretório_do_arquivo\\imagem_sitio.jpg");
sitio.Imagens.Add("diretório_do_arquivo\\imagem_sitio_02.jpg");
sitio.Imagens.Add("diretório_do_arquivo\\imagem_sitio_03.jpg");

imoveis.Add(casa);
imoveis.Add(apartamento);
imoveis.Add(sitio);

foreach (var i in imoveis)
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"-Imovel: {i.ID}");
    Console.WriteLine($"-Endereço: {i.Endereco}");
    Console.WriteLine($"-Tipo: {i.Tipo}");
    Console.WriteLine($"-Valor: {i.Valor}");
    Console.WriteLine($"-Quartos: {i.Quartos}");
    Console.WriteLine($"-Localização: {i.Localizacao}");
    foreach (var imagem in i.Imagens)
    {
        Console.WriteLine($"---Diretório Imagem: {imagem}");
    }
}