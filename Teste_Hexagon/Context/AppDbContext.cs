using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Teste_Hexagon.Model;


namespace Teste_Hexagon.Context
{
    public class Teste_HexagonContext : DbContext
    {
        public Teste_HexagonContext(DbContextOptions<Teste_HexagonContext> options) : base(options) { }
        public DbSet<Pessoa> Pessoas { get; set; }
    }

}
