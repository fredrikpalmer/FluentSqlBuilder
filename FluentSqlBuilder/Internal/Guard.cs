using System;

namespace FluentSqlBuilder.Internal
{
    internal static class Guard
    {
        internal static void Null<T>(T arg, string msg)
        {
            if (arg == null) throw new ArgumentException(msg);
        }
    }
}
