using ApiFestivos.Infrastructure.Interfaces; // Para IRepository<>
using ApiFestivos.Data; // Asegúrate de que este es el espacio de nombres correcto para FestivosDbContext
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFestivos.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly FestivosDbContext _context; // Aquí se debe encontrar el contexto

        public Repository(FestivosDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id) // Permite que el resultado sea nulo
        {
            return await _context.Set<T>().FindAsync(id);
        }


        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}


