using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WorkOfFund.Models;

namespace WorkOfFund.Models
{
    public class WorkerViewModel
    {
        public int worker_id { get; set; }

        [Required(ErrorMessage ="Введіть ім'я", AllowEmptyStrings = false)]
        public string worker_name { get; set; }

        [Required(ErrorMessage = "Введіть прізвище", AllowEmptyStrings = false)]
        public string worker_surname { get; set; }

        [Required(ErrorMessage = "Введіть логін", AllowEmptyStrings = false)]
        public string worker_login { get; set; }

        [Required(ErrorMessage = "Введіть пароль", AllowEmptyStrings = false)]
        public string worker_password { get; set; }

        public int wfund_id { get; set; }
        public int wposition_id { get; set; }
        
        //custom attribute
        public string position_name { get; set; }
    }
}