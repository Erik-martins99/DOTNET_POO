using System.Reflection.Metadata;
using Musicas.Models;
using Musicas.Models.Escola;
using Musicas.Models.Estoque;

Banda imagineDragons = new Banda("Imagine Dragons");

Musica musica = new Musica(imagineDragons);
musica.Nome = "Beliver";
musica.Duracao = 182;
musica.Disponivel = true;

Musica musica2 = new Musica(imagineDragons);
musica2.Nome = "Memory";
musica2.Duracao = 203;
musica2.Disponivel = false;

Album album = new Album();
album.Nome = "Bad Dreams";
album.AdicionaMusica(musica);
album.AdicionaMusica(musica2);

Musica musica3 = new Musica(imagineDragons);
musica3.Nome = "I feel like a monster";
musica3.Duracao = 302;
musica3.Disponivel = true;

Musica musica4 = new Musica(imagineDragons);
musica4.Nome = "Monster";
musica4.Duracao = 199;
musica4.Disponivel = false;

Album album2 = new Album();
album2.Nome = "Monsters in my dreams";
album2.AdicionaMusica(musica3);
album2.AdicionaMusica(musica4);
//album2.ImprimeAlbum();

imagineDragons.AdicionarAlbum(album);
imagineDragons.AdicionarAlbum(album2);
imagineDragons.ExibirDiscografia();
/*
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

Produto produto1 = new Produto("Fuba", 3.49);
Produto produto2 = new Produto("Calabresa", 17.49);
Produto produto3 = new Produto("Cadé", 16.15);
Estoque estoque = new Estoque();
estoque.AdcionarProduto(produto1);
estoque.AdcionarProduto(produto2);
estoque.AdcionarProduto(produto3);
estoque.ImprimirEstoque();

Aluno erik = new Aluno("Erik", 15, [10.0, 9.8, 7.8]);
Aluno maria = new Aluno("Maria", 14, [8.0, 9.2, 8.7]);
Aluno joao = new Aluno("Joao", 15, [6.0, 9.1, 8]);

Disciplina portugues = new Disciplina("Portugues");
portugues.AdicionaAluno(erik);
portugues.AdicionaAluno(maria);

Disciplina matematica = new Disciplina("Matematica");
matematica.AdicionaAluno(erik);
matematica.AdicionaAluno(joao);

Disciplina geografia = new Disciplina("Geografia");
geografia.AdicionaAluno(erik);
geografia.AdicionaAluno(maria);
matematica.AdicionaAluno(joao);

Professor Leonardo = new Professor("Leonardo");
Leonardo.AdicionaDisciplinas(portugues);
Leonardo.AdicionaDisciplinas(geografia);
Leonardo.ImprimeInformacoes();

Professor Elmo = new Professor("Elmo");
Elmo.AdicionaDisciplinas(matematica);
Elmo.ImprimeInformacoes();
*/