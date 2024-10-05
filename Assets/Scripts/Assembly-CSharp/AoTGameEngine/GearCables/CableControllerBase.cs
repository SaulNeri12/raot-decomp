using UnityEngine;


namespace AoTGameEngine.GearCables
{

	using AoTGameEngine.GearCables.Cables;
	
    //[RequireComponent]
    public class CableControllerBase : MonoBehaviour
    {
        /// <summary>
        /// Delegate for handling cable phase change events.
        /// </summary>
        public delegate void CablePhaseChangeEvent();
        
        /// <summary>
        /// Delegate for handling cable retraction events.
        /// </summary>
        public delegate void CableRetractionEvent(); // Definition of the delegate

        // Fields
        /// <summary>
        /// Reference to the cable object.
        /// </summary>
        protected CableBase cable;

        /// <summary>
        /// Reference to the anchor point of the hook.
        /// </summary>
        protected HookAnchor anchor;

        /// <summary>
        /// Transform of the target to which the cable is connected.
        /// </summary>
        protected Transform cableTarget;

        /// <summary>
        /// Current phase of the cable (e.g., advancing, retracting).
        /// </summary>
        private CablePhase phase;

        /// <summary>
        /// Threshold for length change detection.
        /// </summary>
        private const float DELTA_LENGTH_THRESHOLD = 0.1f;

        /// <summary>
        /// Buffer time for reeling actions.
        /// </summary>
        private const float REEL_TIME_BUFFER = 0.1f;

        /// <summary>
        /// Length of the cable in the last frame.
        /// </summary>
        private float lengthLastFrame;

        /// <summary>
        /// Change in cable length since the last frame.
        /// </summary>
        private float deltaLength;

        /// <summary>
        /// Time when the cable was last reeled in.
        /// </summary>
        private float lastReelInTime;

        /// <summary>
        /// Time when the cable was last reeled out.
        /// </summary>
        private float lastReelOutTime;

        /// <summary>
        /// Event triggered when the cable phase changes.
        /// </summary>
        private event CablePhaseChangeEvent OnCablePhaseChanged;

        /// <summary>
        /// Event triggered when the cable is retracted past a specific point.
        /// </summary>
        private event CableRetractionEvent OnCableRetractedPastInteriorPoint; // Usage is correct.

        /// <summary>
        /// Time when the current action started.
        /// </summary>
        private float actionStartTime;

        /// <summary>
        /// Maximum duration for an action.
        /// </summary>
        private const float MAX_ACTION_DURATION = 2f;
    }
}
