using System;

namespace apiSAM.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Password { get; set; }
        public string DocumentID { get; set; }
    }
}