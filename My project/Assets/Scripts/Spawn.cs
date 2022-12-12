using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] obst;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnObs());
    }
    private IEnumerator SpawnObs()
    {
        int val = Random.Range(40, 8000);
        if(val < 50)
        {
            int r = Random.Range(0, obst.Length);
            Instantiate(obst[r], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

}
