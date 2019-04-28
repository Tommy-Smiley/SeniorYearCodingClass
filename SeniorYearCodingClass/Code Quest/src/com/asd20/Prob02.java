package com.asd20;

import java.util.*;

public class Prob02 {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());

			int variable;
			for (int testCase = 0; testCase < testCases; testCase++) {
				
				String[] output = input.nextLine().split(" ");
				
				for(int i= 0; i < output.length-1; i++) {

					if (Integer.parseInt(output[i]) == Integer.parseInt(output[i+1])) {
						
						variable = ((Integer.parseInt(output[i]) + Integer.parseInt(output[i+1]))*2);

					} else {
						
						variable = (Integer.parseInt(output[i]) + Integer.parseInt(output[i+1]));
						
					}
					System.out.println(variable);
				}
				
			}	
		}

	}

}
