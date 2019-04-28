package com.asd20;

import java.util.*;

public class Prob04 {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());
			
			for (int testCase = 0; testCase < testCases; testCase++) {
				
				String[] text = input.nextLine().split(" ");
				int speed = Integer.parseInt(text[0]);
				Boolean birthday = Boolean.parseBoolean(text[1]);
				int speedLimit = 60;
				int smallTicket = 80;
				int bigTicket = 81;
					
				if(birthday) {

					speedLimit += 5;
					smallTicket += 5;
					bigTicket += 5;
					
				}
				
				if(speed <= speedLimit) {
					
					System.out.println("no ticket");
					
				} else if (speed <= smallTicket) {
					
					System.out.println("small ticket");
					
				} else {
					
					System.out.println("big ticket");
					
				}
					
				
				
			}	
		}

	}

}
