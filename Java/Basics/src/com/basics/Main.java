package com.basics;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main
{
    private static final Scanner scanner = new Scanner(System.in);

    private static final List<Double> ints = new ArrayList<>();

    public static void main(final String[] args)
    {
        System.out.println("Add prices to your list. Negative values are ignored. Type \"0\" when you finished.");

        do
        {
            System.out.print("Add price: ");

            double input = scanner.nextDouble();

            if (0 < input)
                ints.add(input);
            else if (0 > input)
                System.out.println("\tValue ignored!");
            else
                break;

        } while (true);

        Double sum = ints.stream().reduce((double) 0, Double::sum);

        System.out.println("Entered values:");

        ints.forEach(item -> {
            System.out.printf("*\t%.2f\n", item);
        });
        
        System.out.printf(
                "==========\nSum before taxes: \t%.2f%nSum after taxes: \t%.2f%n",
                sum,
                sum * 1.24);
    }
}
