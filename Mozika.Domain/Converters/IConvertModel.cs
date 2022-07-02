namespace Mozika.Domain.Converters
{
    public interface IConvertModel<TSource, TTarget>
    {
        TTarget Convert();
    }
}