//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sampleadmin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.orders = new HashSet<cart>();
        }
    
        public int cid { get; set; }
        //[Required(ErrorMessage = "Enter Username")]
        [DisplayName("UserName")]
        public string username { get; set; }

        //[Required(ErrorMessage = "Enter Password")]
        [DisplayName("Password")]
        //[DataType(DataType.Password)]
        //[RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}", ErrorMessage = "Password Should contain Upper and lower case alphabets and numbers\n Atleast 8 characters and more")]
        public string password { get; set; }

        //[Required(ErrorMessage = "Enter Phone No")]
        [DisplayName("Phone No")]
        //[DataType(DataType.PhoneNumber)]
        //[MinLength(10)]

        public string phno { get; set; }
        //[Required(ErrorMessage = "Enter Email Id")]
        [DisplayName("Email Id")]
        //[DataType(DataType.EmailAddress)]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string email { get; set; }
        //[Required(ErrorMessage = "Enter Address")]
        [DisplayName("Address")]

        public string address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart> orders { get; set; }
    }
}
