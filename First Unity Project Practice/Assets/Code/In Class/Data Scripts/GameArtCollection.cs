using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
	public List<GameArtClass> collectionList;  //a list is exactly like an array. asset prefabs can go into 
	//asset scriptable objects
	public void AddData(GameArtClass obj)
	{
		//Debug.Log(collectionList[0]); DO NOT DO THIS. USE LOOPS. 
		//Debug.Log(collectionList[1]);
		//Debug.Log(collectionList[2]);
		//Below is a for each loop. It looks at each item and spits out data. 
		foreach (var gameArt in collectionList) //gameArt can be anything because COLLECTIONLIST already determines what it's pulling from. 
		{
			Debug.Log(gameArt); //this will find all game art items in the collection list and debug them all at once. 
		}

		//another way to do it is below
		//FoREACH loop is the BETTER one but sometimes you'll have to use the one below. 
		
		for (var i = 0; i < collectionList.Count; i++) //++ means add by one
		{
			//Debug.Log(collectionList[i]);
			if (!collectionList.Contains(obj)) //this is a loop, it will check all the data, see if it contains it then you can add it. 
			{
				collectionList.Add(obj);  //this checks the object itself. 
			}
		}
		
		
	}

	public void removeLastItem()
	{
		if (!collectionList.Contains(null)) //if it contains nothing. if it contains something then it will remove that something. 
		{
			collectionList.RemoveAt(collectionList.Count-1); //This will remove the last item you picked up if running into an enemy. 
		}
		
		
	}
}
