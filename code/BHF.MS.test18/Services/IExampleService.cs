using BHF.MS.test18.Models;

namespace BHF.MS.test18.Services
{
    public interface IExampleService
    {
        Task<HttpResponseMessage> PostSomething(ExampleModel model);
        Task<HttpResponseMessage> GetSomething();
    }
}

