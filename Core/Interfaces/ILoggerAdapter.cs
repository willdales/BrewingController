﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILoggerAdapter<T>
    {
        void LogInformation(string message, params object?[] args);
        void LogError(Exception ex, string message, params object[] args);
    }
}
