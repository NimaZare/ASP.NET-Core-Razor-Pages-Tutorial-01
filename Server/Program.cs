var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

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
app.MapRazorPages();

app.Run();
