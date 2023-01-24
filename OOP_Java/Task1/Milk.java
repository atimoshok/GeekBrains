package OOP_Java.Task1;

public class Milk extends Product{
    private int volumeMl;

    public Milk(String name, double cost, int millilitres) {
        super(name, cost);
        this.volumeMl = millilitres;
    }

    @Override
    public String toString() {
        return String.format(super.toString() + " %d ml", volumeMl);
    } 
}