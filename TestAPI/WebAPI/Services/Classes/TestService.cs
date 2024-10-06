using WebAPI.Services.Interfaces;

namespace WebAPI.Services.Classes
{
    public class TestService : ITestService
    {
        public async Task<string> test(string test)
        {
            return test;
        }
    }
}
