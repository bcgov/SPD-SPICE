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
    /// spice_services
    /// </summary>
    public partial class MicrosoftDynamicsCRMspiceServices
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMspiceServices
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceServices()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMspiceServices
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceServices(object exchangerate = default(object), object spiceDifficult = default(object), object spiceAdjudication = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), long? versionnumber = default(long?), object spiceIntermediate = default(object), int? statecode = default(int?), string _spiceMinistryserviceidValue = default(string), int? importsequencenumber = default(int?), object spiceBusLowfee = default(object), string spiceName = default(string), int? utcconversiontimezonecode = default(int?), object spiceBusLowfeeBase = default(object), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), object spiceBusHighfeeBase = default(object), string _createdonbehalfbyValue = default(string), object spiceSimpleBase = default(object), object spiceBusHighfee = default(object), int? statuscode = default(int?), object spiceNoadjudication = default(object), object spiceSimple = default(object), object spiceNoadjudicationBase = default(object), int? spiceScreeningtype = default(int?), string _organizationidValue = default(string), object spiceDifficultBase = default(object), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string spiceServicesid = default(string), string _modifiedonbehalfbyValue = default(string), object spiceAdjudicationBase = default(object), object spiceIntermediateBase = default(object), string _createdbyValue = default(string), int? spiceSerApplicanttype = default(int?), string _modifiedbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> spiceServicesSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceServicesDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceServicesDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> spiceServicesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> spiceServicesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> spiceServicesProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> spiceServicesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> spiceServicesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMspiceMinistry spiceMinistryServiceId = default(MicrosoftDynamicsCRMspiceMinistry), IList<MicrosoftDynamicsCRMincident> spiceSpiceServicesIncident = default(IList<MicrosoftDynamicsCRMincident>))
        {
            Exchangerate = exchangerate;
            SpiceDifficult = spiceDifficult;
            SpiceAdjudication = spiceAdjudication;
            Createdon = createdon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Versionnumber = versionnumber;
            SpiceIntermediate = spiceIntermediate;
            Statecode = statecode;
            this._spiceMinistryserviceidValue = _spiceMinistryserviceidValue;
            Importsequencenumber = importsequencenumber;
            SpiceBusLowfee = spiceBusLowfee;
            SpiceName = spiceName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SpiceBusLowfeeBase = spiceBusLowfeeBase;
            Overriddencreatedon = overriddencreatedon;
            SpiceBusHighfeeBase = spiceBusHighfeeBase;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SpiceSimpleBase = spiceSimpleBase;
            SpiceBusHighfee = spiceBusHighfee;
            Statuscode = statuscode;
            SpiceNoadjudication = spiceNoadjudication;
            SpiceSimple = spiceSimple;
            SpiceNoadjudicationBase = spiceNoadjudicationBase;
            SpiceScreeningtype = spiceScreeningtype;
            this._organizationidValue = _organizationidValue;
            SpiceDifficultBase = spiceDifficultBase;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            SpiceServicesid = spiceServicesid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SpiceAdjudicationBase = spiceAdjudicationBase;
            SpiceIntermediateBase = spiceIntermediateBase;
            this._createdbyValue = _createdbyValue;
            SpiceSerApplicanttype = spiceSerApplicanttype;
            this._modifiedbyValue = _modifiedbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            SpiceServicesSyncErrors = spiceServicesSyncErrors;
            SpiceServicesDuplicateMatchingRecord = spiceServicesDuplicateMatchingRecord;
            SpiceServicesDuplicateBaseRecord = spiceServicesDuplicateBaseRecord;
            SpiceServicesAsyncOperations = spiceServicesAsyncOperations;
            SpiceServicesMailboxTrackingFolders = spiceServicesMailboxTrackingFolders;
            SpiceServicesProcessSession = spiceServicesProcessSession;
            SpiceServicesBulkDeleteFailures = spiceServicesBulkDeleteFailures;
            SpiceServicesPrincipalObjectAttributeAccesses = spiceServicesPrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            SpiceMinistryServiceId = spiceMinistryServiceId;
            SpiceSpiceServicesIncident = spiceSpiceServicesIncident;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_difficult")]
        public object SpiceDifficult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_adjudication")]
        public object SpiceAdjudication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_intermediate")]
        public object SpiceIntermediate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_spice_ministryserviceid_value")]
        public string _spiceMinistryserviceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_bus_lowfee")]
        public object SpiceBusLowfee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_name")]
        public string SpiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_bus_lowfee_base")]
        public object SpiceBusLowfeeBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_bus_highfee_base")]
        public object SpiceBusHighfeeBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_simple_base")]
        public object SpiceSimpleBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_bus_highfee")]
        public object SpiceBusHighfee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_noadjudication")]
        public object SpiceNoadjudication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_simple")]
        public object SpiceSimple { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_noadjudication_base")]
        public object SpiceNoadjudicationBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_screeningtype")]
        public int? SpiceScreeningtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_difficult_base")]
        public object SpiceDifficultBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_servicesid")]
        public string SpiceServicesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_adjudication_base")]
        public object SpiceAdjudicationBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_intermediate_base")]
        public object SpiceIntermediateBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_ser_applicanttype")]
        public int? SpiceSerApplicanttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SpiceServicesSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceServicesDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceServicesDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SpiceServicesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SpiceServicesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SpiceServicesProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SpiceServicesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SpiceServicesPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_MinistryServiceId")]
        public MicrosoftDynamicsCRMspiceMinistry SpiceMinistryServiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_spice_services_incident")]
        public IList<MicrosoftDynamicsCRMincident> SpiceSpiceServicesIncident { get; set; }

    }
}
