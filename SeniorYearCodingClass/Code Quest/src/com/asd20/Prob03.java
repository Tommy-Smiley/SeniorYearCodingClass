package com.asd20;

import java.util.*;

public class Prob03 {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());

			Boolean variable;
			for (int testCase = 0; testCase < testCases; testCase++) {
				
				String[] output = input.nextLine().split(" ");
				
				for(int i= 0; i < output.length-1; i++) {

					if (output[i].equals(output[i+1])) {
						
						variable = true;

					} else {
						
						variable = false;
						
					}
					System.out.println(variable);
				}
				
			}	
		}

	}

}
