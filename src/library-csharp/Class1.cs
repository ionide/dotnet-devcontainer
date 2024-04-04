namespace library_csharp;

public class Class1
{
    public static string GetMessage()
    {
        return library_fsharp.Say.hello("from library-csharp");
    }
}
