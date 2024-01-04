using System.Runtime.CompilerServices;

abstract class Animal
{
    public string Name { get; set; }

    public void SetName(string name){
       Name=name;
    }
    public string GetName(){
        return Name;
    }
   public abstract void Eat();
}