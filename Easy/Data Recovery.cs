
import java.io.*;

public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            String [] mitad = line.split(";");
             String [] text = mitad[0].split(" ");
            String [] nums = mitad[1].split(" ");
            String [] cont = new String[text.length];
            for (int i = 0; i < nums.length; i++) {
                cont[Integer.parseInt(nums[i]) - 1] = text[i];
            }
            String res = "";
            for (int i = 0; i < cont.length; i++) {
                if (cont[i] == null) {
                    cont[i] = text[text.length-1];
                }
                if (i == cont.length-1) {
                    res = res + cont[i]; 
                } else{
                    res = res + cont[i] + " ";    
            }
            
            }
        System.out.println(res);
        }
    }
}
