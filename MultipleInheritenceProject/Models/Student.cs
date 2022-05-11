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
        public int StudentId { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Woman { get; set; }
        public DateTime DataOfBirth { get; set; }
        public string City { get; set; }
        public string StreetAndNumber { get; set; }
        public int PostCode { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }

        public bool IsLoginNameCorrect(string givenLoginName)
        {
            return false;
        }

        public bool IsPasswordCorrect(string givenPassword)
        {
            return false;
        }

        public bool VerifyLoginName(string givenLoginName)
        {
            return false;
        }

        public bool VerifyPassword(string givenPassword)
        {
            return false;
        }
    }
}
