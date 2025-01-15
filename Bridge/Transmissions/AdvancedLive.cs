﻿using System;
using Bridge.Platforms;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão.");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live.");
        }

        public void Records()
        {
            Console.WriteLine("A Live está sendo gravada!");
        }
    }
}
