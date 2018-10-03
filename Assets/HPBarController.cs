using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour {

	Slider _mslider;
	Slider _eslider;
	//MonsterControllerを入れる
	public MonsterController monsterController;
	//enemycontrollerを入れる
	public EnemyController enemyController;

	float MonsterHP = 1;
	float EnemyHP = 1;

	void Start () {
		_mslider = GameObject.Find("mHPBar").GetComponent<Slider>();
		_eslider = GameObject.Find("eHPBar").GetComponent<Slider>();
		float MoHP = monsterController.monHP;
		float MoPo = monsterController.power;
		float EnHP = enemyController.eneHP;
		float EnPo = enemyController.enepower;
	}
	
	
	void Update () {
		_mslider.value = MonsterHP;
		_eslider.value = EnemyHP;
	}

	public void EnemyAttack() {
		MonsterHP = MonsterHP - enemyController.enepower / 100;
	}
	public void MonsterAttack() {
		EnemyHP = EnemyHP - monsterController.power /60;
	}
}
