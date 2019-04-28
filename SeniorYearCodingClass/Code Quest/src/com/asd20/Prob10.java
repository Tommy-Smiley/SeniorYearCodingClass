package com.asd20;

import java.util.*;
import java.lang.reflect.Array;

public class Prob10 {

	public static void main(String[] args) {
		
		String text;
		char[] charList = null;
		int decode;
		try(Scanner input = new Scanner(System.in)){
			int testCases = Integer.parseInt(input.nextLine());
			
			for (int testCase = 0; testCase < testCases; testCase++) {
				int shift = input.nextInt();
				for (int i = 0; i < shift; i ++) {

					text = input.nextLine().toString();
					
					for(int j = 0; j < text.length(); j++) {
						text.getChars(0, text.length()-1, charList, 0);
					}
					
					/*for(int i = 0; i < text.length(); i++) {
						letters.add(Integer.parseInt(text.getChars(i, i+1, letters, 0));
					}*/
					
					decode = (charList[i]) + shift;
					
					System.out.println(decode);
					
				}
				
			}	
		}

	}

}
