#pragma strict
public var speed:float = 1f;
private var dmove:float = 38f;
	function Update()
	{
		if(transform.position.x > dmove){
			transform.position = new Vector2(-38,5.467466);
		}
		transform.Translate(Vector3.right*speed);
	} 