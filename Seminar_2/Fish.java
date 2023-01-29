package Seminar_2;

public class Fish extends Animal implements Swimable{

    public Fish(String name, int box) {
        super(name, box);
    }

    @Override
    public int speedOfSwim() {
        return 10;
    }

    @Override
    public String say() {
        return "буль-буль";
    }
    
}
