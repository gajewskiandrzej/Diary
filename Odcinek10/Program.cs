using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDiary diary = new StudentDiary();
            diary.AddRating(3);
            diary.AddRating(5);

            StudentDiary diary2 = diary;
            diary2.AddRating(4);

            StudentDiary diary3 = diary2;
            diary3.AddRating(8);
        }
    }
}
