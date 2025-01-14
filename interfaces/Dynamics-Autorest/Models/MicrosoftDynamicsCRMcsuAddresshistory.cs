// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.csu_addresshistory
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuAddresshistory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuAddresshistory class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuAddresshistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuAddresshistory class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuAddresshistory(bool? csuIscurrentaddress = default(bool?), string csuAddress1Country = default(string), string _createdonbehalfbyValue = default(string), string csuAddress1Stateorprovince = default(string), string csuAddress1Line2 = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string csuName = default(string), int? utcconversiontimezonecode = default(int?), string csuProvince = default(string), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string csuAddresshistoryid = default(string), System.DateTimeOffset? csuAddressdateto = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string csuAddress1Line1 = default(string), string _owneridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string csuAddress1City = default(string), string _modifiedonbehalfbyValue = default(string), string csuAddressdescription = default(string), string versionnumber = default(string), string _owningbusinessunitValue = default(string), string _csuPersondetailidValue = default(string), int? statecode = default(int?), string _createdbyValue = default(string), string _owningteamValue = default(string), string csuAddress1Postalcode = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? csuAddressdatefrom = default(System.DateTimeOffset?), int? statuscode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuAddresshistorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuAddresshistoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuAddresshistoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuAddresshistoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuAddresshistoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuAddresshistoryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuAddresshistoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuAddresshistoryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcontact csuPersonDetailid = default(MicrosoftDynamicsCRMcontact))
        {
            CsuIscurrentaddress = csuIscurrentaddress;
            CsuAddress1Country = csuAddress1Country;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            CsuAddress1Stateorprovince = csuAddress1Stateorprovince;
            CsuAddress1Line2 = csuAddress1Line2;
            Overriddencreatedon = overriddencreatedon;
            this._owninguserValue = _owninguserValue;
            CsuName = csuName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CsuProvince = csuProvince;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            CsuAddresshistoryid = csuAddresshistoryid;
            CsuAddressdateto = csuAddressdateto;
            this._modifiedbyValue = _modifiedbyValue;
            CsuAddress1Line1 = csuAddress1Line1;
            this._owneridValue = _owneridValue;
            Modifiedon = modifiedon;
            CsuAddress1City = csuAddress1City;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            CsuAddressdescription = csuAddressdescription;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._csuPersondetailidValue = _csuPersondetailidValue;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            CsuAddress1Postalcode = csuAddress1Postalcode;
            Createdon = createdon;
            CsuAddressdatefrom = csuAddressdatefrom;
            Statuscode = statuscode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuAddresshistorySyncErrors = csuAddresshistorySyncErrors;
            CsuAddresshistoryDuplicateMatchingRecord = csuAddresshistoryDuplicateMatchingRecord;
            CsuAddresshistoryDuplicateBaseRecord = csuAddresshistoryDuplicateBaseRecord;
            CsuAddresshistoryAsyncOperations = csuAddresshistoryAsyncOperations;
            CsuAddresshistoryMailboxTrackingFolders = csuAddresshistoryMailboxTrackingFolders;
            CsuAddresshistoryProcessSession = csuAddresshistoryProcessSession;
            CsuAddresshistoryBulkDeleteFailures = csuAddresshistoryBulkDeleteFailures;
            CsuAddresshistoryPrincipalObjectAttributeAccesses = csuAddresshistoryPrincipalObjectAttributeAccesses;
            CsuPersonDetailid = csuPersonDetailid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_iscurrentaddress")]
        public bool? CsuIscurrentaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1_country")]
        public string CsuAddress1Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1_stateorprovince")]
        public string CsuAddress1Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1_line2")]
        public string CsuAddress1Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_province")]
        public string CsuProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistoryid")]
        public string CsuAddresshistoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addressdateto")]
        public System.DateTimeOffset? CsuAddressdateto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1_line1")]
        public string CsuAddress1Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1_city")]
        public string CsuAddress1City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addressdescription")]
        public string CsuAddressdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_persondetailid_value")]
        public string _csuPersondetailidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1_postalcode")]
        public string CsuAddress1Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addressdatefrom")]
        public System.DateTimeOffset? CsuAddressdatefrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

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
        [JsonProperty(PropertyName = "csu_addresshistory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuAddresshistorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuAddresshistoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuAddresshistoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuAddresshistoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuAddresshistoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuAddresshistoryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuAddresshistoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addresshistory_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuAddresshistoryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_PersonDetailid")]
        public MicrosoftDynamicsCRMcontact CsuPersonDetailid { get; set; }

    }
}
