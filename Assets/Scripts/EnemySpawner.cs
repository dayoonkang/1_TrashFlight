using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    [SerializeField]
    private GameObject boss;

    private float [] arrPosX = {-2.26f,-1.13f, 0f, 1.13f, 2.26f};

    [SerializeField]
    private float spawnInterval = 1.5f;
    
        // Start is called before the first frame update
    void Start()
    {
        StartEnemyRoutine();
    }

    void StartEnemyRoutine(){
        StartCoroutine("EnemyRoutine");
    }

    public void StopEnemyRoutine(){
        StopCoroutine("EnemyRoutine");
    }

    IEnumerator EnemyRoutine() {
        yield return new WaitForSeconds(3f);

        float moveSpeed = 2.5f;
        int spawnCount = 0;
        int enemyIndex =0;
        while(true) {
            foreach(float posX in arrPosX){
                SpawnEnemy(posX, enemyIndex, moveSpeed );
            }
            
            spawnCount += 1;
            if (spawnCount % 3 == 0) {
                enemyIndex +=1;
                moveSpeed +=1;
            }

            if(enemyIndex >= enemies.Length) {
                SpawnBoss();
                enemyIndex =0;
                moveSpeed = 5f;
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnEnemy(float posX, int index, float moveSpeed){
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);

        if (Random.Range(0,5) ==0 ){
            index += 1;
        }
        if (index >= enemies.Length){
            index = enemies.Length - 1;
        }

        GameObject enemyObject = Instantiate(enemies[index], spawnPos, Quaternion.identity);
        Enemy enemy = enemyObject.GetComponent<Enemy>();
        enemy.SetMoveSpeed(moveSpeed);
    }
    void SpawnBoss(){
        Instantiate(boss, transform.position, Quaternion.identity);
    }
}
