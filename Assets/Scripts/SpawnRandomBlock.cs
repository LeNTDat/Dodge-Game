using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnRandomBlock : MonoBehaviour
{
    public GameObject block;
    public GameObject UpdownBlock;
    public GameObject FinishPlate;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0, 0.5f, 0);
        for(int i = 0; i < 5; i++)
        {
            SpawnBlock();
            Invoke("SpawnUpDownBlock", 2f);
        }
        SpawnFinishPlate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BlockChallenge" || other.gameObject.tag == "RotateBlock") { 
            Destroy(other);
        }
        
    }

    void SpawnFinishPlate ()
    {
        pos.x = Random.Range(-40.0f, 20.0f);
        pos.z = Random.Range(-25f, 35f);
        Instantiate(FinishPlate, pos, Quaternion.identity);
    }

    void SpawnUpDownBlock()
    {
        pos.x = Random.Range(-40.0f, 20.0f);
        pos.z = Random.Range(-25f, 35f);
        Instantiate(UpdownBlock, pos, Quaternion.identity);
    }

    void SpawnBlock()
    {
        pos.x = Random.Range(-40.0f, 20.0f);
        pos.z = Random.Range(-25f, 35f);
        Instantiate(block, pos, Quaternion.identity);
    }
}
