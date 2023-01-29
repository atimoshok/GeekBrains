package solid.dip;

import java.util.List;

public class DisplayReport implements Printable {
    public void output(List<ReportItem> items) {
        System.out.println("Output to file");
        for (ReportItem item : items) {
            System.out.format("printer %s - %f \n\r", item.getDescription(), item.getAmount());
        }
    }
}
