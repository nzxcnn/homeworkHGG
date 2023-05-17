using System;

namespace HomeWork1
{
    public class Money
    {
        public string Currency { get; set; }
        public Money Balance { get; set; }
        public Money Overbalance { get; set; }
    }
    public class Agent : Money
    {
        public int AgentID { get; set; }

        public string ResponseType { get; set; }

        public Money Balances { get; set; }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
