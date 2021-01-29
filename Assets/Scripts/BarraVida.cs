using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BarraVida : MonoBehaviour
{

    public Slider slider;
    Animator anim;

    public void VidaMaxima(int vida){
        slider.maxValue = vida;
        slider.value = vida;
     
    }
    public void ControleVida(int vida){
        slider.value= vida;
     
    }


}
