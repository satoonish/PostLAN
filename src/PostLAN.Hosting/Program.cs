using Kamishibai;
using PostLAN.View;
using PostLAN.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var builder = KamishibaiApplication<App, ShellWindow>.CreateBuilder();
builder.Services.AddTransient<ShellWindowViewModel>();

var app = builder.Build();
await app.RunAsync();
