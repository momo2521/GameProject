using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectScene : MonoBehaviour {
	public Transform[] itemButtons;
	public Transform[] Controllers;
	// Use this for initialization
	void Start () {
		//初始化tab的数组
		this.initTabArray ();
	}
	private void initTabArray(){
		itemButtons = new Transform[3];
		Transform mainObj = transform.Find ("Tabbar/MainButton");
		Transform movieObj = transform.Find ("Tabbar/MovieButton");
		Transform myObj = transform.Find ("Tabbar/MyButton");
		itemButtons.SetValue (mainObj,0);
		itemButtons.SetValue (movieObj,1);
		itemButtons.SetValue (myObj,2);
		int index = 0;
		foreach(Transform item in itemButtons){
			item.tag = index;
			item.GetComponent<Button>().onClick.AddListener(delegate() {
				Debug.Log("test!");
			});
		}

		Controllers = new Transform[3];
		Transform mainView = transform.Find ("Controllers/MainView");
		Transform movieView = transform.Find ("Controllers/MovieView");
		Transform myView = transform.Find ("Controllers/MyView");
		Controllers.SetValue (mainView,0);
		Controllers.SetValue (movieView,1);
		Controllers.SetValue (myView,2);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
