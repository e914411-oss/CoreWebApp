using CoreWebApp;
using CoreWebApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();


// Cookie Authentication 加上Cookie驗證
builder.Services.AddAuthentication("AppCookie")
    .AddCookie("AppCookie", opt =>
    {
        opt.LoginPath = "/Auth/Login";
        opt.AccessDeniedPath = "/Auth/Denied";
        opt.Cookie.HttpOnly = true;
        opt.SlidingExpiration = true;
        opt.ExpireTimeSpan = TimeSpan.FromHours(1);
    });

builder.Services.AddAuthorization();

builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});

// HttpClient: AuthApiClient 註冊連接資料庫的CoreAPI
builder.Services.AddHttpClient<AuthApiClient>((sp, client) =>
{
    var cfg = sp.GetRequiredService<IConfiguration>();
    var baseUrl = cfg["Api:BaseUrl"] ?? throw new InvalidOperationException("Api:BaseUrl not set");
    client.BaseAddress = new Uri(baseUrl);
});

//註冊裝置偵測服務（用於判斷行動裝置或桌面裝置）
builder.Services.AddSingleton<IDeviceDetector, DeviceDetector>();

//註冊讀取資料都API
builder.Services.AddSingleton(sp =>
{
    var cfg = sp.GetRequiredService<IConfiguration>();
    var baseUrl = cfg["Api:BaseUrl"] ?? throw new InvalidOperationException("Api:BaseUrl not set");

    return new HttpClient
    {
        BaseAddress = new Uri(baseUrl),
        Timeout = TimeSpan.FromSeconds(30)
    };
});
builder.Services.AddScoped<ReadDTApiClient>();

//註冊政府網站登入的網址以及用於回傳Token的服務器
builder.Services.Configure<GovLoginOptions>(
    builder.Configuration.GetSection("GovLogin")
);

builder.Services.AddHttpClient<GspOAuthClient>((sp, http) =>
{
    var opt = sp.GetRequiredService<IOptions<GovLoginOptions>>().Value;

    if (string.IsNullOrWhiteSpace(opt.BaseUrl))
        throw new InvalidOperationException("GovLogin1:BaseUrl 未設定");

    http.BaseAddress = new Uri(opt.BaseUrl);
    http.Timeout = TimeSpan.FromSeconds(20);
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSession(); // 注意要放在 Routing 後面

app.UseAuthentication(); // 一定要在 UseAuthorization 前
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Entry}/{action=Index}/{id?}");

app.Run();
