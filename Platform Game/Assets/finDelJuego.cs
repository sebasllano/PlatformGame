using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finDelJuego : MonoBehaviour
{

    public GameObject panelFinal;


   void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            panelFinal.SetActive(true);
            SceneManager.LoadScene("Menu");
            Time.timeScale = 1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            panelFinal.SetActive(true);
            Time.timeScale = 0f;
            //Debug.Log("Game Over!");
            

        }
    }

}
