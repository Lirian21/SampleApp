



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SampleProject.Models;

namespace SampleProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string flashID;
        public List<MasterPageItem> menuListz { get; set; }
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    RaisePropertyChanged();
                }
            }
        }
         private string _titlemessage;
        public string TitleMessage
        {
            get
            {
                return _titlemessage;
            }
            set
            {
                if (_titlemessage != value)
                {
                    _titlemessage = value;
                   
                }
            }
        }


        async void HandleCustomEvent(object sender, PropertyChangedEventArgs a)
        {
            try
            {
                //RestAPI rest = new RestAPI("http://xxxxxxx/wp-json/wc/v3/", "xxxx", "xxxxx");
               // WCObject wc = new WCObject(rest);
                var y = await App.Current.MainPage.DisplayAlert(TitleMessage, Message, "Go Sale", "ok");
                if (y)
                {
                    //var p = await wc.Tag.GetAll(new Dictionary<string, string>() {

                   // { "per_page", "100" } });

                    //foreach (var item in p)
                   // {
                    //    if (_titlemessage == item.name)
                    //    {
                     //       flashID = item.id.ToString();
                     //   }
                  //  }
                   // await Navigation.PushAsync(new FlashSale_s());
                }
            }
            catch (Exception ex)
            {
               // Crashes.TrackError(ex);
            }
        }


        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            try
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }
            }
            catch (Exception ex)
            {
              //  Crashes.TrackError(ex);
            }
        }
        public Home(string x)
        {
            try
            {
                this.PropertyChanged += HandleCustomEvent;
                //This is just the Menu
                x = "Mica Market";
                Title = x;
                InitializeComponent();

                menuListz = new List<MasterPageItem>();
               
                menuListz.Add(new MasterPageItem()
                {
                    Title = "Home",
                    Icon = "IC3.png",
                    TargetType = typeof(MainPage)
                });
                menuListz.Add(new MasterPageItem()
                {
                    Title = "Login",
                    Icon = "IC8.png",
                    TargetType = typeof(Login)
                });
            }
            catch (Exception ex)
            {
             
            }
            try
            {
                
                // Setting our list to be ItemSource for ListView in MainPage.xaml  
                navigationDrawerList.ItemsSource = menuListz;
                // Initial navigation, this can be used for our home page  
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));

                NavigationPage.SetHasBackButton(this, false);
                 #region Data Persistance
               //if (Preferences.ContainsKey("CId"))
               //{
                    ////Fetch Customer ID
                    //var CustomerID = Preferences.Get("CId", "default_value");
                    //Users.CId = Convert.ToInt32(CustomerID);
                  
                    //Users.Loggedin = true;

                    //var CustomerName = Preferences.Get("CUsername", "default_value");
                    //logoutbtn.IsVisible = true;
                    ////Fetch Customer Email
                    //var userToken = WpApiCredentials.token;
                    //userToken = Preferences.Get("Token", "default_value");
                    ////var name = Usermail.Substring(0, Usermail.IndexOf('@')).Replace(".", " ");
                    //Emailnav.Text = "User: " + CustomerName;
                    //Users.CEmail = Preferences.Get("CEmail", "default_value");
                    ////Fetch Customer Username
                    //Users.Username = Preferences.Get("CUsername", "default_value");
               //}
               //else
               //{
                    //Users.Loggedin = false;
                    //Emailnav.Text = "Please log in";
                    //logoutbtn.IsVisible = false;
               //}
                #endregion
            }
            catch (Exception ex)
            {
                //Crashes.TrackError(ex);
            }
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = (MasterPageItem)e.SelectedItem;
                Type page = item.TargetType;
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                //Crashes.TrackError(ex);
            }
        }
      
        private void logoutbtn_Clicked(object sender, EventArgs e)
        {
            //try
            //{
            //    Preferences.Clear();
            //    App.Current.MainPage.DisplayAlert("Thank you", "You've Succesfully Logged out", "OK");
            //    Users.Loggedin = false;
            //    Emailnav.Text = "Please log in";
            //    App.Current.MainPage.Navigation.PushAsync(new Home(""));
                
            //}
            //catch (Exception ex)
            //{
            //    Crashes.TrackError(ex);
            //}
        }
    }
}
