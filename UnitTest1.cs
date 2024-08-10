namespace greener_api_test_e2e
{
    public class Tests
    {
        private HttpClient _client;

        [OneTimeSetUp]
        public void Setup()
        {
            _client = new HttpClient { BaseAddress = new Uri("http://localhost:5265/") };
        }

        [Test]
        public async Task Test1()
        {
            var response = await _client.GetAsync("user/9");

            response.EnsureSuccessStatusCode();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _client.Dispose();
        }

    }
}