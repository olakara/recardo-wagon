using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization( options => {
    options.ResourcesPath = "Resources";
});

// set the default culture and supported culture list
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.SetDefaultCulture("ar");
    options.FallBackToParentUICultures = true;
    options.RequestCultureProviders.Clear();
});

// Add services to the container.
builder.Services.AddRazorPages().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
        .AddDataAnnotationsLocalization(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseRequestLocalization();


app.MapRazorPages();

app.Run();
