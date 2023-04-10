using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SistemaVida : MonoBehaviour
{
    public GameObject[] corazones;
    public int vida;
    private bool muerte;
    public Animator animator;
    public bool IsHurt;
    public GameObject panelFinal;


    private Vector3 respawnPoint;
    public GameObject fallDetector;


    // Start is called before the first frame update
    private void Start()
    {
        
        vida = corazones.Length;
        respawnPoint = transform.position;

    }




    // Update is called once per frame
    void Update()
    {
        if (muerte == true) 
        {
            panelFinal.SetActive(true);
           

            Time.timeScale = 0f;
            //Debug.Log("Game Over!");
            if (Input.GetKeyDown(KeyCode.R))
            {
                panelFinal.SetActive(true);
                SceneManager.LoadScene("Menu");
                Time.timeScale = 1f;
            }
                                                              
        }
    }


    //    public void CargaScene()
    //    {
    //        SceneManager.LoadScene("SampleScene");

    //}

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            IsHurt = true;
            
          
            Damage(1);


        }

       

        else if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
            Damage(1);
        }

       
    }



    public void Damage(int d)
    {

        if (vida >= 1)
        {
            vida -= d;
            Destroy(corazones[vida].gameObject);
            if (vida < 1)
            {
                muerte = true;
            }

        }

    }


}

