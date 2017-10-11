using Flunt.Validations;

namespace Flunt.Specifications
{
    public interface ISpecification
    {
        ValidationContract Contract { get; }
    }
}