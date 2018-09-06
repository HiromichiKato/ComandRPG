using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

    public MonsterController monsterController;
    public EnemyController enemyController;


    // Use this for initialization
    void Start() {
        
        float mPo = monsterController.power;
        float mDe = monsterController.defense;
        float mRe = monsterController.recover;
        float mMa = monsterController.magic;
        float mMP = monsterController.MP;
        float mNM = monsterController.needMP;
        float eHP = enemyController.eneHP;

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnClickAttack() {
        enemyController.eneHP= enemyController.eneHP - monsterController.power;
        Debug.Log("" + monsterController.power + "のダメージを与えた。");
        Debug.Log("敵の残りHPは" + enemyController.eneHP);
    }
    public void OnClickDefense() {
        Debug.Log("" + monsterController.defense + "のダメージを防いだ。");
    }
    public void OnClickMagic() {
        monsterController.MP = monsterController.MP - monsterController.needMP;
        Debug.Log("MPを" + monsterController.needMP + "消費した。残りMPは" + monsterController.MP + "");
        Debug.Log("攻撃力が" + monsterController.magic + "上がった。");
    }
    public void OnClickRecovery() {
        Debug.Log("HPを" + monsterController.recover + "回復した。");
    }
}