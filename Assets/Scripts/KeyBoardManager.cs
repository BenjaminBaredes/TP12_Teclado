using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardManager : MonoBehaviour
{

    public Key[] keys;

    // Start is called before the first frame update
    void Start()
    {
        keys = GameObject.FindObjectsOfType<Key>();
        if (keys.Length > 0) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
