﻿namespace SSO.Demo.Toolkits.Extension
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string inputStr)
        {
            return string.IsNullOrEmpty(inputStr);
        }

        public static string ValueOfAppsettings(this string inputStr)
        {
            // Configuration
            return "";
        }
    }
}