using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float tiberium = 0;

    public TextMeshPro text;

    public GameObject fighterPrefab;


    // Start is called before the first frame update
    void Start()
    {
        //calling spawn function for fighter
        InvokeRepeating ("Spawn");

        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        }


    }

    void Spawn()
    {

        if(tiberium == 10)
        {
            Instantiate (fighterPrefab);
            tiberium = tiberium - 10;
        }

    }

    // Update is called once per frame
    void Update()
    {

        text.text = "" + tiberium;
        tiberium += Time.deltaTime;

    }
}
