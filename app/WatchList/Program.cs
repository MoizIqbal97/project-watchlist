


var b = WebApplication.CreateBuilder(args);


#region Configure Services

b.Services.AddControllers();

#endregion

var app = b.Build();

#region ConfigurePipeline

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

#endregion

#region Endpoint Routing

app.UseRouting();

app.MapControllers();

app.MapFallbackToFile("index.html");

#endregion
app.Run();
