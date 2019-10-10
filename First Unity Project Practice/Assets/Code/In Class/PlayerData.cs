
using System;
using UnityEngine;
[CreateAssetMenu]
	class PlayerData : ScriptableObject //allow people to select and use characters with different
	//attributes, used to configure a prefab. ways we can generate characters on our screen. 
	{
		public String characterName;
		public Sprite sprite; //sprites are 2D assets
		public Color color;
		public GameObject prefab;
		public float speed = 10f;
		public float maximumHealth = 100f;
		public Sprite characterDesign;
		public Sprite equippedWeapon;
		
		//we are going to use this object as a selector tool. we are saying that all players
		//in our game have a sprite, color, and prefab. all the same. Why? because it will be
		//easy to configure players. 
		//every time we generate a player object we can select different objects of our player.
		public void InstancePlayer() //we need to instansiate a prefab adn assign a color to it
		{
			var newPlayer = Instantiate(prefab); //it's going to take the prefab and put it on the screen.
			var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
			//use get component in children because the sprite renderer is a child of the main object in unity. 
			newSprite.sprite = sprite;
			newSprite.color = color; //when we instansiate it tell it find a sprite renderer, once it does
			//we tell it what color it is for the color we picked. 
			newSprite.sprite = equippedWeapon;
			newSprite.sprite = characterDesign;
			//newSprite. = characterName; //It won't let me call just a "String" it wants me to call 
			//"ToString". Don't know why just yet. 
		}
		
		//what should happen is when I press play, the player will change to either a red diamond
		//or a green circle upon the players slection. But my player isn't instantiating. 
		//it's not appearing for some reason and I need to figure out why. I think it's something in
		//Unity, not the actual code. 
		//Go into the player prefab and fix something there, I think that's the issue. 
	}
