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
        // V�rifie si la somme des valeurs dans textBox1 et textBox2 est �gale � 55.
        if (Int32.Parse(textBox1.GetComponent<TMP_Text>().text+ textBox2.GetComponent<TMP_Text>().text)==55)
        {
            Debug.Log("Right number");
            gameObject.SetActive(false);
            level2.SetActive(true);
        }
    }
    public void Increase()
    {
        // Incr�mente la valeur dans textBox1.
        int number = Int32.Parse( textBox1.GetComponent<TMP_Text>().text);
        number += 1;
        textBox1.GetComponent<TMP_Text>().text=number.ToString();
    }
    public void Increase1()
    {
        // Incr�mente la valeur dans textBox2.
        int number = Int32.Parse(textBox2.GetComponent<TMP_Text>().text);
        number += 1;
        textBox2.GetComponent<TMP_Text>().text = number.ToString();
    }
    public void Decrease()
    {
        // D�cr�mente la valeur dans textBox1.
        int number = Int32.Parse(textBox1.GetComponent<TMP_Text>().text);
        number -= 1;
        textBox1.GetComponent<TMP_Text>().text = number.ToString();

    }
    public void Decrease1()
    {
        // D�cr�mente la valeur dans textBox2.
        int number = Int32.Parse(textBox2.GetComponent<TMP_Text>().text);
        number -= 1;
        textBox2.GetComponent<TMP_Text>().text = number.ToString();
    }
    public void Disappear()
    {
        // D�sactive l'objet associ� � ce script.
        gameObject.SetActive(false);
    }
    public void Continue()
    {
        // D�sactive level2 et charge la sc�ne 3.
        level2.SetActive(false);
        SceneManager.LoadScene(3);
    }
}
