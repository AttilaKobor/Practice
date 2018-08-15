package Study;

public class Human {
    String name;
    int age;
    int height;
    String eyeColor;

    public void speak(){
        System.out.println("Hello, my name is " + name);
        System.out.println("I am " + height + "cm" );
        System.out.println("I am " + age + "old");
        System.out.println("My eyecolor is " + eyeColor);
    }
    public Human(){

    }
    public void eat(){
        System.out.println("eating...");
    }
    public void walk(){
        System.out.println("walking...");
    }
    public void work(){
        System.out.println("working...");
    }
}
