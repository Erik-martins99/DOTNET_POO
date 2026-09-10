using POO;
using Teste1.Models.Movie;

/*Musica musica1 = new Musica();
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
*/

Movie titanic = new Movie("TItanic", 320);
Movie regresso = new Movie("O regresso", 240);
Movie venom = new Movie("Venom", 120);

Artista leonardoDeCaprio = new Artista("Leonardo de Caprio", 53);
Artista tomHardy = new Artista("Tom Hardy", 42);

titanic.adicionarArtista(leonardoDeCaprio);
regresso.adicionarArtista(leonardoDeCaprio);
regresso.adicionarArtista(tomHardy);
venom.adicionarArtista(tomHardy);

leonardoDeCaprio.fichaTecnica();
tomHardy.fichaTecnica();
titanic.fichaTecnica();
regresso.fichaTecnica();
