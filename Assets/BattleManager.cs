using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

    //それぞれの数値を入れるためにスクリプトを入れる
    public MonsterController monsterController;
    public EnemyController enemyController;
    //それぞれのButtonを入れる
    public GameObject Attack;
    public GameObject Defense;
    public GameObject Magic;
    public GameObject Recovery;


    bool Enemyturn;


    // Use this for initialization
    void Start() {
        

        //それぞれの数値を代入
        float mHP = monsterController.monHP;
        float mPo = monsterController.power;
        float mDe = monsterController.defense;
        float mRe = monsterController.recover;
        float mMa = monsterController.magic;
        float mMP = monsterController.MP;
        float mNM = monsterController.needMP;
        float eHP = enemyController.eneHP;
        float ePo = enemyController.enepower;

    }

    // Update is called once per frame
    void Update() {
        
    }


    enum BattlePhase {
        myTurn,
        myTurnEnd,         enemyTurn,
        enemyTurnEnd,     }

    enum ButtonState {
        Attack,
        Defense,
        Magic,
        Recovery,
    }

    ButtonState buttonState;
    BattlePhase phase = BattlePhase.myTurn;
    int myTurnCount = 0;
    int enemyTurnCount = 0;
     void TurnManager() {
        while(enemyController.eneHP > 0 && monsterController.monHP > 0) {
            switch (phase) {
                case BattlePhase.myTurn:
                    switch (buttonState) {
                        case ButtonState.Attack:
                            enemyController.eneHP = enemyController.eneHP - monsterController.power;
                            Debug.Log("" + monsterController.power + "のダメージを与えた。");
                            Debug.Log("敵の残りHPは" + enemyController.eneHP);
                            break;

                        case ButtonState.Defense:
                            Debug.Log("" + monsterController.defense + "のダメージを防いだ。");
                            break;

                        case ButtonState.Magic:
                            monsterController.MP = monsterController.MP - monsterController.needMP;
                            Debug.Log("MPを" + monsterController.needMP + "消費した。残りMPは" + monsterController.MP + "");
                            Debug.Log("攻撃力が" + monsterController.magic + "上がった。");
                            break;

                        case ButtonState.Recovery:
                            Debug.Log("HPを" + monsterController.recover + "回復した。");
                            break;
                    }
                    phase = BattlePhase.myTurnEnd;
                    break;
                case BattlePhase.myTurnEnd:
                    phase = BattlePhase.enemyTurn;
                    myTurnCount++;
                    break;
                case BattlePhase.enemyTurn:
                    Debug.Log("EnemyTurn");
                    EnemyMovement();
                    break;
                case BattlePhase.enemyTurnEnd:
                    enemyTurnCount++;
                    if (myTurnCount == enemyTurnCount)
                    {
                        phase = BattlePhase.myTurn;
                    }
                    break;
            }
        }
    }

    public void OnClickAttack() {
        buttonState = ButtonState.Attack;
        Attack.SetActive(false);
        Defense.SetActive(false);
        Magic.SetActive(false);
        Recovery.SetActive(false);
        TurnManager();
    }
    public void OnClickDefense() {
        buttonState = ButtonState.Defense;
        Attack.SetActive(false);
        Defense.SetActive(false);
        Magic.SetActive(false);
        Recovery.SetActive(false);
        TurnManager();
    }
    public void OnClickMagic() {
        buttonState = ButtonState.Magic;
        Attack.SetActive(false);
        Defense.SetActive(false);
        Magic.SetActive(false);
        Recovery.SetActive(false);
        TurnManager();
    }
    public void OnClickRecovery() {
        buttonState = ButtonState.Recovery;
        Attack.SetActive(false);
        Defense.SetActive(false);
        Magic.SetActive(false);
        Recovery.SetActive(false);
        TurnManager();
    }

    enum EnemyState {
        EAttack,
        EDefense,
        EMagic,
        ERecovery,
    }

    EnemyState enemyState;

    public void EnemyMovement() {
        if (enemyController.eneHP > 25) {
            int num = Random.Range(1, 11);
            if (num <= 4) {
                enemyState = EnemyState.EAttack;
                Debug.Log("敵の攻撃。");
            }
            else if (num >= 5 && num <= 7) {
                enemyState = EnemyState.EMagic;
                Debug.Log("敵の必殺技。");
            }
            else {
                enemyState = EnemyState.EDefense;
                Debug.Log("敵は防御した。");
            }
        }
        else {
            int num = Random.Range(1, 11);
            if (num <= 3) {
                enemyState = EnemyState.EDefense;
                Debug.Log("敵は防御した。");
            }
            else {
                enemyState = EnemyState.ERecovery;
                Debug.Log("敵は回復した。");
            }
        }
    }


}

