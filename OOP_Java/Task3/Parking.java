import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Parking implements Iterable<CarNumber> {
    private CarNumber head;
    private CarNumber tail;
    // private int size;

    private List<CarNumber> cars = new ArrayList<>();

    public Parking() {
        this.head = null;
        this.tail = null;
        // size = 0;
    }

    public void addCar (CarNumber number) {
        addLastCar(number);
    }

    public void addLastCar (CarNumber number) {
        // size++;
        // if (tail == null) {
        //     head = number;
        //     tail = head;
        //     number.setNext(null);
        //     number.setPrevious(null);
        // }
        // else {
        //     number.setNext(null);
        //     number.setPrevious(tail);
        //     tail = number;
        // }
        cars.add(number);
    }

    public void addFirstCar (CarNumber number) {
        // if (head == null) {
        //     head = number;
        //     tail = head;
        //     number.setNext(null);
        //     number.setPrevious(null);
        // }
        // else {
        //     number.setNext(head);
        //     number.setPrevious(null);
        //     head = number;
        // }
        cars.add(0, number);
    }

    @Override
    public Iterator<CarNumber> iterator() {
        return new Iterator<CarNumber>(){
            private int current = 0;

            @Override
            public boolean hasNext() {
                // return current < size;
                return current < cars.size();
            }

            @Override
            public CarNumber next() {
                return cars.get(current++);
            }
        };
    }
}