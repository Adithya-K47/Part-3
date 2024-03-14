using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float dashSpeed = 10;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = dashSpeed;
        base.Attack();
        Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
        Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
        
    }
}
