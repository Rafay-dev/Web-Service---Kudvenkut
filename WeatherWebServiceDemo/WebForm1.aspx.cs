using System;
namespace WeatherWebServiceDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // LC:7 -1
        protected void btnGetWeather_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSoapClient client = new WeatherService.WeatherSoapClient("WeatherSoap");
            WeatherService.WeatherReturn result = client.GetCityWeatherByZIP(txtZip.Text);

            if (result.Success)
            {
                lblError.Text = "";
                lblCity.Text = result.City;
                lblState.Text = result.State;
                lblTemperature.Text = result.Temperature;
                lblWind.Text = result.Wind;
                lblWeatherStationCity.Text = result.WeatherStationCity;
            }
            else
            {
                lblError.Text = result.ResponseText;
                lblCity.Text = "";
                lblState.Text = "";
                lblTemperature.Text = "";
                lblWind.Text = "";
                lblWeatherStationCity.Text = "";
            }
        }
    }
}