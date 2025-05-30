using Arentheym.EnergieVergelijker.Domain;

namespace Application;

public class Login
{
    private readonly Vergelijker _vergelijker = new();

    public bool CodeExists(string code)
    {
        return _vergelijker.CodeExists(code);
    }

    public void Search()
    {
        var result = _vergelijker.Search(new SearchFilter());
    }
}
