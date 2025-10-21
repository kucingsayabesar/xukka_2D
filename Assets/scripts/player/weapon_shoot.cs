using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Заготовка под стрельбу
public class weapon_shoot : MonoBehaviour
{

	public GameObject bullet_l, bullet_r;
	public GameObject out_of_ammo = null;
	public GameObject gilza;
	Vector2 bulletPos;
	public float fireRate = 15f;
	float nextFire = 5f;
	public AudioSource audioSource;
	public AudioClip shotgun1;
	public AudioClip shotgun2;
	public AudioClip empty_ammo;
	public float volume = 0.5f;
		public bool faceRight = true;
	
	

	void Update()
	{

		if (Input.GetButtonDown("Fire1") && Time.time > nextFire)   //Скрипт стрельбы
		{
			nextFire = Time.time + fireRate;
			if (ammo_script.ammo_12x70 >= 1)
				fire();     //Если число патронов больше или равно единице происходит выстрел
			if (ammo_script.ammo_12x70 == 0)
				empty();    //Если число патронов меньше или равно нулю выстрел не происходит
		}

		void fire()
		{   //Стрельба
			audioSource.PlayOneShot(shotgun1, volume);  //Воспроизведение звука
			bulletPos = transform.position; //То место откуда вылетают пули
			if (faceRight)  //Смотрит вправо // не работает проверка куда он смотрит
			{
				bulletPos += new Vector2(1.35f, 0.32f); //Установка места откуда вылетают пули
//				rb.AddForce(Vector2.left * 1000);   //Отдача от ружья
				Instantiate(bullet_r, bulletPos, Quaternion.identity);  //Спавн пули_которая вылетает справа
				ammo_script.ammo_12x70 -= 1;    //Уменьшение количества патронов на единицу
				Instantiate(gilza, transform.position, Quaternion.identity);    //Спавн гильзы
			}
			else
			{
				bulletPos += new Vector2(-1.35f, 0.32f);    //Установка места откуда вылетают пули
//				rb.AddForce(Vector2.right * 1000);  //Отдача от ружья
				Instantiate(bullet_l, bulletPos, Quaternion.identity);  //Спавн пули_которая вылетает слева
				ammo_script.ammo_12x70 -= 1;    //Уменьшение количества патронов на единицу
				Instantiate(gilza, transform.position, Quaternion.identity);    //Спавн гильзы
			}
		}

		void empty()    //Если патронов НЕТ :(
		{
			print("OUT OF AMMO1111!!!!");   //Запись в ЛОГ
			audioSource.PlayOneShot(empty_ammo, volume);    //Воспроизведение звука
			Instantiate(out_of_ammo, transform.position, Quaternion.identity);  // Вывод надписи нет патронов
		}
	}
	
}