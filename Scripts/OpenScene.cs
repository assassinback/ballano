using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class OpenScene : MonoBehaviour {
	public Slider gObject;
    public GameObject x;
	public void ChangeScene(string gotoScene)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene (gotoScene);
		

	}
    public void ChangeScene1(string gotoScene)
    {

        if (PlayerPrefs.GetInt("lives") > 0 && PlayerPrefs.GetInt("livesinfi") == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(gotoScene);
        }
        else if(PlayerPrefs.GetInt("livesinfi") == 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(gotoScene);
        }
        else
        {
            x.SetActive(true);
        }

    }
    public void cha(int index)
	 {
		 //gObject=GameObject.Find("Slider").GetComponent<Slider>();
	 	//gObject=GameObject.Find("slider").GetComponent<>;
	 	gObject.gameObject.SetActive(true);
	 	StartCoroutine(enu(index));
	 }
	 IEnumerator enu(int index)
	 {
	 	AsyncOperation op=SceneManager.LoadSceneAsync(index);

	 	while(!op.isDone)
	 	{
	 		float prog=Mathf.Clamp01(op.progress/0.9f);
			gObject.value=prog;
			yield return null;
	 	}


	 }
}
