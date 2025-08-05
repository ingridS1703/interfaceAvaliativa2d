
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class LoadScene : MonoBehaviour
 {
    public string jogo;
    
    public void Load()
    {
       SceneManager.LoadScene(jogo);
    }
 }