using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Interfaces.Base
{
    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Woman { get; set; }

        public DateTime DataOfBirth { get; set; }

        public string HungarianFullName {
            get => $"{this.LastName} {this.FirstName}";
        }

        public string FullName
        {
            get => $"{this.FirstName} {this.LastName}";
        }

        public bool IsWoman
        {
            get => this.Woman;
        }

        public bool IsMan
        {
            get => !this.Woman;
        }
        public int Age
        {
            get
            {
                int day = DateTime.Now.DayOfYear - this.DataOfBirth.DayOfYear;
                if (day < 0) return DateTime.Now.Year - this.DataOfBirth.Year - 1;
                return DateTime.Now.Year - this.DataOfBirth.Year;
            }
        }
    }
}