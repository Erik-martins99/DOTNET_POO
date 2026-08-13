using System.Reflection.Metadata;
using Musicas.Models;

Musica musica = new Musica();
musica.Nome = "Beliver";
musica.Artista = "Imagine Dragons";
musica.Duracao = 182;
musica.Disponivel = true;
//musica.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.Nome = "Noob";
musica2.Artista = "Linkin Park";
musica2.Duracao = 203;
musica2.Disponivel = false;
//musica2.ExibirFichaTecnica();

Album album = new Album();
album.Nome = "Meus Rocks";
album.AdicionaMusica(musica);
album.AdicionaMusica(musica2);
album.ImprimeAlbum();

Titular erik = new Titular("Erik Oliveira Martins", "erik.olv.martins@gmail.com");
Conta conta = new Conta();
conta.AbrirConta(
    erik,
    "072",
    "1223456",
    2000,
    559
);
conta.DadosDaConta();