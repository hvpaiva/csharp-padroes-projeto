using System;

namespace Facade
{
    public class DvdPlayer
    {
        private Dvd _dvd;
        private int _time;
        private bool _isOn;

        public void On()
        {
            if (_isOn)
            {
                Console.WriteLine("Player já está ligado.");
            }
            else
            {
                _isOn = true;
                Console.WriteLine("Ligando o player.");
            }
        }

        public void Insert(Dvd dvd)
        {
            if (!_isOn) return;

            if (_dvd != null)
            {
                Console.WriteLine($"O Dvd de {_dvd.Banda} já está no player.");
            }
            else
            {
                _dvd = dvd;
                Console.WriteLine($"Inserindo o Dvd de {dvd.Banda}");
            }
        }

        public void Eject()
        {
            if (!_isOn) return;

            if (_dvd == null)
            {
                Console.WriteLine("Nenhum Dvd no Dvd Player.");
            }
            else
            {
                Console.WriteLine($"Ejetando {_dvd.Banda}");
                _dvd = null;
            }
        }

        public void Play()
        {
            if (!_isOn) return;

            Console.WriteLine(_dvd == null ? "Nenhum Dvd no player." : $"Tocando dvd de {_dvd.Banda}");
        }

        public void Pause()
        {
            if (!_isOn) return;
            
            Console.WriteLine($"Pausando em {_time = (new Random()).Next(_time, _time + 120)}");
        }

        public void Resume()
        {
            if (!_isOn) return;
            
            Console.WriteLine($"Despausando em {_time}");
        }

        public void Off()
        {
            if (!_isOn) return;
            
            if (_dvd != null)
            {
                Eject();
            }

            Console.WriteLine("Desligando DvdPlayer");
        }
    }
}