using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Pair_up.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Pair_up.ViewModels
{
    public  class MembersViewModel:BaseViewModel
    { 
        public ObservableCollection<People> PeoplesList { get; set; } = new ObservableCollection<People>();

        public Command OnClickMix { get; set; }

      public TimerViewModel timer { get; set; } = new TimerViewModel();
        public ImageSource Image { get; private set; }

        public MembersViewModel()
        {
           
            Accelerometer.ShakeDetected +=Accelerometer_ShakeDetected;
            Accelerometer.Start(SensorSpeed.Fastest);


            OnClickMix = new Command(MixPeoples);

            GetPeoples();
            timer.Timer();
        }

         ~MembersViewModel()
        {
            Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;
            Accelerometer.Stop();
        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            MixPeoples();
            Vibration.Vibrate(new TimeSpan(0,0,0,0,200));

          /*  var screenshot = await Screenshot.CaptureAsync();
            var stream = await screenshot.OpenReadAsync();

            Image = ImageSource.FromStream(() => stream);*/

        }

          void MixPeoples()
        {
            if (timer.isrunning)
            {
                IsBusy = false;
            }
            else
            {
                IsBusy = true;
                Preferences.Set("Start", DateTime.Now);

                Randomizer();

                int[] mas;
                mas = finder();

                while (mas[0] - mas[1] == ((int)(PeoplesList.Count / 2)))
                {
                    Randomizer();
                    finder();
                }
                while (mas[0] - mas[1] == 9)
                {
                    Randomizer();
                    finder();
                }
                IsBusy = false;
            }
       
        }


        public ObservableCollection<People> GetPeoples()
        {
            PeoplesList.Add(new People { Name = "Юля Марчук", Photo = "Julia.png" });
            PeoplesList.Add(new People { Name = "Олег Богун", Photo = "Oleh.png" });
            PeoplesList.Add(new People { Name = "Тіма Богун", Photo = "Tima.png" });
            PeoplesList.Add(new People { Name = "Віталій Марчук", Photo = "Vitaliy.png" });
            PeoplesList.Add(new People { Name = "Зоря Кварцяна", Photo = "Zorya.png" });
            PeoplesList.Add(new People { Name = "Костя Мазуркевич", Photo = "Kostya.png" });
            PeoplesList.Add(new People { Name = "Рома Борисенко", Photo = "Roma.png" });
            PeoplesList.Add(new People { Name = "Влад Хвищук", Photo = "Vlad.png" });
            PeoplesList.Add(new People { Name = "Вася Сергєєва", Photo = "Vasya.png" });
            PeoplesList.Add(new People { Name = "Артем Хвищук", Photo = "Artem.png" });
            PeoplesList.Add(new People { Name = "Влад Лагута", Photo = "VladL.png" });
            PeoplesList.Add(new People { Name = "Настя Полтавченко", Photo = "Nastya.png" });
            PeoplesList.Add(new People { Name = "Марк Тімановський", Photo = "Mark.png" });
            PeoplesList.Add(new People { Name = "Ніна Хвищук", Photo = "Nina.png" });
            PeoplesList.Add(new People { Name = "Vanya", Photo = "Vanya.png" });
            PeoplesList.Add(new People { Name = "Abel", Photo = "Abel.png" });


            return PeoplesList;
        }

        public ObservableCollection<People> Randomizer()
        {
            Random rand = new Random();

            for (int i = this.PeoplesList.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                var tmp = this.PeoplesList[j];
                this.PeoplesList[j] = this.PeoplesList[i];
                this.PeoplesList[i] = tmp;
            }

            return this.PeoplesList;
        }

        public int[] finder()
        {
           
            int KostId = 0, KsuId = 0;
            int []mas = { KostId, KsuId };

            for (int i = 0; i < this.PeoplesList.Count - 1; i++)
            {
                if (this.PeoplesList[i].Name == "Костя Мазуркевич")
                {
                    KostId = i;
                }
                if (this.PeoplesList[i].Name == "Ксюша Чепурна")
                {
                    KsuId = i;
                }
            }
            return mas;
        }

    }
}
