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
      //  MembersViewModel viewModel = new MembersViewModel();

        bool isRunning = false;

        public int day;
        public int hour;
        public int minute;
        public int second;

        public MainPage()
        {
            InitializeComponent();

           // BindingContext = viewModel = new MembersViewModel();

           /*  var dtm = new TimeSpan(6, 23, 59, 59);

           
            isRunning = true;

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
                            timer.Text = time.Days + ""+time.Hours+""+time.Minutes;
                          //  pairing_button.Text = time.Days + " days";// time.Days + ":" + time.Hours + ":" + time.Minutes + ":" + time.Seconds; ;
                            return isRunning = true;

                        }
                       // return isRunning;
                    });
                  if(Convert.ToInt32(time.Days) <= 0 && Convert.ToInt32(time.Hours)<=0 && Convert.ToInt32(time.Minutes) <= 0 && Convert.ToInt32(time.Seconds) <= 0)
                    {
                        isRunning = false;
                    }
                });
            }*/
            }

     //   public Times time = new Times { Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(00,00, 00, 10).Ticks) };

      
    }
}
