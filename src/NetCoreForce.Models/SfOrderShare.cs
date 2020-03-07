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
	/// Order Share
	///<para>SObject Name: OrderShare</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOrderShare : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OrderShare"; }
		}

		///<summary>
		/// Order Share ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Order ID
		/// <para>Name: OrderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orderId")]
		[Updateable(false), Creatable(false)]
		public string OrderId { get; set; }

		///<summary>
		/// ReferenceTo: Order
		/// <para>RelationshipName: Order</para>
		///</summary>
		[JsonProperty(PropertyName = "order")]
		[Updateable(false), Creatable(false)]
		public SfOrder Order { get; set; }

		///<summary>
		/// User/Group ID
		/// <para>Name: UserOrGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userOrGroupId")]
		[Updateable(false), Creatable(false)]
		public string UserOrGroupId { get; set; }

		///<summary>
		/// Order Access Level
		/// <para>Name: OrderAccessLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orderAccessLevel")]
		[Updateable(false), Creatable(false)]
		public string OrderAccessLevel { get; set; }

		///<summary>
		/// Apex Sharing Reason ID
		/// <para>Name: RowCause</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowCause")]
		[Updateable(false), Creatable(false)]
		public string RowCause { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

	}
}
