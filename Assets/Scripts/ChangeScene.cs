using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public string nomeDaCena;

  void Start(){
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
  }
   public void ChangeS(){
       SceneManager.LoadScene(nomeDaCena);
   }

   public void Sair(){
       Application.Quit();
   }
}
