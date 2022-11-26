using laba8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8.Models
{
    [Serializable]
    public class Administrator
    {
        private Role _role;

        public string SecondName { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        //public string Role
        //{
        //    get => _role.ToString();

        //    set => _role = (Role)Enum.Parse(typeof(Role), value);
        //}

        public int Role { get; set; }
    }
}
