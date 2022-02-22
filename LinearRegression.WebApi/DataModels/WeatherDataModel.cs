using Microsoft.ML.Data;

namespace LinearRegression.WebApi.DataModels
{
    public class WeatherModelInput
    {
        [ColumnName(@"Summary")]
        public string Summary { get; set; }

        [ColumnName(@"Precip Type")]
        public string PrecipType { get; set; }

        [ColumnName(@"Humidity")]
        public float Humidity { get; set; }

        [ColumnName(@"Wind Speed (km/h)")]
        public float WindSpeed { get; set; }

        [ColumnName(@"Wind Bearing (degrees)")]
        public float WindBearing { get; set; }

        [ColumnName(@"Visibility (km)")]
        public float Visibility { get; set; }

        [ColumnName(@"Pressure (millibars)")]
        public float Pressure { get; set; }
    }

    public class WearherModelOutput
    {
        [ColumnName(@"Score")]
        public float Temperature { get; set; }
    }
}
