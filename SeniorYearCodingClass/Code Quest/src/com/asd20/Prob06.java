package com.asd20;

import java.util.*;
import java.math.*;

public class Prob06 {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());
			double variable;
			double circ = 40075;
			for (int testCase = 0; testCase < testCases; testCase++) {
				
				variable = (double) ((input.nextInt())+(circ/(2*Math.PI)));
				variable *= 2*Math.PI;
				variable = Math.round(variable*10);
				System.out.println(variable/10);
			}	
		}

	}

}
