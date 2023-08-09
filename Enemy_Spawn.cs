using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public bool enableSpawn = false;

    public GameObject Enemy; // prefab에서 받을 public 변수
    int enemyVisibleLimit; // 동시 적 스폰 갯수
    int enemySpawnLimit; //최대 적 스폰 갯수

    public GameObject[] enemies; //생성된 객체를 받아올 배열

    void SpawnEnemy()
    {
        float randomX = random.Range(); // (괄호안에 적이 나타날 x좌표..)
        if(enableSpawn)
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy"); // prefab 태그로 적 갯수 찾기
            if(enemies.Length<20)
            {
                GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 1.1f, 0f), Quaternion.identity); // 문제의 하늘에서 적이 랜덤위치에서 떨어지는거..
            }
        }
    }

    void Start()
    {
        enemyVisibleLimit = 5; // 필드에 나와있는 동시적 갯수 5개로 제한. 더 늘려도 괜찮을까?..
        enemySpawnLimit = 10; // 

        InvokeRepeating("SpawnEnemy", 1, 3); // 1초후 부터, SpawnEnemy 함수를 3초마다 반복해서 실행
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
