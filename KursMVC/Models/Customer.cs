using KursMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer 
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewstletter { get; set; }
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        /// <summary>
        /// Z uwagi na nazewnictwo entity traktuje ta zmienna jako foreign key
        /// </summary>
        public byte MembershipTypeId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? Birthday { get; set; }
    }
} 