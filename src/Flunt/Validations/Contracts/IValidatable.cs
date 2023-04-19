namespace Flunt.Validations.Contracts;

public interface IValidatable
{
    /// <summary>
    /// Method to apply a contract and validate the object
    /// </summary>
    void Validate();
}