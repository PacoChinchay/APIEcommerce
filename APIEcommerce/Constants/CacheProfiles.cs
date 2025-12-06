using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Constants
{
    public class CacheProfiles
    {
        public const string default10 = "Default10";
        public const string default20 = "Default20";

        public static readonly CacheProfile Profile10 = new CacheProfile
        {
            Duration = 10
        };

        public static readonly CacheProfile Profile20 = new CacheProfile
        {
            Duration = 20
        };
    }
}
