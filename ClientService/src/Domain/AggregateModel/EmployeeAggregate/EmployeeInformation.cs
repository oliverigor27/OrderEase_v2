using OrderEase.ClientService.Domain.SeedWork;

namespace OrderEase.ClientService.Domain.AggregateModel.EmployeeAggregate;

public sealed class EmployeeInformation : BaseEntity
{
    internal EmployeeInformation(
        string name, 
        string lastName, 
        DateTime birthDate, 
        Address address
    )
    {
        Name = name;
        LastName = lastName;
        BirthDate = birthDate;
        Address = address;
    }

    public string Name { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public Address Address { get; private set; }

    internal void UpdateEmployee(
        string name,
        string lastName,
        string birthDate,
        Address address
    ) 
    {
        Name = name;
        LastName = lastName;
        BirthDate = DateTime.Parse(birthDate);
        Address = address;
    }
}
