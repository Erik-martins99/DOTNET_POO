using System.Reflection.Metadata;
using Musicas.Models;
using Musicas.Models.Escola;
using Musicas.Models.Estoque;

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
*/

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
