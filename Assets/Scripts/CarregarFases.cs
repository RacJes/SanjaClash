using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarregarFases : MonoBehaviour
{
    public string faseParaCarregar; // altera o especto da unity, sequencia de caracteres no valor e seu nome

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)) // qual cena que devemos carregar 
        {
            SceneManager.LoadScene(faseParaCarregar); // qual fase carregar
        }
    }
            
}
