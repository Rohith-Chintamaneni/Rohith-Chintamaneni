using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    class MeetingRooms2
    {
        // Chronological Order: We individually sort the start time and end time. Even though we lose the identity of interval.When we encounter an ending event, that means that some meeting that started earlier has ended now. We are not really concerned with which meeting has ended. All we need is that some meeting ended thus making a room available. 
        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals, (i1, i2) => i1[0] - i2[0]); // sorted by start time
            int[] starttime_Intervals = new int[intervals.Length];
            int[] endtime_Intervals = new int[intervals.Length];
            int i = 0;
            // individually split start time
            foreach (var stInterval in intervals)
            {
                starttime_Intervals[i] = stInterval[0]; // insert start times
               
                i++;
            }

            i = 0;
            Array.Sort(intervals, (i1, i2) => i1[1] - i2[1]); // sorted by endtime
            // individually split end time
            foreach (var stInterval in intervals)
            {
                endtime_Intervals[i] = stInterval[1]; // insert end times
                i++;
            }

            int st_pointer =0, ed_pointer =0;
            int countofrooms = 0;
            while (st_pointer < starttime_Intervals.Length)
            {
                if (starttime_Intervals[st_pointer] >= endtime_Intervals[ed_pointer])
                {
                    countofrooms--;
                    ed_pointer++;
                }

                countofrooms++;
                st_pointer++;
            }

            return countofrooms;
        }
    }
}
