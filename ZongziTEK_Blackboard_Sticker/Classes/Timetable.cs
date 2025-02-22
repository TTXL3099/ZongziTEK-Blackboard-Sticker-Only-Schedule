﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZongziTEK_Blackboard_Sticker
{
    public class Timetable
    {
        public List<Lesson> Monday { get; set; }
        public List<Lesson> Tuesday { get; set; }
        public List<Lesson> Wednesday { get; set; }
        public List<Lesson> Thursday { get; set; }
        public List<Lesson> Friday { get; set; }
        public List<Lesson> Saturday { get; set; }
        public List<Lesson> Sunday { get; set; }
    }

    public class Lesson
    {
        public string Subject { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Lesson(string subject, TimeSpan startTime, TimeSpan endTime)
        {
            Subject = subject;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
