class Goomba{
	protected int posX;
	private int speed;
	protected string[] goombaSprite;
    private bool direction;

    public Goomba(int speed)
    {
        this.posX = 0;
        this.speed = speed;
        this.goombaSprite = new string[10];
        // SetSprite();
        this.direction = true;
    }

    public virtual void SetSprite()
    {
        goombaSprite[0] = @"     ________  ";
        goombaSprite[1] = @"    /        \ ";
        goombaSprite[2] = @"   /  \    /  \ ";
        goombaSprite[3] = @"  /   |    |   \ ";
        goombaSprite[4] = @" /  -^------^-  \ ";
        goombaSprite[5] = @"|________________| ";
        goombaSprite[6] = @"      /    \ ";  
        goombaSprite[7] = @" ____|      |____ ";
        goombaSprite[8] = @"/____\ ==== /____\ ";
        goombaSprite[9] = @"                     ";   
    }

	public virtual void DrawSprite()
    {
        string spaces = "";

        for(int i=0; i<this.posX; i++)
        {
            spaces += " ";
        }
        foreach(string eachline in goombaSprite)
        {
            Console.WriteLine(spaces + eachline);
        }
	}

    public void ChangeDir()
    {
        this.direction =! this.direction;
    }

	public void UpdatePos(){
        if (this.direction == true)
        {
            this.posX = this.posX + speed;
        }
        else
        {
            this.posX = this.posX - speed;
        }
	}
}
