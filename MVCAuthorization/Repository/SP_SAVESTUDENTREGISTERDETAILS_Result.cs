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
    
    public partial class SP_SAVESTUDENTREGISTERDETAILS_Result
    {
        public int ID { get; set; }
        public string STUDENTID { get; set; }
        public string STUDENTNAME { get; set; }
        public Nullable<System.DateTime> DATEOFBIRTH { get; set; }
        public Nullable<int> GENDER { get; set; }
        public string ADDRESS { get; set; }
        public string CONTACTEMAIL { get; set; }
        public Nullable<decimal> CONTACTMOBILE { get; set; }
        public string ADDITIONALCOMMENTS { get; set; }
        public Nullable<bool> ISRESGISTERED { get; set; }
        public Nullable<System.DateTime> RESGISTEREDDATE { get; set; }
        public Nullable<bool> ISACTIVE { get; set; }
        public Nullable<bool> PASSWORDGENERATED { get; set; }
        public Nullable<System.DateTime> CREATEDON { get; set; }
    }
}