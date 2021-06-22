using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherPJ
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

        }
        public List<Weather> Weathers { get => WeatherData(); }
        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "42", Date = "Sunday 16", Icon = "weather,png" });
            tempList.Add(new Weather { Temp = "40", Date = "Monday 16", Icon = "weather,png" });
            tempList.Add(new Weather { Temp = "32", Date = "Tuesday 16", Icon = "weather,png" });
            tempList.Add(new Weather { Temp = "38", Date = "Wednesday 16", Icon = "weather,png" });
            tempList.Add(new Weather { Temp = "24", Date = "Friday 16", Icon = "weather,png" });
            tempList.Add(new Weather { Temp = "30", Date = "Saturday 16", Icon = "weather,png" });
            tempList.Add(new Weather { Temp = "36", Date = "Sunday 16", Icon = "weather,png" });

            return tempList;
        }

        public class Weather
        {
            public string Temp { get; set; }
            public string Date { get; set; }
            public string Icon { get; set; }
        }
    }
}
