﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class UserDBContext : DbContext
    {
        public UserDBContext()
            : base("name=UserDBContext2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<tbl_Gender_Master> tbl_Gender_Master { get; set; }
        public virtual DbSet<Tbl_Password_Log> Tbl_Password_Log { get; set; }
        public virtual DbSet<tbl_std_pass> tbl_std_pass { get; set; }
        public virtual DbSet<tbl_StudentInfo> tbl_StudentInfo { get; set; }
        public virtual DbSet<Tbl_UserPassword> Tbl_UserPassword { get; set; }
        public virtual DbSet<Tbl_UserRoles> Tbl_UserRoles { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<CustomerRawInfo> CustomerRawInfoes { get; set; }
        public virtual DbSet<tbl_ColorTable> tbl_ColorTable { get; set; }
        public virtual DbSet<Tbl_Customers_M> Tbl_Customers_M { get; set; }
        public virtual DbSet<tbl_Emp_Password> tbl_Emp_Password { get; set; }
    
        public virtual ObjectResult<SP_GET_PRODUCT_DETAILS_Result> SP_GET_PRODUCT_DETAILS(string pRODUCTID, string cATEGORY)
        {
            var pRODUCTIDParameter = pRODUCTID != null ?
                new ObjectParameter("PRODUCTID", pRODUCTID) :
                new ObjectParameter("PRODUCTID", typeof(string));
    
            var cATEGORYParameter = cATEGORY != null ?
                new ObjectParameter("CATEGORY", cATEGORY) :
                new ObjectParameter("CATEGORY", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_PRODUCT_DETAILS_Result>("SP_GET_PRODUCT_DETAILS", pRODUCTIDParameter, cATEGORYParameter);
        }
    
        public virtual ObjectResult<SP_GET_PRODUCT_INFO_Result> SP_GET_PRODUCT_INFO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_PRODUCT_INFO_Result>("SP_GET_PRODUCT_INFO");
        }
    
        public virtual int SP_INSERT_PRODUCT_INFO(string pRODUCTID, string cATEGORY, string mAINCATEGORY, string tAXTAFFICCODE, string sUPPLIERNAME, string wEIGHTMEASURE, string wEIGHTUNIT, string dESCRIPTION, string nAME, string dATEOFSALE, string pRODUCTPICURL, string sTATUS, string qUANTITY, string uOM, string cURRENCYCODE, string pRICE)
        {
            var pRODUCTIDParameter = pRODUCTID != null ?
                new ObjectParameter("PRODUCTID", pRODUCTID) :
                new ObjectParameter("PRODUCTID", typeof(string));
    
            var cATEGORYParameter = cATEGORY != null ?
                new ObjectParameter("CATEGORY", cATEGORY) :
                new ObjectParameter("CATEGORY", typeof(string));
    
            var mAINCATEGORYParameter = mAINCATEGORY != null ?
                new ObjectParameter("MAINCATEGORY", mAINCATEGORY) :
                new ObjectParameter("MAINCATEGORY", typeof(string));
    
            var tAXTAFFICCODEParameter = tAXTAFFICCODE != null ?
                new ObjectParameter("TAXTAFFICCODE", tAXTAFFICCODE) :
                new ObjectParameter("TAXTAFFICCODE", typeof(string));
    
            var sUPPLIERNAMEParameter = sUPPLIERNAME != null ?
                new ObjectParameter("SUPPLIERNAME", sUPPLIERNAME) :
                new ObjectParameter("SUPPLIERNAME", typeof(string));
    
            var wEIGHTMEASUREParameter = wEIGHTMEASURE != null ?
                new ObjectParameter("WEIGHTMEASURE", wEIGHTMEASURE) :
                new ObjectParameter("WEIGHTMEASURE", typeof(string));
    
            var wEIGHTUNITParameter = wEIGHTUNIT != null ?
                new ObjectParameter("WEIGHTUNIT", wEIGHTUNIT) :
                new ObjectParameter("WEIGHTUNIT", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dATEOFSALEParameter = dATEOFSALE != null ?
                new ObjectParameter("DATEOFSALE", dATEOFSALE) :
                new ObjectParameter("DATEOFSALE", typeof(string));
    
            var pRODUCTPICURLParameter = pRODUCTPICURL != null ?
                new ObjectParameter("PRODUCTPICURL", pRODUCTPICURL) :
                new ObjectParameter("PRODUCTPICURL", typeof(string));
    
            var sTATUSParameter = sTATUS != null ?
                new ObjectParameter("STATUS", sTATUS) :
                new ObjectParameter("STATUS", typeof(string));
    
            var qUANTITYParameter = qUANTITY != null ?
                new ObjectParameter("QUANTITY", qUANTITY) :
                new ObjectParameter("QUANTITY", typeof(string));
    
            var uOMParameter = uOM != null ?
                new ObjectParameter("UOM", uOM) :
                new ObjectParameter("UOM", typeof(string));
    
            var cURRENCYCODEParameter = cURRENCYCODE != null ?
                new ObjectParameter("CURRENCYCODE", cURRENCYCODE) :
                new ObjectParameter("CURRENCYCODE", typeof(string));
    
            var pRICEParameter = pRICE != null ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERT_PRODUCT_INFO", pRODUCTIDParameter, cATEGORYParameter, mAINCATEGORYParameter, tAXTAFFICCODEParameter, sUPPLIERNAMEParameter, wEIGHTMEASUREParameter, wEIGHTUNITParameter, dESCRIPTIONParameter, nAMEParameter, dATEOFSALEParameter, pRODUCTPICURLParameter, sTATUSParameter, qUANTITYParameter, uOMParameter, cURRENCYCODEParameter, pRICEParameter);
        }
    
        public virtual ObjectResult<SP_SAVESTUDENTREGISTERDETAILS_Result> SP_SAVESTUDENTREGISTERDETAILS(string sTUDENTID, string sTUDENTNAME, Nullable<System.DateTime> dATEOFBIRTH, Nullable<int> gENDER, string aDDRESS, string cONTACTEMAIL, Nullable<decimal> cONTACTMOBILE, string aDDITIONALCOMMENTS, Nullable<bool> iSRESGISTERED, Nullable<bool> iSACTIVE, Nullable<bool> pASSWORDGENERATED, string fLAG)
        {
            var sTUDENTIDParameter = sTUDENTID != null ?
                new ObjectParameter("STUDENTID", sTUDENTID) :
                new ObjectParameter("STUDENTID", typeof(string));
    
            var sTUDENTNAMEParameter = sTUDENTNAME != null ?
                new ObjectParameter("STUDENTNAME", sTUDENTNAME) :
                new ObjectParameter("STUDENTNAME", typeof(string));
    
            var dATEOFBIRTHParameter = dATEOFBIRTH.HasValue ?
                new ObjectParameter("DATEOFBIRTH", dATEOFBIRTH) :
                new ObjectParameter("DATEOFBIRTH", typeof(System.DateTime));
    
            var gENDERParameter = gENDER.HasValue ?
                new ObjectParameter("GENDER", gENDER) :
                new ObjectParameter("GENDER", typeof(int));
    
            var aDDRESSParameter = aDDRESS != null ?
                new ObjectParameter("ADDRESS", aDDRESS) :
                new ObjectParameter("ADDRESS", typeof(string));
    
            var cONTACTEMAILParameter = cONTACTEMAIL != null ?
                new ObjectParameter("CONTACTEMAIL", cONTACTEMAIL) :
                new ObjectParameter("CONTACTEMAIL", typeof(string));
    
            var cONTACTMOBILEParameter = cONTACTMOBILE.HasValue ?
                new ObjectParameter("CONTACTMOBILE", cONTACTMOBILE) :
                new ObjectParameter("CONTACTMOBILE", typeof(decimal));
    
            var aDDITIONALCOMMENTSParameter = aDDITIONALCOMMENTS != null ?
                new ObjectParameter("ADDITIONALCOMMENTS", aDDITIONALCOMMENTS) :
                new ObjectParameter("ADDITIONALCOMMENTS", typeof(string));
    
            var iSRESGISTEREDParameter = iSRESGISTERED.HasValue ?
                new ObjectParameter("ISRESGISTERED", iSRESGISTERED) :
                new ObjectParameter("ISRESGISTERED", typeof(bool));
    
            var iSACTIVEParameter = iSACTIVE.HasValue ?
                new ObjectParameter("ISACTIVE", iSACTIVE) :
                new ObjectParameter("ISACTIVE", typeof(bool));
    
            var pASSWORDGENERATEDParameter = pASSWORDGENERATED.HasValue ?
                new ObjectParameter("PASSWORDGENERATED", pASSWORDGENERATED) :
                new ObjectParameter("PASSWORDGENERATED", typeof(bool));
    
            var fLAGParameter = fLAG != null ?
                new ObjectParameter("FLAG", fLAG) :
                new ObjectParameter("FLAG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SAVESTUDENTREGISTERDETAILS_Result>("SP_SAVESTUDENTREGISTERDETAILS", sTUDENTIDParameter, sTUDENTNAMEParameter, dATEOFBIRTHParameter, gENDERParameter, aDDRESSParameter, cONTACTEMAILParameter, cONTACTMOBILEParameter, aDDITIONALCOMMENTSParameter, iSRESGISTEREDParameter, iSACTIVEParameter, pASSWORDGENERATEDParameter, fLAGParameter);
        }
    
        public virtual ObjectResult<USP_COUNTRYDATA_Result> USP_COUNTRYDATA(string nAME)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_COUNTRYDATA_Result>("USP_COUNTRYDATA", nAMEParameter);
        }
    
        public virtual ObjectResult<uspGetStudentss_Result> uspGetStudentss()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetStudentss_Result>("uspGetStudentss");
        }
    }
}
