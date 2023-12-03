namespace Infrastructure.Settings
{
	public class ApplicationSettings
	{
		public static readonly string KeyName = nameof(ApplicationSettings);

		public string? ActivationKey { get; set; }

		public CultureSettings? CultureSettings { get; set; }
	}
}
