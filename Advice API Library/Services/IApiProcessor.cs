using Advice_API_Library.Models;

namespace Advice_API_Library.Services
{
    public interface IApiProcessor
    {
        public Task<Advice> LoadAdvice();
    }
}