using Arentheym.EnergieVergelijker.Domain;

namespace Arentheym.EnergieVergelijker.Application;

public class Login
{
    private readonly Vergelijker _vergelijker = new();

    public string Code { get; set; } = string.Empty;

    public bool CodeExists(string code)
    {
        if (!_vergelijker.CodeExists(code))
        {
            return false;
        }

        Code = code;
        return true;
    }
}
