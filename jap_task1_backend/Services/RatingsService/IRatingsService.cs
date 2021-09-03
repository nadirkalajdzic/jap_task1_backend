using jap_task1_backend.Models;
using System.Threading.Tasks;

namespace jap_task1_backend.Services.RatingsService
{
    public interface IRatingsService
    {
        Task<ServiceResponse<bool>> AddRating(float Value, int VideoId);
    }
}
