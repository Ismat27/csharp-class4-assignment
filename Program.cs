namespace Assignment
{
    public enum BITDepartment
    {
        SALES , TECH
    }

    interface IBIT { 
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        public string BitId { get; set; }
        public string LaptopBarcode { get; set; }
        public BITDepartment Department { get; set; }
        public object GetProfile();
        public string GetFullName();

    }

    class Program
    {
        public static void Main(string[] args) {
            var bit1 = new BIT()
            {
                FirstName = "Ismail",
                LastName = "Adegbite",
                Email = "adegbiteismail27@gmail.com",
                BitId = "BIT2023034",
                LaptopBarcode = "WMBBIT2023034",
                Department = BITDepartment.TECH,
                PhoneNumber = "09012345678",
                Address = "Address",
                City = "Abeokuta",
                State = "Ogun",
            };

            Console.WriteLine(bit1.GetProfile());
            Console.WriteLine(bit1.GetFullName());
        }

        class BIT: IBIT
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string BitId { get; set; }
            public string LaptopBarcode { get; set; }
            public BITDepartment Department { get; set; }

            public string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }

            public object GetProfile()
            {
                return new { 
                    Id,
                    FirstName,
                    LastName,
                    Email,
                    BitId,
                    LaptopBarcode,
                    Department

                };
            }

        }
    }
}