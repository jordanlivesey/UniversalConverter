using Common.Base.Interfaces;
using Common.Model.Base;

namespace Common.Base
{
    public abstract class ConverterBase : IConverter<IConvertOption>
    {
        public abstract double Convert(IConvertOption convertOptions);
    }
}
