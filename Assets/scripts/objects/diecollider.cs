using UnityEngine;
using UnityEngine.SceneManagement;

public class diecollider : MonoBehaviour {

	public GameObject spawnpoint;
	public GameObject blood_player = null;
	public GameObject player_grave = null;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "hero"){
			Instantiate(blood_player, transform.position, Quaternion.identity);
	//		player_health.healthValue -= 1;
		//	Invoke ("pl_grave", 1.0f);
		//	other.transform.position = spawnpoint.transform.position;
			}
		}
		void pl_grave () {
		Instantiate(player_grave, transform.position, Quaternion.identity);
		}
	}
