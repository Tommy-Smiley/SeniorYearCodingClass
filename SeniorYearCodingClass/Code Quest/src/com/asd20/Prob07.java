package com.asd20;

import java.util.*;

public class Prob07 {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());
			int listNumber = Integer.parseInt(input.nextLine());

			float max = 101f;
			float min = -1f;
			
			ArrayList<Float> numbers = new ArrayList<Float>();
			for(int h = 0; h< listNumber; h++) {
				numbers.add(Float.parseFloat(input.nextLine()));
			}
			
			for (int testCase = 0; testCase < testCases; testCase++) {
				for(int i = 0; i < listNumber; i++) {
							
						for(int j = 0; j<numbers.size(); j++) {
							if (numbers.get(j) > max) {
								max = numbers.get(j);
							}
							if (numbers.get(j) < min) {
								min = numbers.get(j);
							}
							
						}
						
					}
				Float output;
				ArrayList<Float> outputs = new ArrayList<Float>();
				for(int x = 0; x < numbers.size(); x++) {
					
					output = (Float.parseFloat(input.nextLine()) - min/(max - min))*255f;
					outputs.add(output);
					
				}
				
				for (int o = 0; 0 < outputs.size()-1; o++) {
					
					System.out.println(outputs.get(o));
					
				}
				
			}	
		}

	}

}
