using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Pair_up.Models;

namespace Pair_up.ViewModels
{
	public class TimerViewModel:BaseViewModel
	{

		private int day;
		public int Day
		{
			get => day;
			set { day = value; OnPropertyChanged(); }
		}

		private int hour;
        public int Hour
        {
            get => hour;
            set { hour = value; OnPropertyChanged(); }
        }

        private int minute;
        public int Minute
        {
            get => minute;
            set { minute = value; OnPropertyChanged(); }
        }

        private int second;
        public int Second
        {
            get => second;
            set { second = value; OnPropertyChanged(); }
        }

        public bool isrunning;

        private string outtime;

        public string OutTime
        {
            get => outtime;
            set { outtime = value; OnPropertyChanged(); }
        }

        TimeSpan datetime = new TimeSpan(6,23,59,59);

        DateTime runtime = Preferences.Get("Start", DateTime.Now);

        public Times time = new Times { Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(00, 00, 00, 10).Ticks) };


        public void Timer()
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                Device.StartTimer(new TimeSpan(0, 0, 0, 1), () =>
                {
                    isrunning = true;
                    if (Convert.ToInt32(time.Seconds) == 1 && Convert.ToInt32(time.Minutes) <= 0 && Convert.ToInt32(time.Hours) <= 0 && Convert.ToInt32(time.Days) <= 0)
                    {
                        isrunning = false;
                        return isrunning;
                    }
                    else
                    {
                        runtime = Preferences.Get("Start", DateTime.Now);
                        TimeSpan span = datetime - (DateTime.Now - runtime);
                        time.Timespan = span;
                        OutTime = time.Days + "" + time.Hours + "" + time.Minutes + "" + time.Seconds ;
                        return isrunning = true;
                    }

                 

                });
            });
        }


	}
}

