using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Puntaje : MonoBehaviour
{
   
    public int Puntos = 0;

    public TextMeshProUGUI puntosTexto;

    private void OnTriggerEnter(Collider other)
     {
        if(other.transform.tag == "Player")
        {
            Puntos++;
            puntosTexto.text = "Puntaje: " + Puntos.ToString();
            Debug.Log(Puntos);
            Destroy(gameObject);
        }
        
    }

    
}
