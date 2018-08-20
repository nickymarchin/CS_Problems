using System;

namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterSeconds = int.Parse(Console.ReadLine());
            int percentageOfGood = int.Parse(Console.ReadLine());
            int uploadSeconds = int.Parse(Console.ReadLine());

            int filteredPictures = (int)Math.Ceiling(totalPictures * (percentageOfGood / 100.0));
 
            int filterTime = totalPictures * filterSeconds;
            int uploadTime = filteredPictures * uploadSeconds;

            long total = filterTime + uploadTime;

            //Console.WriteLine($"{totalTime / 86400:D1}:{totalTime / 3600:D2}:{(totalTime / 60) % 60:D2}:{totalTime % 60:D2}");

            long seconds = 0;
            long minutes = 0;
            long hours = 0;
            long days = 0;

            seconds = total % 60;
            total = total - seconds;
            hours = total / 3600;
            minutes = total / 60 - hours * 60;
            days = hours / 24;
            hours = total / 3600 - days * 24;

            Console.WriteLine("{0}:{1}:{2}:{3}", days.ToString("0"), hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"));

        }
    }
}
