using POO;

Musica musica1 = new Musica();
musica1.Nome = "Roxane"; 
musica1.Artista = "The Police";
musica1.Duracao = 221;
musica1.Disponivel = true;
Console.Write(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 198;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);

Produto iphone = new Produto();
iphone.Nome = "Iphone 13 Pro MAX";
iphone.Marca = "Apple";
iphone.Preco = 3000.99f;
iphone.Estoque = 2;
Console.WriteLine(iphone.InformacoesDetalhadas);