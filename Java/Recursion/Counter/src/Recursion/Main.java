package Recursion;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextDouble();
        System.out.println(Counter(n));

    }

    private static int Counter(int n) {
        if (n > 0) {
            Counter(n-1);
            System.out.println(n);
        }
        return n;
    }
}
