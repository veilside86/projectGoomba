Star star = new Star(10);
Ground ground = new Ground(120);
GoombaAdv aGoomba = new GoombaAdv(4);
Goomba goomba = new Goomba(2);
GoombaWalk gWalk = new GoombaWalk(star, aGoomba, ground);
gWalk.StartAnimation();
