using UnityEngine;
using System.Collections.Generic;

namespace AoTGameEngine.GearCables.Cables
{
    /// <summary>
    /// Abstract class that represents the base for cables in the game.
    /// </summary>
    public abstract class CableBase
    {
        // Fields
        protected CableVertexHandler cvh; // Cable vertex handler
        protected CableMotionBezierData cableMotionData; // Data for cable motion
        protected readonly CableControllerBase controller; // Controller for the cable
        private readonly List<Vector3> addPositions; // List to store additional positions

  		/// <summary>
        /// Initializes a new instance of the <see cref="CableBase"/> class.
        /// </summary>
        /// <param name="controller">The controller associated with the cable.</param>
        /// <param name="origin">The transform of the cable's origin.</param>
        /// <param name="target">The transform of the cable's target.</param>
        public CableBase(CableControllerBase controller, Transform origin, Transform target)
        {
            this.controller = controller;
			this.cableMotionData = new CableMotionBezierData(0.0f, false, 0.0f);
            // Additional initialization here
        }

        // Properties
        /// <summary>
        /// Gets the cable renderer.
        /// </summary>
        public CableRenderer CableRenderer { get; }

        /// <summary>
        /// Gets a value indicating whether the cable has internal points.
        /// </summary>
        public bool HasInternalPoints { get; }

        /// <summary>
        /// Gets the total number of vertices in the cable.
        /// </summary>
        public int VertexCount { get; }

        /// <summary>
        /// Gets the number of vertices that are rendered.
        /// </summary>
        public int RenderVertexCount { get; }

        // Methods

        /// <summary>
        /// Virtual method to draw debug information for the cable.
        /// </summary>
        public virtual void DrawDebug() { }

        /// <summary>
        /// Gets new Bezier data for the cable.
        /// </summary>
        /// <returns>Bezier motion data.</returns>
        //protected CableMotionBezierData GetNewBezierData() { return null;}

        /// <summary>
        /// Virtual method to clean up the cable.
        /// </summary>
        public virtual void Cleanup() { }

        /// <summary>
        /// Gets a vertex from the start of the cable.
        /// </summary>
        /// <param name="offset">Offset from the start.</param>
        /// <returns>The corresponding vertex.</returns>
        public virtual CableVertex GetVertexFromStart(int offset) { return null;}

        /// <summary>
        /// Gets a vertex from the end of the cable.
        /// </summary>
        /// <param name="offset">Offset from the end.</param>
        /// <returns>The corresponding vertex.</returns>
        public virtual CableVertex GetVertexFromEnd(int offset) { return null;}

        /// <summary>
        /// Abstract method to update the cable.
        /// </summary>
        public abstract void UpdateCable();

        /// <summary>
        /// Abstract method to update the vertices.
        /// </summary>
        protected abstract void UpdateVertices();

        /// <summary>
        /// Virtual method to remove the penultimate position of the cable.
        /// </summary>
        /// <returns>True if the position was removed; otherwise, false.</returns>
        public virtual bool RemovePenultimatePosition() { return false; }

        /// <summary>
        /// Virtual method to clear the cable.
        /// </summary>
        public virtual void ClearCable() { }

        /// <summary>
        /// Gets the length of the cable to the pivot point.
        /// </summary>
        /// <returns>The length of the cable to the pivot point.</returns>
        public float GetCableLengthToPivot() { return 0.0f;}

        /// <summary>
        /// Gets the total length of the cable.
        /// </summary>
        /// <returns>The total length of the cable.</returns>
        public float GetCableTotalLength() { return 0.0f;}

        /// <summary>
        /// Virtual method to get the length of the cable between two points.
        /// </summary>
        /// <param name="startIndex">The start index of the cable segment.</param>
        /// <param name="endIndex">The end index of the cable segment.</param>
        /// <returns>The length between the two points.</returns>
        public virtual float GetCableLengthBetweenPoints(int startIndex, int endIndex) { return 0.0f; }

        /// <summary>
        /// Sets the positions of the cable.
        /// </summary>
        protected void SetPositions() { }

        /// <summary>
        /// Applies soft corner wrapping to the cable.
        /// </summary>
        /// <param name="curr">The current cable vertex.</param>
        /// <param name="prev">The previous cable vertex.</param>
        private void ApplySoftCornerWrapping(CableVertex curr, CableVertex prev) { }

        /// <summary>
        /// Applies Bezier waviness to the cable.
        /// </summary>
        /// <param name="curr">The current cable vertex.</param>
        /// <param name="next">The next cable vertex.</param>
        private void ApplyBezierWaviness(CableVertex curr, CableVertex next) { }

        /// <summary>
        /// Event handler for when the cable phase changes.
        /// </summary>
        /// <param name="phase">The new phase of the cable.</param>
        //private void <.ctor>b__7_0(CablePhase phase) { }
    }
}
