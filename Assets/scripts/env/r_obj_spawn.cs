using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r_obj_spawn : MonoBehaviour
{	
	public GameObject[] EnvObject;
	private int random;
	
    // Update is called once per frame
    void Start()
    {
				random = Random.Range(0, EnvObject.Length);
				RandomSpawn();
    }
	
	private void RandomSpawn()
	{
		Instantiate(EnvObject[random], transform.position, Quaternion.identity);
	}
}
