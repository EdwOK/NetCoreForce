// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Platform Event Subscription
	///<para>SObject Name: EventBusSubscriber</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEventBusSubscriber : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EventBusSubscriber"; }
		}

		///<summary>
		/// Event ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// External ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Creatable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// Subscriber Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Creatable(false)]
		public string Type { get; set; }

		///<summary>
		/// Topic
		/// <para>Name: Topic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "topic")]
		[Updateable(false), Creatable(false)]
		public string Topic { get; set; }

		///<summary>
		/// Position
		/// <para>Name: Position</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "position")]
		[Updateable(false), Creatable(false)]
		public int? Position { get; set; }

		///<summary>
		/// Tip
		/// <para>Name: Tip</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tip")]
		[Updateable(false), Creatable(false)]
		public int? Tip { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Creatable(false)]
		public string Status { get; set; }

	}
}
