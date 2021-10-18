namespace Core.Prototype
{
    public class User
    {
        private int Id { get; set; }

        private string Name { get; set; }

        private string Gender { get; set; }

        public User SetId(int id)
        {
            Id = id;
            return this;
        }

        public User SetName(string name)
        {
            Name = name;
            return this;
        }

        public User SetGender(string gender)
        {
            Gender = gender;
            return this;
        }

        public User Copy()
        {
            return new User()
            {
                Id = Id,
                Name = Name,
                Gender = Gender
            };
        }
    }
}
