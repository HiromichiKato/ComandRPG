using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterController : MonoBehaviour {
    
    //hpを設定
    public float monHP = 100;
    //攻撃力を設定
    public float power = 25;
    //防御力を設定
    public float defense = 15;
    //回復力を設定
    public float recover = 30;
    //魔法について設定
    public float magic = 10;
    //すばやさを設定
    public float speed = 25;
    //animationを入れる
    private Animator animator;

    bool isAttack;
    bool isDefense;
    bool isMagic;
    bool isRecovery;


    public void APush() {
        isAttack = true;
    }
    public void noAPush() {
        isAttack = false;
    }
    public void DPush() {
        isDefense = true;
    }
    public void noDPush() {
        isDefense = false;
    }
    public void MPush() {
        isMagic = true;
    }
    public void noMPush() {
        isMagic = false;
    }
    public void RPush() {
        isRecovery = true;
    }
    public void noRPush() {
        isRecovery = false;
    }


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isAttack == true) {
            this.animator.SetBool("Attack", true);
        }

        if(isDefense == true) {
            this.animator.SetBool("Defense", true);
        }

        if(isMagic == true) {
            this.animator.SetBool("Magic", true);
        }

        if(isRecovery == true) {
            this.animator.SetBool("Recovery", true);
        }
	}
}
