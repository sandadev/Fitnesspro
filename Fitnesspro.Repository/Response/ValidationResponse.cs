using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.DataAccess.Response
{
   public class ValidationResponse
    {
        public bool IsSuccess { set; get; }
        public List<string> ValidationMessages { set; get; }
    }
}
