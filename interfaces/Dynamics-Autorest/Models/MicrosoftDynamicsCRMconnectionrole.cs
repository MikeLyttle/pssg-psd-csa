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
    /// Microsoft.Dynamics.CRM.connectionrole
    /// </summary>
    public partial class MicrosoftDynamicsCRMconnectionrole
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconnectionrole class.
        /// </summary>
        public MicrosoftDynamicsCRMconnectionrole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconnectionrole class.
        /// </summary>
        public MicrosoftDynamicsCRMconnectionrole(string _organizationidValue = default(string), string versionnumber = default(string), int? statuscode = default(int?), int? componentstate = default(int?), int? importsequencenumber = default(int?), string description = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), string solutionid = default(string), string _modifiedonbehalfbyValue = default(string), int? category = default(int?), string _modifiedbyValue = default(string), int? statecode = default(int?), string iscustomizable = default(string), string connectionroleid = default(string), string connectionroleidunique = default(string), bool? ismanaged = default(bool?), string _createdonbehalfbyValue = default(string), string introducedversion = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprocesssession> connectionRoleProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> connectionRoleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMconnection> connectionRoleConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> connectionRoleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> connectionRoleConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnectionrole> connectionroleassociationAssociation = default(IList<MicrosoftDynamicsCRMconnectionrole>), IList<MicrosoftDynamicsCRMconnectionrole> connectionroleassociationAssociationReferenced = default(IList<MicrosoftDynamicsCRMconnectionrole>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
        {
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            Componentstate = componentstate;
            Importsequencenumber = importsequencenumber;
            Description = description;
            Overwritetime = overwritetime;
            Createdon = createdon;
            Modifiedon = modifiedon;
            Name = name;
            Solutionid = solutionid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Category = category;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            Iscustomizable = iscustomizable;
            Connectionroleid = connectionroleid;
            Connectionroleidunique = connectionroleidunique;
            Ismanaged = ismanaged;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Introducedversion = introducedversion;
            this._createdbyValue = _createdbyValue;
            Modifiedby = modifiedby;
            Createdby = createdby;
            ConnectionRoleProcessSessions = connectionRoleProcessSessions;
            Modifiedonbehalfby = modifiedonbehalfby;
            ConnectionRoleAsyncOperations = connectionRoleAsyncOperations;
            ConnectionRoleConnections2 = connectionRoleConnections2;
            ConnectionRoleSyncErrors = connectionRoleSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            ConnectionRoleConnections1 = connectionRoleConnections1;
            ConnectionroleassociationAssociation = connectionroleassociationAssociation;
            ConnectionroleassociationAssociationReferenced = connectionroleassociationAssociationReferenced;
            Organizationid = organizationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public int? Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionroleid")]
        public string Connectionroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionroleidunique")]
        public string Connectionroleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConnectionRole_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ConnectionRoleProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Connection_Role_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ConnectionRoleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_role_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ConnectionRoleConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConnectionRole_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ConnectionRoleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_role_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ConnectionRoleConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionroleassociation_association")]
        public IList<MicrosoftDynamicsCRMconnectionrole> ConnectionroleassociationAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionroleassociation_association_referenced")]
        public IList<MicrosoftDynamicsCRMconnectionrole> ConnectionroleassociationAssociationReferenced { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

    }
}