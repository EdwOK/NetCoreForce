// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Permission Set License
	///<para>SObject Name: PermissionSetLicense</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPermissionSetLicense : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PermissionSetLicense"; }
		}

		///<summary>
		/// Permission Set License ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Creatable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Creatable(false)]
		public string Language { get; set; }

		///<summary>
		/// Permission Set License Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Creatable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Permission Set License Key
		/// <para>Name: PermissionSetLicenseKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetLicenseKey")]
		[Updateable(false), Creatable(false)]
		public string PermissionSetLicenseKey { get; set; }

		///<summary>
		/// Total Licenses
		/// <para>Name: TotalLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "totalLicenses")]
		[Updateable(false), Creatable(false)]
		public int? TotalLicenses { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Creatable(false)]
		public string Status { get; set; }

		///<summary>
		/// Expiration Date
		/// <para>Name: ExpirationDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expirationDate")]
		[Updateable(false), Creatable(false)]
		public DateTime? ExpirationDate { get; set; }

		///<summary>
		/// Send Email
		/// <para>Name: MaximumPermissionsEmailSingle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailSingle")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEmailSingle { get; set; }

		///<summary>
		/// Mass Email
		/// <para>Name: MaximumPermissionsEmailMass</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailMass")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEmailMass { get; set; }

		///<summary>
		/// Edit Tasks
		/// <para>Name: MaximumPermissionsEditTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditTask")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditTask { get; set; }

		///<summary>
		/// Edit Events
		/// <para>Name: MaximumPermissionsEditEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditEvent")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditEvent { get; set; }

		///<summary>
		/// Export Reports
		/// <para>Name: MaximumPermissionsExportReport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsExportReport")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsExportReport { get; set; }

		///<summary>
		/// Import Personal Contacts
		/// <para>Name: MaximumPermissionsImportPersonal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsImportPersonal")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsImportPersonal { get; set; }

		///<summary>
		/// Manage Users
		/// <para>Name: MaximumPermissionsManageUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageUsers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageUsers { get; set; }

		///<summary>
		/// Manage Public List Views
		/// <para>Name: MaximumPermissionsEditPublicFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditPublicFilters")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditPublicFilters { get; set; }

		///<summary>
		/// Manage Public Templates
		/// <para>Name: MaximumPermissionsEditPublicTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditPublicTemplates")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditPublicTemplates { get; set; }

		///<summary>
		/// Modify All Data
		/// <para>Name: MaximumPermissionsModifyAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModifyAllData")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsModifyAllData { get; set; }

		///<summary>
		/// Manage Cases
		/// <para>Name: MaximumPermissionsManageCases</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCases")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageCases { get; set; }

		///<summary>
		/// Mass Edits from Lists
		/// <para>Name: MaximumPermissionsMassInlineEdit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsMassInlineEdit")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsMassInlineEdit { get; set; }

		///<summary>
		/// Manage Articles
		/// <para>Name: MaximumPermissionsEditKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditKnowledge")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditKnowledge { get; set; }

		///<summary>
		/// Manage Salesforce Knowledge
		/// <para>Name: MaximumPermissionsManageKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageKnowledge")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageKnowledge { get; set; }

		///<summary>
		/// Manage Published Solutions
		/// <para>Name: MaximumPermissionsManageSolutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSolutions")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageSolutions { get; set; }

		///<summary>
		/// Customize Application
		/// <para>Name: MaximumPermissionsCustomizeApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomizeApplication")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCustomizeApplication { get; set; }

		///<summary>
		/// Edit Read Only Fields
		/// <para>Name: MaximumPermissionsEditReadonlyFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditReadonlyFields")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditReadonlyFields { get; set; }

		///<summary>
		/// Run Reports
		/// <para>Name: MaximumPermissionsRunReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsRunReports")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsRunReports { get; set; }

		///<summary>
		/// View Setup and Configuration
		/// <para>Name: MaximumPermissionsViewSetup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewSetup")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewSetup { get; set; }

		///<summary>
		/// Transfer Record
		/// <para>Name: MaximumPermissionsTransferAnyEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransferAnyEntity")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsTransferAnyEntity { get; set; }

		///<summary>
		/// Report Builder
		/// <para>Name: MaximumPermissionsNewReportBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsNewReportBuilder")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsNewReportBuilder { get; set; }

		///<summary>
		/// Activate Contracts
		/// <para>Name: MaximumPermissionsActivateContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsActivateContract")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsActivateContract { get; set; }

		///<summary>
		/// Activate Orders
		/// <para>Name: MaximumPermissionsActivateOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsActivateOrder")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsActivateOrder { get; set; }

		///<summary>
		/// Import Leads
		/// <para>Name: MaximumPermissionsImportLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsImportLeads")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsImportLeads { get; set; }

		///<summary>
		/// Manage Leads
		/// <para>Name: MaximumPermissionsManageLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageLeads")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageLeads { get; set; }

		///<summary>
		/// Transfer Leads
		/// <para>Name: MaximumPermissionsTransferAnyLead</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransferAnyLead")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsTransferAnyLead { get; set; }

		///<summary>
		/// View All Data
		/// <para>Name: MaximumPermissionsViewAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllData")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewAllData { get; set; }

		///<summary>
		/// Manage Public Documents
		/// <para>Name: MaximumPermissionsEditPublicDocuments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditPublicDocuments")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditPublicDocuments { get; set; }

		///<summary>
		/// View Encrypted Data
		/// <para>Name: MaximumPermissionsViewEncryptedData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewEncryptedData")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewEncryptedData { get; set; }

		///<summary>
		/// Manage Letterheads
		/// <para>Name: MaximumPermissionsEditBrandTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditBrandTemplates")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditBrandTemplates { get; set; }

		///<summary>
		/// Edit HTML Templates
		/// <para>Name: MaximumPermissionsEditHtmlTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditHtmlTemplates")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditHtmlTemplates { get; set; }

		///<summary>
		/// Chatter Internal User
		/// <para>Name: MaximumPermissionsChatterInternalUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterInternalUser")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterInternalUser { get; set; }

		///<summary>
		/// Manage Encryption Keys
		/// <para>Name: MaximumPermissionsManageEncryptionKeys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageEncryptionKeys")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageEncryptionKeys { get; set; }

		///<summary>
		/// Delete Activated Contracts
		/// <para>Name: MaximumPermissionsDeleteActivatedContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDeleteActivatedContract")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsDeleteActivatedContract { get; set; }

		///<summary>
		/// Invite Customers To Chatter
		/// <para>Name: MaximumPermissionsChatterInviteExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterInviteExternalUsers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterInviteExternalUsers { get; set; }

		///<summary>
		/// Send Stay-in-Touch Requests
		/// <para>Name: MaximumPermissionsSendSitRequests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSendSitRequests")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSendSitRequests { get; set; }

		///<summary>
		/// Manage Connected Apps
		/// <para>Name: MaximumPermissionsManageRemoteAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageRemoteAccess")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageRemoteAccess { get; set; }

		///<summary>
		/// Drag-and-Drop Dashboard Builder
		/// <para>Name: MaximumPermissionsCanUseNewDashboardBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanUseNewDashboardBuilder")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCanUseNewDashboardBuilder { get; set; }

		///<summary>
		/// Manage Categories
		/// <para>Name: MaximumPermissionsManageCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCategories")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageCategories { get; set; }

		///<summary>
		/// Convert Leads
		/// <para>Name: MaximumPermissionsConvertLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConvertLeads")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsConvertLeads { get; set; }

		///<summary>
		/// Password Never Expires
		/// <para>Name: MaximumPermissionsPasswordNeverExpires</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPasswordNeverExpires")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsPasswordNeverExpires { get; set; }

		///<summary>
		/// Use Team Reassignment Wizards
		/// <para>Name: MaximumPermissionsUseTeamReassignWizards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsUseTeamReassignWizards")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsUseTeamReassignWizards { get; set; }

		///<summary>
		/// Edit Activated Orders
		/// <para>Name: MaximumPermissionsEditActivatedOrders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditActivatedOrders")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditActivatedOrders { get; set; }

		///<summary>
		/// Download AppExchange Packages
		/// <para>Name: MaximumPermissionsInstallPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInstallPackaging")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsInstallPackaging { get; set; }

		///<summary>
		/// Upload AppExchange Packages
		/// <para>Name: MaximumPermissionsPublishPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPublishPackaging")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsPublishPackaging { get; set; }

		///<summary>
		/// Create and Own New Chatter Groups
		/// <para>Name: MaximumPermissionsChatterOwnGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterOwnGroups")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterOwnGroups { get; set; }

		///<summary>
		/// Edit Opportunity Product Sales Price
		/// <para>Name: MaximumPermissionsEditOppLineItemUnitPrice</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditOppLineItemUnitPrice")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditOppLineItemUnitPrice { get; set; }

		///<summary>
		/// Create AppExchange Packages
		/// <para>Name: MaximumPermissionsCreatePackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreatePackaging")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreatePackaging { get; set; }

		///<summary>
		/// Bulk API Hard Delete
		/// <para>Name: MaximumPermissionsBulkApiHardDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsBulkApiHardDelete")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsBulkApiHardDelete { get; set; }

		///<summary>
		/// Import Solutions
		/// <para>Name: MaximumPermissionsSolutionImport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSolutionImport")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSolutionImport { get; set; }

		///<summary>
		/// Manage Call Centers
		/// <para>Name: MaximumPermissionsManageCallCenters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCallCenters")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageCallCenters { get; set; }

		///<summary>
		/// Manage Synonyms
		/// <para>Name: MaximumPermissionsManageSynonyms</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSynonyms")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageSynonyms { get; set; }

		///<summary>
		/// View Content in Portals
		/// <para>Name: MaximumPermissionsViewContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewContent")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewContent { get; set; }

		///<summary>
		/// Manage Email Client Configurations
		/// <para>Name: MaximumPermissionsManageEmailClientConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageEmailClientConfig")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageEmailClientConfig { get; set; }

		///<summary>
		/// Send Outbound Messages
		/// <para>Name: MaximumPermissionsEnableNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEnableNotifications")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEnableNotifications { get; set; }

		///<summary>
		/// Manage Data Integrations
		/// <para>Name: MaximumPermissionsManageDataIntegrations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDataIntegrations")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageDataIntegrations { get; set; }

		///<summary>
		/// Create Content Deliveries
		/// <para>Name: MaximumPermissionsDistributeFromPersWksp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDistributeFromPersWksp")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsDistributeFromPersWksp { get; set; }

		///<summary>
		/// View Data Categories
		/// <para>Name: MaximumPermissionsViewDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewDataCategories")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewDataCategories { get; set; }

		///<summary>
		/// Manage Data Categories
		/// <para>Name: MaximumPermissionsManageDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDataCategories")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageDataCategories { get; set; }

		///<summary>
		/// Author Apex
		/// <para>Name: MaximumPermissionsAuthorApex</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAuthorApex")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAuthorApex { get; set; }

		///<summary>
		/// Manage Mobile Configurations
		/// <para>Name: MaximumPermissionsManageMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageMobile")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageMobile { get; set; }

		///<summary>
		/// API Enabled
		/// <para>Name: MaximumPermissionsApiEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsApiEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsApiEnabled { get; set; }

		///<summary>
		/// Manage Custom Report Types
		/// <para>Name: MaximumPermissionsManageCustomReportTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCustomReportTypes")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageCustomReportTypes { get; set; }

		///<summary>
		/// Edit Case Comments
		/// <para>Name: MaximumPermissionsEditCaseComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditCaseComments")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditCaseComments { get; set; }

		///<summary>
		/// Transfer Cases
		/// <para>Name: MaximumPermissionsTransferAnyCase</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransferAnyCase")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsTransferAnyCase { get; set; }

		///<summary>
		/// Manage Salesforce CRM Content
		/// <para>Name: MaximumPermissionsContentAdministrator</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsContentAdministrator")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsContentAdministrator { get; set; }

		///<summary>
		/// Create Libraries
		/// <para>Name: MaximumPermissionsCreateWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateWorkspaces")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateWorkspaces { get; set; }

		///<summary>
		/// Manage Content Permissions
		/// <para>Name: MaximumPermissionsManageContentPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageContentPermissions")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageContentPermissions { get; set; }

		///<summary>
		/// Manage Content Properties
		/// <para>Name: MaximumPermissionsManageContentProperties</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageContentProperties")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageContentProperties { get; set; }

		///<summary>
		/// Manage record types and layouts for Files
		/// <para>Name: MaximumPermissionsManageContentTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageContentTypes")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageContentTypes { get; set; }

		///<summary>
		/// Manage Lightning Sync
		/// <para>Name: MaximumPermissionsManageExchangeConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageExchangeConfig")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageExchangeConfig { get; set; }

		///<summary>
		/// Manage Reporting Snapshots
		/// <para>Name: MaximumPermissionsManageAnalyticSnapshots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageAnalyticSnapshots")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageAnalyticSnapshots { get; set; }

		///<summary>
		/// Schedule Reports
		/// <para>Name: MaximumPermissionsScheduleReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsScheduleReports")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsScheduleReports { get; set; }

		///<summary>
		/// Manage Business Hours Holidays
		/// <para>Name: MaximumPermissionsManageBusinessHourHolidays</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageBusinessHourHolidays")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageBusinessHourHolidays { get; set; }

		///<summary>
		/// Manage Dynamic Dashboards
		/// <para>Name: MaximumPermissionsManageDynamicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDynamicDashboards")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageDynamicDashboards { get; set; }

		///<summary>
		/// Show Custom Sidebar On All Pages
		/// <para>Name: MaximumPermissionsCustomSidebarOnAllPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomSidebarOnAllPages")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCustomSidebarOnAllPages { get; set; }

		///<summary>
		/// Manage Force.com Flow
		/// <para>Name: MaximumPermissionsManageInteraction</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageInteraction")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageInteraction { get; set; }

		///<summary>
		/// View My Team&#39;s Dashboards
		/// <para>Name: MaximumPermissionsViewMyTeamsDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewMyTeamsDashboards")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewMyTeamsDashboards { get; set; }

		///<summary>
		/// Moderate Chatter
		/// <para>Name: MaximumPermissionsModerateChatter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModerateChatter")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsModerateChatter { get; set; }

		///<summary>
		/// Reset User Passwords and Unlock Users
		/// <para>Name: MaximumPermissionsResetPasswords</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsResetPasswords")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsResetPasswords { get; set; }

		///<summary>
		/// Require Force.com Flow User Feature License
		/// <para>Name: MaximumPermissionsFlowUFLRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsFlowUFLRequired")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsFlowUFLRequired { get; set; }

		///<summary>
		/// Insert System Field Values for Chatter Feeds
		/// <para>Name: MaximumPermissionsCanInsertFeedSystemFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanInsertFeedSystemFields")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCanInsertFeedSystemFields { get; set; }

		///<summary>
		/// Manage Knowledge Article Import/Export
		/// <para>Name: MaximumPermissionsManageKnowledgeImportExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageKnowledgeImportExport")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageKnowledgeImportExport { get; set; }

		///<summary>
		/// Manage Email Templates
		/// <para>Name: MaximumPermissionsEmailTemplateManagement</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailTemplateManagement")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEmailTemplateManagement { get; set; }

		///<summary>
		/// Email Administration
		/// <para>Name: MaximumPermissionsEmailAdministration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailAdministration")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEmailAdministration { get; set; }

		///<summary>
		/// Manage Chatter Messages and Direct Messages
		/// <para>Name: MaximumPermissionsManageChatterMessages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageChatterMessages")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageChatterMessages { get; set; }

		///<summary>
		/// Email-Based Identity Verification Option
		/// <para>Name: MaximumPermissionsAllowEmailIC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowEmailIC")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAllowEmailIC { get; set; }

		///<summary>
		/// Create Public Links
		/// <para>Name: MaximumPermissionsChatterFileLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterFileLink")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterFileLink { get; set; }

		///<summary>
		/// Two-Factor Authentication for User Interface Logins
		/// <para>Name: MaximumPermissionsForceTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsForceTwoFactor")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsForceTwoFactor { get; set; }

		///<summary>
		/// View Event Log Files
		/// <para>Name: MaximumPermissionsViewEventLogFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewEventLogFiles")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewEventLogFiles { get; set; }

		///<summary>
		/// Create and Set Up Communities
		/// <para>Name: MaximumPermissionsManageNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageNetworks")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageNetworks { get; set; }

		///<summary>
		/// Manage Auth. Providers
		/// <para>Name: MaximumPermissionsManageAuthProviders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageAuthProviders")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageAuthProviders { get; set; }

		///<summary>
		/// Run Flows
		/// <para>Name: MaximumPermissionsRunFlow</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsRunFlow")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsRunFlow { get; set; }

		///<summary>
		/// Create and Customize Dashboards
		/// <para>Name: MaximumPermissionsCreateCustomizeDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateCustomizeDashboards")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateCustomizeDashboards { get; set; }

		///<summary>
		/// Create Dashboard Folders
		/// <para>Name: MaximumPermissionsCreateDashboardFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateDashboardFolders")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateDashboardFolders { get; set; }

		///<summary>
		/// View Dashboards in Public Folders
		/// <para>Name: MaximumPermissionsViewPublicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewPublicDashboards")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewPublicDashboards { get; set; }

		///<summary>
		/// Manage Dashboards in Public Folders
		/// <para>Name: MaximumPermissionsManageDashbdsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDashbdsInPubFolders")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageDashbdsInPubFolders { get; set; }

		///<summary>
		/// Create and Customize Reports
		/// <para>Name: MaximumPermissionsCreateCustomizeReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateCustomizeReports")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateCustomizeReports { get; set; }

		///<summary>
		/// Create Report Folders
		/// <para>Name: MaximumPermissionsCreateReportFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateReportFolders")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateReportFolders { get; set; }

		///<summary>
		/// View Reports in Public Folders
		/// <para>Name: MaximumPermissionsViewPublicReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewPublicReports")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewPublicReports { get; set; }

		///<summary>
		/// Manage Reports in Public Folders
		/// <para>Name: MaximumPermissionsManageReportsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageReportsInPubFolders")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageReportsInPubFolders { get; set; }

		///<summary>
		/// Edit My Dashboards
		/// <para>Name: MaximumPermissionsEditMyDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditMyDashboards")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditMyDashboards { get; set; }

		///<summary>
		/// Edit My Reports
		/// <para>Name: MaximumPermissionsEditMyReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditMyReports")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditMyReports { get; set; }

		///<summary>
		/// View All Users
		/// <para>Name: MaximumPermissionsViewAllUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllUsers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewAllUsers { get; set; }

		///<summary>
		/// Knowledge One
		/// <para>Name: MaximumPermissionsAllowUniversalSearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowUniversalSearch")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAllowUniversalSearch { get; set; }

		///<summary>
		/// Connect Organization to Environment Hub
		/// <para>Name: MaximumPermissionsConnectOrgToEnvironmentHub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConnectOrgToEnvironmentHub")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsConnectOrgToEnvironmentHub { get; set; }

		///<summary>
		/// Enable Work.com Calibration
		/// <para>Name: MaximumPermissionsWorkCalibrationUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsWorkCalibrationUser")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsWorkCalibrationUser { get; set; }

		///<summary>
		/// Create and Customize List Views
		/// <para>Name: MaximumPermissionsCreateCustomizeFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateCustomizeFilters")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateCustomizeFilters { get; set; }

		///<summary>
		/// Enable Work.com
		/// <para>Name: MaximumPermissionsWorkDotComUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsWorkDotComUserPerm")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsWorkDotComUserPerm { get; set; }

		///<summary>
		/// Manage Communities
		/// <para>Name: MaximumPermissionsGovernNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsGovernNetworks")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsGovernNetworks { get; set; }

		///<summary>
		/// Sales Console
		/// <para>Name: MaximumPermissionsSalesConsole</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSalesConsole")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSalesConsole { get; set; }

		///<summary>
		/// Two-Factor Authentication for API Logins
		/// <para>Name: MaximumPermissionsTwoFactorApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTwoFactorApi")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsTwoFactorApi { get; set; }

		///<summary>
		/// Delete Topics
		/// <para>Name: MaximumPermissionsDeleteTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDeleteTopics")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsDeleteTopics { get; set; }

		///<summary>
		/// Edit Topics
		/// <para>Name: MaximumPermissionsEditTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditTopics")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEditTopics { get; set; }

		///<summary>
		/// Create Topics
		/// <para>Name: MaximumPermissionsCreateTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateTopics")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateTopics { get; set; }

		///<summary>
		/// Assign Topics
		/// <para>Name: MaximumPermissionsAssignTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAssignTopics")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAssignTopics { get; set; }

		///<summary>
		/// Use Identity Features
		/// <para>Name: MaximumPermissionsIdentityEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIdentityEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsIdentityEnabled { get; set; }

		///<summary>
		/// Use Identity Connect
		/// <para>Name: MaximumPermissionsIdentityConnect</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIdentityConnect")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsIdentityConnect { get; set; }

		///<summary>
		/// Allow View Knowledge
		/// <para>Name: MaximumPermissionsAllowViewKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowViewKnowledge")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAllowViewKnowledge { get; set; }

		///<summary>
		/// Access Libraries
		/// <para>Name: MaximumPermissionsContentWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsContentWorkspaces")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsContentWorkspaces { get; set; }

		///<summary>
		/// Manage Promoted Search Terms
		/// <para>Name: MaximumPermissionsManageSearchPromotionRules</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSearchPromotionRules")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageSearchPromotionRules { get; set; }

		///<summary>
		/// Access Custom Mobile Apps
		/// <para>Name: MaximumPermissionsCustomMobileAppsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomMobileAppsAccess")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCustomMobileAppsAccess { get; set; }

		///<summary>
		/// View Help Link
		/// <para>Name: MaximumPermissionsViewHelpLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewHelpLink")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewHelpLink { get; set; }

		///<summary>
		/// Manage Profiles and Permission Sets
		/// <para>Name: MaximumPermissionsManageProfilesPermissionsets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageProfilesPermissionsets")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageProfilesPermissionsets { get; set; }

		///<summary>
		/// Assign Permission Sets
		/// <para>Name: MaximumPermissionsAssignPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAssignPermissionSets")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAssignPermissionSets { get; set; }

		///<summary>
		/// Manage Roles
		/// <para>Name: MaximumPermissionsManageRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageRoles")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageRoles { get; set; }

		///<summary>
		/// Manage IP Addresses
		/// <para>Name: MaximumPermissionsManageIpAddresses</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageIpAddresses")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageIpAddresses { get; set; }

		///<summary>
		/// Manage Sharing
		/// <para>Name: MaximumPermissionsManageSharing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSharing")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageSharing { get; set; }

		///<summary>
		/// Manage Internal Users
		/// <para>Name: MaximumPermissionsManageInternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageInternalUsers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageInternalUsers { get; set; }

		///<summary>
		/// Manage Password Policies
		/// <para>Name: MaximumPermissionsManagePasswordPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManagePasswordPolicies")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManagePasswordPolicies { get; set; }

		///<summary>
		/// Manage Login Access Policies
		/// <para>Name: MaximumPermissionsManageLoginAccessPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageLoginAccessPolicies")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageLoginAccessPolicies { get; set; }

		///<summary>
		/// Manage Custom Permissions
		/// <para>Name: MaximumPermissionsManageCustomPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCustomPermissions")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageCustomPermissions { get; set; }

		///<summary>
		/// Verify Answers to Chatter Questions
		/// <para>Name: MaximumPermissionsCanVerifyComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanVerifyComment")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCanVerifyComment { get; set; }

		///<summary>
		/// Manage Unlisted Groups
		/// <para>Name: MaximumPermissionsManageUnlistedGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageUnlistedGroups")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageUnlistedGroups { get; set; }

		///<summary>
		/// Modify Secure Agents
		/// <para>Name: MaximumPermissionsModifySecureAgents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModifySecureAgents")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsModifySecureAgents { get; set; }

		///<summary>
		/// Manage Two-Factor Authentication in API
		/// <para>Name: MaximumPermissionsManageTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageTwoFactor")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageTwoFactor { get; set; }

		///<summary>
		/// Access Chatter For SharePoint
		/// <para>Name: MaximumPermissionsChatterForSharePoint</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterForSharePoint")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterForSharePoint { get; set; }

		///<summary>
		/// Lightning Experience User
		/// <para>Name: MaximumPermissionsLightningExperienceUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLightningExperienceUser")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsLightningExperienceUser { get; set; }

		///<summary>
		/// Configure Custom Recommendations
		/// <para>Name: MaximumPermissionsConfigCustomRecs</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConfigCustomRecs")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsConfigCustomRecs { get; set; }

		///<summary>
		/// Manage Macros Users Can&#39;t Undo
		/// <para>Name: MaximumPermissionsSubmitMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubmitMacrosAllowed")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSubmitMacrosAllowed { get; set; }

		///<summary>
		/// Run Macros on Multiple Records
		/// <para>Name: MaximumPermissionsBulkMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsBulkMacrosAllowed")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsBulkMacrosAllowed { get; set; }

		///<summary>
		/// Share internal Knowledge articles externally
		/// <para>Name: MaximumPermissionsShareInternalArticles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsShareInternalArticles")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsShareInternalArticles { get; set; }

		///<summary>
		/// Manage Session Permission Set Activations
		/// <para>Name: MaximumPermissionsManageSessionPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSessionPermissionSets")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageSessionPermissionSets { get; set; }

		///<summary>
		/// Send announcement emails
		/// <para>Name: MaximumPermissionsSendAnnouncementEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSendAnnouncementEmails")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSendAnnouncementEmails { get; set; }

		///<summary>
		/// Edit My Own Posts
		/// <para>Name: MaximumPermissionsChatterEditOwnPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterEditOwnPost")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterEditOwnPost { get; set; }

		///<summary>
		/// Edit Posts on Records I Own
		/// <para>Name: MaximumPermissionsChatterEditOwnRecordPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterEditOwnRecordPost")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterEditOwnRecordPost { get; set; }

		///<summary>
		/// Import Custom Objects
		/// <para>Name: MaximumPermissionsImportCustomObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsImportCustomObjects")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsImportCustomObjects { get; set; }

		///<summary>
		/// Manage Two-Factor Authentication in User Interface
		/// <para>Name: MaximumPermissionsDelegatedTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDelegatedTwoFactor")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsDelegatedTwoFactor { get; set; }

		///<summary>
		/// Allow Inclusion of Code Snippets from UI
		/// <para>Name: MaximumPermissionsChatterComposeUiCodesnippet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterComposeUiCodesnippet")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsChatterComposeUiCodesnippet { get; set; }

		///<summary>
		/// Select Files from Salesforce
		/// <para>Name: MaximumPermissionsSelectFilesFromSalesforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSelectFilesFromSalesforce")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSelectFilesFromSalesforce { get; set; }

		///<summary>
		/// Moderate Community Users
		/// <para>Name: MaximumPermissionsModerateNetworkUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModerateNetworkUsers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsModerateNetworkUsers { get; set; }

		///<summary>
		/// Merge Topics
		/// <para>Name: MaximumPermissionsMergeTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsMergeTopics")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsMergeTopics { get; set; }

		///<summary>
		/// Subscribe to Reports
		/// <para>Name: MaximumPermissionsSubscribeToLightningReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeToLightningReports")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSubscribeToLightningReports { get; set; }

		///<summary>
		/// Manage All Private Reports and Dashboards
		/// <para>Name: MaximumPermissionsManagePvtRptsAndDashbds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManagePvtRptsAndDashbds")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManagePvtRptsAndDashbds { get; set; }

		///<summary>
		/// Lightning Login User
		/// <para>Name: MaximumPermissionsAllowLightningLogin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowLightningLogin")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAllowLightningLogin { get; set; }

		///<summary>
		/// Campaign Influence
		/// <para>Name: MaximumPermissionsCampaignInfluence2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCampaignInfluence2")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCampaignInfluence2 { get; set; }

		///<summary>
		/// Access to view Data Assessment
		/// <para>Name: MaximumPermissionsViewDataAssessment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewDataAssessment")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewDataAssessment { get; set; }

		///<summary>
		/// Remove People from Direct Messages
		/// <para>Name: MaximumPermissionsRemoveDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsRemoveDirectMessageMembers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsRemoveDirectMessageMembers { get; set; }

		///<summary>
		/// Can Approve Feed Post and Comment
		/// <para>Name: MaximumPermissionsCanApproveFeedPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanApproveFeedPost")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCanApproveFeedPost { get; set; }

		///<summary>
		/// Add People to Direct Messages
		/// <para>Name: MaximumPermissionsAddDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAddDirectMessageMembers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAddDirectMessageMembers { get; set; }

		///<summary>
		/// View and Edit Converted Leads
		/// <para>Name: MaximumPermissionsAllowViewEditConvertedLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowViewEditConvertedLeads")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAllowViewEditConvertedLeads { get; set; }

		///<summary>
		/// Show Company Name as Community Role
		/// <para>Name: MaximumPermissionsShowCompanyNameAsUserBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsShowCompanyNameAsUserBadge")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsShowCompanyNameAsUserBadge { get; set; }

		///<summary>
		/// Access Community Management
		/// <para>Name: MaximumPermissionsAccessCMC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAccessCMC")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsAccessCMC { get; set; }

		///<summary>
		/// View Health Check
		/// <para>Name: MaximumPermissionsViewHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewHealthCheck")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewHealthCheck { get; set; }

		///<summary>
		/// Manage Health Check
		/// <para>Name: MaximumPermissionsManageHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageHealthCheck")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageHealthCheck { get; set; }

		///<summary>
		/// Create and Update Second-Generation Packages
		/// <para>Name: MaximumPermissionsPackaging2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPackaging2")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsPackaging2 { get; set; }

		///<summary>
		/// Manage Certificates
		/// <para>Name: MaximumPermissionsManageCertificates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCertificates")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsManageCertificates { get; set; }

		///<summary>
		/// Report Builder (Lightning Experience)
		/// <para>Name: MaximumPermissionsCreateReportInLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateReportInLightning")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsCreateReportInLightning { get; set; }

		///<summary>
		/// Hide Option to Switch to Salesforce Classic
		/// <para>Name: MaximumPermissionsPreventClassicExperience</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPreventClassicExperience")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsPreventClassicExperience { get; set; }

		///<summary>
		/// Hide the Seen By List
		/// <para>Name: MaximumPermissionsHideReadByList</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsHideReadByList")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsHideReadByList { get; set; }

		///<summary>
		/// Allow sending of List Emails
		/// <para>Name: MaximumPermissionsListEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsListEmailSend")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsListEmailSend { get; set; }

		///<summary>
		/// Pin Posts in Feeds
		/// <para>Name: MaximumPermissionsFeedPinning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsFeedPinning")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsFeedPinning { get; set; }

		///<summary>
		/// IoT User
		/// <para>Name: MaximumPermissionsIotUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIotUser")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsIotUser { get; set; }

		///<summary>
		/// Allow WebLink access via the Tooling API
		/// <para>Name: MaximumPermissionsUseWebLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsUseWebLink")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsUseWebLink { get; set; }

		///<summary>
		/// View All Activities
		/// <para>Name: MaximumPermissionsViewAllActivities</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllActivities")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsViewAllActivities { get; set; }

		///<summary>
		/// Subscribe to Reports: Add Recipients
		/// <para>Name: MaximumPermissionsSubscribeReportToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeReportToOtherUsers")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSubscribeReportToOtherUsers { get; set; }

		///<summary>
		/// Lightning Console User
		/// <para>Name: MaximumPermissionsLightningConsoleAllowedForUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLightningConsoleAllowedForUser")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsLightningConsoleAllowedForUser { get; set; }

		///<summary>
		/// Subscribe to Reports: Set Running User
		/// <para>Name: MaximumPermissionsSubscribeReportsRunAsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeReportsRunAsUser")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsSubscribeReportsRunAsUser { get; set; }

		///<summary>
		/// Show App Launcher in Communities
		/// <para>Name: MaximumPermissionsEnableCommunityAppLauncher</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEnableCommunityAppLauncher")]
		[Updateable(false), Creatable(false)]
		public bool? MaximumPermissionsEnableCommunityAppLauncher { get; set; }

		///<summary>
		/// Used Licenses
		/// <para>Name: UsedLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usedLicenses")]
		[Updateable(false), Creatable(false)]
		public int? UsedLicenses { get; set; }

	}
}
