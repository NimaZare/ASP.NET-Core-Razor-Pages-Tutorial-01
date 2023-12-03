using Infrastructure.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.Configure<Infrastructure.Settings.ApplicationSettings>
    (builder.Configuration.GetSection(key: Infrastructure.Settings.ApplicationSettings.KeyName));

var app = builder.Build();

if (app.Environment.IsDevelopment() == false)
{
	app.UseExceptionHandler("/Errors");
	app.UseHsts();
}

// *** This codes steps is very important !! ***
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//app.UseAuthentication();
//app.UseAuthorization();
app.UseCultureCookie();
app.MapRazorPages();

app.Run();
