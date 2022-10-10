namespace ApplicationLicense;

class Program
{
    static void Main()
    {
        Console.WriteLine("Тип ключа: ");
        var key = Console.ReadLine();

        var license = new ApplicationLicense(key);

        if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Pro)
        {
            Console.WriteLine("Pro функцію доступно");
        }

        if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Trial)
        {
            Console.WriteLine("Trial функцію доступно ");
        }

        if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Free)
        {
            Console.WriteLine("Free функцію доступно");
        }
    }
}

