class Ground
{
    private int length;
    private string[] groundSprite;

    public Ground(int length)
    {
        this.length = length;
        this.groundSprite = new string[2];
        SetSprite();
    }

    private void SetSprite()
    {
        string grassOneLayer = "";
        for(int i=0; i<this.length; i++){
            grassOneLayer += "/";
        }
        groundSprite[0] = grassOneLayer;
        groundSprite[1] = grassOneLayer;
    }

    public void DrawSprite()
    {
        foreach(string eachline in groundSprite){
            Console.WriteLine(eachline);
        }
    }
}