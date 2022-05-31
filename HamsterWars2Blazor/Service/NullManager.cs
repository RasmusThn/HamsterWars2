namespace HamsterWars2Blazor.Service
{
    public static class ServiceCheckManager
    {
        public static void NullCheck<T>(T target)
        {
            if (target is null)
            {
                throw new ArgumentNullException();
            }
        }
        public static void ResponseCheck(HttpResponseMessage response)
        {
            var content = response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Reason: {response.ReasonPhrase}, Message{content}");
            }
        }
    }
}
