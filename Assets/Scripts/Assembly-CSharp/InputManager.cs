using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
	public static InputManager Instance;

	public string interactButtonKeyboard;

	public string plannerButtonKeyboard;

	public string actionButtonKeyboard;

	public string pauseButtonKeyboard;

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		//Swag Swag Cool Shiz
	}

	private void Update()
	{
	}

	public string[] GetInputStrings()
	{
		return new string[4] { interactButtonKeyboard, plannerButtonKeyboard, actionButtonKeyboard, pauseButtonKeyboard };
	}

	public bool IsInteractPressed()
	{
		return Input.GetKeyDown((KeyCode)Enum.Parse(typeof(KeyCode), interactButtonKeyboard)) || Input.GetKey("A");
	}

	public bool IsInteractHeld()
	{
		return Input.GetKey((KeyCode)Enum.Parse(typeof(KeyCode), interactButtonKeyboard)) || Input.GetKey("A");
	}

	public bool IsPlannerPressed()
	{
		return Input.GetKeyDown((KeyCode)Enum.Parse(typeof(KeyCode), plannerButtonKeyboard)) || Input.GetKey("X");
	}

	public bool IsActionPressed()
	{
		return Input.GetKeyDown((KeyCode)Enum.Parse(typeof(KeyCode), actionButtonKeyboard)) || Input.GetKey("B");
	}

	public bool IsPausePressed()
	{
		return Input.GetKeyDown((KeyCode)Enum.Parse(typeof(KeyCode), pauseButtonKeyboard)) || Input.GetKey("Return");
	}

	public void ReconfigureInteractKeyboard(string x)
	{
		interactButtonKeyboard = x;
	}

	public void ReconfigurePlannerKeyboard(string x)
	{
		plannerButtonKeyboard = x;
	}

	public void ReconfigureActionKeyboard(string x)
	{
		actionButtonKeyboard = x;
	}

	public void ReconfigurePauseKeyboard(string x)
	{
		pauseButtonKeyboard = x;
	}
}