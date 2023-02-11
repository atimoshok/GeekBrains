import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Parking implements Iterable<CarNumber> {
    private List<CarNumber> cars = new ArrayList<>();

    public void addCar (CarNumber number) {
        cars.add(number);
    }
    
    @Override
    public Iterator<CarNumber> iterator() {
        return new Iterator<CarNumber>(){
            private int current = 0;

            @Override
            public boolean hasNext() {
                return current < cars.size();
            }

            @Override
            public CarNumber next() {
                return cars.get(current++);
            } 
        };
    }
    
}
