package Study;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws IOException {

        Scanner scanner = new Scanner(System.in);
        int divisor = scanner.nextInt();

        try {
            int result = 0 / divisor;
            System.out.println(result);
        } catch (ArithmeticException e)
        {
            System.out.println("fail");
        }




    }
}
