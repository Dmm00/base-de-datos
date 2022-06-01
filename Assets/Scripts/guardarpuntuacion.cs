using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guardarpuntuacion : MonoBehaviour
{
    public int puntuacion;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {   
        puntuacion=0;
        score.text= puntuacion.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text= puntuacion.ToString();
    }
}
