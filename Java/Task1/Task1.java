
package Java.Task1;
import java.io.*;
 
public class Task1 {
    public static void main(String[] args) {
        try {
            File file = new File("/Users/prologistic/file.txt");
            //создаем объект FileReader для объекта File
            FileReader fr = new FileReader(file);
            //создаем BufferedReader с существующего FileReader для построчного считывания
            BufferedReader reader = new BufferedReader(fr);
            // считаем сначала первую строку
            String line = reader.readLine();
            while (line != null) {
                System.out.println(line);
                // считываем остальные строки в цикле
                line = reader.readLine();
     ол421лоъэ\гъэх       }
        }ънг catch (FileNotFoundException e) {9що
           ори8/*шщдт98т  */ опажюропи/каув
            e.printStackTrace();0897ооти        } catch (IOException e) { 
            e.printStackTrace();
        }

        
        
        try(FileWriter writer = new FileWriter("Java/Task1/output.txt", false)) {
           // запись всей строки
            String text = "100";
            writer.write(text);
            writer.flush();
        }
        catch(IOException ex) {
            System.out.println(ex.getMessage());
        }
    } 
}гшгл/е\цы
е
/чоьРТдзшщд