# Starting with the Console

This will be the first part of this series.

## Lesson 1

-------------

Most developers started writing their coding career with a `Hello World`.

Lesson 1 get us started with a Console App displaying Hello World.

Go to your favorite folder where you want your code files saved and open in Terminal (Mac), PowerShell or Command Prompt (Windows), Bash (Linux)

Type `dotnet new console -o lesson-01-hello-world` and hit 'Enter' on your keyboard.

This command creates a .NET Core Console application in a new folder called lesson-01-hello-world

Next step, type `cd lesson-01-hello-world` in your commandline/terminal, hit enter then next type `dotnet run` and hit 'Enter' again.

You should get this shown to you.

        Hello World!

You may ask, I didn't write any code. Yes, that is true. What happened behind the scenes was that the `dotnet new console` command created a template program file you that looks like this.

        using System;

        namespace lesson_01_hello_world
        {
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Hello World!");
                }
            }
        }

So, the dotnet run command simply executed the `Console.WriteLine("Hello World!");` statement and displayed `Hello World!` to us.

More details [here](lesson-01-hello-world/hello-world.md).

## Lesson 2

-------------

In Lesson 2, we will be talking about basic C# data types.
This does not cover all but the most data types you'll be using in the course of this lesson will be covered. Here they are.

Data Type | Description and Usage
----------|----------------------
string | representing alphanumeric characters
int | representing whole numbers
double | representing decimal numbers
float | reperesenting floating point numbers
bool | used to determine the truth value of an assignment

More details [here](lesson-02-data-types/data-types.md).

## Lesson 3

Q: How do we then use data types?

A: We declare them as variables.

A variable is a name given to a storage area that is used to store values of various data types. (Reference [here](https://www.guru99.com/c-sharp-variables-operator.html))

A variable needs to represent a data type -simple or custom-defined.

In this lessson, we use the basic data types and do some operations on them.

We also introduce the concept of statements, operators and comments.

More details [here](lesson-03-variables-and-calculations/variables-and-calculations.md).

## Lesson 4

In the last lesson, one of the statements was returning a value that was normally not expected an ideal.

More details [here](lesson-04-debugging/debugging.md).

## Lesson 5

Let's play with some strings in this lesson -  concatenations and escape sequences.

More details [here](lesson-05-strings/string.md).

## Lesson 6

One important part of amy app/program is the use of dates and times. In this lesson, we walk through the usage of the `DateTime` data type.

More details [here](lesson-06-date-time/date-time.md).

## Lesson 7

More details [here](lesson-07-arrays-and-collections/arrays-and-collections.md).

## Lesson 8

More details [here](lesson-08-enums-and-structs/enums-and-structs.md).

## Lesson 9

More details [here](lesson-09-making-choices/making-choices.md).

## Lesson 10

More details [here](lesson-10-repeating-program-steps/repeating-program-steps.md).

## Lesson 11

More details [here](lesson-11-reusing-code-with-methods/reusing-code-with-methods.md).

## Lesson 12

More details [here](lesson-12-handling-errors/handling-errors.md).

## Lesson 13

More details [here](lesson-13-preventing-bugs/preventing-bugs.md).

## Lesson 14

More details [here](lesson-14-defining-classes/defining-classes.md).

## Lesson 15

More details [here](lesson-15-initializing-objects/initializing-objects.md).

## Lesson 16

More details [here](lesson-16-switches/switches.md).

## Lesson 17

More details [here](lesson-17-overloading-operators/overloading-operators.md).

## Lesson 18

More details [here](lesson-18-using-interfaces/using-interfaces.md).

## Lesson 19

More details [here](lesson-19-basic-oop-concepts/basic-oop-concepts.md).

## Lesson 20

More details [here](lesson-20-linq/linq.md).
