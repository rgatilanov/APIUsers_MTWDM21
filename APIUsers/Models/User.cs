using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIUsers.Models
{
    //Conincidir propiedades con el nombre de los campos en la tabla
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_lastname { get; set; }
        public string user_nick { get; set; }
        public string user_password { get; set; }
        public DateTime user_createdate { get; set; }
        public Boolean user_status { get; set; }

    }
}
