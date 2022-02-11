using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumOlusturucu : MonoBehaviour
{
   
    public GameObject platformPrefab;
    [SerializeField] int platformSayisi = 200;


    void Start()
    {
        LevelUret();
    }

    void LevelUret(){

        Vector2 platformVektor = new Vector2();

        for (int i = 0; i < platformSayisi; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            platformVektor.x = Random.Range(-2.2f, 2.2f);
            platformVektor.y += Random.Range(1.6f, 2f);
           tempPlatform.transform.position = platformVektor;
        }
    }
}
