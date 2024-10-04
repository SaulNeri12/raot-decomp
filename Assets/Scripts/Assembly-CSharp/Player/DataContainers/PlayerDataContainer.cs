
using UnityEngine;

namespace Player.DataContainers
{
	using AoTGameEngine.Strikeables;
	using AoTGameEngine.Character;
	using AoTGameEngine.Input;

	public abstract class PlayerDataContainer
	{
		/*
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private readonly Transform <Transform>k__BackingField; // 0x10
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private readonly Rigidbody <Rigidbody>k__BackingField; // 0x18
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private readonly Strikeable <Strikeable>k__BackingField; // 0x20
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private PlayerPhysicsCache <PhysicsCache>k__BackingField; // 0x28
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private CharacterObject <Character>k__BackingField; // 0x30
		private readonly VectorHistory cameraLookHistory; // 0x38
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private PlayerStateData <StateData>k__BackingField; // 0x40
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private PlayerGearData <GearData>k__BackingField; // 0x48
		[CompilerGeneratedAttribute] // RVA: 0x2D30 Offset: 0x2130 VA: 0x180002D30
		private PlayerInputData <InputData>k__BackingField; // 0x50
		*/
		// Fields
		public const float STRIKEPOINT_HIGH_OFFSET = 1.1f;
		public const float STRIKEPOINT_LOW_OFFSET = 0.6f;
		private readonly Transform m_Transform;
		private readonly Rigidbody m_RigidBody;
		private readonly Strikeable m_Strikeable;
		private CharacterObject m_CharacterObject;
		//private readonly VectorHistory cameraLookHistory;
		// [NOTE: FOR TESTING ONLY]
		private Vector3 m_CameraLookDirection;
		private PlayerStateData m_PlayerState;
		private PlayerGearData m_GearData;
		private PlayerInputData m_InputData;

		// Properties
		public Transform Transform { get => this.m_Transform; }
		public Rigidbody RigidBody { get => this.m_RigidBody; }
		public Strikeable Strikeable { get => this.m_Strikeable; }
		//public PlayerPhysicsCache PhysicsCache { get => ; set; }
		public CharacterObject Character { get => this.m_CharacterObject; set => this.m_CharacterObject = value; }
		public Vector3 CameraLookDirection { get => this.m_CameraLookDirection; }

		/*
		public PlayerStateData StateData { get => ; set; }
		public PlayerGearData GearData { get; set; }
		public PlayerInputData InputData { get; set; }
		public abstract bool IsLocalPlayer { get; }
		*/

	}
}