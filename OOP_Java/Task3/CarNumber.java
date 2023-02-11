public class CarNumber {
    private String number;

    private CarNumber next;
    private CarNumber previous;
    
    public CarNumber(String number) {
        this.number = number;
        this.next = null;
        this.previous = null;
    }

    @Override
    public String toString() {
        return "CarNumber = " + number;
    }

    public String getNumber() {
        return number;
    }

    public CarNumber getNext() {
        return next;
    }

    public CarNumber getPrevious() {
        return previous;
    }

    public void setNext(CarNumber next) {
        this.next = next;
    }

    public void setPrevious(CarNumber previous) {
        this.previous = previous;
    }
}
