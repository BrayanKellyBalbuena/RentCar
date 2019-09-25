using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Abstractions
{
   public abstract class Catalog : Entity
    {
        private string _name;
        public string Description { get; set; }

 
        public string Name
        {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"{nameof(Catalog)} property {nameof(Name)} can't be null or empty");
                _name = value;
            }
        }


    }
}
