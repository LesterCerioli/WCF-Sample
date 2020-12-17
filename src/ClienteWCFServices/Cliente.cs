using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteWCFServices
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public bool Save()
        {
            return true;
        }
    }
}