using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class PatientDatabase
    {
        private Random _random = new Random();
        private double RandomInt
        {
            get => _random.Next(35, 40)+Math.Round(_random.NextDouble(),1);
        }
        internal List<Weather> Weathers { get; private set; }

        public void Initialize()
        {
            Weathers = new List<Weather>
            {
                new Weather(RandomInt, MeasureUnits.Celsius, new Patient("Костя")),
                new Weather(RandomInt, MeasureUnits.Celsius, new Patient("Миша")),
                new Weather(RandomInt, MeasureUnits.Fahrenheit, new Patient("Слава")),
                new Weather(RandomInt, MeasureUnits.Kelvin, new Patient("Даниил")),
                new Weather(RandomInt, MeasureUnits.Celsius, new Patient("Настя")),
                new Weather(RandomInt, MeasureUnits.Celsius, new Patient("Оля")),
                new Weather(RandomInt, MeasureUnits.Kelvin, new Patient("Коля")),
                new Weather(RandomInt, MeasureUnits.Celsius, new Patient("Саша")),
                new Weather(RandomInt, MeasureUnits.Celsius, new Patient("Артём"))
            };
        }
    }
}