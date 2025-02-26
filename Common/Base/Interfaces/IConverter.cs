using Common.Model.Base;

namespace Common.Base.Interfaces
{
    public interface IConverter<T> where T : IConvertOption
    {
        double Convert(T convertOptions);
    }
}
