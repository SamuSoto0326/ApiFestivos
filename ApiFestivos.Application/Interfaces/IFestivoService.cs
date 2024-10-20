using System.Collections.Generic;
using System.Threading.Tasks;
using ApiFestivos.Models;  

namespace ApiFestivos.Application.Interfaces
{
    public interface IFestivoService
    {
        Task<IEnumerable<FestivoDto>> GetFestivosAsync();
        Task<FestivoDto> GetFestivoByIdAsync(int id);
        Task AddFestivoAsync(FestivoDto festivo);
        Task UpdateFestivoAsync(FestivoDto festivo);
        Task DeleteFestivoAsync(int id);
    }
}
