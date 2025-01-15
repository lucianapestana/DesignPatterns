using System;
using Bridge.Platforms;
using Bridge.Transmissions;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Records();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartLiveAdvanced(new Red());
            StartLive(new Blue());
            StartLive(new Purple());
            StartLiveAdvanced(new Yellow());

            Console.ReadLine();
        }
    }
}
