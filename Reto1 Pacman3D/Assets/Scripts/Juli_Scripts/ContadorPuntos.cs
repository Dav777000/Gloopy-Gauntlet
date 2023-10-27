using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorPuntos : MonoBehaviour
{
    public static ContadorPuntos Instance;

    public TMP_Text puntoTexto;
    public int currentPoints;
    public GameObject cherry;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        puntoTexto.text = "Puntaje: " + currentPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPuntos(int v)
    {
        currentPoints += v;
        puntoTexto.text = "Puntaje: " + currentPoints.ToString();
        if (currentPoints >= 15)
        {
            cherry.SetActive(true);
        }
    }


}
