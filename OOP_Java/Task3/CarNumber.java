public class CarNumber {
    private String number;
    
    public CarNumber(String number) {
        this.number = number;
    }

    @Override
    public String toString() {
        return "CarNumber = " + number;
    }

    public String getNumber() {
        return number;
    }
}
