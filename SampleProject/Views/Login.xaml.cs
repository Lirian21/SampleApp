using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using SampleProject.Views;
using SampleProject.Models;

namespace SampleProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
       
        public Login()
        {

            InitializeComponent();

            try
            {
                #region Ini Fetch
                //Initialize Fetch Method
                //ExtractWooData(FetchCustomers.customers);
                #endregion
            }
            catch (Exception ex)
            {
                //Crashes.TrackError(ex);
            }
        }
        //(List<Customer> x)
        private async void ExtractWooData()
        {
            try
            {
                #region FetchC
                //RestAPI rest = new RestAPI("http://xxxxxxxxx/wp-json/wc/v3/", "xxxxxxx", "xxxxxx");
                //WCObject wc = new WCObject(rest);
                //int pageNum = 1;
                //var isNull = false;
                //List<Customer> oldlist;

                //while (!isNull)
                //{
                //    var page = pageNum.ToString();
                //    x = await wc.Customer.GetAll(new Dictionary<string, string>() {
                //    {
                //    "page", page
                //    },  {
                //    "per_page", "100"
                //    }
                //});
                //    oldlist = FetchCustomers.customers ?? new List<Customer>();
                //    if (x.Count == 0)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        //1st loop customers needs to = 100
                //        //2nd loop oldist needs to = 40+
                //        //If count = 0 then => Combine Customers + Oldist
                //        pageNum++;

                //        FetchCustomers.customers = oldlist.Union(x).ToList();
                //    }
                //}
            }
            catch (Exception ex)
            {
                //Crashes.TrackError(ex);
            }
            #endregion
        }
    
        public async void Login_Phase1()
        {
           
                #region Login Phase 1

                //var client = new WordPressClient("http://xxxxxx/wp-json/");
                //client.AuthMethod = AuthMethod.JWT;
                //try
                //{
                //    await client.RequestJWToken(Usernamelabel.Text, Password.Text);
                //    Login_Phase2();
                //}
                //catch (Exception e)
                //{
                // await App.Current.MainPage.DisplayAlert("Oops", "Details are wrong,Please Ensure you've Entered them Correctly", "OK");

                //}
      
         
            #endregion
        }

        public void Login_Phase2()
        {
            try
            {
                #region login Phase 2
                //var list = FetchCustomers.customers.ToList();
                //// find the first match
                //var found = list.Where(user => user.username == Usernamelabel.Text).FirstOrDefault();

                //if (found != null)
                //{
                //    Preferences.Set("CId", found.id.ToString());
                //    if (WpApiCredentials.token != null)
                //    {
                //        Preferences.Set("Token", WpApiCredentials.token);
                //    }
                   
                //    Preferences.Set("CUsername", found.username);
                //    Preferences.Set("CEmail", found.email);
                //    Users.Loggedin = true;
                //    Application.Current.SavePropertiesAsync();
                //    App.Current.MainPage.DisplayAlert("Complete", "Login Process Complete, Enjoy", "OK");
                //    App.Current.MainPage = new Home("Mica Market");
                //}
               
            }

            catch (Exception ex)
            {
                //Crashes.TrackError(ex);
            }
            #endregion
        }

        #region Login Button
        private void loginbtn_Clicked(object sender, EventArgs e)
        {
            //try
            //{
            //    ExtractWooData(FetchCustomers.customers);
            //    WpApiCredentials.Username = Usernamelabel.Text;
            //    WpApiCredentials.Password = Password.Text;
            //    Login_Phase1();
            //}
            //catch (Exception ex)
            //{
            //    Crashes.TrackError(ex);
            //}
        }

        #endregion
    }
}