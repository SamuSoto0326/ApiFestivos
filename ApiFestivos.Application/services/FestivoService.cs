using System.Collections.Generic;
using System.Threading.Tasks;
using ApiFestivos.Application.Interfaces;
using ApiFestivos.Models; // Ajusta el namespace de tus modelos
using ApiFestivos.Infrastructure.Repositories; // Ajusta según el repositorio que creaste

namespace ApiFestivos.Application.Services
{
    public class FestivoService : IFestivoService
    {
        private readonly IFestivoRepository _festivoRepository;

        // Constructor que recibe el repositorio
        public FestivoService(IFestivoRepository festivoRepository)
        {
            _festivoRepository = festivoRepository;
        }

        // Obtener todos los festivos
        public async Task<IEnumerable<FestivoDto>> GetFestivosAsync()
        {
            var festivos = await _festivoRepository.GetAllFestivosAsync();
            // Si es necesario, transforma las entidades a DTOs antes de devolver
            return festivos; // Ajusta según sea DTO o entidades directas
        }

        // Obtener un festivo por ID
        public async Task<FestivoDto> GetFestivoByIdAsync(int id)
        {
            var festivo = await _festivoRepository.GetFestivoByIdAsync(id);
            return festivo;
        }

        // Agregar un nuevo festivo
        public async Task AddFestivoAsync(FestivoDto festivo)
        {
            await _festivoRepository.AddFestivoAsync(festivo);
        }

        // Actualizar un festivo existente
        public async Task UpdateFestivoAsync(FestivoDto festivo)
        {
            await _festivoRepository.UpdateFestivoAsync(festivo);
        }

        // Eliminar un festivo por su ID
        public async Task DeleteFestivoAsync(int id)
        {
            await _festivoRepository.DeleteFestivoAsync(id);
        }
    }
}
