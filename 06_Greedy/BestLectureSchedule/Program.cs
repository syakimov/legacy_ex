using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestLectureSchedule
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lectureLine = Console.ReadLine().Split(' ');
            int numberOfLectures = int.Parse(lectureLine[1]);


            Lecture[] lectures = new Lecture[numberOfLectures];
            for (int i = 0; i < numberOfLectures; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int sTime = int.Parse(line[1]);
                int endTime = int.Parse(line[3]);
                string name = line[0].Substring(0, line[0].Length - 1);

                lectures[i] = new Lecture(name, sTime, endTime);
            }

            var orderedLectures = lectures.OrderBy(x => x.EndTime);

            int startTime = 0;
            var schedule = new List<Lecture>();

            foreach (var lecture in orderedLectures)
            {
                if (lecture.StartTime >= startTime)
                {
                    schedule.Add(lecture);
                    startTime = lecture.EndTime;
                }
            }

            Console.WriteLine("Lectures ({0})",schedule.Count);
            Console.WriteLine(string.Join("\n", schedule));
        }
    }
}
