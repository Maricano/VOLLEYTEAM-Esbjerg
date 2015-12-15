﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModel
{
   public class PlayerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int TeamId { get; set; }

        public int Training { get; set; }

        public int Games { get; set; }

        public int PlayerOfTheMatch { get; set; }
    }
}
