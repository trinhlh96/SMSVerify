using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionSMS.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public CustomerStatus Status { get; set; }
    }
    public enum CustomerStatus
    {
        Deativate,Active 
    }
}