using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_ExtraExploration.Models
{
    [Table("userManagers")]
    public class UserManager
    {
        [Key]
        public int Id;
        public string AccountSid;
        public string AuthToken;
        public virtual Message Messages;
    }
}
