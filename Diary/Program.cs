using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDiary diary = new StudentDiary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            ///
            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();
            ///
            DiaryStatistics stats = diary.ComputeStatistic();
            Console.WriteLine("Średnia wartość: " + stats.averaGrade);
            Console.WriteLine("Maksymalna wartość: " + stats.maxGrade);
            Console.WriteLine("Minimalna wartość: " + stats.minGrade);

            StudentDiary diary2 = new StudentDiary();
            diary2.AddRating(5.5f);
            diary2.AddRating(6.5f);
            diary2.AddRating(2.7f);

            stats = diary2.ComputeStatistic();
            Console.WriteLine("Średnia wartość: " + stats.averaGrade);
            Console.WriteLine("Maksymalna wartość: " + stats.maxGrade);
            Console.WriteLine("Minimalna wartość: " + stats.minGrade);

            Console.ReadKey();

            //for (;;)
            //{
            //    Console.WriteLine("Podaj ocenę z zakresu 1 - 10");
            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(), out rating);


            //    if(rating == 11)
            //    {
            //        break;
            //    }

            //    if (result)
            //    {
            //        diary.AddRating(rating);
            //    }
            //}
            //Console.WriteLine("Srednia Twoich ocen to: " + diary.CalculateAverage());
            //Console.WriteLine("Najwyzsza Twoja ocena to: " + diary.GiveMaxRating());
            //Console.WriteLine("Najniższa Twoja ocena to: " + diary.GiveMinRating());

        }
    }
}
