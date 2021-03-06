﻿using System.IO;

namespace Extensibility
{
    public class FileLogger : Ilogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
            
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");

        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");


        }

        public void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }

        }

    }
}