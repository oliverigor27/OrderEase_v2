using OrderEase.ClientService.Domain.SeedWork;

namespace OrderEase.ClientService.Domain.AggregateModel.EmployeeAggregate;

public sealed class Address : ValueObject
{
    internal Address()
    {
        FullAddress = string.Empty;
        City = string.Empty;
        State = string.Empty;
        Country = string.Empty;
    }

    internal Address(
        string fullAddress, 
        string city, 
        string state, 
        string country
    )
    {
        FullAddress = fullAddress;
        City = city;
        State = state;
        Country = country;
    }

    public string FullAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FullAddress;
        yield return City;
        yield return State;
        yield return Country;
    }
}
