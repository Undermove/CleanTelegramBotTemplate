// ReSharper disable PropertyCanBeMadeInitOnly.Global
namespace Domain.New.Entities;

public class User
{
    public string UserId { get; set; } = null!;
    public long TelegramId { get; set; }
}