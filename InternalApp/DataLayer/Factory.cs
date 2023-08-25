using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Factory
    {
        /// <summary>
        /// Method used to create an object for DALAuthentication
        /// </summary>
        /// <returns></returns>
        public IData CreatingObj()
        {
            return new DALAuthentication();
        }
    }
}
