using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

    public MonsterController monsterController;
    public EnemyController enemyController;

    float enemyHP;


    // Use this for initialization
    void Start() {
        
        float mPo = monsterController.power;
        float mDe = monsterController.defense;
        float mRe = monsterController.recover;
        float mMa = monsterController.magic;
        float eHP = enemyController.eneHP;

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnClickAttack() {
        enemyHP = enemyController.eneHP - monsterController.power;
        Debug.Log("" + monsterController.power + "のダメージを与えた。");
        Debug.Log("敵の残りHPは" + enemyHP);
    }
    public void OnClickDefense() {
        Debug.Log("" + monsterController.defense + "のダメージを防いだ。");
    }
    public void OnClickMagic() {
        Debug.Log("攻撃力が" + monsterController.magic + "上がった。");
    }
    public void OnClickRecovery() {
        Debug.Log("HPを" + monsterController.recover + "回復した。");
    }
}