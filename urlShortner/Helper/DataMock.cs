using UrlShortner;

namespace UrlShortner.Helper;

public class DataMock
{
    public static readonly List<User> Users =
    [
        new User { FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Password = "password123", PasswordSalt = "a0eebc999c0b4ef8bb6d6bb9bd380a11", Roles = ["Emperor", "Priest"] },
        new User { FirstName = "Bob", LastName = "Smith", Email = "bob.smith@example.com", Password = "password456", PasswordSalt = "1c3e7bda9e5b4c7cb47d6d79f530d117", Roles = ["Deacon"] },
        new User { FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@example.com", Password = "password789", PasswordSalt = "2b2d4e4b3c6d4d8ab9a56e14c3d7a1ff", Roles = ["Grand Wizard"] },
        new User { FirstName = "David", LastName = "Lee", Email = "david.lee@example.com", Password = "securepass", PasswordSalt = "3a6f2c6d2e9b4f9ba5d56c11c6b7a2aa", Roles = ["Space Cowboy"] },
        new User { FirstName = "Emma", LastName = "Wilson", Email = "emma.wilson@example.com", Password = "password321", PasswordSalt = "4b7e3e5a1d8b4e8cb9c56a10b7c3a3ee", Roles = ["Supreme Overlord"] },
        new User { FirstName = "Frank", LastName = "Davis", Email = "frank.davis@example.com", Password = "pass1234", PasswordSalt = "5c8f3f4b0f9b4d7bb8a56e12c5d7a4ff", Roles = ["Chief Happiness Officer"] },
        new User { FirstName = "Grace", LastName = "Martinez", Email = "grace.martinez@example.com", Password = "secure123", PasswordSalt = "6d9f4d4b0e8b4c7bb6a56c14c6b7a3ff", Roles = ["Emperor"] },
        new User { FirstName = "Henry", LastName = "Garcia", Email = "henry.garcia@example.com", Password = "password987", PasswordSalt = "7e1f5e5a0d7b4f9bb7c56e16c5d7b2aa", Roles = ["Priest"] },
        new User { FirstName = "Robert", LastName = "Lopez", Email = "isabella.lopez@example.com", Password = "pass4567", PasswordSalt = "8f2f6f6b0c6b4e9bb9a56a18c3b7b1ff", Roles = ["Deacon"] },
        new User { FirstName = "Jack", LastName = "Taylor", Email = "jack.taylor@example.com", Password = "pass6789", PasswordSalt = "9a3f7g7b0b5b4d7bb8a56c19c4d7a2ff", Roles = ["Grand Wizard"] },
        new User { FirstName = "Katherine", LastName = "Clark", Email = "katherine.clark@example.com", Password = "secure567", PasswordSalt = "1b4f8h8b0a4b4c9bb7a56e20c4d7b3aa", Roles = ["Space Cowboy"] },
        new User { FirstName = "Liam", LastName = "Lewis", Email = "liam.lewis@example.com", Password = "password890", PasswordSalt = "2c5f9i9b0b3b4d8bb6a56a21c3b7a4ee", Roles = ["Supreme Overlord"] },
        new User { FirstName = "Mia", LastName = "Moore", Email = "mia.moore@example.com", Password = "pass8901", PasswordSalt = "3d6f0j0b0c2b4e7bb5a56c22c2b7b1ff", Roles = ["Chief Happiness Officer"] },
    ];

    public static readonly List<string> Roles =
    [
        "Emperor",
        "Priest",
        "Deacon",
        "Grand Wizard",
        "Space Cowboy",
        "Supreme Overlord",
        "Chief Happiness Officer"
    ];

    public static readonly List<string> Permissions =
    [
        "AddCustomer",
        "EditCustomer",
        "DeleteCustomer",
        "ViewCustomerDetails",
        "ManageInventory",
        "PlaceOrders",
        "ManagePayments",
        "ViewReports",
        "AssignTasks",
        "ApproveExpenses",
        "ScheduleMeetings",
        "ManageProjects",
        "AccessSensitiveData",
        "GenerateReports",
        "ModerateDiscussions"
    ];

    public static readonly List<(string Role, string Permission)> RolesPermissionsMatrix =
    [
        ("Priest", "AddCustomer"),
        ("Priest", "EditCustomer"),
        ("Priest", "DeleteCustomer"),
        ("Priest", "ViewCustomerDetails"),
        ("Priest", "ManageInventory"),
        ("Priest", "PlaceOrders"),
        ("Priest", "ManagePayments"),
        ("Priest", "ViewReports"),
        ("Priest", "AssignTasks"),
        ("Emperor", "ApproveExpenses"),
        ("Emperor", "ScheduleMeetings"),
        ("Emperor", "ManageProjects"),
        ("Emperor", "AccessSensitiveData"),
        ("Deacon", "ScheduleMeetings"),
        ("Deacon", "AccessSensitiveData"),
        ("Grand Wizard", "GenerateReports"),
        ("Grand Wizard", "ModerateDiscussions"),
        ("Grand Wizard", "ViewReports"),
        ("Space Cowboy", "ViewCustomerDetails"),
        ("Space Cowboy", "ManageInventory"),
        ("Space Cowboy", "PlaceOrders"),
        ("Supreme Overlord", "ApproveExpenses"),
        ("Supreme Overlord", "ManageProjects"),
        ("Chief Happiness Officer", "ViewReports"),
        ("Chief Happiness Officer", "AssignTasks"),
        ("Chief Happiness Officer", "GenerateReports")
    ];

    public static User? GetUserByEmail(string email)
    {
        return Users.FirstOrDefault(user => user.Email!.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
}
