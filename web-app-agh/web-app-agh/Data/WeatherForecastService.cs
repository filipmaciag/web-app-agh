namespace web_app_agh.Data
{
	public class WeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing in CI/CD"
	};

		public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
			return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = startDate.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray());
		}
	}
}