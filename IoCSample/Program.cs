using Microsoft.Extensions.DependencyInjection;

namespace IoCSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var provider = RegisterTypes();

            var timeService = provider.GetRequiredService<ITimeService>();

            var currentTime = timeService.ShowTime();
            Console.WriteLine(currentTime);

            ResolveDISample(provider);

            Console.ReadLine();
        }

        private static void ResolveDISample(ServiceProvider provider)
        {
            // Das Framework injiziert die Abhaengigkeiten via Konstruktur
            // Hier ein Beispiel wie ein Framework dynamisch DI mit Reflection realisieren koennte

            // 1. Mit Reflection koennen wir die Typen der Parameter auslesen
            var parameters = typeof(ConsumingClass).GetConstructors()[0].GetParameters();
            foreach (var parameter in parameters)
            {
                var type = parameter.ParameterType;
                var service = provider.GetService(type);

                // 2. Mit dem Activator aus Reflection koennen wir dynamisch Instanzen von Klassen erstellen
                var consumer = (ConsumingClass)Activator.CreateInstance(typeof(ConsumingClass), service);

                Console.WriteLine(type);
                consumer.DoSomething();
            }
        }

        private static ServiceProvider RegisterTypes()
        {
            // Wie ein Lookup fuer alle registrierten Abhaengigkeiten
            var serviceContainer = new ServiceCollection();

            // Wir registrieren die konkrete Implementierung des Service gegen das Interface ITimeService
            serviceContainer.AddTransient<ITimeService, CurrentTimeService>();

            // Hier wird die vorherige Registrierung mit einer anderen Implementierung ersetzt
            serviceContainer.AddTransient<ITimeService, UniversalTimeService>();

            return serviceContainer.BuildServiceProvider();
        }

        public class ConsumingClass
        {
            private readonly ITimeService _timeService;

            public ConsumingClass(ITimeService timeService)
            {
                _timeService = timeService;
            }

            public void DoSomething()
            {
                Console.WriteLine(_timeService.ShowTime());
            }
        }
    }
}
