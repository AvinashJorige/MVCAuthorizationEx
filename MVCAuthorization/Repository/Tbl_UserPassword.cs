//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAuthorization.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_UserPassword
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string HashCode { get; set; }
        public string Password { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public bool IsActive { get; set; }
    }
}
