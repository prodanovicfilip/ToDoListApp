using Microsoft.Extensions.DependencyInjection;
using ToDoListApp.Models;

namespace ToDoListApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Services.AddDbContext<ToDoContext>();
            Services.AddTransient<Form1>();
            Services.AddTransient<AddToDo>();
            Services.AddTransient<ViewToDo>();
            BuildServiceProvider(out Form1 form);
            Application.Run(form);
        }
        private static IServiceCollection Services { get; set; } = new ServiceCollection();
        private static ServiceProvider ServiceProvider { get; set; }
        public static void BuildServiceProvider(out Form1 form)
        {
            ServiceProvider = Services.BuildServiceProvider();
            form = ServiceProvider.GetRequiredService<Form1>();
        }
        public static T GetService<T>()
        {
            return (T)ServiceProvider.GetRequiredService<T>();
        }
    }
}