using Microsoft.ML.Data;

namespace LinearRegression.WebApi.DataModels
{
    public class TaxiFareModelInput
    {
        [ColumnName(@"vendor_id")]
        public string VendorId { get; set; }

        [ColumnName(@"rate_code")]
        public float RateCode { get; set; }

        [ColumnName(@"passenger_count")]
        public float PassengerCount { get; set; }


        [ColumnName(@"trip_distance")]
        public float TripDistance { get; set; }

        [ColumnName(@"payment_type")]
        public string PaymentType { get; set; }

    }

    public class TaxiFareModelOutput
    {
        [ColumnName(@"Score")]
        public float FareAmount { get; set; }
    }
}
