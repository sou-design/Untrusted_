using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextBox;
    public GameObject Date;
    public GameObject Place;
    void Start()
    {
        StartCoroutine(SequenceBegin());
    }
    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(1);
        Place.SetActive(true);
        yield return new WaitForSeconds(1);
        Date.SetActive(true);
        yield return new WaitForSeconds(1);
        Place.SetActive(false);
        Date.SetActive(false);
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<TMP_Text>().text = "I was invited to a dinner with my friend ";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<TMP_Text>().text = "";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<TMP_Text>().text = "My friend is not here ... he disappeared";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<TMP_Text>().text = "";
        yield return new WaitForSeconds(5);
        TextBox.GetComponent<TMP_Text>().text = "I must find him !";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<TMP_Text>().text = "";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<TMP_Text>().text = "I can hear some weird voices from here";
        yield return new WaitForSeconds(5);
        TextBox.GetComponent<TMP_Text>().text = "I am terrified but I must do it !";
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
