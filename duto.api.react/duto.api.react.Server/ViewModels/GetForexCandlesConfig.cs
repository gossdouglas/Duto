namespace duto.api.react.Server.ViewModels
{
    public class GetForexCandlesConfig
    {
        public string forexTicker { get; set; }
        public string multiplier { get; set; }
        public string timespan { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string? adjusted { get; set; }
        public string? sort { get; set; }
        public string? limit { get; set; }

    }
}
