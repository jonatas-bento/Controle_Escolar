using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ControleEscolar_WebAPI.Models;

namespace ControleEscolar_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TurmaEscola>()
                .HasKey(TE => new { TE.TurmaId, TE.EscolaId });

            builder.Entity<Escola>()
                .HasData(new List<Escola>(){
                    new Escola(1, "José Maria de Souza"),
                    new Escola(2, "Aparício Otaviano Costa"),
                    new Escola(3, "Domingues Paulo Vitor"),
                    new Escola(4, "Petrúcio Pessoa"),
                    new Escola(5, "Norma Braga da Silva"),
                });

            builder.Entity<Turma>()
                .HasData(new List<Turma>(){
                    new Turma(1, "101", "1ºano", 1),
                    new Turma(2, "201", "2ºano", 1),
                    new Turma(3, "301", "3ºano", 1),
                    new Turma(4, "401", "4ºano", 1),
                    new Turma(5, "101", "1ºano",2),
                    new Turma(6, "201", "2ºano",2),
                    new Turma(7, "301", "3ºano",2),
                    new Turma(8, "401", "4ºano",2),
                    new Turma(9, "101", "1ºano",3),
                    new Turma(10, "201", "2ºano",3),
                    new Turma(11, "301", "3ºano",3),
                    new Turma(12, "401", "4ºano",3),
                    new Turma(13, "101", "1ºano",4),
                    new Turma(14, "201", "2ºano",4),
                    new Turma(15, "301", "3ºano",4),
                    new Turma(16, "401", "4ºano",4),
                    new Turma(17, "101", "1ºano",5),
                    new Turma(18, "201", "2ºano",5),
                    new Turma(19, "301", "3ºano",5),
                    new Turma(20, "401", "4ºano",5),
                });

            builder.Entity<Aluno>()
            .HasData(new List<Aluno>(){
                    new Aluno(1, "Marta de Souza", 20),
                    new Aluno(2, "Paula Isabela", 20),
                    new Aluno(3, "Laura Antonia", 20),
                    new Aluno(4, "Marta de Souza", 20),
                    new Aluno(5, "Roberto Isabela", 19),
                    new Aluno(6, "Lauro Silva", 19),
                    new Aluno(7, "Marlon de Souza", 19),
                    new Aluno(8, "Paulo Fraga", 19),
                    new Aluno(9, "Lauzane Antonia", 18),
                    new Aluno(10, "Marta de Souza", 18),
                    new Aluno(11, "Paula Isabela", 18),
                    new Aluno(12, "Laurindo Antonio", 18),
                    new Aluno(13, "José Luiz Maria", 17),
                    new Aluno(14, "Lucas Machado", 17),
                    new Aluno(15, "Pedro Alvares", 17),
                    new Aluno(16, "Paulo José", 16),
                    new Aluno(17, "Marcos de Souza", 16),
                    new Aluno(18, "Isabela Rocha", 16),
                    new Aluno(19, "Antonia Sophia", 16),
                    new Aluno(20, "Marta de Souza", 15),
                    new Aluno(21, "Paula Isabela", 15),
                    new Aluno(22, "Laurindo Antonio", 15),
                    new Aluno(23, "José Luiz Maria", 14),
                    new Aluno(24, "Lucas Machado", 15),
                    new Aluno(25, "Pedro Alvares", 14),
                    new Aluno(26, "Paulo José", 14),
                    new Aluno(27, "Marcos de Souza", 14),
                    new Aluno(28, "Isabela Rocha", 13),
                    new Aluno(29, "Antonia Sophia", 13),
                    new Aluno(30, "Marta de Souza", 13),
                    new Aluno(31, "Paula Isabela", 12),
                    new Aluno(32, "Laurindo Antonio", 12),
                    new Aluno(33, "José Luiz Maria", 12),
                    new Aluno(34, "Lucas Machado", 11),
                    new Aluno(35, "Pedro Alvares", 11),
                    new Aluno(36, "Paulo José", 11),
                    new Aluno(37, "Marcos de Souza", 10),
                    new Aluno(38, "Isabela Rocha", 10),
                    new Aluno(39, "Antonia Sophia", 10),
                    new Aluno(40, "Marta de Souza", 10),
                    new Aluno(41, "Paula Isabela", 11),
                    new Aluno(42, "Laurindo Antonio", 11),
                    new Aluno(43, "José Luiz Maria", 11),
                    new Aluno(44, "Lucas Machado", 12),
                    new Aluno(45, "Pedro Alvares", 12),
                    new Aluno(46, "Paulo José", 12),
                    new Aluno(47, "Marcos de Souza", 13),
                    new Aluno(48, "Isabela Rocha", 10),
                    new Aluno(49, "Antonia Sophia", 8),
                    new Aluno(50, "Marta de Souza", 10),
                    new Aluno(51, "Paula Isabela", 9),
                    new Aluno(52, "Laurindo Antonio", 7),
                    new Aluno(53, "José Luiz Maria", 5),
                    new Aluno(54, "Lucas Machado", 5),
                    new Aluno(55, "Pedro Alvares", 5),
                    new Aluno(56, "Paulo José", 1),
                    new Aluno(57, "Marcos de Souza", 1),
                    new Aluno(58, "Isabela Rocha", 1),
                    new Aluno(59, "Antonia Sophia", 1),
                    new Aluno(60, "Marta de Souza", 2),
                    new Aluno(61, "Paula Isabela", 4),
                    new Aluno(62, "Laurindo Antonio", 3),
                    new Aluno(63, "José Luiz Maria", 5),
                    new Aluno(64, "Lucas Machado", 3),
                    new Aluno(65, "Pedro Alvares", 3),
                    new Aluno(66, "Paulo José", 3),
                    new Aluno(67, "Marcos de Souza", 2),
                    new Aluno(68, "Isabela Rocha", 1),
                    new Aluno(69, "Antonia Sophia", 1)
            });

            builder.Entity<TurmaEscola>()
                .HasData(new List<TurmaEscola>() {
                    new TurmaEscola() {TurmaId = 1, EscolaId = 1 },
                    new TurmaEscola() {TurmaId = 2, EscolaId = 1 },
                    new TurmaEscola() {TurmaId = 3, EscolaId = 1 },
                    new TurmaEscola() {TurmaId = 4, EscolaId = 1 },
                    new TurmaEscola() {TurmaId = 5, EscolaId = 2 },
                    new TurmaEscola() {TurmaId = 6, EscolaId = 2 },
                    new TurmaEscola() {TurmaId = 7, EscolaId = 2 },
                    new TurmaEscola() {TurmaId = 8, EscolaId = 2 },
                    new TurmaEscola() {TurmaId = 9, EscolaId = 3 },
                    new TurmaEscola() {TurmaId = 10, EscolaId = 3 },
                    new TurmaEscola() {TurmaId = 11, EscolaId = 3 },
                    new TurmaEscola() {TurmaId = 12, EscolaId = 3 },
                    new TurmaEscola() {TurmaId = 13, EscolaId = 4 },
                    new TurmaEscola() {TurmaId = 14, EscolaId = 4 },
                    new TurmaEscola() {TurmaId = 15, EscolaId = 4 },
                    new TurmaEscola() {TurmaId = 16, EscolaId = 4 },
                    new TurmaEscola() {TurmaId = 17, EscolaId = 5 },
                    new TurmaEscola() {TurmaId = 18, EscolaId = 5 },
                    new TurmaEscola() {TurmaId = 19, EscolaId = 5 },
                    new TurmaEscola() {TurmaId = 20, EscolaId = 5 }
                });


        }
    }
}
