using System.Collections;
using System.Collections.Generic;

namespace Item14
{
    public class Item14Tester
    {
        public void Main(){
            IEnumerable weatherDatas = new WeatherDataStream();
            weatherDatas.GetEnumerator();
        }
    }

    public class WeatherData
    {
        
        public double Temperature { get;  }
        public int WindSpeed { get;  }
        
        public WeatherData(double temp,int wind)
        {
            Temperature = temp;
            WindSpeed = wind;
        }
        
    }

    public class WeatherDataStream : IEnumerable<WeatherData>
    {
        public IEnumerator<WeatherData> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}