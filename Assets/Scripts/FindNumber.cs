using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindNumber : MonoBehaviour
{
    public GameObject textBox1, textBox2,level2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vérifie si la somme des valeurs dans textBox1 et textBox2 est égale à 55.
        if (Int32.Parse(textBox1.GetComponent<TMP_Text>().text+ textBox2.GetComponent<TMP_Text>().text)==55)
        {
            Debug.Log("Right number");
            gameObject.SetActive(false);
            level2.SetActive(true);
        }
    }
    public void Increase()
    {
        // Incrémente la valeur dans textBox1.
        int number = Int32.Parse( textBox1.GetComponent<TMP_Text>().text);
        number += 1;
        textBox1.GetComponent<TMP_Text>().text=number.ToString();
    }
    public void Increase1()
    {
        // Incrémente la valeur dans textBox2.
        int number = Int32.Parse(textBox2.GetComponent<TMP_Text>().text);
        number += 1;
        textBox2.GetComponent<TMP_Text>().text = number.ToString();
    }
    public void Decrease()
    {
        // Décrémente la valeur dans textBox1.
        int number = Int32.Parse(textBox1.GetComponent<TMP_Text>().text);
        number -= 1;
        textBox1.GetComponent<TMP_Text>().text = number.ToString();

    }
    public void Decrease1()
    {
        // Décrémente la valeur dans textBox2.
        int number = Int32.Parse(textBox2.GetComponent<TMP_Text>().text);
        number -= 1;
        textBox2.GetComponent<TMP_Text>().text = number.ToString();
    }
    public void Disappear()
    {
        // Désactive l'objet associé à ce script.
        gameObject.SetActive(false);
    }
    public void Continue()
    {
        // Désactive level2 et charge la scène 3.
        level2.SetActive(false);
        SceneManager.LoadScene(3);
    }
}
