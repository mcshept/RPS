package de.shept.rps;

import java.util.Random;
import java.util.Scanner;

public class Main {

    private static final String[] options = new String[]{"Rock", "Paper", "Scissors"};

    public static void main(String[] args) {

        Random random = new Random();
        int i = random.nextInt(options.length);

        System.out.println("Please choose an option: Rock, Paper or Scissors");
        Scanner scanner = new Scanner(System.in);
        String option = scanner.nextLine();
        switch (options[i]) {
            case "Rock":
                switch (option) {
                    case "Rock":
                        System.out.println("Computer has chosen Rock.");
                        System.out.println("Draw");
                        break;
                    case "Paper":
                        System.out.println("Computer has chosen Rock.");
                        System.out.println("You win!");
                        break;
                    case "Scissors":
                        System.out.println("Computer has chosen Rock.");
                        System.out.println("You lose!");
                        break;
                    default:
                        System.out.println("This is not a valid option!");
                }
                break;
            case "Paper":
                switch (option) {
                    case "Rock":
                        System.out.println("Computer has chosen Paper.");
                        System.out.println("You lose!");
                        break;
                    case "Paper":
                        System.out.println("Computer has chosen Paper.");
                        System.out.println("Draw!");
                        break;
                    case "Scissors":
                        System.out.println("Computer has chosen Paper.");
                        System.out.println("You win!");
                        break;
                    default:
                        System.out.println("This is not a valid option!");
                }
                break;
            case "Scissors":
                switch (option) {
                    case "Rock":
                        System.out.println("Computer has chosen Scissors.");
                        System.out.println("You win!");
                        break;
                    case "Paper":
                        System.out.println("Computer has chosen Scissors.");
                        System.out.println("You lose!");
                        break;
                    case "Scissors":
                        System.out.println("Computer has chosen Scissors.");
                        System.out.println("Draw!");
                        break;
                    default:
                        System.out.println("This is not a valid option!");
                }
                break;
        }

        scanner.close();

    }

}
