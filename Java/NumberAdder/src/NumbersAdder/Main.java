package NumbersAdder;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        System.out.println(numberAdder(n));
    }

    private static int numberAdder(int n) {
        {
            int one = 1;
            if (one == null) {
                numberAdder(one + 1);
                System.out.println(one);
            }
            return n;
        }

    }
}
