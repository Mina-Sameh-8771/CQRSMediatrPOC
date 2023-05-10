using AutoMapper;

namespace CQRSMediatrPOC.AuotMapper
{

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public string GetFullName()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }

    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string FullName { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Door { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>().IncludeMembers(u => u.Address);
            CreateMap<Address, UserViewModel>(MemberList.None);

        }
    }
}
