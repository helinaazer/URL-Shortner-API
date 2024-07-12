using UrlShortner;

namespace UrlShortner.Helper;

public class DataMock
{
    public static readonly List<User> Users =
    [
        new User { FirstName = "Nora", LastName = "Simmons", Email = "email1@gmail.com", Password = "tnejsnXtVjhYOwQZ7zRu0bcOooUrRQmGu5v3Wii4WrS29vZ7/m61VcxtVrxWSQTK19zyHBV7cj4tKjw/AT+Vbg==", PasswordSalt = "S@lt1234WithLongerRandom", Roles = ["Software Developer", "Data Analyst"] },
        new User { FirstName = "Elijah", LastName = "Parker", Email = "email2@gmail.com", Password = "Osv1ilESBRT1BswiyW3YRZS9o6+EMd4hbfkKkZVqk++ie+rmVuvqk5V5Wif3kYbviHRBJ9xefvJJhKIjd7xwjQ==", PasswordSalt = "R4nd0mS@ltForExtraSecurity", Roles = ["Product Manager"] },
        new User { FirstName = "Grace", LastName = "Mitchell", Email = "email3@gmail.com", Password = "XX1OrOeM+8Bw50ZbQU5Ngu+8ZnaX2YWactkRVmFEvCr7KRqbNAqtBBpZz5OboFu7DLfVvP1sN5N0mprrWE6oFg==", PasswordSalt = "SecureSalt5WithThirtyDigits", Roles = ["Data Analyst"] },
        new User { FirstName = "Henry", LastName = "Foster", Email = "email4@gmail.com", Password = "mIJliri/Y+5NqptFoE3LjXgm7a24ha45HSLk7IDlyhbDuJuZyG56L+zg0zF/ZTL192D56LWCbU3qbRuHx+6ozA==", PasswordSalt = "P@ssw0rdSaltIsReallyLong", Roles = ["Software Developer"] },
        new User { FirstName = "Scarlett", LastName = "Adams", Email = "email5@gmail.com", Password = "cKi/EOwVg1CgT8qHznyTWhfU2DH2nCRdFpvku9FYBkHpC/Cd5bwtzmOwJAOwmWWLCNTMd11QVC7g+72pxxHBPA==", PasswordSalt = "SaltySecret9WithMoreDigits", Roles = ["Data Analyst"] },
        new User { FirstName = "Lucas", LastName = "Bennett", Email = "email6@gmail.com", Password = "mmT+6eddUpDsaiAmO6GTGzCBMCUp8CAgJ8Q4v588uVd6PIzWQUwPv2KIxE5vf1RCP8lFcVfFXhMnp7z0epEDiw==", PasswordSalt = "SaltedPass7ForBetterProtection", Roles = ["Software Developer"] },
        new User { FirstName = "Chloe", LastName = "Turner", Email = "email7@gmail.com", Password = "0NFO7AdIFzEYcR1N7HIRlv4JTqi2i35ifKyg00F/PfISVyTC8onropAwAvh60yTfngtmJ6L/2Pj2/0B4jvBExQ==", PasswordSalt = "RandomSalt2WithThirtyCharacters", Roles = ["Product Manager"] },
        new User { FirstName = "Jackson", LastName = "Hayes", Email = "email8@gmail.com", Password = "JY3r4KpgvD2R61JdIdtNC8kScBZc8Tv6iwqHAnBF/4D/GW61/4jXE/nwlYHlDiGTlWVwKvfnII49KPC8zWnDhg==", PasswordSalt = "S@ltY0urP@ssWithExtendedLength", Roles = ["Cybersecurity Analyst"] },
        new User { FirstName = "Lily", LastName = "Morgan", Email = "email9@gmail.com", Password = "6Mh1mDLK6sXeNWvBOYP9A8/CIg93+mwuMNCRFW4K5WbIxjxU7Ws/beYu8RjSjCPpoT1ZeGSdRISmV+pv/KU5qA==", PasswordSalt = "123Salt456AndStillThirtyChars", Roles = ["Cybersecurity Analyst"] },
        new User { FirstName = "Owen", LastName = "Carter", Email = "email0@gmail.com", Password = "GlgrR1YQK8kowlWBGkJTnbZ1nruKh01s2ohvT1bsYknPnro2kFlmPl0um8QYxFxtIZiQCTSU72Q54iexxMiHvw==", PasswordSalt = "SecretS@ltWithThirtyDigits", Roles = ["Product Manager", "Data Analyst"] },
        new User { FirstName = "Helina", LastName = "Azer", Email = "helina_azer@hotmail.com", Password = "AeIY7ykctzlnHdIgCXol0pUqCc/K/cn6RR91LbslKJrO16cfNQDKR7zp64UMVDF53JWGnqqDp96w1o0N9FF3OQ==", PasswordSalt = "SaltAndPepper!ThirtyCharacters", Roles = ["Software Developer"] },
    ];

    public static readonly List<string> Roles =
    [
        "Software Developer",
        "Product Manager",
        "Data Analyst",
        "Cybersecurity Analyst"
    ];

    public static readonly List<string> Permissions =
    [
        "AccessCode",
        "MergeCode",
        "Deploy",
        "AccessTools",
        "CreateProduct",
        "ManageProduct",
        "AccessDatabase",
        "RunQueries",
        "AccessSecurityTools",
        "ConductAssessment",
        "RespondToIncidents",
    ];

    public static readonly List<(string Role, string Permission)> RolesPermissionsMatrix =
    [
        ("Software Developer", "AccessCode"),
        ("Software Developer", "MergeCode"),
        ("Software Developer", "Deploy"),
        ("Software Developer", "AccessTools"),
        ("Product Manager", "AccessTools"),
        ("Product Manager", "CreateProduct"),
        ("Product Manager", "ManageProduct"),
        ("Data Analyst", "AccessDatabase"),
        ("Data Analyst", "RunQueries"),
        ("Data Analyst", "AccessTools"),
        ("Cybersecurity Analyst", "AccessSecurityTools"),
        ("Cybersecurity Analyst", "ConductAssessment"),
        ("Cybersecurity Analyst", "RespondToIncidents")
    ];

    public static User? GetUserByEmail(string email)
    {
        return Users.FirstOrDefault(user => user.Email!.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
}
