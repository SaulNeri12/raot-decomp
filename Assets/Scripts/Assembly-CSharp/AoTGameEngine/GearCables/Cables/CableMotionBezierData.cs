using UnityEngine;

namespace AoTGameEngine.GearCables.Cables
{
	public struct CableMotionBezierData // TypeDefIndex: 9355
	{
		// Fields
		private readonly float maxDistance; // 0x0
		private readonly float intensity; // 0x4
		private readonly Vector3 randomDirection; // 0x8
		private float progress; // 0x14
		private bool isProgressAdvancing; // 0x18

		public CableMotionBezierData(float maxDistance, bool isProgressAdvancing, float intensity) { 
			this.maxDistance = maxDistance;
			this.intensity = intensity;
			this.isProgressAdvancing  = isProgressAdvancing;
			this.progress = 0.0f;
			this.randomDirection = new Vector3(0,0,0);
		}

		/*
		TODO: Complete the Bezier class
		private Bezier.LinearData linearData; // 0x1C
		private Bezier.CubicData cubicDataA; // 0x34
		private Bezier.CubicData cubicDataB; // 0x64

		// Methods

		// RVA: 0x4EC100 Offset: 0x4EAB00 VA: 0x1804EC100
		//public void .ctor(float maxDistance, bool isProgressAdvancing, float intensity) { }

		// RVA: 0x4EC1B0 Offset: 0x4EABB0 VA: 0x1804EC1B0
		private float GetWaviness() { }

		// RVA: 0x4EC330 Offset: 0x4EAD30 VA: 0x1804EC330
		private Vector3 GetPointOnCurve(float t, float s) { return null;}

		// RVA: 0x4EC460 Offset: 0x4EAE60 VA: 0x1804EC460
		private Vector3 GetPointOnLine(float t) { return null; }

		// RVA: 0x4EC670 Offset: 0x4EB070 VA: 0x1804EC670
		public Vector3 GetBlendedPoint(float percentAlongPath) { return null; }

		// RVA: 0x4EC7F0 Offset: 0x4EB1F0 VA: 0x1804EC7F0
		public void Update(Vector3 start, Vector3 end) { }
		*/
	}
}