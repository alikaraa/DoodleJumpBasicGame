using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{
 
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Karakter"))
        {
            if(collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<Character>().KarakteriZiplat();
                Destroy(this.gameObject);
            }
        }
    }

    public void StartButton(){
        SceneManager.LoadScene("Game");
    }
}

