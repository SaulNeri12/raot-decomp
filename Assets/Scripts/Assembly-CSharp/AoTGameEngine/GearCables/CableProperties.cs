using UnityEngine;
using UnityEngine.Rendering;

namespace AoTGameEngine.GearCables
{
	public class CableProperties : MonoBehaviour
	{
		// Fields

        /// <summary>
        /// The maximum number of vertices the cable can have. 
        /// This is used for controlling the detail of the cable's mesh.
        /// </summary>
        public const int MAX_VERTICES = 16;

        /// <summary>
        /// The prefab used as the anchor point for the cable, where it attaches to surfaces or objects.
        /// </summary>
        public GameObject anchorPrefab; // 0x18

        /// <summary>
        /// The speed at which the cable advances (extends) when deployed.
        /// </summary>
        public float advanceSpeed; // 0x20

        /// <summary>
        /// The speed at which the cable retracts when pulled back.
        /// </summary>
        public float retractSpeed; // 0x24

        /// <summary>
        /// Indicates whether to use a local pool of vertices for the cable. 
        /// This can optimize performance by reusing mesh data.
        /// </summary>
        public bool useLocalVertexPool; // 0x28

        /// <summary>
        /// The width of the cable, defining how thick it appears in the game world.
        /// </summary>
        public float cableWidth; // 0x2C

        /// <summary>
        /// The material applied to the cable, which defines its appearance such as color and texture.
        /// </summary>
        public Material material; // 0x30

        /// <summary>
        /// Determines whether the cable casts shadows in the scene. 
        /// Controls how shadows are projected onto other objects.
        /// </summary>
        public ShadowCastingMode castShadows; // 0x38

        /// <summary>
        /// Specifies whether the cable should receive shadows from other objects.
        /// </summary>
        public bool receiveShadows;

        /// <summary>
        /// Defines the collision mode of the cable, such as None, Static, or Dynamic.
        /// This determines how the cable interacts with physical objects.
        /// </summary>
        public CableCollisionMode collisionMode; // 0x40

        /// <summary>
        /// The collision layer mask that the cable will interact with. 
        /// Specifies which layers should be considered for collisions.
        /// </summary>
        public LayerMask collisionMask; // 0x44

        /// <summary>
        /// The distance the cable juts out from its anchor point, adding a small gap between the cable and anchor.
        /// </summary>
        public float jutDistance; // 0x48

        /// <summary>
        /// Determines whether the cable will use soft corners when wrapping around obstacles.
        /// Reduces sharp bends in the cable's appearance.
        /// </summary>
        public bool useSoftCornerWrap; // 0x4C

        /// <summary>
        /// The distance the cable shifts when wrapping around corners or obstacles.
        /// </summary>
        public float wrapShiftDistance; // 0x50

        /// <summary>
        /// Enables or disables animations for the cable's movement.
        /// </summary>
        public bool animationEnabled; // 0x54

        /// <summary>
        /// The number of points used to define the cable's animation curve.
        /// Higher values create smoother animations but increase computational cost.
        /// </summary>
        public int numAnimCurvePoints; // 0x58

        /// <summary>
        /// The intensity of the cable's advance animation, controlling how dramatic the animation is when extending.
        /// </summary>
        public float advanceAnimIntensity; // 0x5C

        /// <summary>
        /// The intensity of the cable's retract animation, controlling how dramatic the animation is when retracting.
        /// </summary>
        public float retractAnimIntensity; // 0x60
	}
}