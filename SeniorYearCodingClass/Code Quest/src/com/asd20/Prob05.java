package com.asd20;

import java.util.*;

public class Prob05 {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());

			int variable;
			Boolean can;
			for (int testCase = 0; testCase < testCases; testCase++) {
				
				String[] output = input.nextLine().split(" ");
				
				for(int i= 0; i < output.length-2; i++) {

					variable = (Integer.parseInt(output[i]) + Integer.parseInt(output[i+1])*5);
					if (variable >= Integer.parseInt(output[i+2])) {
						
						can = true;
						
					} else {
						
						can = false;
						
					}
					System.out.println(can);
				}
				
			}	
		}

	}

}
