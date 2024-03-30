using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VerifyCollection : MonoBehaviour
{
    public GameObject textBox;
    public GameObject victory;
    public GameObject door_closed;
    public GameObject door_opened;
    public GameObject friend;
    public AudioSource DoorSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        // V�rifie si le texte dans la zone de texte converti en entier est �gal � 6.
        if (Int32.Parse(textBox.GetComponent<TMP_Text>().text) == 6)
        {
            // Si la condition est vraie, d�marre la coroutine "final".
            StartCoroutine(final());
        }
    }
    // Coroutine qui g�re la fin du jeu.
    IEnumerator final()
    {
        // Affiche un message de d�bogage dans la console.
        Debug.Log("All pieces collected");

        // D�sactive la porte ferm�e et active la porte ouverte et le personnage ami.
        DoorSound.enabled = true;
        door_closed.SetActive(false);
        door_opened.SetActive(true);
        yield return new WaitForSeconds(5);
        DoorSound.enabled = false;
        friend.SetActive(true);

        // Attend pendant 5 secondes.
        yield return new WaitForSeconds(12);

        // Active l'�l�ment visuel indiquant la victoire.
        victory.SetActive(true);
    }
}
