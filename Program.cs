using System;

namespace Anemoia
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            using (Anemoia? game = new Anemoia())
                game.Run();
        }
    }
}