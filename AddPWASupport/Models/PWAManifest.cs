using System.Collections.Generic;

namespace AddPWASupport.Models
{

    public class PWAManifest
    {
        public PWAManifest()
        {
            this.icons = new List<Icon>();
            this.screenshots = new List<Screenshot>();
        }
        public string lang { get; set; }
        public string dir { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string short_name { get; set; }
        public List<Icon> icons { get; set; }
        public string scope { get; set; }
        public string start_url { get; set; }
        public string display { get; set; }
        public string orientation { get; set; }
        public string theme_color { get; set; }
        public string background_color { get; set; }
        public Serviceworker serviceworker { get; set; }
        public List<Screenshot> screenshots { get; set; }

        public void SetDeafultIcons()
        {
            this.icons.Add(new Icon() { src = "icons/windows10/Square71x71Logo.scale-400.png", type = "image/png", sizes = "284x284" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square71x71Logo.scale-200.png", type = "image/png", sizes = "142x142" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square71x71Logo.scale-100.png", type = "image/png", sizes = "71x71" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square71x71Logo.scale-150.png", type = "image/png", sizes = "107x107" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square71x71Logo.scale-125.png", type = "image/png", sizes = "89x89" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square150x150Logo.scale-400.png", type = "image/png", sizes = "600x600" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square150x150Logo.scale-200.png", type = "image/png", sizes = "300x300" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square150x150Logo.scale-100.png", type = "image/png", sizes = "150x150" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square150x150Logo.scale-150.png", type = "image/png", sizes = "225x225" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square150x150Logo.scale-125.png", type = "image/png", sizes = "188x188" });
            this.icons.Add(new Icon() { src = "icons/windows10/Wide310x150Logo.scale-400.png", type = "image/png", sizes = "1240x600" });
            this.icons.Add(new Icon() { src = "icons/windows10/Wide310x150Logo.scale-200.png", type = "image/png", sizes = "620x300" });
            this.icons.Add(new Icon() { src = "icons/windows10/Wide310x150Logo.scale-100.png", type = "image/png", sizes = "310x150" });
            this.icons.Add(new Icon() { src = "icons/windows10/Wide310x150Logo.scale-150.png", type = "image/png", sizes = "465x225" });
            this.icons.Add(new Icon() { src = "icons/windows10/Wide310x150Logo.scale-125.png", type = "image/png", sizes = "388x188" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square310x310Logo.scale-400.png", type = "image/png", sizes = "1240x1240" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square310x310Logo.scale-200.png", type = "image/png", sizes = "620x620" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square310x310Logo.scale-100.png", type = "image/png", sizes = "310x310" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square310x310Logo.scale-150.png", type = "image/png", sizes = "465x465" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square310x310Logo.scale-125.png", type = "image/png", sizes = "388x388" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.scale-400.png", type = "image/png", sizes = "176x176" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.scale-200.png", type = "image/png", sizes = "88x88" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.scale-100.png", type = "image/png", sizes = "44x44" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.scale-150.png", type = "image/png", sizes = "66x66" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.scale-125.png", type = "image/png", sizes = "55x55" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-256.png", type = "image/png", sizes = "256x256" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-48.png", type = "image/png", sizes = "48x48" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-24.png", type = "image/png", sizes = "24x24" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-16.png", type = "image/png", sizes = "16x16" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-256_altform-unplated.png", type = "image/png", sizes = "256x256" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-48_altform-unplated.png", type = "image/png", sizes = "48x48" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-24_altform-unplated.png", type = "image/png", sizes = "24x24" });
            this.icons.Add(new Icon() { src = "icons/windows10/Square44x44Logo.targetsize-16_altform-unplated.png", type = "image/png", sizes = "16x16" });
            this.icons.Add(new Icon() { src = "icons/windows10/StoreLogo.scale-400.png", type = "image/png", sizes = "200x200" });
            this.icons.Add(new Icon() { src = "icons/windows10/StoreLogo.scale-200.png", type = "image/png", sizes = "100x100" });
            this.icons.Add(new Icon() { src = "icons/windows10/StoreLogo.scale-150.png", type = "image/png", sizes = "75x75" });
            this.icons.Add(new Icon() { src = "icons/windows10/StoreLogo.scale-125.png", type = "image/png", sizes = "63x63" });
            this.icons.Add(new Icon() { src = "icons/windows10/StoreLogo.scale-100.png", type = "image/png", sizes = "50x50" });
            this.icons.Add(new Icon() { src = "icons/windows10/StoreLogo.png", type = "image/png", sizes = "50x50" });
            this.icons.Add(new Icon() { src = "icons/windows10/SplashScreen.scale-400.png", type = "image/png", sizes = "2480x1200" });
            this.icons.Add(new Icon() { src = "icons/windows10/SplashScreen.scale-200.png", type = "image/png", sizes = "1240x600" });
            this.icons.Add(new Icon() { src = "icons/windows10/SplashScreen.scale-150.png", type = "image/png", sizes = "930x450" });
            this.icons.Add(new Icon() { src = "icons/windows10/SplashScreen.scale-125.png", type = "image/png", sizes = "775x375" });
            this.icons.Add(new Icon() { src = "icons/windows10/SplashScreen.scale-100.png", type = "image/png", sizes = "620x300" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-smallsquare-24-24.png", type = "image/png", sizes = "24x24" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-smallsquare-30-30.png", type = "image/png", sizes = "30x30" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-smallsquare-42-42.png", type = "image/png", sizes = "42x42" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-smallsquare-54-54.png", type = "image/png", sizes = "54x54" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-splashscreen-1116-540.png", type = "image/png", sizes = "1116x540" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-splashscreen-868-420.png", type = "image/png", sizes = "868x420" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-splashscreen-620-300.png", type = "image/png", sizes = "620x300" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-squarelogo-270-270.png", type = "image/png", sizes = "270x270" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-squarelogo-210-210.png", type = "image/png", sizes = "210x210" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-squarelogo-150-150.png", type = "image/png", sizes = "150x150" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-squarelogo-120-120.png", type = "image/png", sizes = "120x120" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-storelogo-90-90.png", type = "image/png", sizes = "90x90" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-storelogo-70-70.png", type = "image/png", sizes = "70x70" });
            this.icons.Add(new Icon() { src = "icons/windows/windows-storelogo-50-50.png", type = "image/png", sizes = "50x50" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-appicon-106-106.png", type = "image/png", sizes = "106x106" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-appicon-62-62.png", type = "image/png", sizes = "62x62" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-appicon-44-44.png", type = "image/png", sizes = "44x44" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-mediumtile-360-360.png", type = "image/png", sizes = "360x360" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-mediumtile-210-210.png", type = "image/png", sizes = "210x210" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-mediumtile-150-150.png", type = "image/png", sizes = "150x150" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-smalltile-170-170.png", type = "image/png", sizes = "170x170" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-smalltile-99-99.png", type = "image/png", sizes = "99x99" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-smalltile-71-71.png", type = "image/png", sizes = "71x71" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-storelogo-120-120.png", type = "image/png", sizes = "120x120" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-storelogo-70-70.png", type = "image/png", sizes = "70x70" });
            this.icons.Add(new Icon() { src = "icons/windows/windowsphone-storelogo-50-50.png", type = "image/png", sizes = "50x50" });
            this.icons.Add(new Icon() { src = "icons/android/android-launchericon-512-512.png", type = "image/png", sizes = "512x512" });
            this.icons.Add(new Icon() { src = "icons/android/android-launchericon-192-192.png", type = "image/png", sizes = "192x192" });
            this.icons.Add(new Icon() { src = "icons/android/android-launchericon-144-144.png", type = "image/png", sizes = "144x144" });
            this.icons.Add(new Icon() { src = "icons/android/android-launchericon-96-96.png", type = "image/png", sizes = "96x96" });
            this.icons.Add(new Icon() { src = "icons/android/android-launchericon-72-72.png", type = "image/png", sizes = "72x72" });
            this.icons.Add(new Icon() { src = "icons/android/android-launchericon-48-48.png", type = "image/png", sizes = "48x48" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-appicon-1024-1024.png", type = "image/png", sizes = "1024x1024" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-appicon-180-180.png", type = "image/png", sizes = "180x180" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-appicon-152-152.png", type = "image/png", sizes = "152x152" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-appicon-120-120.png", type = "image/png", sizes = "120x120" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-appicon-76-76.png", type = "image/png", sizes = "76x76" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-750-1334.png", type = "image/png", sizes = "750x1334" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-1334-750.png", type = "image/png", sizes = "1334x750" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-1242-2208.png", type = "image/png", sizes = "1242x2208" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-2208-1242.png", type = "image/png", sizes = "2208x1242" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-640-960.png", type = "image/png", sizes = "640x960" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-640-1136.png", type = "image/png", sizes = "640x1136" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-1536-2048.png", type = "image/png", sizes = "1536x2048" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-2048-1536.png", type = "image/png", sizes = "2048x1536" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-768-1024.png", type = "image/png", sizes = "768x1024" });
            this.icons.Add(new Icon() { src = "icons/ios/ios-launchimage-1024-768.png", type = "image/png", sizes = "1024x768" });
            this.icons.Add(new Icon() { src = "icons/chrome/chrome-extensionmanagementpage-48-48.png", type = "image/png", sizes = "48x48" });
            this.icons.Add(new Icon() { src = "icons/chrome/chrome-favicon-16-16.png", type = "image/png", sizes = "16x16" });
            this.icons.Add(new Icon() { src = "icons/chrome/chrome-installprocess-128-128.png", type = "image/png", sizes = "128x128" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-marketplace-512-512.png", type = "image/png", sizes = "512x512" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-marketplace-128-128.png", type = "image/png", sizes = "128x128" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-256-256.png", type = "image/png", sizes = "256x256" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-128-128.png", type = "image/png", sizes = "128x128" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-90-90.png", type = "image/png", sizes = "90x90" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-64-64.png", type = "image/png", sizes = "64x64" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-48-48.png", type = "image/png", sizes = "48x48" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-32-32.png", type = "image/png", sizes = "32x32" });
            this.icons.Add(new Icon() { src = "icons/firefox/firefox-general-16-16.png", type = "image/png", sizes = "16x16" });

        }
    }
    public class Serviceworker
    {
        public string src { get; set; }
        public string scope { get; set; }
        public string update_via_cache { get; set; }
    }

    public class Icon
    {
        public string src { get; set; }
        public string sizes { get; set; }
        public string type { get; set; }
    }

    public class Screenshot
    {
        public string src { get; set; }
        public string sizes { get; set; }
        public string type { get; set; }
    }


}
