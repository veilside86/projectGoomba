class Star
{
	private int posX;
	private string[] starSprite;
	public Star(int posX){
		this.posX = posX;
		this.starSprite = new string[6];
		SetSprite();
	}

	private void SetSprite()
	{
		starSprite[0] = @"        ";
		starSprite[1] = @" __/\__ ";
		starSprite[2] = @" \ || / ";
		starSprite[3] = @" /_  _\ ";
		starSprite[4] = @"   \/   ";
		starSprite[5] = @"        ";
	}

	public void DrawSprite()
	{
		string spaces = "";
		for(int i=0; i<this.posX; i++){
			spaces += " ";
		}
		foreach (string eachline in starSprite){
			Console.WriteLine(spaces + eachline);
		}
	}
}
