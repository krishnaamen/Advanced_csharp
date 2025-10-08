using static System.Net.Mime.MediaTypeNames;

namespace ExerciseInfo;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    public DateTime HireDate { get; set; }
    public bool IsActive { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Age}) - {Email}";
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public bool InStock { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public DateTime ReleaseDate { get; set; }
    public double Rating { get; set; }
    public List<string> Tags { get; set; } = new();

    public override string ToString()
    {
        return $"{Name} - ${Price} ({Category})";
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public Address Address { get; set; }
    public List<Order> Orders { get; set; } = new();
    public CustomerType Type { get; set; }
    public decimal TotalSpent { get; set; }
    public DateTime LastOrderDate { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}

public enum CustomerType
{
    Regular,
    Premium,
    VIP
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public decimal ShippingCost { get; set; }
    public decimal Tax { get; set; }
    public decimal Discount { get; set; }

    public decimal TotalAmount => Items.Sum(i => i.TotalPrice) + ShippingCost + Tax - Discount;
}

public class OrderItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;
}

public enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

public class Sale
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalAmount { get; set; }
    public string Region { get; set; }
    public string SalesPerson { get; set; }
}

public class SalesTarget
{
    public string Region { get; set; }
    public string Product { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal Target { get; set; }
    public decimal Actual { get; set; }
}

// Game Development Data
public enum EntityType { Player, Enemy, Item, Obstacle, NPC }
public enum GameEventType { PlayerMove, EnemySpawn, ItemCollect, LevelComplete }

public class GameEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EntityType Type { get; set; }
    public (int X, int Y) Position { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public Dictionary<string, object> Properties { get; set; } = new();
}

public static class TestData
{
    public static List<Person> GetPeople()
    {
        return new List<Person>
        {
            new Person { Id = 1, Name = "Alice Johnson", Age = 28, Email = "alice.johnson@email.com", City = "New York", Country = "USA", Salary = 75000, Department = "Engineering", HireDate = new DateTime(2020, 3, 15), IsActive = true },
            new Person { Id = 2, Name = "Bob Smith", Age = 35, Email = "bob.smith@email.com", City = "London", Country = "UK", Salary = 68000, Department = "Marketing", HireDate = new DateTime(2018, 7, 22), IsActive = true },
            new Person { Id = 3, Name = "Carol Brown", Age = 42, Email = "carol.brown@email.com", City = "Toronto", Country = "Canada", Salary = 92000, Department = "Engineering", HireDate = new DateTime(2015, 1, 10), IsActive = false },
            new Person { Id = 4, Name = "David Wilson", Age = 31, Email = "david.wilson@email.com", City = "Sydney", Country = "Australia", Salary = 71000, Department = "Sales", HireDate = new DateTime(2019, 9, 5), IsActive = true },
            new Person { Id = 5, Name = "Eva Davis", Age = 29, Email = "eva.davis@email.com", City = "Berlin", Country = "Germany", Salary = 69000, Department = "Engineering", HireDate = new DateTime(2021, 2, 18), IsActive = true },
            new Person { Id = 6, Name = "Frank Miller", Age = 45, Email = "frank.miller@email.com", City = "Paris", Country = "France", Salary = 85000, Department = "Management", HireDate = new DateTime(2012, 6, 3), IsActive = true },
            new Person { Id = 7, Name = "Grace Taylor", Age = 26, Email = "grace.taylor@email.com", City = "Tokyo", Country = "Japan", Salary = 63000, Department = "Design", HireDate = new DateTime(2022, 4, 12), IsActive = true },
            new Person { Id = 8, Name = "Henry Anderson", Age = 38, Email = "henry.anderson@email.com", City = "Stockholm", Country = "Sweden", Salary = 78000, Department = "Engineering", HireDate = new DateTime(2017, 11, 28), IsActive = true },
            new Person { Id = 9, Name = "Iris Thompson", Age = 33, Email = "iris.thompson@email.com", City = "Amsterdam", Country = "Netherlands", Salary = 72000, Department = "Marketing", HireDate = new DateTime(2019, 8, 14), IsActive = false },
            new Person { Id = 10, Name = "Jack White", Age = 27, Email = "jack.white@email.com", City = "Copenhagen", Country = "Denmark", Salary = 65000, Department = "Sales", HireDate = new DateTime(2021, 10, 7), IsActive = true }
        };
    }

    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Laptop Pro X1", Price = 1299.99m, Category = "Electronics", InStock = true, Quantity = 45, Brand = "TechCorp", ReleaseDate = new DateTime(2023, 3, 15), Rating = 4.5, Tags = new List<string> { "premium", "business", "performance" } },
            new Product { Id = 2, Name = "Wireless Headphones", Price = 199.99m, Category = "Electronics", InStock = true, Quantity = 120, Brand = "AudioMax", ReleaseDate = new DateTime(2023, 6, 10), Rating = 4.2, Tags = new List<string> { "wireless", "noise-cancelling", "portable" } },
            new Product { Id = 3, Name = "Gaming Chair", Price = 299.99m, Category = "Furniture", InStock = false, Quantity = 0, Brand = "ComfortPro", ReleaseDate = new DateTime(2022, 11, 20), Rating = 4.0, Tags = new List<string> { "gaming", "ergonomic", "adjustable" } },
            new Product { Id = 4, Name = "Coffee Maker Deluxe", Price = 89.99m, Category = "Appliances", InStock = true, Quantity = 75, Brand = "BrewMaster", ReleaseDate = new DateTime(2023, 1, 5), Rating = 4.3, Tags = new List<string> { "coffee", "automatic", "programmable" } },
            new Product { Id = 5, Name = "Smartphone Galaxy", Price = 799.99m, Category = "Electronics", InStock = true, Quantity = 60, Brand = "MobileTech", ReleaseDate = new DateTime(2023, 8, 22), Rating = 4.6, Tags = new List<string> { "smartphone", "5G", "camera" } },
            new Product { Id = 6, Name = "Desk Organizer", Price = 24.99m, Category = "Office", InStock = true, Quantity = 200, Brand = "OfficeEssentials", ReleaseDate = new DateTime(2023, 2, 14), Rating = 3.8, Tags = new List<string> { "organization", "desk", "storage" } },
            new Product { Id = 7, Name = "Fitness Tracker", Price = 149.99m, Category = "Electronics", InStock = true, Quantity = 85, Brand = "HealthTech", ReleaseDate = new DateTime(2023, 5, 30), Rating = 4.1, Tags = new List<string> { "fitness", "health", "wearable" } },
            new Product { Id = 8, Name = "Reading Lamp", Price = 45.99m, Category = "Lighting", InStock = true, Quantity = 90, Brand = "BrightLight", ReleaseDate = new DateTime(2022, 12, 8), Rating = 4.0, Tags = new List<string> { "LED", "adjustable", "reading" } },
            new Product { Id = 9, Name = "Bluetooth Speaker", Price = 79.99m, Category = "Electronics", InStock = false, Quantity = 0, Brand = "SoundWave", ReleaseDate = new DateTime(2023, 4, 18), Rating = 4.4, Tags = new List<string> { "bluetooth", "portable", "waterproof" } },
            new Product { Id = 10, Name = "Office Chair", Price = 199.99m, Category = "Furniture", InStock = true, Quantity = 30, Brand = "ComfortPro", ReleaseDate = new DateTime(2023, 7, 12), Rating = 3.9, Tags = new List<string> { "office", "ergonomic", "mesh" } }
        };
    }

    public static List<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Sarah Connor",
                Email = "sarah.connor@email.com",
                DateOfBirth = new DateTime(1985, 3, 12),
                PhoneNumber = "+1-555-0101",
                Address = new Address { Street = "123 Main St", City = "Los Angeles", State = "CA", ZipCode = "90210", Country = "USA" },
                Type = CustomerType.Premium,
                TotalSpent = 2450.75m,
                LastOrderDate = new DateTime(2023, 9, 15)
            },
            new Customer
            {
                Id = 2,
                Name = "John McClane",
                Email = "john.mcclane@email.com",
                DateOfBirth = new DateTime(1978, 7, 22),
                PhoneNumber = "+1-555-0102",
                Address = new Address { Street = "456 Oak Ave", City = "New York", State = "NY", ZipCode = "10001", Country = "USA" },
                Type = CustomerType.VIP,
                TotalSpent = 5890.25m,
                LastOrderDate = new DateTime(2023, 10, 1)
            },
            new Customer
            {
                Id = 3,
                Name = "Ellen Ripley",
                Email = "ellen.ripley@email.com",
                DateOfBirth = new DateTime(1990, 11, 8),
                PhoneNumber = "+44-20-7946-0958",
                Address = new Address { Street = "789 Queen St", City = "London", State = "", ZipCode = "SW1A 1AA", Country = "UK" },
                Type = CustomerType.Regular,
                TotalSpent = 1230.50m,
                LastOrderDate = new DateTime(2023, 8, 28)
            }
        };
    }

    public static List<Sale> GetSalesData()
    {
        var random = new Random(42); // Fixed seed for reproducible data
        var sales = new List<Sale>();
        var products = GetProducts();
        var customers = GetCustomers();
        var regions = new[] { "North", "South", "East", "West", "Central" };
        var salesPeople = new[] { "John Smith", "Jane Doe", "Mike Johnson", "Lisa Brown", "David Wilson" };

        for (int i = 1; i <= 100; i++)
        {
            var product = products[random.Next(products.Count)];
            var customer = customers[random.Next(customers.Count)];
            var quantity = random.Next(1, 10);
            var unitPrice = product.Price * (0.8m + (decimal)random.NextDouble() * 0.4m); // Price variation

            sales.Add(new Sale
            {
                Id = i,
                Date = DateTime.Now.AddDays(-random.Next(365)),
                ProductId = product.Id,
                ProductName = product.Name,
                CustomerId = customer.Id,
                CustomerName = customer.Name,
                Quantity = quantity,
                UnitPrice = unitPrice,
                TotalAmount = quantity * unitPrice,
                Region = regions[random.Next(regions.Length)],
                SalesPerson = salesPeople[random.Next(salesPeople.Length)]
            });
        }

        return sales;
    }

    public static List<int> GetNumberArrays()
    {
        return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30, 42, 50, 73, 89, 100 };
    }

    public static List<string> GetStringData()
    {
        return new List<string>
        {
            "Hello World",
            "Programming is fun",
            "C# is awesome",
            "   extra   spaces   ",
            "MiXeD cAsE tExT",
            "test@example.com",
            "invalid-email",
            "  leading and trailing  ",
            "Special!@#$%Characters",
            "1234567890",
            "a quick brown fox jumps over the lazy dog",
            "UPPERCASE TEXT",
            "lowercase text",
            "",
            "   ",
            "Single",
            "Two Words",
            "Three Simple Words",
            "This is a longer sentence with multiple words and punctuation!"
        };
    }

    // Game-related test data
    public static List<(string Name, int Level, int Health, string Class)> GetGameCharacters()
    {
        return new List<(string, int, int, string)>
        {
            ("Aragorn", 25, 100, "Ranger"),
            ("Gandalf", 50, 80, "Wizard"),
            ("Legolas", 22, 85, "Archer"),
            ("Gimli", 28, 120, "Warrior"),
            ("Frodo", 5, 60, "Hobbit"),
            ("Boromir", 20, 95, "Fighter"),
            ("Arwen", 30, 75, "Elf"),
            ("Galadriel", 100, 90, "Sorceress"),
            ("Samwise", 8, 70, "Gardener"),
            ("Sauron", 999, 1000, "Dark Lord")
        };
    }

    // Financial/Stock data
    public static List<(DateTime Date, string Symbol, decimal Price, int Volume)> GetStockData()
    {
        var data = new List<(DateTime, string, decimal, int)>();
        var symbols = new[] { "AAPL", "MSFT", "GOOGL", "AMZN", "TSLA" };
        var random = new Random(42);
        var baseDate = DateTime.Now.AddDays(-365);

        foreach (var symbol in symbols)
        {
            var basePrice = 100m + random.Next(50, 500);
            for (int i = 0; i < 365; i++)
            {
                var price = basePrice * (0.8m + (decimal)random.NextDouble() * 0.4m);
                var volume = random.Next(1000000, 10000000);
                data.Add((baseDate.AddDays(i), symbol, Math.Round(price, 2), volume));
            }
        }

        return data;
    }

    // Configuration test data
    public static Dictionary<string, object> GetConfigurationData()
    {
        return new Dictionary<string, object>
        {
            ["database.connectionString"] = "Server=localhost;Database=TestDB;",
            ["database.timeout"] = 30,
            ["database.retryAttempts"] = 3,
            ["logging.level"] = "Info",
            ["logging.file"] = "app.log",
            ["logging.maxSize"] = "10MB",
            ["api.baseUrl"] = "https://api.example.com",
            ["api.timeout"] = 5000,
            ["api.retries"] = 2,
            ["ui.theme"] = "dark",
            ["ui.language"] = "en-US",
            ["ui.pageSize"] = 20,
            ["cache.enabled"] = true,
            ["cache.ttl"] = 3600,
            ["cache.maxItems"] = 1000
        };
    }

    // File system simulation data
    public static List<(string Path, bool IsDirectory, long Size, DateTime Modified)> GetFileSystemData()
    {
        return new List<(string, bool, long, DateTime)>
        {
            ("/", true, 0, DateTime.Now.AddDays(-100)),
            ("/home", true, 0, DateTime.Now.AddDays(-90)),
            ("/home/user", true, 0, DateTime.Now.AddDays(-80)),
            ("/home/user/documents", true, 0, DateTime.Now.AddDays(-30)),
            ("/home/user/documents/report.pdf", false, 1024000, DateTime.Now.AddDays(-5)),
            ("/home/user/documents/presentation.pptx", false, 2048000, DateTime.Now.AddDays(-3)),
            ("/home/user/pictures", true, 0, DateTime.Now.AddDays(-20)),
            ("/home/user/pictures/vacation.jpg", false, 3072000, DateTime.Now.AddDays(-15)),
            ("/home/user/pictures/family.png", false, 1536000, DateTime.Now.AddDays(-10)),
            ("/home/user/downloads", true, 0, DateTime.Now.AddDays(-7)),
            ("/home/user/downloads/software.zip", false, 10240000, DateTime.Now.AddDays(-2)),
            ("/var", true, 0, DateTime.Now.AddDays(-100)),
            ("/var/log", true, 0, DateTime.Now.AddDays(-50)),
            ("/var/log/app.log", false, 512000, DateTime.Now.AddHours(-2)),
            ("/var/log/error.log", false, 256000, DateTime.Now.AddHours(-1))
        };
    }
}

public static class TestHelpers
{
    // Performance measurement
    public static void MeasureTime(string operationName, Action operation)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        operation();
        stopwatch.Stop();
        Console.WriteLine($"{operationName}: {stopwatch.ElapsedMilliseconds}ms");
    }

    // Random data generation
    public static List<T> GenerateRandomData<T>(int count, Func<int, T> generator)
    {
        return Enumerable.Range(0, count).Select(generator).ToList();
    }

    // Data validation helpers
    public static bool IsValidEmail(string email)
    {
        return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");
    }

    public static bool IsInRange<T>(T value, T min, T max) where T : IComparable<T>
    {
        return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
    }

    // Collection comparison
    public static bool AreEqual<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        return first.SequenceEqual(second);
    }

    // Mock data generators
    public static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static decimal GenerateRandomPrice(decimal min = 1.0m, decimal max = 1000.0m)
    {
        var random = new Random();
        return Math.Round(min + (decimal)random.NextDouble() * (max - min), 2);
    }

    public static List<GameEntity> GetGameEntities()
    {
        return new List<GameEntity>
    {
        new GameEntity { Id = 1, Name = "Hero", Type = EntityType.Player, Position = (10, 10), Health = 100, Level = 5 },
        new GameEntity { Id = 2, Name = "Goblin", Type = EntityType.Enemy, Position = (15, 12), Health = 30, Level = 2 },
        new GameEntity { Id = 3, Name = "Health Potion", Type = EntityType.Item, Position = (8, 15), Health = 0, Level = 0 },
        new GameEntity { Id = 4, Name = "Stone Wall", Type = EntityType.Obstacle, Position = (12, 8), Health = 0, Level = 0 },
        new GameEntity { Id = 5, Name = "Merchant", Type = EntityType.NPC, Position = (20, 20), Health = 50, Level = 1 }
    };
    }
}