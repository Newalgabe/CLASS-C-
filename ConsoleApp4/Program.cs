// task 1

//class Website
//{
//    private string name;
//    private string url;
//    private string description;
//    private string ipAddress;

//    public void SetName(string n)
//    {
//        name = n;
//    }

//    public string GetName()
//    {
//        return name;
//    }

//    public void SetUrl(string u)
//    {
//        url = u;
//    }

//    public string GetUrl()
//    {
//        return url;
//    }

//    public void SetDescription(string d)
//    {
//        description = d;
//    }

//    public string GetDescription()
//    {
//        return description;
//    }

//    public void SetIpAddress(string ip)
//    {
//        ipAddress = ip;
//    }

//    public string GetIpAddress()
//    {
//        return ipAddress;
//    }

//    public void InputData()
//    {
//        Console.Write("Enter website name: ");
//        SetName(Console.ReadLine());

//        Console.Write("Enter website URL: ");
//        SetUrl(Console.ReadLine());

//        Console.Write("Enter website description: ");
//        SetDescription(Console.ReadLine());

//        Console.Write("Enter website IP address: ");
//        SetIpAddress(Console.ReadLine());
//    }

//    public void DisplayData()
//    {
//        Console.WriteLine($"Website Name: {GetName()}");
//        Console.WriteLine($"Website URL: {GetUrl()}");
//        Console.WriteLine($"Website Description: {GetDescription()}");
//        Console.WriteLine($"Website IP Address: {GetIpAddress()}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Website website = new Website();
//        website.InputData();

//        Console.WriteLine("\nWebsite Data:");
//        website.DisplayData();
//    }
//}


// task 2

//class Magazine
//{
//    private string name;
//    private int foundingYear;
//    private string description;
//    private string contactPhone;
//    private string contactEmail;

//    public void SetName(string n)
//    {
//        name = n;
//    }

//    public string GetName()
//    {
//        return name;
//    }

//    public void SetFoundingYear(int year)
//    {
//        foundingYear = year;
//    }

//    public int GetFoundingYear()
//    {
//        return foundingYear;
//    }

//    public void SetDescription(string d)
//    {
//        description = d;
//    }

//    public string GetDescription()
//    {
//        return description;
//    }

//    public void SetContactPhone(string phone)
//    {
//        contactPhone = phone;
//    }

//    public string GetContactPhone()
//    {
//        return contactPhone;
//    }

//    public void SetContactEmail(string email)
//    {
//        contactEmail = email;
//    }

//    public string GetContactEmail()
//    {
//        return contactEmail;
//    }

//    public void InputData()
//    {
//        Console.Write("Enter magazine name: ");
//        SetName(Console.ReadLine());

//        Console.Write("Enter founding year: ");
//        SetFoundingYear(int.Parse(Console.ReadLine()));

//        Console.Write("Enter magazine description: ");
//        SetDescription(Console.ReadLine());

//        Console.Write("Enter contact phone: ");
//        SetContactPhone(Console.ReadLine());

//        Console.Write("Enter contact email: ");
//        SetContactEmail(Console.ReadLine());
//    }

//    public void DisplayData()
//    {
//        Console.WriteLine($"Magazine Name: {GetName()}");
//        Console.WriteLine($"Founding Year: {GetFoundingYear()}");
//        Console.WriteLine($"Magazine Description: {GetDescription()}");
//        Console.WriteLine($"Contact Phone: {GetContactPhone()}");
//        Console.WriteLine($"Contact Email: {GetContactEmail()}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Magazine magazine = new Magazine();
//        magazine.InputData();

//        Console.WriteLine("\nMagazine Data:");
//        magazine.DisplayData();
//    }
//}



// task 3

//class Store
//{
//    private string name;
//    private string address;
//    private string profileDescription;
//    private string contactPhone;
//    private string contactEmail;

//    public void SetName(string n)
//    {
//        name = n;
//    }

//    public string GetName()
//    {
//        return name;
//    }

//    public void SetAddress(string a)
//    {
//        address = a;
//    }

//    public string GetAddress()
//    {
//        return address;
//    }

//    public void SetProfileDescription(string pd)
//    {
//        profileDescription = pd;
//    }

//    public string GetProfileDescription()
//    {
//        return profileDescription;
//    }

//    public void SetContactPhone(string phone)
//    {
//        contactPhone = phone;
//    }

//    public string GetContactPhone()
//    {
//        return contactPhone;
//    }

//    public void SetContactEmail(string email)
//    {
//        contactEmail = email;
//    }

//    public string GetContactEmail()
//    {
//        return contactEmail;
//    }

//    public void InputData()
//    {
//        Console.Write("Enter store name: ");
//        SetName(Console.ReadLine());

//        Console.Write("Enter store address: ");
//        SetAddress(Console.ReadLine());

//        Console.Write("Enter profile description: ");
//        SetProfileDescription(Console.ReadLine());

//        Console.Write("Enter contact phone: ");
//        SetContactPhone(Console.ReadLine());

//        Console.Write("Enter contact email: ");
//        SetContactEmail(Console.ReadLine());
//    }

//    public void DisplayData()
//    {
//        Console.WriteLine($"Store Name: {GetName()}");
//        Console.WriteLine($"Store Address: {GetAddress()}");
//        Console.WriteLine($"Profile Description: {GetProfileDescription()}");
//        Console.WriteLine($"Contact Phone: {GetContactPhone()}");
//        Console.WriteLine($"Contact Email: {GetContactEmail()}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Store store = new Store();
//        store.InputData();

//        Console.WriteLine("\nStore Data:");
//        store.DisplayData();
//    }
//}