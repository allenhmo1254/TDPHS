var Gradient : Gradient;
var timeMultiplier:float=1;

private var curColor:Color;
private var time:float=0;



function Start ()
{

renderer.material.SetColor ("_TintColor", Color(0, 0, 0, 0));

}


function Update () {
time+=Time.deltaTime*timeMultiplier;
curColor=Gradient.Evaluate(time);


renderer.material.SetColor ("_TintColor", curColor);
}

