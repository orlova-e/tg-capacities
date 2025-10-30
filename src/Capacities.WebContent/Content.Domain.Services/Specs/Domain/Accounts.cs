using Content.Domain.Core.Entities;

namespace Content.Domain.Services.Specs.Domain;

public static class Accounts
{
    public static Spec<Account> ByName(string name) => new(x => x.Name == name);
    
    public static Spec<Account> ByTelegramId(long telegramId) => new(x => x.TelegramId == telegramId);
}