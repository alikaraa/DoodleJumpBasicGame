using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    [SerializeField] float hareketHizi;
    [SerializeField] float ziplamaKuvveti;
    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(yatayEksen * hareketHizi * Time.deltaTime,0,0);

    }

    public void KarakteriZiplat(){
        rb.AddForce(Vector2.up * ziplamaKuvveti);
    }
}
