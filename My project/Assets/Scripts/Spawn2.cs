using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject obj;
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
        int val = Random.Range(0, 8000);
        if (val > 7985)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
