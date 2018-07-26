using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker
    {
        public String currentConditions;
        public Phone phone;
        public Emailer emailer;

        public WeatherTracker()
        {
            phone = new Phone();
            emailer = new Emailer();
        }

        
        public void setCurrentConditions(String weatherDescription)
        {
            this.currentConditions = weatherDescription;
            if (weatherDescription == "rainy")
            {
                generateweatherAlter(weatherDescription);
            }
            if (weatherDescription == "sunny")
            {
                generateweatherAlter(weatherDescription);
            }
        }

        private void generateweatherAlter(String weatherDescription)
        {
            String alert = phone.generateWeatherAlert(weatherDescription);
            Console.WriteLine(alert);
        }
    }
}
