using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Trener;

public class IStrikeJsonConverter : JsonConverter<List<IStrike>>
{
    public override List<IStrike> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var strikesList = new List<IStrike>();
            foreach (var element in doc.RootElement.EnumerateArray())
            {

                if (!element.TryGetProperty("type", out var typeProperty))
                {
                    throw new JsonException("Missing 'type' property in strike element");
                }
                var type = element.GetProperty("type").GetString();

                IStrike strike;
                if (type == "punch")
                {
                    strike = JsonSerializer.Deserialize<PunchClass>(element.GetRawText(), options);
                }
                else if (type == "move")
                {
                    strike = JsonSerializer.Deserialize<MoveClass>(element.GetRawText(), options);
                }
                else if (type == "defence")
                {
                    strike = JsonSerializer.Deserialize<DefenceClass>(element.GetRawText(), options);
                }
                else if (type == "advice")
                {
                    strike = JsonSerializer.Deserialize<AdviceClass>(element.GetRawText(), options);
                }
                else
                {
                    throw new JsonException($"Unknown strike type: {type}");
                }

                strikesList.Add(strike);
            }

            return strikesList;
        }
    }

    public override void Write(Utf8JsonWriter writer, List<IStrike> value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
