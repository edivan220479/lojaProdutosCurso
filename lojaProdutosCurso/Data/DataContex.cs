using Microsoft.EntityFrameworkCore;

namespace lojaProdutosCurso.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
