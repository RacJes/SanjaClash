using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [Header ("Paineis e Menu")] 
    private bool isPaused;
    public GameObject painelPausa;
    public string cena;

    private bool verificajogo;
    public GameObject Fimdejogo;
    // Start is called before the first frame update
     
     void Start()
     {
         Time.timeScale=1f;
     }
     void Update()
    {
        if(!isPaused){}  

        if(Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }

            if(!verificajogo)
            {
                
            }
      
    }

    public void Pause()
    {
        if(isPaused)
        {
            isPaused = false;
            Time.timeScale =1f;
            painelPausa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0f;
            painelPausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;

        }
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene(cena);
    }

    public void SairJogo(){
        Application.Quit();
    }
    public void FimDeJogo()
    {
        verificajogo = true;
        Fimdejogo.SetActive(true);

    }
   
}
