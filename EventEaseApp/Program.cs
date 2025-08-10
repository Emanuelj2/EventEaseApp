using System;
using EventEaseApp.Components;
using EventEaseApp.Data;
using EventEaseApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register EF Core with in-memory DB
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("EventCardsDb"));


// Register event service
builder.Services.AddScoped<IEventService, EventService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();