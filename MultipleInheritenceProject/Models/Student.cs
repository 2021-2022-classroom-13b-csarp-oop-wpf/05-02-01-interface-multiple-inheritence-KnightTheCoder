using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreta.Models.Interfaces;

namespace MultipleInheritenceProject.Models
{
    class Student : IStudent
    {
        public int StudentId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Woman { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StreetAndNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PostCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LoginName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsLoginNameCorrect(string givenLoginName)
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordCorrect(string givenPassword)
        {
            throw new NotImplementedException();
        }

        public bool VerifyLoginName(string givenLoginName)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string givenPassword)
        {
            throw new NotImplementedException();
        }
    }
}
