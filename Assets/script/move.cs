using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public int playerX, playerZ;
    public GameObject textobject;
    public Vector3[] verboten;
    public Vector3 startpos;
    // Use this for initialization
    void Start()
    {
        playerX = -2;
        playerZ = -5;
        //Debug.Log (transform.position);
        transform.position = new Vector3(playerX, 0, playerZ);
        startpos = new Vector3(0, 0, 0);
        textobject.GetComponent<TextMesh>().text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        playerZ = (int)transform.position.z;
        playerX = (int)transform.position.x;
        textobject.GetComponent<TextMesh>().text = ("reach the end of the hallway to win ");

        if (playerX == 2 && playerZ == 2)
        { //player is in bad position}
            Debug.Log("reset the player's position");

        }
        if (playerX == -2 && playerZ == 3)
            textobject.GetComponent<TextMesh>().text = ("you win.goodbye");

        if (Input.GetKeyDown("up"))
        {
            transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.position += new Vector3(1, 0, 1);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.position += new Vector3(0, 0, 0);
        }

        for (int i = 0; i < verboten.Length; i++)
            if(transform.position == verboten[i]) {
                Debug.Log("u ded :(");
                //reset the player's position on your own
                textobject.GetComponent<TextMesh>().text = ("u ded ");
                transform.position = startpos;
        }

        {

        }


    }
}