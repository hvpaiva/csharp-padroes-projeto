namespace Facade
{
    public class HomeTheaterFacade
    {
        private Dimmer _dimmer;
        private Dvd _dvd;
        private DvdPlayer _dvdPlayer;

        public HomeTheaterFacade(Dimmer dimmer, Dvd dvd, DvdPlayer dvdPlayer)
        {
            _dimmer = dimmer;
            _dvd = dvd;
            _dvdPlayer = dvdPlayer;
        }

        public void WatchShow()
        {
            _dimmer.Dim(5);
            _dvdPlayer.On();
            _dvdPlayer.Insert(_dvd);
            _dvdPlayer.Play();
        }

        public void Pause()
        {
            _dimmer.Dim(10);
            _dvdPlayer.Pause();
        }

        public void Resume()
        {
            _dimmer.Dim(5);
            _dvdPlayer.Resume();
        }

        public void TurnOffShow()
        {
            _dimmer.Dim(10);
            _dvdPlayer.Off();
        }
    }
}