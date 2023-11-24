using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FlightManagement_API.Converters
{
    public class CustomDateTimeConverter(string dateFormat) : JsonConverter<DateTime>
    {


        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString(), dateFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime dateTimeValue, JsonSerializerOptions options)
        {
            writer.WriteStringValue(dateTimeValue.ToString(dateFormat));
        }
    }
}
