using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdIns : MonoBehaviour
{
    public GameObject Bird;

    public float InsTimeOri, InsTimeCur;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InsTimeCur -= Time.deltaTime;

        if (InsTimeCur <= 0 && GameController.dead == false)
        {
            InsTimeCur = InsTimeOri;
            BirdI();
        }
    }

    void BirdI()
    {
        Vector3 spawn_pos = new Vector3(15, Random.Range(-4, 2), 0);

        Instantiate(Bird, spawn_pos, Quaternion.identity);
    }
}
