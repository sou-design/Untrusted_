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
        // Vérifie si le texte dans la zone de texte converti en entier est égal à 6.
        if (Int32.Parse(textBox.GetComponent<TMP_Text>().text) == 6)
        {
            // Si la condition est vraie, démarre la coroutine "final".
            StartCoroutine(final());
        }
    }
    // Coroutine qui gère la fin du jeu.
    IEnumerator final()
    {
        // Affiche un message de débogage dans la console.
        Debug.Log("All pieces collected");

        // Désactive la porte fermée et active la porte ouverte et le personnage ami.
        DoorSound.enabled = true;
        door_closed.SetActive(false);
        door_opened.SetActive(true);
        yield return new WaitForSeconds(5);
        DoorSound.enabled = false;
        friend.SetActive(true);

        // Attend pendant 5 secondes.
        yield return new WaitForSeconds(12);

        // Active l'élément visuel indiquant la victoire.
        victory.SetActive(true);
    }
}
