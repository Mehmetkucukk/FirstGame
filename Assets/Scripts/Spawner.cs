using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Player playerCs;
    public GameObject borular;
    public float xkonumu;
    public float ykonumuBaslangýc;
    public float ykonumubitis;
    void Start()
    {
        StartCoroutine(spawnEt());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnEt()
    {
        while (!playerCs.isDead)
        {
            Instantiate(borular, new Vector3(xkonumu, Random.Range(-ykonumuBaslangýc, ykonumubitis),0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        
    }
}
