using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cartes : MonoBehaviour
{
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // Détruit le GameObject auquel ce script est attaché.
        Destroy(gameObject);
        int number = Int32.Parse(textBox.GetComponent<TMP_Text>().text);
        // Incrémente la valeur.
        number += 1;
        // Met à jour le composant TMP_Text avec la nouvelle valeur.
        textBox.GetComponent<TMP_Text>().text = number.ToString();
    }
}
