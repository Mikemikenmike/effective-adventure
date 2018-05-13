using UnityEngine;

public class PersistentGameObject : MonoBehaviour
{

	private static bool _created = false;

	void Awake() {
		if (!_created) {
			DontDestroyOnLoad(this.gameObject);
			_created = true;
		}
	}
}
