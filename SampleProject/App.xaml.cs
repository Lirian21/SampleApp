using System;
using Xamarin.Forms;
using SampleProject;
using System.Linq;
using Xamarin.Essentials;
using SampleProject.Views;

using System.Collections.Generic;
using System.IO;

namespace SampleProject
{
    public partial class App : Application
    {
        public static bool IsConnected { get; set; }
   
       
        public App()
        {
            //only for the sample app
            IsConnected = true;
            //
            InitializeComponent();
            //MakeWebRequest();

            //try
            //{
            // In all Honesty not sure why i'm passing title's the whole time agian.
               MainPage = new NavigationPage(new Home("The Title Usually"));

            //    if (IsConnected == true)
            //    {
            //        //FlowListView.Init();




            //       AppCenter.Start("xxxxx" +
            //                  "uwp={Your UWP App secret here};" +
            //                  "ios={Your iOS App secret here}",
            //                  typeof(Analytics), typeof(Crashes));


            //        CrossFirebasePushNotification.Current.Subscribe("general");
            //        CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            //        {
            //            System.Diagnostics.Debug.WriteLine($"TOKEN REC: {p.Token}");
            //        };

            //        CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            //        {
            //            try
            //            {
            //                System.Diagnostics.Debug.WriteLine("Received");
            //                if (p.Data.ContainsKey("body") && p.Data.ContainsKey("title"))
            //                {
            //                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                    {
            //                        mPage.Message = $"{p.Data["body"]}";
            //                        mPage.TitleMessage = $"{p.Data["title"]}";
            //                    });
            //                }
            //            }
            //            catch (IOException ex)
            //            {
            //                Crashes.TrackError(ex);
            //            }
            //        };
            //        CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            //        {
            //            //System.Diagnostics.Debug.WriteLine(p.Identifier);

            //            System.Diagnostics.Debug.WriteLine("Opened");
            //            foreach (var data in p.Data)
            //            {
            //                System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
            //            }

            //            if (!string.IsNullOrEmpty(p.Identifier))
            //            {
            //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                {
            //                    mPage.Message = p.Identifier;
            //                });
            //            }
            //            else if (p.Data.ContainsKey("color"))
            //            {
            //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                {
            //                    mPage.Navigation.PushAsync(new ContentPage()
            //                    {
            //                        BackgroundColor = Color.FromHex($"{p.Data["color"]}")
            //                    });
            //                });

            //            }
            //            else if (p.Data.ContainsKey("title"))
            //            {
            //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                {
            //                    mPage.TitleMessage = $"{p.Data["title"]}";
            //                });
            //            }
            //        };

            //        CrossFirebasePushNotification.Current.OnNotificationAction += (s, p) =>
            //        {
            //            System.Diagnostics.Debug.WriteLine("Action");

            //            if (!string.IsNullOrEmpty(p.Identifier))
            //            {
            //                System.Diagnostics.Debug.WriteLine($"ActionId: {p.Identifier}");
            //                foreach (var data in p.Data)
            //                {
            //                    System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
            //                }
            //            }
            //        };

            //        CrossFirebasePushNotification.Current.OnNotificationDeleted += (s, p) =>
            //        {
            //            System.Diagnostics.Debug.WriteLine("Dismissed");
            //        };


            //    }
            //    else
            //    {
            //        MainPage = new NoInternet();
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Crashes.TrackError(ex);
            //}
        }

        public static void MakeWebRequest()
        {
            //if (!CrossConnectivity.Current.IsConnected)
            //{
            //    //You are offline, notify the user

            //    IsConnected = false;
            //}
            //else { IsConnected = true; }



        }


        protected override void OnStart()
        {
            //try
            //{

            //    if (IsConnected == true)
            //    {

            //        AppCenter.Start("android=exxxxxxxxxxxxx;" +
            //                  "uwp={Your UWP App secret here};" +
            //                  "ios={Your iOS App secret here}",
            //                  typeof(Analytics), typeof(Crashes));
            //        MainPage = new NavigationPage(new Home("Mica Market"));
            //        if (Preferences.ContainsKey("Cart"))
            //        {
            //            var FetchingCart = Preferences.Get("Cart", "default_value");
            //            FullCart.Cartlistz = JsonConvert.DeserializeObject<List<Cartlist>>(FetchingCart);
            //        }
            //        if (FullCart.Cartlistz?.Any() != true || FullCart.Cartlistz.Any() != true || FullCart.Cartlistz.Count() == 0)
            //        {
            //            CartPersistance.LoadedCart = false;
            //        }
            //        else
            //        {
            //            CartPersistance.LoadedCart = true;
            //            string jsonString = JsonConvert.SerializeObject(FullCart.Cartlistz);
            //            CartPersistance.PerCart = jsonString;
            //        }
            //        CrossFirebasePushNotification.Current.Subscribe("general");
            //        CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            //        {
            //            System.Diagnostics.Debug.WriteLine($"TOKEN REC: {p.Token}");
            //        };

            //        CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            //        {
            //            try
            //            {
            //                System.Diagnostics.Debug.WriteLine("Received");
            //                if (p.Data.ContainsKey("body") && p.Data.ContainsKey("title"))
            //                {
            //                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                    {
            //                        mPage.Message = $"{p.Data["body"]}";
            //                        mPage.TitleMessage = $"{p.Data["title"]}";
            //                    });
            //                }
            //            }
            //            catch (IOException ex)
            //            {
            //                Crashes.TrackError(ex);
            //            }
            //        };
            //        CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            //        {
            //            //System.Diagnostics.Debug.WriteLine(p.Identifier);

            //            System.Diagnostics.Debug.WriteLine("Opened");
            //            foreach (var data in p.Data)
            //            {
            //                System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
            //            }

            //            if (!string.IsNullOrEmpty(p.Identifier))
            //            {
            //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                {
            //                    mPage.Message = p.Identifier;
            //                });
            //            }
            //            else if (p.Data.ContainsKey("color"))
            //            {
            //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                {
            //                    mPage.Navigation.PushAsync(new ContentPage()
            //                    {
            //                        BackgroundColor = Color.FromHex($"{p.Data["color"]}")
            //                    });
            //                });
            //            }
            //            else if (p.Data.ContainsKey("title"))
            //            {
            //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //                {
            //                    mPage.TitleMessage = $"{p.Data["title"]}";
            //                });
            //            }
            //        };

            //        CrossFirebasePushNotification.Current.OnNotificationAction += (s, p) =>
            //        {
            //            System.Diagnostics.Debug.WriteLine("Action");

            //            if (!string.IsNullOrEmpty(p.Identifier))
            //            {
            //                System.Diagnostics.Debug.WriteLine($"ActionId: {p.Identifier}");
            //                foreach (var data in p.Data)
            //                {
            //                    System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
            //                }
            //            }
            //        };

            //        CrossFirebasePushNotification.Current.OnNotificationDeleted += (s, p) =>
            //        {
            //            System.Diagnostics.Debug.WriteLine("Dismissed");
            //        };
            //    }
            //    else
            //    {
            //        MainPage = new NoInternet();
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Crashes.TrackError(ex);
            //}
        }


        protected override void OnSleep()
        {
        //    try
        //    {
        //        if (IsConnected == true)
        //        {
        //            mPage = new Ecombeta.Views.Home("Mica Market")
        //            {

        //            };

        //            MainPage = new NavigationPage(mPage);

        //            CrossFirebasePushNotification.Current.Subscribe("general");
        //            CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
        //            {
        //                System.Diagnostics.Debug.WriteLine($"TOKEN REC: {p.Token}");
        //            };

        //            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
        //            {
        //                try
        //                {
        //                    System.Diagnostics.Debug.WriteLine("Received");
        //                    if (p.Data.ContainsKey("body") && p.Data.ContainsKey("title"))
        //                    {
        //                        Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
        //                        {
        //                            mPage.Message = $"{p.Data["body"]}";
        //                            mPage.TitleMessage = $"{p.Data["title"]}";
        //                        });
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    Crashes.TrackError(ex);
        //                }
        //            };
        //            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
        //            {
        //                //System.Diagnostics.Debug.WriteLine(p.Identifier);

        //                System.Diagnostics.Debug.WriteLine("Opened");
        //                foreach (var data in p.Data)
        //                {
        //                    System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
        //                }

        //                if (!string.IsNullOrEmpty(p.Identifier))
        //                {
        //                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
        //                    {
        //                        mPage.Message = p.Identifier;
        //                    });
        //                }
        //                else if (p.Data.ContainsKey("color"))
        //                {
        //                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
        //                    {
        //                        mPage.Navigation.PushAsync(new ContentPage()
        //                        {
        //                            BackgroundColor = Color.FromHex($"{p.Data["color"]}")
        //                        });
        //                    });
        //                }
        //                else if (p.Data.ContainsKey("title"))
        //                {
        //                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
        //                    {
        //                        mPage.TitleMessage = $"{p.Data["title"]}";
        //                    });
        //                }
        //            };

        //            CrossFirebasePushNotification.Current.OnNotificationAction += (s, p) =>
        //            {
        //                System.Diagnostics.Debug.WriteLine("Action");

        //                if (!string.IsNullOrEmpty(p.Identifier))
        //                {
        //                    System.Diagnostics.Debug.WriteLine($"ActionId: {p.Identifier}");
        //                    foreach (var data in p.Data)
        //                    {
        //                        System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
        //                    }
        //                }
        //            };

        //            CrossFirebasePushNotification.Current.OnNotificationDeleted += (s, p) =>
        //            {
        //                System.Diagnostics.Debug.WriteLine("Dismissed");
        //            };

        //            MainPage = new NavigationPage(mPage);
        //        }
        //        else
        //        {
        //            MainPage = new NoInternet();
        //        }
        //    }
        //    catch (IOException ex)
        //    {
        //        Crashes.TrackError(ex);
        //    }
        }

        protected override void OnResume()
        {
            try
            {
                MakeWebRequest();
                if (IsConnected != true)
                {
                    //MainPage = new NoInternet();
                }
                else
                {
                    //This is a new idea just restarting the mainpage but yea
                    MainPage = new NavigationPage(new MainPage());
                }
            }
            catch (IOException ex)
            {
                //Crashes.TrackError(ex);
            }
        }
        public static void SetDatailPage(Page page)
        {
            if (App.Current.MainPage is MasterDetailPage)
            {   
                var masterPage = (MasterDetailPage)App.Current.MainPage;
                masterPage.Detail = new NavigationPage(page);
            }
        }
    }
}
