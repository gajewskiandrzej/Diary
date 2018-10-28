using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class StudentDiary
    {
        public StudentDiary()
        {
            ratings = new List<float>();
        }

        //Stan (zmienne - pola)
        List<float> ratings;

        //Zachowania - metody
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        //public float CalculateAverage()
        //{
        //    float sum = 0, avg = 0;

        //    foreach (var rating in ratings)
        //    {
        //        sum += rating;
        //    }
        //    avg = sum / ratings.Count;
        //    return avg;
        //}

        internal DiaryStatistics ComputeStatistic()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.averaGrade = sum / ratings.Count;
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();

            return stats;
        }

        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}

        //public float GiveMinRating()
        //{
        //    return ratings.Min();
        //}
    }
}
