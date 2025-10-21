using UnityEngine;
using System.Collections;

public class enemy_die : MonoBehaviour
{

	public int enemy_health = 10;
	public GameObject prefab = null;
	public GameObject blood;

	void Update()
	{
		if (enemy_health <= 0)
		{
			Destroy(gameObject, .5f);
			StartCoroutine("spawn");
			//			scorescript.scoreValue += 10;
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "bullet_deagle")
		{
			enemy_health -= 3;

		}

		else

				if (other.tag == "bullet_mac10")
		{
			enemy_health -= 1;

		}

		else
						if (other.tag == "bullet_ak74")
		{
			enemy_health -= 2;

		}


		else
								if (other.tag == "bullet_shotgun")
		{
			enemy_health -= 5;
			Instantiate(blood, transform.position, Quaternion.identity);


		}

		else
								if (other.tag == "tank")
		{
			enemy_health -= 10;
			Instantiate(blood, transform.position, Quaternion.identity);


		}

		void spawn()
		{
			Instantiate(prefab, transform.position, Quaternion.identity);
		}
	}
}