using UnityEngine;

// TODO:

namespace AoTGameEngine.GearCables
{
	public class HookAnchor : MonoBehaviour
	{
		// Fields
		/// <summary>
		/// The point where the cable is embedded into a surface or object.
		/// </summary>
		public Transform embedPoint; // 0x18

		/// <summary>
		/// The point where the cable is attached to another object or anchor.
		/// </summary>
		public Transform attachPoint; // 0x20

		// Properties
		/// <summary>
		/// Checks if the cable has an attach point defined (returns true if attachPoint is not null).
		/// </summary>
		public bool HasAttachPoint { get => this.attachPoint != null; }

		/// <summary>
		/// Checks if the cable has an embed point defined (returns true if embedPoint is not null).
		/// </summary>
		public bool HasEmbedPoint { get => this.embedPoint != null; }

		/// <summary>
		/// The current position of the cable in world space.
		/// </summary>
		public Vector3 Position { get; set; }

		/// <summary>
		/// The position of the attachment point in world space.
		/// This property is read-only.
		/// </summary>
		public Vector3 AttachPosition { get; }

		/// <summary>
		/// Indicates whether the cable is active or not.
		/// </summary>
		public bool Active { get; set; }

		/// <summary>
		/// The offset position of the cable relative to the embed point.
		/// This property is read-only.
		/// </summary>
		private Vector3 EmbedOffset { get; }


		//public void .ctor() { }
	}
}