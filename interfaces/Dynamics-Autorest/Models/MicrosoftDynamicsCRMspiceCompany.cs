// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// spice_company
    /// </summary>
    public partial class MicrosoftDynamicsCRMspiceCompany
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMspiceCompany
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceCompany()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMspiceCompany
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceCompany(string spiceCity = default(string), string _createdonbehalfbyValue = default(string), int? spiceBusinesstypes = default(int?), string spicePostalcode = default(string), string spiceCarlaCompany = default(string), string _owningbusinessunitValue = default(string), string spiceProvince = default(string), string _owneridValue = default(string), string _createdbyValue = default(string), string spiceCompanyid = default(string), string spiceCountry = default(string), long? versionnumber = default(long?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string spiceStreet = default(string), string spicePhone = default(string), string spiceName = default(string), int? statecode = default(int?), string spiceEmail = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string spiceAddress = default(string), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), string _owningteamValue = default(string), string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> spiceCompanyActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMspiceRequiredchecks> spiceCompanySpiceRequiredcheckses = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>), IList<MicrosoftDynamicsCRMsyncerror> spiceCompanySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceCompanyDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceCompanyDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> spiceCompanyAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> spiceCompanyMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> spiceCompanyProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> spiceCompanyBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> spiceCompanyPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> spiceCompanyAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> spiceCompanyEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> spiceCompanyFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> spiceCompanyLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> spiceCompanyPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> spiceCompanyTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> spiceCompanyRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> spiceCompanySocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> spiceCompanyConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> spiceCompanyConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> spiceCompanyAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> spiceCompanyServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMaccount> spiceCompanyAccount = default(IList<MicrosoftDynamicsCRMaccount>))
        {
            SpiceCity = spiceCity;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SpiceBusinesstypes = spiceBusinesstypes;
            SpicePostalcode = spicePostalcode;
            SpiceCarlaCompany = spiceCarlaCompany;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SpiceProvince = spiceProvince;
            this._owneridValue = _owneridValue;
            this._createdbyValue = _createdbyValue;
            SpiceCompanyid = spiceCompanyid;
            SpiceCountry = spiceCountry;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SpiceStreet = spiceStreet;
            SpicePhone = spicePhone;
            SpiceName = spiceName;
            Statecode = statecode;
            SpiceEmail = spiceEmail;
            Createdon = createdon;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            SpiceAddress = spiceAddress;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SpiceCompanyActivityPointers = spiceCompanyActivityPointers;
            SpiceCompanySpiceRequiredcheckses = spiceCompanySpiceRequiredcheckses;
            SpiceCompanySyncErrors = spiceCompanySyncErrors;
            SpiceCompanyDuplicateMatchingRecord = spiceCompanyDuplicateMatchingRecord;
            SpiceCompanyDuplicateBaseRecord = spiceCompanyDuplicateBaseRecord;
            SpiceCompanyAsyncOperations = spiceCompanyAsyncOperations;
            SpiceCompanyMailboxTrackingFolders = spiceCompanyMailboxTrackingFolders;
            SpiceCompanyProcessSession = spiceCompanyProcessSession;
            SpiceCompanyBulkDeleteFailures = spiceCompanyBulkDeleteFailures;
            SpiceCompanyPrincipalObjectAttributeAccesses = spiceCompanyPrincipalObjectAttributeAccesses;
            SpiceCompanyAppointments = spiceCompanyAppointments;
            SpiceCompanyEmails = spiceCompanyEmails;
            SpiceCompanyFaxes = spiceCompanyFaxes;
            SpiceCompanyLetters = spiceCompanyLetters;
            SpiceCompanyPhoneCalls = spiceCompanyPhoneCalls;
            SpiceCompanyTasks = spiceCompanyTasks;
            SpiceCompanyRecurringAppointmentMasters = spiceCompanyRecurringAppointmentMasters;
            SpiceCompanySocialActivities = spiceCompanySocialActivities;
            SpiceCompanyConnections1 = spiceCompanyConnections1;
            SpiceCompanyConnections2 = spiceCompanyConnections2;
            SpiceCompanyAnnotations = spiceCompanyAnnotations;
            SpiceCompanyServiceAppointments = spiceCompanyServiceAppointments;
            SpiceCompanyAccount = spiceCompanyAccount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_city")]
        public string SpiceCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_businesstypes")]
        public int? SpiceBusinesstypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_postalcode")]
        public string SpicePostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_carla_company")]
        public string SpiceCarlaCompany { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_province")]
        public string SpiceProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_companyid")]
        public string SpiceCompanyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_country")]
        public string SpiceCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_street")]
        public string SpiceStreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_phone")]
        public string SpicePhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_name")]
        public string SpiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_email")]
        public string SpiceEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_address")]
        public string SpiceAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SpiceCompanyActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_spice_requiredcheckses")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> SpiceCompanySpiceRequiredcheckses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SpiceCompanySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceCompanyDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceCompanyDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SpiceCompanyAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SpiceCompanyMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SpiceCompanyProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SpiceCompanyBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SpiceCompanyPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> SpiceCompanyAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_Emails")]
        public IList<MicrosoftDynamicsCRMemail> SpiceCompanyEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> SpiceCompanyFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_Letters")]
        public IList<MicrosoftDynamicsCRMletter> SpiceCompanyLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> SpiceCompanyPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> SpiceCompanyTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SpiceCompanyRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SpiceCompanySocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> SpiceCompanyConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> SpiceCompanyConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> SpiceCompanyAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SpiceCompanyServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_company_account")]
        public IList<MicrosoftDynamicsCRMaccount> SpiceCompanyAccount { get; set; }

    }
}
