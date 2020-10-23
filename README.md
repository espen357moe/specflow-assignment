# Specflow assignments

## Assignment 1

### Install Specflow extension and add subtraction feature

1. Install the Visual Studio Specflow extension (this will enable Specflow and help with syntax highlighting of feature files)
1. Add _subtraction_ as a new feature for the calculator
1. Add a _scenario outline_ for subtraction in the feature, similar to Addition.feature
1. Add a When-step for subtraction in the step definitions
1. Implement subtract method in Calculator
1. Run the tests and see that they pass

## Assignment 2

### For the sake of the assignment, let's say that no negative numbers should be allowed in addition

1. Add a _scenario outline_ for adding negative numbers in Addition.feature
1. in the *Then* step, expect an exception to be thrown with the message "Negative numbers not allowed"
1. Add Examples for the scenario outline
1. Add a step definition that checks that an exception containing the expected message is thrown (you'll also have to add some logic to throw and catch the exception)
1. Run the tests and see that they pass
