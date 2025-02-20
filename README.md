# Unreachable Code Due to Constructor Initialization

This repository demonstrates a common C# coding error where a developer assumes a class member is initialized to a default value (in this case, 0 for an integer), but forgets that the constructor initializes it to a different value (10 in this example). As a result, the conditional statement within the `MyMethod` function will never execute, leading to unreachable code.

## Bug Description
The bug lies in the `MyMethod` function. The `if` condition checks if `MyProperty` is equal to 0. However, the constructor of the `ExampleClass` explicitly initializes `MyProperty` to 10. This means the `if` block will always be skipped, resulting in the code within it being unreachable.

## Bug Solution
The solution involves reviewing the constructor initialization and ensuring the conditional statement accurately reflects the possible values of `MyProperty`.  The solution provided ensures the code is correct and the condition is met in the corrected scenario.