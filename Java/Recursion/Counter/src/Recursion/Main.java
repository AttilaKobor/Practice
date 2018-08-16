package Recursion;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Scanner scanner = new Scanner(System.in);
        double n = scanner.nextDouble();
        System.out.println(Counter(n));

    }

    private static double Counter(double n) {
        if (n > 0) {
            Counter(n-1);
            System.out.println(n);
        }
        return n;
    }
}
