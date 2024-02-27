using Academy_2024.Models;

namespace Academy_2024.Repositories
{
    public class UserRepository
    {
        private static List<Users> Users = new List<Users> { new Users { Id = 1, FirstName = "Jhon", LastName = "Doe" } };


        public List<Users> GetAll() { return Users; }



        public Users? GetById(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }

        public void Create(Users data)
        {
            Users.Add(data);
        }


        public Users? Update(int id, Users data)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    user.FirstName= data.FirstName;
                    user.LastName= data.LastName;
                    return user;
                }
            }

            return null;
        }

        public bool Delete(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    Users.Remove(user);
                    return true;
                }
            }

            return false;
        }


    }
}
