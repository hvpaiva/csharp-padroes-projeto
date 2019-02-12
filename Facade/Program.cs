using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimmer = new Dimmer();
            var dvdPlayer = new DvdPlayer();
            var dvd = new Dvd("Gorillaz");
            var homeTheater = new HomeTheaterFacade(dimmer, dvd, dvdPlayer);
            
            homeTheater.WatchShow();
            homeTheater.Pause();
            homeTheater.Resume();
            homeTheater.TurnOffShow();
        }
    }
}