using System;
using System.Collections.ObjectModel;
using Pair_up.Models;

namespace Pair_up.ViewModels
{
    public  class MembersViewModel
    { 
        public ObservableCollection<MyListModel> QuestionList { get; set; } = new ObservableCollection<MyListModel>();
      
        public MembersViewModel()
        {

            QuestionList.Add(new MyListModel { Quest = "Юля Марчук", Photo="Julia.png"});
            QuestionList.Add(new MyListModel { Quest = "Олег Богун", Photo="Oleg.png" });
            QuestionList.Add(new MyListModel { Quest = "Тіма Богун", Photo="Tima.png" });
            QuestionList.Add(new MyListModel { Quest = "Віталій Марчук", Photo="Vitaliy.png" });
            QuestionList.Add(new MyListModel { Quest = "Зоря Кварцяна", Photo="Zorya.png" });
            QuestionList.Add(new MyListModel { Quest = "Костя Мазуркевич", Photo="Kostya.png" });
            QuestionList.Add(new MyListModel { Quest = "Рома Борисенко", Photo="Roma.png" });
            QuestionList.Add(new MyListModel { Quest = "Влад Хвищук", Photo="Vlad.png" });
            QuestionList.Add(new MyListModel { Quest = "Вася Сергєєва", Photo="Vasya.png" });
            QuestionList.Add(new MyListModel { Quest = "Артем Хвищук", Photo="Artem.png" });
            QuestionList.Add(new MyListModel { Quest = "Влад Лагута", Photo="VladL.png" });
            QuestionList.Add(new MyListModel { Quest = "Настя Полтавченко", Photo="Nastya.png" });



            /*
            QuestionList.Add(new MyListModel { Quest = "Олег Богун" });
            QuestionList.Add(new MyListModel { Quest = "Тіма Богун" });
            QuestionList.Add(new MyListModel { Quest = "Рома Борисенко" });
            QuestionList.Add(new MyListModel { Quest = "Віталій Марчук " });
            QuestionList.Add(new MyListModel { Quest = "Влад Хвищук" });
            QuestionList.Add(new MyListModel { Quest = "Зоря Кварцяна" });
            QuestionList.Add(new MyListModel { Quest = "Юля Марчук" });
            QuestionList.Add(new MyListModel { Quest = "Вася Сергєєва" });
            QuestionList.Add(new MyListModel { Quest = "Настя Полтавченко" });
            QuestionList.Add(new MyListModel { Quest = "Костя Мазуркевич" });
            QuestionList.Add(new MyListModel { Quest = "Даша Невгод" });
            QuestionList.Add(new MyListModel { Quest = "Рената Споревая" });
            QuestionList.Add(new MyListModel { Quest = "Аліна Кварцяна" });
            QuestionList.Add(new MyListModel { Quest = "Артем Хвищук" });
            QuestionList.Add(new MyListModel { Quest = "Влад Лагута" });
            QuestionList.Add(new MyListModel { Quest = "Ксюша Чепурна" });
            QuestionList.Add(new MyListModel { Quest = "Тіма Чепурний" });
            QuestionList.Add(new MyListModel { Quest = "Ніна Хвищук" });

            */
        }

        public ObservableCollection<MyListModel> Randomizer()
        {
            Random rand = new Random();

            for (int i = this.QuestionList.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                var tmp = this.QuestionList[j];
                this.QuestionList[j] = this.QuestionList[i];
                this.QuestionList[i] = tmp;
            }

            return this.QuestionList;
        }

        public int[] finder()
        {
           
            int KostId = 0, KsuId = 0;
            int []mas = { KostId, KsuId };

            for (int i = 0; i < this.QuestionList.Count - 1; i++)
            {
                if (this.QuestionList[i].Quest == "Костя Мазуркевич")
                {
                    KostId = i;
                }
                if (this.QuestionList[i].Quest == "Ксюша Чепурна")
                {
                    KsuId = i;
                }
            }
            return mas;
        }

    }
}
