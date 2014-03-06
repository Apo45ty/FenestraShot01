#pragma strict
public var speed:float = 1;
	function Update()
	{
		if(transform.position.x > 38){
			transform.position = new Vector2(-38,5.467466);
		}
		transform.Translate(Vector3.right*speed);
	} 