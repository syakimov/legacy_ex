using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestLectureSchedule
{
    class Lecture
    {

        public Lecture(string name,int startTime,int endTime)
        {
            this.LectureName = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public string LectureName { get; set; }

        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public override string ToString()
        {
            return string.Format("( {0}-{1} ) -> {2}", StartTime, EndTime, LectureName);
        }

    }
}
