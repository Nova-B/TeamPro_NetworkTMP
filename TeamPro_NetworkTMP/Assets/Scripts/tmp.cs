using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tmp : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
