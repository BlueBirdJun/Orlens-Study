using SharpRaven;
using SharpRaven.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Helpers
{
    public class SentryUtil
    {
        public static void SendSentry(Exception exc)
        {
            var ravenClient = new RavenClient("https://e5e9094d64c84df390cd96198378ba1b@sentry.io/1419325");
            ravenClient.Capture(new SentryEvent(exc));

        }

        public static void SendStringSentry(string exc)
        {
            var ravenClient = new RavenClient("https://e5e9094d64c84df390cd96198378ba1b@sentry.io/1419325");
            ravenClient.Capture(new SentryEvent(exc));

        }
    }
}
