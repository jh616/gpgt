using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public bool enableSpawn = false;

    public GameObject Enemy; // prefab���� ���� public ����
    int enemyVisibleLimit; // ���� �� ���� ����
    int enemySpawnLimit; //�ִ� �� ���� ����

    public GameObject[] enemies; //������ ��ü�� �޾ƿ� �迭

    void SpawnEnemy()
    {
        float randomX = random.Range(); // (��ȣ�ȿ� ���� ��Ÿ�� x��ǥ..)
        if(enableSpawn)
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy"); // prefab �±׷� �� ���� ã��
            if(enemies.Length<20)
            {
                GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 1.1f, 0f), Quaternion.identity); // ������ �ϴÿ��� ���� ������ġ���� �������°�..
            }
        }
    }

    void Start()
    {
        enemyVisibleLimit = 5; // �ʵ忡 �����ִ� ������ ���� 5���� ����. �� �÷��� ��������?..
        enemySpawnLimit = 10; // 

        InvokeRepeating("SpawnEnemy", 1, 3); // 1���� ����, SpawnEnemy �Լ��� 3�ʸ��� �ݺ��ؼ� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
