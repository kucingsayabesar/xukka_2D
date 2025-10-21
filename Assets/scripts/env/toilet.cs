using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tar : MonoBehaviour {

public GameObject quote;
public GameObject quote2;
public GameObject fake_obj_gam = null;
public GameObject prefab = null;	

public static  int healthToilet = 69;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "bullet"){
			healthToilet -= 1;
			Instantiate(quote, transform.position, Quaternion.identity);
			if(healthToilet == 0){
			Invoke("quote2_spawn", 1f);
			}
		}
	}
	void quote2_spawn () {
			Destroy(gameObject,.5f);
			StartCoroutine ("spawn");
		Instantiate(quote2, transform.position, Quaternion.identity);
		}
	void spawn () {
		Instantiate(fake_obj_gam, transform.position, Quaternion.identity);
		Invoke("spawn_vanya", 0.5f);
	}
	void spawn_vanya () {
		Instantiate(prefab, transform.position, Quaternion.identity);
	}
	}