using System;

namespace MovieTicketApp
{
    public class Sessions
    {
        public int MovieId { get; set; } // Add a public setter for movieId
        public DateTime Time1 { get; set; } // Add public setter for session1
        public DateTime Time2 { get; set; } // Add public setter for session2
        public DateTime Time3 { get; set; } // Add public setter for session3
        public DateTime Time4 { get; set; } // Add public setter for session4
        public DateTime Time5 { get; set; } // Add public setter for session5
        public int TotalAvailableSeats { get; set; } // Add public setter

        public Sessions() { 

        }

        public Sessions(int movieId, DateTime time1, DateTime time2, DateTime time3, DateTime time4, DateTime time5, int totalAvailableSeats)
        {
            this.MovieId = movieId;
            this.Time1 = time1;
            this.Time2 = time2;
            this.Time3 = time3;
            this.Time4 = time4;
            this.Time5 = time5;
            this.TotalAvailableSeats = totalAvailableSeats;
        }
    }
}
