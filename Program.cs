namespace MVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}"));

            app.Run();
        }
    }
}
