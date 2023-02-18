using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockIns : MonoBehaviour
{
    public GameObject Rock;

    public float InsTimeOri, InsTimeCur;

    // Start is called before the first frame update
    void Start()
    {
        InsTimeCur = InsTimeOri;
    }

    // Update is called once per frame
    void Update()
    {
        InsTimeCur -= Time.deltaTime;

        if (InsTimeCur <= 0 && GameController.dead == false)
        {
            InsTimeCur = InsTimeOri;
            RockI();
        }
    }

    void RockI()
    {
        Vector3 spawn_pos = new Vector3(Random.Range(-6, 6), 8, 0);

        Instantiate(Rock, spawn_pos, Quaternion.identity);
    }
}
