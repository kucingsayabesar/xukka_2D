using UnityEngine;
using System.Collections;

public class physic_item : MonoBehaviour {

	public int enemy_health = 10;
	public GameObject small_pieces = null;
	public GameObject scrap = null;

	

	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "bullet")
		{
			enemy_health -= 1;
			Instantiate(small_pieces, transform.position, Quaternion.identity);
		
						if(enemy_health <= 0){
						Destroy(gameObject,.5f);
						StartCoroutine ("spawn");
						}
		}
	}
	
		void spawn () {
		Instantiate(scrap, transform.position, Quaternion.identity);
	}
}