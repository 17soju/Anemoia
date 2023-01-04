using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.IO;

namespace Anemoia.AnemoiaEngine.Logging
{
    public abstract class Logger : IDisposable
    {

        /// <summary>
        /// path location
        /// </summary>
        private readonly string path;

        private FileStream stream;
        private StreamWriter writer;
        private string time = DateTime.Now.ToLongTimeString();

        public Logger(string logPath)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException($"path shouldnt be null/empty");
            }

            path = logPath;
        }

        public void Log()
        {
            if (!File.Exists(path))
            {
                return;
            }
            writer.WriteLine(time);
        }

        public void Dispose()
        {
            writer.Dispose();
            stream.Dispose();
        }
        



    }
}
