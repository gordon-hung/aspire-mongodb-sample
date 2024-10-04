namespace Aspire.MongoDBSample.Core;

public interface IPasswordHasher
{
    public string HashPassword(string plainPassword);

    public bool VerifyPassword(string plainPassword, string hashedPassword);
}
