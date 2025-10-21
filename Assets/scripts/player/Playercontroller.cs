using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour {
	
	public Transform groundCheck_point;
	public float groundCheck_radius;
	public LayerMask ground_layer;
	public GameObject spawnpoint;	
	private bool IsItGround;
	public GameObject shot_shotgun_l, shot_shotgun_r, shot_mac10_l, shot_mac10_r, shot_ak74_l, shot_ak74_r, shot_deagle_l, shot_deagle_r, shot_svd_l, shot_svd_r;
	public GameObject out_of_ammo = null;
	public GameObject light;
	public GameObject task_message;
	public GameObject gilza;
	public GameObject gilza_machinegun;
	public GameObject gilza_pistol;
	Vector2 bulletPos;
	public float fireRate = 5f;
	float nextFire = 5f;
	public float speed = 10f;
	private Rigidbody2D rb;
	private bool faceRight = true;
	//sounds
	public AudioSource a_shotgun;
	public AudioSource a_machinegun;
	public AudioSource a_pistol;
	public AudioSource a_rocket;
	public AudioClip shotgun1;
	public AudioClip shotgun2;
	public AudioClip machinegun;
	public AudioClip pistol;
	public AudioClip rocket;
	public AudioClip empty_ammo;
//	public AudioClip jump_snd;
	public float volume = 0.5f;
	// Use this for initialization
	void Start (){
		rb = GetComponent <Rigidbody2D> ();
		Cursor.visible = false;
		light.SetActive(false);
	}


	void Update () {
		IsItGround = Physics2D.OverlapCircle(groundCheck_point.position,groundCheck_radius,ground_layer);
		float moveX = Input.GetAxis ("Horizontal");
		rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space) && IsItGround)
			rb.AddForce (Vector2.up * 11000);
		if (moveX > 0 && !faceRight)
			flip ();
		else if (moveX < 0 && faceRight)
			flip ();
		
		if (Input.GetButtonDown ("Fire1") && weapon_switch.weaponSwitch == 2 && Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		if (ammo_script.ammo_12x70 >= 1)
		fire();
		if (ammo_script.ammo_12x70 == 0)
		empty();
		}
		
		if (Input.GetButtonDown ("Fire2") && weapon_switch.weaponSwitch == 2 && Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		if (ammo_script.ammo_12x70 >= 2)
		fire_duplet();
		if (ammo_script.ammo_12x70 == 1)
		empty();
		}		
		
		if (Input.GetButtonDown ("Fire1") && weapon_switch.weaponSwitch == 0 && Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		if (ammo_script.ammo_1143x23 >= 1)
		fire_pistol();
		if (ammo_script.ammo_1143x23 == 0)
		empty();
		}
		
		if (Input.GetButtonDown ("Fire1") && weapon_switch.weaponSwitch == 1 && Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		if (ammo_script.ammo_9x19 >= 1)
		fire_mac10();
		if (ammo_script.ammo_9x19 == 0)
		empty();
		}
		
		if (Input.GetButtonDown ("Fire1") && weapon_switch.weaponSwitch == 3 && Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		if (ammo_script.ammo_545x39 >= 1)
		fire_ak74();
		if (ammo_script.ammo_545x39 == 0)
		empty();
		}

		if (Input.GetButtonDown("Fire1") && weapon_switch.weaponSwitch == 4 && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			if (ammo_script.ammo_og7b >= 1)
				tank_gun();
			if (ammo_script.ammo_og7b == 0)
				empty();
		}

		if (Input.GetButtonDown("Fire2") && weapon_switch.weaponSwitch == 4 && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			if (ammo_script.ammo_762x54 >= 1)
				stationary_mgun();
			if (ammo_script.ammo_762x54 == 0)
				empty();
		}
	}

	public void Pause()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
		}
	}
	
	public void JustJump()
	{
		if (IsItGround == true)
			rb.AddForce (Vector2.up * 11000);
	}
	
	public void Current_Task()
	{
		if (IsItGround == true)
			Instantiate(task_message, transform.position, Quaternion.identity);
	}
	
	public void TurnLeft()	
	{		
			if (!faceRight)
			{
			rb.AddForce (Vector2.left * 35000 * Time.deltaTime);
			}	else
			{
				flip();
			}
	}
	
	public void TurnRight()
	{		
			if (faceRight)
			{
			rb.AddForce (Vector2.right * 35000 * Time.deltaTime);
			}	else
			{
				flip();
			}
	}
	
	public void unstuck()
	{
		if (IsItGround == true)
			print("I'M STUCK!1111");
			rb.transform.position = spawnpoint.transform.position;
	}
	
	public void flashlight()
	{
			light.SetActive(true);
			Invoke ("flashlight2", 1.0f);
	}
	
	public void flashlight2()
	{
			light.SetActive(false);
	}
	
	void flip () {
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
	void fire () {
		a_shotgun.PlayOneShot(shotgun1, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2 (1.35f, 0.32f);
			rb.AddForce (Vector2.left * 1000);
			Instantiate (shot_shotgun_r, bulletPos, Quaternion.identity);
			ammo_script.ammo_12x70 -= 1;
			Instantiate (gilza, transform.position, Quaternion.identity);
		} else
		{
			bulletPos += new Vector2 (-1.35f, 0.32f);
			rb.AddForce (Vector2.right * 1000);
			Instantiate (shot_shotgun_l, bulletPos, Quaternion.identity);
			ammo_script.ammo_12x70 -= 1;
			Instantiate (gilza, transform.position, Quaternion.identity);
		}			
	}
	
		void fire_pistol () {
		a_pistol.PlayOneShot(shotgun1, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2 (1.35f, 0.32f);
			rb.AddForce (Vector2.left * 1000);
			Instantiate (shot_deagle_r, bulletPos, Quaternion.identity);
			ammo_script.ammo_1143x23 -= 1;
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);
		} else
		{
			bulletPos += new Vector2 (-1.35f, 0.32f);
			rb.AddForce (Vector2.right * 1000);
			Instantiate (shot_deagle_l, bulletPos, Quaternion.identity);
			ammo_script.ammo_1143x23 -= 1;
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);
		}			
	}
	
		void fire_mac10 () {
		a_machinegun.PlayOneShot(machinegun, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2 (1.35f, 0.32f);
			rb.AddForce (Vector2.left * 1000);
			ammo_script.ammo_9x19 -= 3;
			Instantiate (shot_mac10_r, bulletPos, Quaternion.identity);
			Instantiate (shot_mac10_r, bulletPos, Quaternion.identity);
			Instantiate (shot_mac10_r, bulletPos, Quaternion.identity);
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);				
		} else
		{
			bulletPos += new Vector2 (-1.35f, 0.32f);
			rb.AddForce (Vector2.right * 1000);
			ammo_script.ammo_9x19 -= 3;
			Instantiate (shot_mac10_l, bulletPos, Quaternion.identity);
			Instantiate (shot_mac10_l, bulletPos, Quaternion.identity);
			Instantiate (shot_mac10_l, bulletPos, Quaternion.identity);	
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);
			Instantiate (gilza_pistol, transform.position, Quaternion.identity);			
		}			
	}
	
		void fire_ak74 () {
		a_machinegun.PlayOneShot(machinegun, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2 (1.35f, 0.32f);
			rb.AddForce (Vector2.left * 1000);
			ammo_script.ammo_545x39 -= 3;
			Instantiate (shot_ak74_r, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_r, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_r, bulletPos, Quaternion.identity);
			Instantiate (gilza_machinegun, transform.position, Quaternion.identity);
			Instantiate (gilza_machinegun, transform.position, Quaternion.identity);
			Instantiate (gilza_machinegun, transform.position, Quaternion.identity);	
		} else
		{
			bulletPos += new Vector2 (-1.35f, 0.32f);
			rb.AddForce (Vector2.right * 1000);		
			ammo_script.ammo_545x39 -= 3;
			Instantiate (shot_ak74_l, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_l, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_l, bulletPos, Quaternion.identity);	
			Instantiate (gilza_machinegun, transform.position, Quaternion.identity);
			Instantiate (gilza_machinegun, transform.position, Quaternion.identity);
			Instantiate (gilza_machinegun, transform.position, Quaternion.identity);	
		}			
	}

	void tank_gun()
	{
		a_pistol.PlayOneShot(shotgun1, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2(1.35f, 0.32f);
//			rb.AddForce(Vector2.left * 500);
			Instantiate(shot_deagle_r, bulletPos, Quaternion.identity);
			ammo_script.ammo_og7b -= 1;
			Instantiate(gilza_pistol, transform.position, Quaternion.identity);
		}
		else
		{
			bulletPos += new Vector2(-1.35f, 0.32f);
//			rb.AddForce(Vector2.right * 500);
			Instantiate(shot_deagle_l, bulletPos, Quaternion.identity);
			ammo_script.ammo_og7b -= 1;
			Instantiate(gilza_pistol, transform.position, Quaternion.identity);
		}
	}

	void stationary_mgun()
	{
		a_machinegun.PlayOneShot(machinegun, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2(1.35f, 0.32f);
//			rb.AddForce(Vector2.left * 1000);
			Instantiate (shot_ak74_r, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_r, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_r, bulletPos, Quaternion.identity);
			ammo_script.ammo_762x54 -= 3;
			Instantiate(gilza_pistol, transform.position, Quaternion.identity);
		}
		else
		{
			bulletPos += new Vector2(-1.35f, 0.32f);
//			rb.AddForce(Vector2.right * 1000);
			Instantiate (shot_ak74_l, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_l, bulletPos, Quaternion.identity);
			Instantiate (shot_ak74_l, bulletPos, Quaternion.identity);
			ammo_script.ammo_762x54 -= 3;
			Instantiate(gilza_pistol, transform.position, Quaternion.identity);
		}
	}

	void empty()
	{
		print("OUT OF AMMO1111!!!!");
		a_shotgun.PlayOneShot(empty_ammo, volume);
		Instantiate(out_of_ammo, transform.position, Quaternion.identity);
	}
	
	
	void fire_duplet () {		
	a_shotgun.PlayOneShot(shotgun2, volume);
		bulletPos = transform.position;
		if (faceRight)
		{
			bulletPos += new Vector2 (1.35f, 0.32f);
			Instantiate (shot_shotgun_r, bulletPos, Quaternion.identity);
			Instantiate (shot_shotgun_r, bulletPos, Quaternion.identity);
			ammo_script.ammo_12x70 -= 2;
			Instantiate (gilza, transform.position, Quaternion.identity);
			Instantiate (gilza, transform.position, Quaternion.identity);
			rb.AddForce (Vector2.left * 2500);
		} else
		{
			bulletPos += new Vector2 (-1.35f, 0.32f);
			Instantiate (shot_shotgun_l, bulletPos, Quaternion.identity);
			Instantiate (shot_shotgun_l, bulletPos, Quaternion.identity);
			ammo_script.ammo_12x70 -= 2;
			Instantiate (gilza, transform.position, Quaternion.identity);
			Instantiate (gilza, transform.position, Quaternion.identity);	
			rb.AddForce (Vector2.right * 2500);		
		}			
	}	
}
