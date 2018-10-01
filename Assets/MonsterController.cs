using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public float MP = 30;
    public float needMP = 10;
    //すばやさを設定
    public float speed = 25;
    //animationを入れる
    public Animator animator;

    bool isAttack;
    bool isDefense;
    bool isMagic;
    bool isRecovery;
    bool isAlive;

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


	
	void Start () {
        animator = GetComponent<Animator>();
	}

	void Update () {
        if(isAttack == true) {
            this.animator.SetBool("Attack", true);
        } else {
            this.animator.SetBool("Attack", false);
        }

        if(isDefense == true) {
            this.animator.SetBool("Defense", true);
        } else {
            this.animator.SetBool("Defense", false);
        }

        if(isMagic == true) {
            this.animator.SetBool("Magic", true);
        } else {
            this.animator.SetBool("Magic", false);
        }

        if(isRecovery == true) {
            this.animator.SetBool("Recovery", true);
        } else {
            this.animator.SetBool("Recovery", false);
        }

        if(monHP >= 0) {
            isAlive = true;
        } else {
            isAlive = false;
        }
        if(isAlive == true) {
            this.animator.SetBool("Death", false);
        } else {
            this.animator.SetBool("Death", true);
        }
	}
}
