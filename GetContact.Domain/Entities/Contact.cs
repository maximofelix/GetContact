using GetContact.Domain.ValueObjects;
using System.Text.RegularExpressions;

namespace GetContact.Domain.Entities;


public class Contact
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; private set; }
    public Region Region { get; private set; }
    public string Phone { get; private set; }
    public string? Email { get; private set; }

    // For Entity Framework Core - Migration updated needed
    protected Contact() { }

    public static Contact Create(string name, int dddCode, string phone, string? email = null)
    {
        return new Contact
        {
            Name = name,
            Region = Region.Create(dddCode),
            Phone = phone,
            Email = email
        };
    }
}
