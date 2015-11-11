import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            
        String[] nums = line.split(";");
        String res = "";
        
        for (int i = 0; i < nums.length; i++) {
            switch (nums[i]) {

                case "zero":
                    res = res + "0";
                    break;
                    case "one":
                    res = res + "1";
                    break;
                case "two":
                    res = res + "2";
                    break;
                case "three":
                    res = res + "3";
                    break;
                case "four":
                    res = res + "4";
                    break;
                case "five":
                    res = res + "5";
                    break;
                case "six":
                    res = res + "6";
                    break;

                case "seven":
                    res = res + "7";
                    break;
                case "eight":
                    res = res + "8";
                    break;
                case "nine":
                    res = res + "9";
                    break;

            }
        }
        System.out.println(res);
        }
    }
}
