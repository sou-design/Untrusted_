using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    [SerializeField] private Transform gameTransform;
    [SerializeField] private Transform part;

    private List<Transform> parts;
    private int pos;
    private int taille = 2;
    private bool melanger = false;
    public bool vic;
   
    public static Puzzle instance { get; private set; }
    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }
    private void CreateGamePieces()
    {

        float width = 1 / (float)taille;
        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                Transform piece = Instantiate(part, gameTransform);
                parts.Add(piece);
                piece.localPosition = new Vector3(0, -(width * i) - width + 1, (width * j) + width - 1);
                piece.localScale = ((width) - 0.01f) * Vector3.one;
                piece.name = $"{j + (i * 2)}";
                // faire disparaitre la derniere piece
                if ((i == 1) && (j == 1))
                {
                    pos = (int)((Mathf.Pow(taille, 2)) - 1);
                    piece.gameObject.SetActive(false);
                }
                else
                {
                    Vector2[] uv = new Vector2[4];
                    float space2 = 0.01f / 2;
                    //appliquer les UV
                    Mesh mesh = piece.GetComponent<MeshFilter>().mesh;
                    uv[0] = new Vector2(((width) * j) + space2, 1 - (((width) * (i + 1)) - space2));
                    uv[1] = new Vector2(((width) * (j + 1)) - space2, 1 - (((width) * (i + 1)) - space2));
                    uv[2] = new Vector2(((width) * j) + space2, 1 - (((width) * i) + space2));
                    uv[3] = new Vector2(((width) * (j + 1)) - space2, 1 - (((width) * i) + space2));
                    mesh.uv = uv;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        parts = new List<Transform>();
        taille = 2;
        CreateGamePieces();
        vic = false;
        
   
    }

    // Update is called once per frame
    void Update()
    {
        if (!melanger)
        {
            melanger = true;
            Debug.Log("Game Completed");
            StartCoroutine(WaitShuffle());
            
        }
        else if(VictoryVerify() && melanger)
        {
            vic= true;
        }
       
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 pos1 = new Vector3(Input.mousePosition.z, Input.mousePosition.y);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                for (int i = 0; i < parts.Count; i++)
                {
                    if (parts[i] == hit.transform)
                    {
                        if (ValidMov(i, -taille, taille))
                        {
                            break;
                        }
                        if (ValidMov(i, +taille, taille))
                        {
                            break;
                        }
                        if (ValidMov(i, -1, 0))
                        {
                            break;
                        }
                        if (ValidMov(i, +1, taille - 1))
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
    private IEnumerator WaitShuffle()
    {
        yield return new WaitForSeconds(0.5f);
        Melanger();vic = false;
        //melanger = false;
    }
    private bool ValidMov(int i, int offset, int colCheck)
    {
        if (((i % taille) != colCheck) && ((i + offset) == pos))
        {
            (parts[i], parts[i + offset]) = (parts[i + offset], parts[i]);
            (parts[i].localPosition, parts[i + offset].localPosition) = ((parts[i + offset].localPosition, parts[i].localPosition));
            pos = i;
            return true;
        }
        return false;
    }
    private bool VictoryVerify()
    {
        
            int index = 0;
            foreach (var p in parts)
            {
                if (p.name != $"{index}")
                {
                    return false;
                }
                index++;

            }
        return true;
    }

    private void Melanger()
    {
        int last_ = 0; int cmp_ = 0;
        while (cmp_ < ((int)Mathf.Pow(taille, 3)))
        {
            // random position
            int pos = Random.Range(0, (int)Mathf.Pow(taille, 2));
            if (pos == last_)
            {
                continue;
            }
            last_ = pos;
            if (ValidMov(pos, -taille, taille))
            {
                cmp_++;
            }
            else if (ValidMov(pos, +taille, taille))
            {
                cmp_++;
            }
            else if (ValidMov(pos, -1, 0))
            {
                cmp_++;
            }
            else if (ValidMov(pos, +1, taille - 1))
            {
                cmp_++;
            }
        }
    }
}






