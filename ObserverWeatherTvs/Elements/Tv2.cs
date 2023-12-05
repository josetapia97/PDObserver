using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverWeatherTvs.Elements
{
    public class Tv2 : IObserver
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private string _name = "TV2";
        public void Update(float temperature, float humidity, float pressure)
        {
            _humidity = humidity;
            _pressure = pressure;
            _temperature = temperature;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"From {_name}: current conditions: {_temperature}F, degrees and {_humidity}% humidity");
        }
    }
}
