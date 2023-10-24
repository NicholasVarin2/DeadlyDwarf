# C# Programming - HW1 Input
In this exercise we practice reading input from the terminal and deciding based on the input.

## Task
Change the code inside of the Main() method so that it does the following:
1. Greet the user with the message "Welcome to number stats! How many entries do you wish to enter?"
1. Prompt the user for a number
1. Show the user the number they entered in this message : "Expecting N numbers" where N is the number the user entered
1. Shows the user the following statistics about the numbers that they entered as shown below:
    * The sum of all numbers entered:sum
    * The average of all numbers entered:avg
    * The number of zeros entered:numZeros
    * The number of positive numbers entered:numPositive
    * The number of negative numbers entered:numNegatives
1. Print "Done!"

In each case, print the message as shown in step 4 followed by a single ':' and the calculated number. Keep in mind that the message should be exact

## Gotchas

Your code should be fail safe. Meaning, if the client provides an input that cannot be converted to an integer, or don't provide any input, you should keep asking them until they do.
If parsing user's input fails, you should print out "Please enter an integer" and repeat. Furthermore, the first entry (number of expected numbers) could not be negative. If it is, print out
"Please enter a positive integer" and repeat.

## Sample input and output
These are two examples of how the program would behave when you run it

### Example one

    Welcome to number stats! How many entries do you wish to enter?
    4
    Expecting 4 numbers
    10
    12
    7
    -4
    The sum of all numbers entered:25
    The average of all numbers entered:6.25
    The number of zeros entered:0
    The number of positive numbers entered:3
    The number of negative numbers entered:1
    Done!

### Example two
    Welcome to number stats! How many entries do you wish to enter?
    three
    Please enter a positive integer
    -2
    Please enter a positive integer
    3
    Expecting 3 numbers
    4
    hello
    Please enter an integer
    %i943
    Please enter an integer
    3
    8
    The sum of all numbers entered:15
    The average of all numbers entered:5
    The number of zeros entered:0
    The number of positive numbers entered:3
    The number of negative numbers entered:0
    Done!

## Submission
Commit and push your changes and submit the URL to your repository

