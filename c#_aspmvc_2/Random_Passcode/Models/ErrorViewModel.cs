using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Random_Passcode.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Counter
    {
        public int count;
    }

    // public static class SessionExtensions
    // {
    //     public static void SetObjectAsJson(this ISession session, string key, object value)
    //     {
    //         session.SetString(key, JsonConvert.SerializeObject(value));
    //     }
    //     public static T GetObjectFromJson<T>(this ISession session, string key)
    //     {
    //         string value = session.GetString(key);
    //         return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    //     }
    // }
}