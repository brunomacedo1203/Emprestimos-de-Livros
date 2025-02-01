using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext:DbContext
    {
     
        //criando um construtor//
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        { 
        }
        
        public DbSet <EmprestimosModel> Emprestimos { get; set; }
    }
}
