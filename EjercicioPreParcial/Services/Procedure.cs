using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPreParcial.Services
{
    internal class Param    {
        public string Parameter { get; set; }
        public object Value { get; set; }

        public Param(string parameter, object value)
        {
            Parameter = parameter;
            Value = value;
        }


    }
}