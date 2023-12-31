﻿using System.Text.Json;

namespace ASP04SessionServices.Helpers
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? Get<T>(this ISession session, string key)
        {
            T? result = default; //pro int = 0; pro string null, pro class = null ...
            string? source = session.GetString(key) ?? default; //pokud je session prázdná, vrací null!
            if (source != null) result = JsonSerializer.Deserialize<T>(source);
            if (typeof(T).IsClass && result == null) result = (T)Activator.CreateInstance(typeof(T));
            return result;
        }
    }
}
