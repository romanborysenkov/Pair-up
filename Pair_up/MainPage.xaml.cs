using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Pair_up.Models;
using Pair_up.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Plugin.LocalNotification;

namespace Pair_up
{
    public partial class MainPage : ContentPage
    {
        MembersViewModel just = new MembersViewModel();

        bool isRunning = false;

        public int day;
        public int hour;
        public int minute;
        public int second;

        public MainPage()
        {
            InitializeComponent();

             var dtm = new TimeSpan(6, 19, 59, 59);

            BindingContext = just;

            isRunning = true;
            second = 01;

            DateTime rt = Preferences.Get("Start", DateTime.Now);

          
            if (Convert.ToInt32(time.Days) != 00 && Convert.ToInt32(time.Hours) != 00 && Convert.ToInt32(time.Minutes) != 00 && Convert.ToInt32(time.Seconds) != 00)
            {
                
            }
            else
            {
                System.Threading.Tasks.Task.Run(async () =>
                {
                    Device.StartTimer(new TimeSpan(0, 0, 1), () =>
                    {
                        isRunning = true;
                        if (Convert.ToInt32(time.Seconds) > 0 && Convert.ToInt32(time.Minutes) <= 0 && Convert.ToInt32(time.Hours) <= 0 && Convert.ToInt32(time.Days) <= 0)
                        {
                            isRunning = false;
                            return isRunning;
                        }
                        else
                        {
                            rt = Preferences.Get("Start", DateTime.Now);
                            isRunning = true;
                            TimeSpan timespan = dtm - (DateTime.Now - rt);
                            time.Timespan = timespan;
                            pairing_button.Text = time.Days + " days";// time.Days + ":" + time.Hours + ":" + time.Minutes + ":" + time.Seconds; ;
                            return isRunning = true;

                        }
                       // return isRunning;
                    });
                  if(Convert.ToInt32(time.Days) <= 0 && Convert.ToInt32(time.Hours)<=0 && Convert.ToInt32(time.Minutes) <= 0 && Convert.ToInt32(time.Seconds) <= 0)
                    {
                        isRunning = false;
                    }
                });
            }
            }

        public class Times
        {
            public DateTime Date { get; set; }
            public TimeSpan Timespan { get; set; }
            public string Days => Timespan.Days.ToString("00");
            public string Hours => Timespan.Hours.ToString("00");
            public string Minutes => Timespan.Minutes.ToString("00");
            public string Seconds => Timespan.Seconds.ToString("00");
        }

        public Times time = new Times { Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(00,00, 00, 10).Ticks) };

        void  Button_Clicked(object sender, EventArgs e)
        {

            var notification = new NotificationRequest
            {
                BadgeNumber = 1,
                Description = "Let's pairing!",
                Title = "Pair up",
                NotificationId = 1337,
                NotifyTime = DateTime.Now.AddDays(6).AddHours(19).AddMinutes(59).AddSeconds(59)
            };

          /* if (Convert.ToInt32(time.Seconds) >0 && Convert.ToInt32(time.Minutes)> 0 && Convert.ToInt32(time.Hours) > 0 && Convert.ToInt32(time.Days) > 0)
            {    
                DisplayAlert("Error!","Remains yet "+pairing_button.Text + "!", "Ok");
            }
            else */
            {
                NotificationCenter.Current.Show(notification);

                Preferences.Set("Start", DateTime.Now);
    
                just.Randomizer();

                 int[] mas;
                mas = just.finder();

                while (mas[0] - mas[1] == ((int)(just.QuestionList.Count/2)))
                {   
                    just.Randomizer();
                    just.finder();   
                }
                while (mas[0] - mas[1] == 9)
                {
                    just.Randomizer();
                    just.finder();
                }
                BindingContext = just;
            }
        }
    }
}
