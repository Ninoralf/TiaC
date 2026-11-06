using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.ServiceModels
{
    // The current details shown in the "Request Info Change" popup on the profile pages
    public class InfoChangeModalModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserCode { get; set; }
        public string IdLabel { get; set; }
        public string Email { get; set; }
    }
}