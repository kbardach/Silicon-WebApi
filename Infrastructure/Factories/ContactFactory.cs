using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class ContactFactory
{

    public static ContactEntity CreateContactEntity(Contact model)
    {
        try
        {
            return new ContactEntity
            {
                FullName = model.FullName,
                EmailAddress = model.EmailAddress,
                Service = model.Service,
                Message = model.Message,
                Created = DateTime.Now,
            };
        }
        catch { }
        return null!;
    }

}
