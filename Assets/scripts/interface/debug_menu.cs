using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class debug_menu : MonoBehaviour	{
    void OnMouseDown ()
    {
				SceneManager.LoadScene ("debug_menu");
    }
}