// Создать список по аналогии LinkedList (список связанных элементов),
// реализовать в нем iterable интерфейс.
// Список должен содержать элементы со ссылкой на следующий элемент
// (если показалось мало, то реализовать ссылку и на предыдущий элемент)

public class Main {
    public static void main(String[] args) {
        Parking parking = new Parking();
        parking.addCar(new CarNumber("828"));
        parking.addCar(new CarNumber("892"));
        parking.addCar(new CarNumber("024"));

        for (CarNumber carNumber : parking) {
            System.out.println(carNumber);
        }

        System.out.println("---------------");
        parking.addFirstCar(new CarNumber("222"));
        for (CarNumber carNumber : parking) {
            System.out.println(carNumber);
        }

    }
}
