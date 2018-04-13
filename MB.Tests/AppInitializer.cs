using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MB.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

