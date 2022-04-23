namespace FuzzySharp.PreProcess
{
    public interface IProcessLanguage<T>
    {
        string Sanitize(T input);
    }
}