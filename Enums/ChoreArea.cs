using System.Text.Json.Serialization;

namespace ChoreScore.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreArea
{
  Kitchen,
  Bedroom,
  LivingRoom,
  Porch
}