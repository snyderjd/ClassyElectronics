using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    public class Radionator4001 : Speakanator3001
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }
        public bool IsRadioOn { get; set; }

        public Radionator4001()
        {
            FavoriteStations = new List<double>();
        }

        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }

        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }

        public void TurnRadioOn()
        {
            IsRadioOn = true;
        }

        public void TurnRadioOFf()
        {
            IsRadioOn = false;
        }
    }
}