using System.Text.Json;
using System.Text.Json.Serialization;

public record CreateChannelRequest(string Name, bool Enabled);

public class CreateChannelRequestConverter : JsonConverter<CreateChannelRequest>
{
    public override CreateChannelRequest? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        return new CreateChannelRequest("test", true);
    }

    public override void Write(Utf8JsonWriter writer, CreateChannelRequest value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(JsonSerializer.Serialize(value));
    }
}
