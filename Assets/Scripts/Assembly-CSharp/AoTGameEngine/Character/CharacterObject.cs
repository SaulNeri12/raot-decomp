
namespace AoTGameEngine.Character
{
	using UnityEngine;

	public class CharacterObject : MonoBehaviour
	{
		private Animator m_Animator;
		private bool m_MeshVisible;
		private bool m_IsFirstPerson;
		private bool m_HasGear;
		private bool m_HasItem;
		

		private void Start() {
			this.GetComponent<Animator>().Play("idle_alert");
		}

		private void Update() {
			if (Input.GetKeyDown("w")) {
				this.GetComponent<Animator>().Play("equipped_run");
			}
		}

		// Properties
		public Animator Animator {get => this.m_Animator; set => this.m_Animator = value;}
		private bool IsFirstPerson { get => this.m_IsFirstPerson; }
		public bool MeshVisible { get => this.m_MeshVisible; set => this.m_MeshVisible = value; }
		public bool HasGear { get => this.m_HasGear; }
		public bool HasItem { get => this.m_HasItem; }
	}
}