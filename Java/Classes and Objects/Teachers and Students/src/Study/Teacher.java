package Study;

public class Teacher {

    String teach;

    public Teacher(){

    }

    public void teach(Student student){
        student.learn();
    }

    public void Answer(){
        System.out.println(teach);
    }

}
