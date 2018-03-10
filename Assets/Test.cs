using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int damage = 3;
		int mCost = 5;

		IntArrayView intArrayView = new IntArrayView ();
		intArrayView.IntArrayInit ();
		intArrayView.IntArrayView1 ();
		intArrayView.IntArrayView2 ();

		Boss boss = new Boss();
		boss.Attack ();
		boss.Defence (damage);
		for(int i=0; i<10; i++){
			boss.MagicAttack (mCost);
		}
		boss.MagicAttack (mCost);
	}

	// Update is called once per frame
	void Update () {

	}

}

public class IntArrayView {

	private int[] intArray = new int[5];

	public void IntArrayInit(){
		int value = 100;
		for(int i=0; i < 5; i++){
			this.intArray [i] = value;
			value += 100;
		}
	}

	public void IntArrayView1(){
		foreach(int i in this.intArray){
			Debug.Log (i);
		}
	}

	public void IntArrayView2(){
		for(int i=this.intArray.Length-1; i>=0; i--){
			Debug.Log (this.intArray[i]);
		}
	}
}

public class Boss {

	private int hp = 100; //体力
	private int power = 25; //攻撃力
	private int mp = 53; //精神力

	public void Attack(){
		Debug.Log (power + "のダメージを与えた");	
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void MagicAttack(int mCost){

		if ((this.mp - mCost) < 0) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			this.mp -= mCost;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		}
	}

}

