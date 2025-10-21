using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_switch : MonoBehaviour
{
    // Start is called before the first frame update
    public static int weaponSwitch = 0;
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
		int currentWeapon = weaponSwitch;
		
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (weaponSwitch >= transform.childCount -1)
            {
                weaponSwitch = 0;
            }
            else 
            {
            weaponSwitch++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (weaponSwitch <= 0)
            {
                weaponSwitch = transform.childCount -1;
            }
            else
            {
                weaponSwitch--;
            }
        }
		if (Input.GetKeyDown(KeyCode.Alpha1) && ammo_script.ammo_9x19 >=0)
		{
			weaponSwitch = 0;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) && ammo_script.ammo_9x19 >=0 && transform.childCount >=2)
		{
			weaponSwitch = 1;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3) && ammo_script.ammo_12x70 >=0 && transform.childCount >=3)
		{
			weaponSwitch = 2;
		}
		if (Input.GetKeyDown(KeyCode.Alpha4) && ammo_script.ammo_545x39 >=0 && transform.childCount >=4)
		{
			weaponSwitch = 3;
		}

        if (currentWeapon != weaponSwitch)
		{
			SelectWeapon();
		}

    }

    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == weaponSwitch)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;

        }
    }
}
